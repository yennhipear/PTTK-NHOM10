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
    class DangKiTaiKhoanDAO
    {
        public DangKiTaiKhoanDAO() { }
        SqlCommand sqlCommand; //de truy van cac cau lenh insert, update, delete...
        SqlDataReader dataReader; //doc data trong table

        public List<DTO.TaiKhoanDTO> TaiKhoans(string query)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;

            List<DTO.TaiKhoanDTO> taikhoans = new List<DTO.TaiKhoanDTO>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taikhoans.Add(new DTO.TaiKhoanDTO(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7), dataReader.GetString(8), dataReader.GetDateTime(9)));
                }
                sqlConnection.Close();
            }
            return taikhoans;
        }

        public void Command(string query) //de dang ki taikhoan
        {
            String connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
