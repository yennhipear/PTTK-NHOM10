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
        
        private static DataProviderDAO Instance = null;

        private DataProviderDAO() { }

        public static DataProviderDAO getInstance()
        {
            if (Instance == null)
                Instance = new DataProviderDAO();
            return Instance;
        }

        //tra ve cai bang data
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

        //tra ve object moi
        public object ExecuteScalar(SqlCommand command)
        {
            object result = null;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
            try
            {
                conn.Open();
                command.Connection = conn;
                result = command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                result = null;
            }            
            return result;
        }

        public int ExecuteNonQuery(SqlCommand command)
        {
            int result = 0;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
            try
            {
                conn.Open();
                command.Connection = conn;
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return result;
        }

        public void ExecuteReader(SqlCommand command)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
            try
            {
                conn.Open();
                command.Connection = conn;
                command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
