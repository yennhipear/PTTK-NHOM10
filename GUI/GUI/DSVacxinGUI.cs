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
    public partial class DSVacxinGUI : Form
    {
        DSVacxinBUS dktcBus;

        public DSVacxinGUI()
        {
            InitializeComponent();
            DSVacxinHT_Datagridview.AutoGenerateColumns = false;

            dktcBus = new DSVacxinBUS();
            DSVacxinHT_Datagridview.DataSource = dktcBus.LayDSVacxinHT();

            DSVacxinHT_Datagridview.CellClick += DSHT_ChiTietBtn_Click;
            DSVacxinHT_Datagridview.CellClick += DSHT_ThemVaoDSChonBtn_Click;
            DSVacxinChon_Datagridview.CellValueChanged += DSChon_ThayDoiSL_CellChange;
            DSVacxinChon_Datagridview.UserDeletedRow += DSChon_XoaHang;
        }

        private void HienThiTongTien()
        {
            long tong = 0;

            foreach (DataGridViewRow row in DSVacxinChon_Datagridview.Rows)
            {
                tong += long.Parse(row.Cells["Chon_GiaBan"].Value.ToString()) * long.Parse(row.Cells["Chon_SL"].Value.ToString());
            }

            ThanhTien_Label.Text = tong.ToString();
            ThanhTien_Label.Visible = true;
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
                row.Cells["Chon_SL"].Value = 1;

                HienThiTongTien();
            }
        }

        public void DSChon_ThayDoiSL_CellChange(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DSVacxinChon_Datagridview.Columns["Chon_SL"].Index && e.RowIndex >= 0)
            {
                HienThiTongTien();
            }            
        }

        public void DSChon_XoaHang(Object sender, DataGridViewRowEventArgs e)
        {
           HienThiTongTien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new DangKyTiemChungGUI(DSVacxinChon_Datagridview, long.Parse(ThanhTien_Label.Text))).Show();
        }

        private void HangSX_Label_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DSVacxinGUI_Load(object sender, EventArgs e)
        {

        }

        private void DSVacxinHT_Datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
