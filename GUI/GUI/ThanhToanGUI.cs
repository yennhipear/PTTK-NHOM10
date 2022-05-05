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
    public partial class ThanhToanGUI : Form
    {
        String MaPhieu;
        public ThanhToanGUI(DataGridView dsChon, long TongTien, String dichVu, String maPhieu)
        {
            InitializeComponent();
            MaPhieu = maPhieu;
            // Copy data từ datagridview được truyền vào vô datagridview của form này         
            foreach (DataGridViewColumn dgvc in dsChon.Columns)
            {
                DSVacxinChon_Datagridview.Columns.Add(dgvc.Clone() as DataGridViewColumn);
            }
            for (int i = 0; i < dsChon.Rows.Count; i++)
            {
                DSVacxinChon_Datagridview.Rows.Add();
                DataGridViewRow dataRow = (DataGridViewRow)DSVacxinChon_Datagridview.Rows[DSVacxinChon_Datagridview.RowCount - 1];
                for (int j = 0; j < dsChon.ColumnCount; j++)
                {
                    dataRow.Cells[j].Value = dsChon.Rows[i].Cells[j].Value;
                }             
            }
            //DSVacxinChon_Datagridview.Refresh();
            
            ThanhTien_Label.Text = TongTien.ToString();
            ThanhTien_Label.Visible = true;

            HoTenKH_TextBox.Text = CurrentUser.HoTen;
            SdtKH_TextBox.Text = CurrentUser.Sdt;
            DiaChiKH_TextBox.Text = CurrentUser.DiaChi;
            NgaySinhKH_Picker.Value = CurrentUser.NgaySinh;
            GioiTinhKH_ComboBox.Text = CurrentUser.GioiTinh;
            DichVu_Combobox.Text = (dichVu == "DKTC" ? "Đăng ký tiêm chủng" : "Đặt mua vắc xin");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng ký thành công. Mã phiếu đăng ký của bạn: " + MaPhieu, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
