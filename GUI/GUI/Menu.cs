using GUI.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new DSVacxinGUI()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new DangKyLichRanhGUI()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new XepLichLamViecGUI()).Show();
        }

        private void btnDatMuaVacxin_Click(object sender, EventArgs e)
        {
            (new DatMuaVacxinGUI()).Show();
        }

    
        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
