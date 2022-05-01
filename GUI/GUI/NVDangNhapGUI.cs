﻿using System;
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
    public partial class NVDangNhapGUI : Form
    {
        public NVDangNhapGUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            String username = tbUsername.Text;
            String password = tbPass.Text;

            if (tbUsername.Text == "" || tbPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đăng nhập.");
            }
            else if (BUS.DangNhapBUS.Instance.NV_username_pass_existed(username, password) == false)
            {
                MessageBox.Show("Thông tin đăng nhập sai.");
            }
            else
            {
                try
                {
                    BUS.DangNhapBUS.Instance.Login(username, password);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            (new DangKyTaiKhoanGUI()).Show();
        }

        private void DangNhapGUI_Load(object sender, EventArgs e)
        {

        }
    }
}