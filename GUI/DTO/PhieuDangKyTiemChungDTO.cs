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
        private String MaPDKTC, MaKH, HoTenNT, CMNDNT, DiaChiNT, GioiTinhNT, SDTNT, QUANHE;
        private DateTime NgayDK, NgSinhNT;

        public PhieuDangKyTiemChungDTO(string maKH, string hoTenNT, string cMNDNT, string diaChiNT, string gioiTinhNT, string sDTNT, string qUANHE, DateTime ngayDK, DateTime ngSinhNT)
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
        }

        public SqlCommand getInsertSqlCommand()
        {
            SqlCommand command = new SqlCommand(
                @"INSERT PHIEUDANGKYTIEMCHUNG (MAKH, HOTENNT, CMNDNT, DIACHINT,NGSINHNT, GIOITINHNT, SDTNT, QUANHE, THOIGIANDK)
                  VALUES (@maKH, @hoTenNT, @cmndNT, @diaChiNT, @ngSinhNT, @gioiTinhNT, @sdtNT, @quanHe, @thoiGianDK)");

            command.Parameters.Add(new SqlParameter("@maKH", MaKH));
            command.Parameters.Add(new SqlParameter("@hoTenNT", HoTenNT));
            command.Parameters.Add(new SqlParameter("@cmndNT", CMNDNT));
            command.Parameters.Add(new SqlParameter("@diaChiNT", DiaChiNT));
            command.Parameters.AddWithValue("@ngSinhNT", NgSinhNT);
            command.Parameters.Add(new SqlParameter("@gioiTinhNT", GioiTinhNT));
            command.Parameters.Add(new SqlParameter("@sdtNT", SDTNT));
            command.Parameters.Add(new SqlParameter("@quanHe", QUANHE));
            command.Parameters.AddWithValue("@thoiGianDK", NgayDK);

            return command;
        }
    }
}
