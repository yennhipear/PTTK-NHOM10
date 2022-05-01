using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

using GUI.DAO;

namespace GUI.BUS
{
    public class DangNhapBUS
    {
        private static DangNhapBUS _instance = null;
        public static DangNhapBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DangNhapBUS();
                }
                return _instance;
            }
        }

        public void Login(String username, String password)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.UserID = username;
                builder.Password = password;
                builder.DataSource = "local";
                builder.InitialCatalog = "DB_HeThongDangKyTiemChung";
                builder.IntegratedSecurity = false;

                using (SqlConnection con = new SqlConnection(builder.ConnectionString))
                {
                    Menu f = new Menu();
                    //this.Hide();
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.ShowDialog();
                    //this.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool KH_username_pass_existed(String username, String password)
        {
            bool flag = false;
            SqlConnection conn = new SqlConnection(@"Data Source = YENNHILE\SQLEXPRESS; Initial Catalog = DB_HeThongDangKyTiemChung; Integrated Security = True");
            if (username != "" )
            {
                conn.Open();
                //kiem tra username co trong data hong
                string sql = "select username, pass from KHACHHANG where USERNAME='" +username+ "' and PASS='" +password+ "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader();

                if (data.Read() == true)
                {
                    //Console.WriteLine(HashString(password)+"n");
                    flag = true;
                    return flag;
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
                flag = false;
            }
            return flag;
        }

        public bool NV_username_pass_existed(String username, String password)
        {
            bool flag = false;
            SqlConnection conn = new SqlConnection(@"Data Source = YENNHILE\SQLEXPRESS; Initial Catalog = DB_HeThongDangKyTiemChung; Integrated Security = True");
            if (username != "")
            {
                conn.Open();
                //kiem tra username co trong data hong
                string sql = "select username, pass from NHANVIEN where USERNAME='" + username + "' and PASS='" + password + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader();

                if (data.Read() == true)
                {
                    //Console.WriteLine(HashString(password)+"n");
                    flag = true;
                    return flag;
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
                flag = false;
            }
            return flag;
        }

        // dont delete!
        public string HashString(string password)
        {
            string salt = "";
            if (String.IsNullOrEmpty(password))
            {
                return String.Empty;
            }

            // Uses SHA256 to create the hash
            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                // Convert the string to a byte array first, to be processed
                byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha.ComputeHash(textBytes);

                // Convert back to a string, removing the '-' that BitConverter adds
                string hash = BitConverter
                    .ToString(hashBytes)
                    .Replace("-", String.Empty);

                return hash;
            }
        }
    }
}
