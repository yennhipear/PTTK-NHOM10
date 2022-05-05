using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GUI.DTO
{
    class CTPHIEUDMVX
    {
        private String MaPDM, MaVacxin;
        private int SoLuong;

        public CTPHIEUDMVX(string maVacxin, int SL)
        {
            MaVacxin = maVacxin;
            SoLuong = SL;
        }

        public SqlCommand getInsertDMCommand(String MaPDMVX)
        {
            MaPDM = MaPDMVX;

            SqlCommand command = new SqlCommand(
            @"INSERT INTO CHITIET_PHIEUDATMUA (MAPDM, MAVACXIN, SOLUONG) 
            VALUES (@maPDM, @maVacxin, @SoLuong)");
            command.Parameters.Add(new SqlParameter("@maPDM", MaPDM));
            command.Parameters.Add(new SqlParameter("@maVacxin", MaVacxin));
            command.Parameters.Add(new SqlParameter("@SoLuong", SoLuong));
            return command;
        }
    }
}
