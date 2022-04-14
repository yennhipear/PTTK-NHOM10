using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace GUI.DAO
{
    class VacxinDAO
    {
        

        public VacxinDAO()
        {

        }

        public DataTable LayDSVacxinHT()
        {
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
            DataTable result = new DataTable();
            try
            {
                cnn.Open();
                String command = "Select MAVACXIN, TENVACXIN, NGUABENH from VACXIN";
                SqlDataAdapter sqlDaDH = new SqlDataAdapter(command, cnn);
                sqlDaDH.Fill(result);

                cnn.Close();
            }
            catch (Exception ex)
            {
                result = null;                
            }
            return result;
        }

        public DataTable LayCTVacxin(String maVacxin)
        {
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
            DataTable result = new DataTable();
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand("Select HANGVACXIN, MOTA from VACXIN WHERE MAVACXIN = @maVacxin", cnn);
                command.Parameters.Add(new SqlParameter("@maVacxin", maVacxin));

                SqlDataAdapter sqlDaDH = new SqlDataAdapter(command);
                sqlDaDH.Fill(result);

                cnn.Close();
            }
            catch (Exception ex)
            {
                result = null;
            }
            return result;
        }
    }
}
