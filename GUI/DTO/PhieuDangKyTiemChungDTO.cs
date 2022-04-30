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
        public String MaPDKTC { get; set; }
        public String MaKH { get; set; }
        public String HoTenNT { get; set; }
        public String CMNDNT { get; set; }
        public String DiaChiNT { get; set; }
        public String GioiTinhNT { get; set; }
        public String SDTNT { get; set; }
        public String QUANHE { get; set; }
        public String TinhTrang { get; set; }
        public String HoTenKH { get; set; }
        public String DiaChiKH { get; set; }
        public String GioiTinhKH { get; set; }
        public String SDTKH { get; set; }
        public DateTime NgayDK { get; set; }
        public DateTime NgSinhNT { get; set; }
        public DateTime NgSinhKH { get; set; }
        public List<CTPHIEUDKTC> DsCT { get; set; }

        public PhieuDangKyTiemChungDTO(string maPDKTC, string maKH, string hoTenNT, string cMNDNT, string diaChiNT, string gioiTinhNT, string sDTNT, string qUANHE, string tinhTrang, string hoTenKH, string diaChiKH, string gioiTinhKH, string sDTKH, DateTime ngayDK, DateTime ngSinhNT, DateTime ngSinhKH)
        {
            MaPDKTC = maPDKTC;
            MaKH = maKH;
            HoTenNT = hoTenNT;
            CMNDNT = cMNDNT;
            DiaChiNT = diaChiNT;
            GioiTinhNT = gioiTinhNT;
            SDTNT = sDTNT;
            QUANHE = qUANHE;
            TinhTrang = tinhTrang;
            HoTenKH = hoTenKH;
            DiaChiKH = diaChiKH;
            GioiTinhKH = gioiTinhKH;
            SDTKH = sDTKH;
            NgayDK = ngayDK;
            NgSinhNT = ngSinhNT;
            NgSinhKH = ngSinhKH;
        }


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
