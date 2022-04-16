using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using GUI.DAO;

namespace GUI.DAO
{
    class VacxinDAO
    {
        public DataTable LayDSVacxinHT()
        {           
            DataTable result = DataProviderDAO.getInstance().ExecuteQuery(new SqlCommand("Select MAVACXIN, TENVACXIN, NGUABENH, GIABAN from VACXIN"));           
            return result;
        }

        public DataTable LayCTVacxin(String maVacxin)
        {
            SqlCommand command = new SqlCommand("Select HANGVACXIN, MOTA from VACXIN WHERE MAVACXIN = @maVacxin");
            command.Parameters.Add(new SqlParameter("@maVacxin", maVacxin));
            
            DataTable result = DataProviderDAO.getInstance().ExecuteQuery(command);         
            return result;
        }
    }
}
