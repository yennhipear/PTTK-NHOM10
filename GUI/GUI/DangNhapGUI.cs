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

            bool isKH = false;
            bool isNV = false;
            if (tbUsername.Text == "" || tbPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đăng nhập.");
            }
            else 
            {
                isKH = BUS.DangNhapBUS.Instance.Login("KH", username, password);
                if (!isKH)
                {
                    isNV = BUS.DangNhapBUS.Instance.Login("NV", username, password);
                    if (!isNV)
                        MessageBox.Show("Thông tin đăng nhập sai.");
                    else
                    {
                        //MessageBox.Show("Nhân viên đăng nhập");
                        GUI.NV_Menu f = new GUI.NV_Menu();
                        this.Hide();
                        f.ShowDialog();
                    }
                } else
                {
                    //MessageBox.Show("Khách hàng đăng nhập");
                    KH_Menu f = new KH_Menu();
                    this.Hide();
                    f.ShowDialog();
                }
            }           
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            (new DangKyTaiKhoanGUI()).Show();
        }       
    }
}
