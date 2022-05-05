using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI
{
    public partial class KHDangNhapGUI : Form
    {
        public KHDangNhapGUI()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            String username = tbUsername.Text;
            String password = tbPass.Text;

            if (tbUsername.Text == "" || tbPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đăng nhập.");
            }
            else if (BUS.DangNhapBUS.Instance.Login("KH", username, password) == false)
            {
                MessageBox.Show("Thông tin đăng nhập sai.");
            }
            else
            {                
                Menu f = new Menu();
                this.Hide();

                f.StartPosition = FormStartPosition.CenterScreen;
                f.ShowDialog();
            }
        }

        private void cbbDangNhap_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbb_DangNhap.SelectedItem.ToString() == "Nhân viên")
            {
                this.Hide();
                NVDangNhapGUI f  = new NVDangNhapGUI();
                f.ShowDialog();
                this.Close();
            }
            this.Hide();
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            (new DangKyTaiKhoanGUI()).Show();
        }

    
    }
}
