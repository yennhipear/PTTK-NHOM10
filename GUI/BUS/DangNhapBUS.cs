using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Configuration;

using GUI.DAO;
using GUI.DTO;
using System.Data;

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

        //public bool Login(String username, String password)
        //{
        //    try
        //    {
        //        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        //        builder.UserID = username;
        //        builder.Password = password;
        //        builder.DataSource = "local";
        //        builder.InitialCatalog = "DB_HeThongDangKyTiemChung";
        //        builder.IntegratedSecurity = false;

        //        using (SqlConnection con = new SqlConnection(builder.ConnectionString))
        //        {
        //            KH_layThongTin(username, con);
        //            return true;                    
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return false;
        //        //throw new Exception(ex.Message);
        //    }
        //}

        public bool Login(String type, String username, String password)
        {
            bool flag = false;
            String table = (type == "NV") ? "NHANVIEN" : "KHACHHANG";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString))
            {
                con.Open();
                //kiem tra username co trong data hong
                SqlCommand cmd = new SqlCommand($"select * from {table} where USERNAME= @username and PASS= @pass", con);
                cmd.Parameters.Add(new SqlParameter("@username", username));
                cmd.Parameters.Add(new SqlParameter("@pass", password));

                DataTable result = new DataTable();
                SqlDataAdapter sqlDaDH = new SqlDataAdapter(cmd);
                sqlDaDH.Fill(result);

                if (result.Rows.Count > 0)
                {
                    if (type == "KH")
                        KH_layThongTin(result);
                    else NV_layThongTin(result);
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                con.Close();
            }           
            return flag;
        }
        
        private void KH_layThongTin(DataTable queryResult)
        {
            CurrentUser.Ma = queryResult.Rows[0]["MAKH"].ToString();
            CurrentUser.HoTen = queryResult.Rows[0]["HOTENKH"].ToString();
            CurrentUser.DiaChi = queryResult.Rows[0]["DIACHIKH"].ToString();
            CurrentUser.GioiTinh = queryResult.Rows[0]["GIOITINHKH"].ToString();
            CurrentUser.Email = queryResult.Rows[0]["EMAILKH"].ToString();
            CurrentUser.Cmnd = queryResult.Rows[0]["CMNDKH"].ToString();
            CurrentUser.NgaySinh = DateTime.Parse(queryResult.Rows[0]["NGAYSINHKH"].ToString());
            CurrentUser.Sdt = queryResult.Rows[0]["SDTKH"].ToString();
            CurrentUser.Username = queryResult.Rows[0]["USERNAME"].ToString();
            CurrentUser.isNhanVien = false;            
        }
         
        private void NV_layThongTin(DataTable queryResult)
        {
            CurrentUser.Ma = queryResult.Rows[0]["MANHANVIEN"].ToString();
            CurrentUser.HoTen = queryResult.Rows[0]["HOTEN"].ToString();
            CurrentUser.Email = queryResult.Rows[0]["EMAIL"].ToString();
            CurrentUser.Sdt = queryResult.Rows[0]["SDT"].ToString();
            CurrentUser.Username = queryResult.Rows[0]["USERNAME"].ToString();
            CurrentUser.isNhanVien = true;
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
