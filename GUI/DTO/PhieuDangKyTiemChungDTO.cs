using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GUI.DTO
{
    class PhieuDangKyTiemChungDTO
    {
        private String MaPDKTC, MaKH, HoTenNT, CMNDNT, DiaChiNT, GioiTinhNT, SDTNT, QUANHE, TinhTrang;
        private DateTime NgayDK, NgSinhNT;

        private List<CTPHIEUDKTC> DsCT = new List<CTPHIEUDKTC>();

        public PhieuDangKyTiemChungDTO(string maKH, string hoTenNT, string cMNDNT, string diaChiNT, string gioiTinhNT, string sDTNT, string qUANHE, DateTime ngayDK, DateTime ngSinhNT, List<CTPHIEUDKTC> dsCT, string tinhTrang)
        {
            MaKH = maKH;
            HoTenNT = hoTenNT;
            CMNDNT = cMNDNT;
            DiaChiNT = diaChiNT;
            GioiTinhNT = gioiTinhNT;
            SDTNT = sDTNT;
            QUANHE = qUANHE;
            NgayDK = ngayDK;
            NgSinhNT = ngSinhNT;
            DsCT = dsCT;
            TinhTrang = tinhTrang;
        }

        public SqlCommand getInsertSqlCommand()
        {
            SqlCommand command = new SqlCommand(
                @"INSERT PHIEUDANGKYTIEMCHUNG (MAKH, HOTENNT, CMNDNT, DIACHINT,NGSINHNT, GIOITINHNT, SDTNT, QUANHE, THOIGIANDK, TINHTRANG)
                  VALUES (@maKH, @hoTenNT, @cmndNT, @diaChiNT, @ngSinhNT, @gioiTinhNT, @sdtNT, @quanHe, @thoiGianDK, @tinhTrang); SELECT SCOPE_IDENTITY()");

            command.Parameters.Add(new SqlParameter("@maKH", MaKH));
            command.Parameters.Add(new SqlParameter("@hoTenNT", HoTenNT));
            command.Parameters.Add(new SqlParameter("@cmndNT", CMNDNT));
            command.Parameters.Add(new SqlParameter("@diaChiNT", DiaChiNT));
            command.Parameters.AddWithValue("@ngSinhNT", NgSinhNT);
            command.Parameters.Add(new SqlParameter("@gioiTinhNT", GioiTinhNT));
            command.Parameters.Add(new SqlParameter("@sdtNT", SDTNT));
            command.Parameters.Add(new SqlParameter("@quanHe", QUANHE));
            command.Parameters.AddWithValue("@thoiGianDK", NgayDK);
            command.Parameters.Add(new SqlParameter("@tinhTrang", TinhTrang));
            return command;
        }
     
        public List<SqlCommand> getInsertCTSqlCommand(String maPDKTC)
        {
            MaPDKTC = maPDKTC;
            List<SqlCommand> commands = new List<SqlCommand>();

            foreach (CTPHIEUDKTC ct in DsCT)
            {
                commands.Add(ct.getInsertCommand(MaPDKTC));
            }           
            return commands;
        }

    }
}
