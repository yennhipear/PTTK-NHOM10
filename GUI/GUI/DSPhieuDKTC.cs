using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.BUS;

namespace GUI.GUI
{
    public partial class DSPhieuDKTCGUI : Form
    {
        private XuLyPhieuDKTCBUS xuLyPhieuBUS;

        public DSPhieuDKTCGUI()
        {
            InitializeComponent();
            DSPhieuDKTC_Datagridview.AutoGenerateColumns = false;

            xuLyPhieuBUS = new XuLyPhieuDKTCBUS();
            DSPhieuDKTC_Datagridview.DataSource = xuLyPhieuBUS.LayDSPhieuDKTC();

            DSPhieuDKTC_Datagridview.CellContentClick += HienThiCTPhieuDKTC;
        }

        public void HienThiCTPhieuDKTC(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DSPhieuDKTC_Datagridview.Columns["ChiTiet"].Index)
            {
                String maPDKTC = DSPhieuDKTC_Datagridview.Rows[e.RowIndex].Cells["MaPDK"].Value.ToString();
                (new XuLyPhieuDKTCGUI(maPDKTC)).Show();
            }
        }


    }
}
