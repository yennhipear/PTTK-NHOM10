using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace GUI.DAO
{
    class PhieuDatMuaVacxinDAO
    {
        private static PhieuDatMuaVacxinDAO Instance = null;

        private PhieuDatMuaVacxinDAO() { }

        public static PhieuDatMuaVacxinDAO getInstance()
        {
            if (Instance == null)
                Instance = new PhieuDatMuaVacxinDAO();
            return Instance;
        }

        public DataTable LayDSPhieuDKTC()
        {
            DataTable result = DataProviderDAO.getInstance().ExecuteQuery(new SqlCommand("Select MAPDM,MAKH,NGAYMUA,TRANGTHAI from PHIEU_DATMUA"));
            return result;
        }

        public PhieuDatMuaVacxinDTO LayThongTinPhieuDMVX(String maPDM)
        {
            SqlCommand command = new SqlCommand(
                @"Select pdm.maPDM, pdm.MAKH, kh.HOTENKH, kh.DIACHIKH, kh.GIOITINHKH, kh.SDTKH, kh.EMAILKH, kh.NGAYSINHKH, pdm.TRANGTHAI, pdm.NGAYMUA
                    From PHIEUDANGKYTIEMCHUNG pdm left join KHACHHANG kh on(pdm.MAKH = kh.MAKH)
                    Where pdk.MAPDM = @maPDM");
            command.Parameters.Add(new SqlParameter("@maPDM", maPDM));
            DataTable result = DataProviderDAO.getInstance().ExecuteQuery(command);

            String MaPDMVX, MaKH, TinhTrang, HoTenKH, DiaChiKH, GioiTinhKH, SDTKH, emailKH;
            DateTime NgayDM, NgSinhKH;

            MaPDMVX = result.Rows[0]["MAPDM"].ToString();
            MaKH = result.Rows[0]["MaKH"].ToString();
            TinhTrang = result.Rows[0]["TinhTrang"].ToString();
            HoTenKH = result.Rows[0]["HoTenKH"].ToString();
            DiaChiKH = result.Rows[0]["DiaChiKH"].ToString();
            GioiTinhKH = result.Rows[0]["GioiTinhKH"].ToString();
            SDTKH = result.Rows[0]["SDTKH"].ToString();
            emailKH = result.Rows[0]["EmailKH"].ToString();

            if (DateTime.TryParse(result.Rows[0]["THOIGIANDK"].ToString(), out NgayDM) == false)
                NgayDM = new DateTime();

            if (DateTime.TryParse(result.Rows[0]["NGAYSINHKH"].ToString(), out NgSinhKH) == false)
                NgSinhKH = new DateTime();

            PhieuDatMuaVacxinDTO phieuDatMua = new PhieuDatMuaVacxinDTO(MaPDMVX, MaKH, TinhTrang, HoTenKH, DiaChiKH, GioiTinhKH, emailKH, SDTKH, NgayDM, NgSinhKH);
            return phieuDatMua;

        }

        public DataTable LayCTPhieuDMVX(String maPDM)
        {
            SqlCommand command = new SqlCommand(
                @"select ct.MAVACXIN, vx.TENVACXIN
                    from ctphieudktc ct
                    left join VACXIN vx on (ct.MAVACXIN = vx.MAVACXIN)
                    Where ct.MAPDM = @maPDM");
            command.Parameters.Add(new SqlParameter("@maPDM", maPDM));
            return DataProviderDAO.getInstance().ExecuteQuery(command);
        }

        public int LuuThongTinDatMua(PhieuDatMuaVacxinDTO phieuDatMua)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = phieuDatMua.getInsertSqlDMCommand();

                SqlTransaction transaction;
                transaction = connection.BeginTransaction("Them Phieu DMVX");

                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    // Thêm Phiếu đk mới, đông thời lấy ID của phiếu vừa mới thêm
                    String newID = command.ExecuteScalar().ToString();

                    // Lấy ds câu lệnh thêm CT phiếu ĐK
                    List<SqlCommand> commands = phieuDatMua.getInsertCTDMSqlCommand(newID);

                    //Duyệt qua ds câu lệnh và thực thi từng câu lệnh để thêm CT phiếu ĐK
                    foreach (SqlCommand comm in commands)
                    {
                        comm.Connection = connection;
                        comm.Transaction = transaction;

                        comm.ExecuteNonQuery();
                    }

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
                    return Convert.ToInt32(newID);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("Message: {0}", ex.Message);

                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                    return -1;
                }
            }
        }

        public int CapNhatTinhTrangPhieu(String maPDM, String tinhTrang)
        {
            SqlCommand command = new SqlCommand("UPDATE PHIEU_DATMUA SET TRANGTHAI = @tinhTrang WHERE MAPDM = @maPDM");
            command.Parameters.Add(new SqlParameter("@maPDM", maPDM));
            command.Parameters.Add(new SqlParameter("@tinhTrang", tinhTrang));
            return DataProviderDAO.getInstance().ExecuteNonQuery(command);
        }
    }
}
