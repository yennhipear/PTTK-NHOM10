using GUI.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.GUI
{
    public partial class DangKyLichRanhGUI : Form
    {
        public DangKyLichRanhGUI()
        {
            InitializeComponent();
        }

        private void dklrBtn_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("Xác nhận đăng ký?", "Xác nhận", MessageBoxButtons.YesNo);
            // get these infos later from DB
            int userID = 1;
            int weekID = 1;
            if (choose == DialogResult.Yes) {
                if(DangKyLichRanhBUS.dangKyLichRanh(userID, weekID, dklrDGV))
                {
                    MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                } else
                {
                    MessageBox.Show("Thông tin đăng ký không hợp lệ", "Lỗi", MessageBoxButtons.OK);
                }
            }
        }

        private void huyDklrBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
