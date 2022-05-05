using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.DTO;

namespace GUI.GUI
{
    public partial class NV_Menu : Form
    {
        public NV_Menu()
        {
            InitializeComponent();
            Hello_Label.Text = $"Xin chào, {CurrentUser.HoTen}";
        }
       
        private void XepLich_Button_Click(object sender, EventArgs e)
        {
            (new XepLichLamViecGUI()).Show();
        }

        private void XuLyPhieuDKTC_Button_Click(object sender, EventArgs e)
        {
            (new DSPhieuDKTCGUI()).Show();
        }

        private void DKLichRanh_Button_Click(object sender, EventArgs e)
        {
            (new DangKyLichRanhGUI()).Show();
        }
    }
}
