using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace GUI.DTO
{
    public class VacxinNgoaiDTO
    {
        public String MaVacxinNgoai { get; set; }
        public String TenVacxinNgoai { get; set; }
        public String LoaiVacxinNgoai { get; set; }
        public String HangVacxinNgoai { get; set; }
      
        public VacxinNgoaiDTO(string MaVXNgoai, string TenVXNgoai, string LoaiVXNgoai, string HangVXNgoai)
        {
            MaVacxinNgoai = MaVXNgoai;
            TenVacxinNgoai = TenVXNgoai;
            LoaiVacxinNgoai = LoaiVXNgoai;
            HangVacxinNgoai = HangVXNgoai;

        }

        public VacxinNgoaiDTO(string TenVXNgoai, string LoaiVXNgoai, string HangVXNgoai)
        {
            TenVacxinNgoai = TenVXNgoai;
            LoaiVacxinNgoai = LoaiVXNgoai;
            HangVacxinNgoai = HangVXNgoai;
        }
        
        public SqlCommand getInsertSqlCommand()
        {
            SqlCommand command = new SqlCommand(
                @"INSERT INTO VACXINNGOAI (TENVACXIN, LOAIVACXIN, HANGVACXIN)
                  VALUES (@tenVXN, @loaiVXN, @hangSX); SELECT SCOPE_IDENTITY()");

            command.Parameters.Add(new SqlParameter("@tenVXN", TenVacxinNgoai));
            command.Parameters.Add(new SqlParameter("@loaiVXN", LoaiVacxinNgoai));
            command.Parameters.Add(new SqlParameter("@hangSX", HangVacxinNgoai));
            return command;
        }
     
                
    }
}


