using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    class CTPHIEUDKTC
    {
        private String MaPDKTC, MaGoiVacxin, TenCN;
        private int LanTiem;

        public CTPHIEUDKTC(string maGoiVacxin, int lanTiem, string tenCN)
        {
            MaGoiVacxin = maGoiVacxin;
            LanTiem = lanTiem;
            TenCN = tenCN;
        }

        public SqlCommand getInsertCommand(String maPDKTC)
        {
            MaPDKTC = maPDKTC;

            SqlCommand command = new SqlCommand(
            @"INSERT CTPHIEUDKTC (MAPDK, MAGOIVACXIN, LANTIEM, MACN) 
            VALUES (@maPDK, @maGoiVacxin, @lanTiem, (Select MACN FROM CHINHANH WHERE TENCN = @tenCN))");
            command.Parameters.Add(new SqlParameter("@maPDK", MaPDKTC));
            command.Parameters.Add(new SqlParameter("@maGoiVacxin", MaGoiVacxin));
            command.Parameters.Add(new SqlParameter("@lanTiem", LanTiem));
            command.Parameters.Add(new SqlParameter("@tenCN", TenCN));
            return command;
        }
    }
}
