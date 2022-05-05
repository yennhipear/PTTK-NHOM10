using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GUI.DTO
{
    class PhieuDatMuaVacxinDTO
    {
        public String MaPDM { get; set; }
        public String MaKH { get; set; }
        public String TinhTrang { get; set; }
        public String HoTenKH { get; set; }
        public String DiaChiKH { get; set; }
        public String GioiTinhKH { get; set; }
        public String SDTKH { get; set; }
        public string EmailKH { get; set; }
        public DateTime NgayDM { get; set; }
        public DateTime NgSinhKH { get; set; }
        public List<CTPHIEUDMVX> DsCT { get; set; }

        public PhieuDatMuaVacxinDTO(string maPDMVX, string maKH, string tinhTrang, string hoTenKH, string diaChiKH, string gioiTinhKH, string sDTKH, string emailKH, DateTime ngayDM , DateTime ngSinhKH)
        {
            MaPDM = maPDMVX;
            MaKH = maKH;
            EmailKH = emailKH;
            TinhTrang = tinhTrang;
            HoTenKH = hoTenKH;
            DiaChiKH = diaChiKH;
            GioiTinhKH = gioiTinhKH;
            SDTKH = sDTKH;
            NgayDM = ngayDM;
            NgSinhKH = ngSinhKH;
        }


        public PhieuDatMuaVacxinDTO(string maKH, DateTime ngayDM, List<CTPHIEUDMVX> dsCT, string tinhTrang)
        {
            MaKH = maKH;
            DsCT = dsCT;
            TinhTrang = tinhTrang;
        }

        public SqlCommand getInsertSqlDMCommand()
        {
            SqlCommand command = new SqlCommand(
                @"INSERT INTO PHIEU_DATMUA (MAKH, NGAYMUA, TINHTRANG)
                  VALUES (@maKH, @ngayMua, @tinhTrang); SELECT SCOPE_IDENTITY()");

            command.Parameters.Add(new SqlParameter("@maKH", MaKH));
            command.Parameters.AddWithValue("@ngayMua", NgayDM);
            command.Parameters.Add(new SqlParameter("@tinhTrang", TinhTrang));
            return command;
        }

        public List<SqlCommand> getInsertCTDMSqlCommand(String maPDMVX)
        {
            MaPDM = maPDMVX;
            List<SqlCommand> commands = new List<SqlCommand>();

            foreach (CTPHIEUDMVX ct in DsCT)
            {
                commands.Add(ct.getInsertDMCommand(maPDMVX));
            }
            return commands;

        }

    }
}
