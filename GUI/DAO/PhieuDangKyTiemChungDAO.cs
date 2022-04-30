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
    class PhieuDangKyTiemChungDAO
    {
        private static PhieuDangKyTiemChungDAO Instance = null;

        private PhieuDangKyTiemChungDAO() { }

        public static PhieuDangKyTiemChungDAO getInstance()
        {
            if (Instance == null)
                Instance = new PhieuDangKyTiemChungDAO();
            return Instance;
        }

        public DataTable LayDSPhieuDKTC()
        {
            DataTable result = DataProviderDAO.getInstance().ExecuteQuery(new SqlCommand("Select MAPDK, MAKH, THOIGIANDK, TINHTRANG from PHIEUDANGKYTIEMCHUNG"));
            return result;
        }

        public PhieuDangKyTiemChungDTO LayThongTinPhieuDKTC(String maPDK)
        {
            SqlCommand command = new SqlCommand(
                @"Select pdk.MAPDK, pdk.MAKH, kh.HOTENKH, kh.DIACHIKH, kh.GIOITINHKH, kh.SDTKH, kh.NGAYSINHKH,
                    pdk.HoTenNT, pdk.CMNDNT, pdk.DIACHINT, pdk.GioiTinhNT, pdk.SDTNT, pdk.NGSINHNT, pdk.QUANHE, pdk.TINHTRANG, pdk.THOIGIANDK
                    From PHIEUDANGKYTIEMCHUNG pdk left join KHACHHANG kh on(pdk.MAKH = kh.MAKH)
                    Where pdk.MAPDK = @maPDK");
            command.Parameters.Add(new SqlParameter("@maPDK", maPDK));
            DataTable result = DataProviderDAO.getInstance().ExecuteQuery(command);

            String MaPDKTC, MaKH, HoTenNT, CMNDNT, DiaChiNT, GioiTinhNT, SDTNT, QUANHE, TinhTrang;
            String HoTenKH, DiaChiKH, GioiTinhKH, SDTKH;
            DateTime NgayDK, NgSinhNT, NgSinhKH;

            MaPDKTC = result.Rows[0]["MAPDK"].ToString();
            MaKH = result.Rows[0]["MaKH"].ToString();
            HoTenNT = result.Rows[0]["HoTenNT"].ToString();
            CMNDNT = result.Rows[0]["CMNDNT"].ToString();
            DiaChiNT = result.Rows[0]["DiaChiNT"].ToString();
            GioiTinhNT = result.Rows[0]["GioiTinhNT"].ToString();
            SDTNT = result.Rows[0]["SDTNT"].ToString();
            QUANHE = result.Rows[0]["QUANHE"].ToString();
            TinhTrang = result.Rows[0]["TinhTrang"].ToString();
            HoTenKH = result.Rows[0]["HoTenKH"].ToString();
            DiaChiKH = result.Rows[0]["DiaChiKH"].ToString();
            GioiTinhKH = result.Rows[0]["GioiTinhKH"].ToString();
            SDTKH = result.Rows[0]["SDTKH"].ToString();

            if (DateTime.TryParse(result.Rows[0]["THOIGIANDK"].ToString(), out NgayDK) == false)
                NgayDK = new DateTime();

            if (DateTime.TryParse(result.Rows[0]["NGSINHNT"].ToString(), out NgSinhNT) == false)
                NgSinhNT = new DateTime();

            if (DateTime.TryParse(result.Rows[0]["NGAYSINHKH"].ToString(), out NgSinhKH) == false)
                NgSinhKH = new DateTime();
            

            PhieuDangKyTiemChungDTO phieuDangKy = new PhieuDangKyTiemChungDTO(MaPDKTC, MaKH, HoTenNT, CMNDNT, DiaChiNT, GioiTinhNT,
                SDTNT, QUANHE, TinhTrang, HoTenKH, DiaChiKH, GioiTinhKH, SDTKH, NgayDK, NgSinhNT, NgSinhKH);            
            return phieuDangKy; 

        }

        public DataTable LayCTPhieuDKTC(String maPDK)
        {
            SqlCommand command = new SqlCommand(
                @"select ct.MAGOIVACXIN, gvx.TENGOIVACXIN, ct.LANTIEM, cn.TENCN
                    from ctphieudktc ct
                    left join GOIVACXIN gvx on (ct.MAGOIVACXIN = gvx.MAGOIVACXIN)
                    left join CHINHANH cn on (ct.MACN = cn.MACN)
                    Where ct.MAPDK = @maPDK");
            command.Parameters.Add(new SqlParameter("@maPDK", maPDK));
            return DataProviderDAO.getInstance().ExecuteQuery(command);
        }

        public int LuuThongTinDangKy(PhieuDangKyTiemChungDTO phieuDangKy)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = phieuDangKy.getInsertSqlCommand();

                SqlTransaction transaction;
                transaction = connection.BeginTransaction("Them Phieu DKTC");
                
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    // Thêm Phiếu đk mới, đông thời lấy ID của phiếu vừa mới thêm
                    String newID = command.ExecuteScalar().ToString();

                    // Lấy ds câu lệnh thêm CT phiếu ĐK
                    List<SqlCommand> commands = phieuDangKy.getInsertCTSqlCommand(newID);
                    
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

    }
}
