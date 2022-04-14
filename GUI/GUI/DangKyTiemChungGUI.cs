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
    public partial class DangKyTiemChungGUI : Form
    {
        DangKyTiemChungBUS dktcBus;

        public DangKyTiemChungGUI()
        {
            InitializeComponent();
            DSVacxinHT_Datagridview.AutoGenerateColumns = false;

            dktcBus = new DangKyTiemChungBUS();
            DSVacxinHT_Datagridview.DataSource = dktcBus.LayDSVacxinHT();

            DSVacxinHT_Datagridview.CellClick += DSHT_ChiTietBtn_Click;
        }

        public void DSHT_ChiTietBtn_Click(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String maVacxin = DSVacxinHT_Datagridview.Rows[e.RowIndex].Cells[0].Value.ToString();
                ChiTiet_Textbox.Lines = dktcBus.LayCTVacxin(maVacxin);
            }
        }
    }
}
