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
            DSVacxinHT_Datagridview.CellClick += DSHT_ThemVaoDSChonBtn_Click;
        }

        public void DSHT_ChiTietBtn_Click(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String maVacxin = DSVacxinHT_Datagridview.Rows[e.RowIndex].Cells[0].Value.ToString();
                String[] chiTietVacxin = dktcBus.LayCTVacxin(maVacxin);

                HangSX_ND_Label.Text = chiTietVacxin[0];
                MoTa_ND_Label.Text = chiTietVacxin[1];

                HangSX_Label.Visible = true;
                MoTa_Label.Visible = true;
                HangSX_ND_Label.Visible = true;
                MoTa_ND_Label.Visible = true;
            }
        }

        public void DSHT_ThemVaoDSChonBtn_Click(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DSVacxinHT_Datagridview.Columns["ThemBtnCol"].Index && e.RowIndex >= 0)
            {
                DSVacxinChon_Datagridview.Rows.Add();
                DataGridViewRow row = DSVacxinChon_Datagridview.Rows[DSVacxinChon_Datagridview.Rows.Count - 1];     //Lấy dòng cuối cùng - dòng mới thêm
               
                //Gán value của từng cell cho dòng mới               
                for (int i = 0; i < DSVacxinHT_Datagridview.ColumnCount -1; i++)
                {
                    row.Cells[i].Value = DSVacxinHT_Datagridview.Rows[e.RowIndex].Cells[i].Value;
                }
            }
        }
    }
}
