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
    public partial class KH_Menu : Form
    {
        public KH_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new DSVacxinGUI()).Show();
        }

        private void btnDatMuaVacxin_Click(object sender, EventArgs e)
        {
            (new DatMuaVacxinGUI()).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new DSPhieuDKTCGUI()).Show();
        }
    }
}
