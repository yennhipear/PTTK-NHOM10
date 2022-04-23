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
            DataTable result = DataProviderDAO.getInstance().ExecuteQuery(new SqlCommand("Select MAVACXIN, TENVACXIN, NGUABENH, GIABAN, SLTIEM from VACXIN"));           
            return result;
        }

        public DataTable LayDSGoiVacxinHT()
        {
            DataTable result = DataProviderDAO.getInstance().ExecuteQuery(new SqlCommand("Select MAGOIVACXIN, TENGOIVACXIN, GIABAN, SLTIEM from GOIVACXIN"));
            return result;
        }

        public DataTable LayCTVacxin(String maVacxin)
        {
            SqlCommand command = new SqlCommand("Select HANGVACXIN, MOTA from VACXIN WHERE MAVACXIN = @maVacxin");
            command.Parameters.Add(new SqlParameter("@maVacxin", maVacxin));
            
            DataTable result = DataProviderDAO.getInstance().ExecuteQuery(command);         
            return result;
        }

        public DataTable LayCTGoiVacxinHT(String maGoiVacxin)
        {
            SqlCommand command = 
                new SqlCommand(@"select v.MAVACXIN, v.TENVACXIN, v.NGUABENH, v.GIABAN, v.SLTIEM
                                from GOIVACXIN g JOIN CTGOIVACXIN ct on(ct.MAGOIVACXIN = g.MAGOIVACXIN)
                                JOIN vacxin v on(v.MAVACXIN = ct.MAVACXIN)
                                where g.MAGOIVACXIN = @maGoiVacxin");

            command.Parameters.Add(new SqlParameter("@maGoiVacxin", maGoiVacxin));

            DataTable result = DataProviderDAO.getInstance().ExecuteQuery(command);
            return result;
        }
    }
}
