using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class DangKyTaiKhoanGUI : Form
    {
        public DangKyTaiKhoanGUI()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DangKyTaiKhoanGUI_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool checkAccount (string acc)
        {
            return Regex.IsMatch(acc, "^[a-zA-Z0-9_.]{6,24}$");
        }

        public bool checkEmail (string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,30}@gmail.com(.vn|)$");
        }

        public bool checkNameandGender(string c)
        {
            return Regex.IsMatch(c, "^[a-zA-Z]{2,100}$");
        }

        public bool checkSDT (string sdt)
        {
            return Regex.IsMatch(sdt, "^[0-9]{10,11}$");
        }

        public bool checkCMND(string cmnd)
        {
            return Regex.IsMatch(cmnd, "^[0-9]{10,12}$");
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string username     = tb_usename.Text;
            string password     = tb_pass.Text;
            string confirmPass  = tb_confirmpass.Text;
            string name         = tb_name.Text;
            string gender       = tb_gender.Text;
            string cmnd         = tb_cmnd.Text;
            string sdt          = tb_sdt.Text;
            string email        = tb_email.Text;
            string diachi       = tb_diachi.Text;

            if (!checkAccount(username))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 kí tự, với các kí tự là chữ cái viết hoa, viết thường và số!");
                return;
            }
            if (!checkAccount(password))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 kí tự, với các kí tự là chữ cái viết hoa, viết thường và số!");
                return;
            }
            if (confirmPass != password)
            {
                MessageBox.Show("Vui lòng xác nhận lại mật khẩu!");
                return;
            }
            if (!checkNameandGender(name))
            {
                MessageBox.Show("Vui lòng nhập họ tên với các kí tự là chữ cái viết hoa, viết thường!");
                return;
            }
            if (!checkNameandGender(gender))
            {
                MessageBox.Show("Vui lòng nhập lại giới tính!");
                return;
            }
            if (!checkCMND(cmnd))
            {
                MessageBox.Show("Vui lòng nhập lại CMND!");
                return;
            }
            if (!checkSDT(sdt))
            {
                MessageBox.Show("Vui lòng nhập lại số điện thoại!");
                return;
            }
            if (!checkEmail(email))
            {
                MessageBox.Show("Vui lòng nhập lại email!");
                return;
            } 

        }
    }
}
