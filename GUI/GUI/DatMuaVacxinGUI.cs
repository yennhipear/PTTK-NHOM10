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
    public partial class DatMuaVacxinGUI : Form
    {
        DatMuaVacxinBUS dmvxBus;
        public DatMuaVacxinGUI()
        {
            InitializeComponent();
            DSVacXinHT_DataGridView.AutoGenerateColumns = false;

            dmvxBus = new DatMuaVacxinBUS();
            DSVacXinHT_DataGridView.DataSource = dmvxBus.LayDSVacxinHT();

            DSVacXinHT_DataGridView.CellClick += DSHT_ChiTiet_Click;
            DSVacXinHT_DataGridView.CellClick += DSHT_ThemVaoSLVacxin_Click;
            DSVacXinHT_DataGridView.CellClick += DSHT_GiamVaoSLVacxin_Click;
         
            DSVacxinDaChon_DataGridView.CellClick += DSDC_XoaVacxin_Click;
        }


        private void HienThiTongTien()
        {
            long tong = 0;

            foreach (DataGridViewRow row in DSVacxinDaChon_DataGridView.Rows)
            {
                tong += long.Parse(row.Cells["Gia"].Value.ToString()) * long.Parse(row.Cells["soluong"].Value.ToString());
            }

            label10.Text = tong.ToString();
            label10.Visible = true;
        }


        public void DSHT_ChiTiet_Click(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String maVacxin = DSVacXinHT_DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                String[] chiTietVacxin = dmvxBus.LayCTVacxin(maVacxin);


                HangSX_ND_Label.Text = chiTietVacxin[0];
                MoTa_ND_Label.Text = chiTietVacxin[1];

                HangSX_Label.Visible = true;
                MoTa_Label.Visible = true;
                HangSX_ND_Label.Visible = true;
                MoTa_ND_Label.Visible = true;
            }
        }


        public void DSHT_ThemVaoSLVacxin_Click(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DSVacXinHT_DataGridView.Columns["btnSoLuong"].Index && e.RowIndex >= 0)
            {
              
                bool DaThem = false;
                //Gán value của từng cell cho dòng mới               
                for (int i = 0; i < DSVacxinDaChon_DataGridView.RowCount; i++)
                {
                    if (DSVacxinDaChon_DataGridView.Rows[i].Cells[0].Value.Equals(DSVacXinHT_DataGridView.Rows[e.RowIndex].Cells[0].Value))
                    {
                        int x = int.Parse(DSVacxinDaChon_DataGridView.Rows[i].Cells["soluong"].Value.ToString());
                        DSVacxinDaChon_DataGridView.Rows[i].Cells["soluong"].Value = x + 1;

                        DaThem = true;
           
                    }
                }


                if (!DaThem)
                {
                    DSVacxinDaChon_DataGridView.Rows.Add();
                    DataGridViewRow row = DSVacxinDaChon_DataGridView.Rows[DSVacxinDaChon_DataGridView.Rows.Count - 1];

                    for (int i = 0; i < DSVacXinHT_DataGridView.ColumnCount - 2; i++)
                    {
                        row.Cells[i].Value = DSVacXinHT_DataGridView.Rows[e.RowIndex].Cells[i].Value;
                    }

                    row.Cells["soluong"].Value = 1;

                }
           
                HienThiTongTien();
            }
        }

        public void DSHT_GiamVaoSLVacxin_Click(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DSVacXinHT_DataGridView.Columns["GiamSL"].Index && e.RowIndex >= 0)
            {

                bool DaXoa= false;
                //Gán value của từng cell cho dòng mới               
                for (int i = 0; i < DSVacxinDaChon_DataGridView.RowCount; i++)
                {
                    if (DSVacxinDaChon_DataGridView.Rows[i].Cells[0].Value.Equals(DSVacXinHT_DataGridView.Rows[e.RowIndex].Cells[0].Value))
                    {
                        int x = int.Parse(DSVacxinDaChon_DataGridView.Rows[i].Cells["soluong"].Value.ToString());
                        DSVacxinDaChon_DataGridView.Rows[i].Cells["soluong"].Value = x - 1;

                        DaXoa = true;

                    }
                }
                HienThiTongTien();

                if (!DaXoa)
                {
                    MessageBox.Show("Không thể xóa vắc xin chưa được chọn!");
                }

            }
        }

        public void DSDC_XoaVacxin_Click(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DSVacxinDaChon_DataGridView.Columns["XoaVacXin"].Index && e.RowIndex >= 0)
            {
                DSVacxinDaChon_DataGridView.Rows.RemoveAt(e.RowIndex);
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new DatVacXinKhac()).Show();
        }
    //}
}
