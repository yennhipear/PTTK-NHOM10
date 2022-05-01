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
        DangKyTiemChungBUS dktcBus;

        public DSVacxinGUI()
        {
            InitializeComponent();
            GoiVacxinHT_Datagridview.AutoGenerateColumns = false;

            dktcBus = new DangKyTiemChungBUS();
            GoiVacxinHT_Datagridview.DataSource = dktcBus.LayDSGoiVacxinHT();

            GoiVacxinHT_Datagridview.CellClick += HienThiCTGoiVacxin;
            GoiVacxinHT_Datagridview.CellClick += DSHT_ThemVaoDSChonBtn_Click;    
            DSVacxinChon_Datagridview.CellClick += HienThiCTGoiVacxin;
            DSVacxinChon_Datagridview.CellClick += DSChon_XoaHang;

            CTGoiVacxin_Datagridview.CellClick += HienThiCTVacxin;
        }

        private void HienThiTongTien()
        {
            long tong = 0;

            foreach (DataGridViewRow row in DSVacxinChon_Datagridview.Rows)
            {
                tong += long.Parse(row.Cells["Chon_GiaBan"].Value.ToString());
            }

            ThanhTien_Label.Text = tong.ToString();
            ThanhTien_Label.Visible = true;
        }

        public void HienThiCTVacxin(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String maVacxin = CTGoiVacxin_Datagridview.Rows[e.RowIndex].Cells[0].Value.ToString();
                String[] chiTietVacxin = dktcBus.LayCTVacxin(maVacxin);

                HangSX_ND_Label.Text = chiTietVacxin[0];
                MoTa_ND_Label.Text = chiTietVacxin[1];

                HangSX_Label.Visible = true;
                MoTa_Label.Visible = true;
                HangSX_ND_Label.Visible = true;
                MoTa_ND_Label.Visible = true;
            }
        }

        public void HienThiCTGoiVacxin(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String maGoiVacxin = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
                CTGoiVacxin_Datagridview.DataSource = dktcBus.LayCTGoiVacxinHT(maGoiVacxin);
            }
        }

        public void DSHT_ThemVaoDSChonBtn_Click(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GoiVacxinHT_Datagridview.Columns["ThemBtnCol"].Index && e.RowIndex >= 0)
            {
                DSVacxinChon_Datagridview.Rows.Add();
                DataGridViewRow row = DSVacxinChon_Datagridview.Rows[DSVacxinChon_Datagridview.Rows.Count - 1];     //Lấy dòng cuối cùng - dòng mới thêm
               
                //Gán value của từng cell cho dòng mới               
                for (int i = 0; i < GoiVacxinHT_Datagridview.ColumnCount -1; i++)
                {
                    row.Cells[i].Value = GoiVacxinHT_Datagridview.Rows[e.RowIndex].Cells[i].Value;
                }
                //row.Cells["Chon_SL"].Value = 1;

                HienThiTongTien();
            }
        }

        public void DSChon_XoaHang(Object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == DSVacxinChon_Datagridview.Columns["Chon_Xoa"].Index && e.RowIndex >= 0)
            {
                DSVacxinChon_Datagridview.Rows.RemoveAt(e.RowIndex);
                HienThiTongTien();
            }
        }

        private void XacNhanButton_Click(object sender, EventArgs e)
        {
            if (DSVacxinChon_Datagridview.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một gói vắc xin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            (new DangKyTiemChungGUI(DSVacxinChon_Datagridview, long.Parse(ThanhTien_Label.Text))).Show();
            this.Close();
        }

        private void DSVacxinGUI_Load(object sender, EventArgs e)
        {

        }

        private void GoiVacxinHT_Datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CTGoiVacxin_Datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
