using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace GUI.DAO
{
    class PhieuDangKyTiemChungDAO
    {
        private static PhieuDangKyTiemChungDAO Instance = null;

        private PhieuDangKyTiemChungDAO() { }

        public static PhieuDangKyTiemChungDAO getInstance()
        {
            if (Instance == null)
                Instance = new PhieuDangKyTiemChungDAO();
            return Instance;
        }

        public int LuuThongTinDangKy(PhieuDangKyTiemChungDTO phieuDangKy)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = phieuDangKy.getInsertSqlCommand();

                SqlTransaction transaction;
                transaction = connection.BeginTransaction("Them Phieu DKTC");
                
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    // Thêm Phiếu đk mới, đông thời lấy ID của phiếu vừa mới thêm
                    String newID = command.ExecuteScalar().ToString();

                    // Lấy ds câu lệnh thêm CT phiếu ĐK
                    List<SqlCommand> commands = phieuDangKy.getInsertCTSqlCommand(newID);
                    
                    //Duyệt qua ds câu lệnh và thực thi từng câu lệnh để thêm CT phiếu ĐK
                    foreach (SqlCommand comm in commands)
                    {
                        comm.Connection = connection;
                        comm.Transaction = transaction;

                        comm.ExecuteNonQuery();
                    }

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
                    return Convert.ToInt32(newID);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("Message: {0}", ex.Message);

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
                    }
                    return -1;
                }
            }
           
           
        }
    }
}
