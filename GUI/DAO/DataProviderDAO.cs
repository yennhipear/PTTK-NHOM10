using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace GUI.DAO
{
    class DataProviderDAO
    {
        private static SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
        private static DataProviderDAO Instance = null;

        private DataProviderDAO() { }

        public static DataProviderDAO getInstance()
        {
            if (Instance == null)
                Instance = new DataProviderDAO();
            return Instance;
        }

        public DataTable ExecuteQuery(SqlCommand command)
        {
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
            DataTable result = new DataTable();
            try
            {
                cnn.Open();
                command.Connection = cnn;
                SqlDataAdapter sqlDaDH = new SqlDataAdapter(command);
                sqlDaDH.Fill(result);

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                result = null;
            }
            return result;
        }
    }
}
