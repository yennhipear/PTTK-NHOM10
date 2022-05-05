using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace GUI.DAO
{
    class VacxinNgoaiDAO
    {
        private static VacxinNgoaiDAO Instance = null;
    
        public static VacxinNgoaiDAO getInstance()
        {
            if (Instance == null)
                Instance = new VacxinNgoaiDAO();
            return Instance;
        }

        public DataTable LayVacxinNgoai()
        {
            DataTable result = DataProviderDAO.getInstance().ExecuteQuery(new SqlCommand("Select * from VACXINNGOAI where MAVACXIN = ( select MAX(MAVACXIN) form VACXINNGOIA) "));
            return result;
        }

        public int LuuThongTinVacxinNgoai(VacxinNgoaiDTO vacxinNgoai)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = vacxinNgoai.getInsertSqlCommand();

                SqlTransaction transaction;
                transaction = connection.BeginTransaction("Them vacxin ngoai");

                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    // Thêm Phiếu đk mới, đông thời lấy ID của vacxin vừa mới thêm
                    String newID = command.ExecuteScalar().ToString();

               

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
                    return Convert.ToInt32(newID);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("Message: {0}", ex.Message);
                    MessageBox.Show("ex" + ex.Message);
                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                        MessageBox.Show("ex2" + ex2.Message);
                    }
                    return -1;
                }
            }
        }
    }
}
