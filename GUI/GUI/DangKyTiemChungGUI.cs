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
        }
    }
}
