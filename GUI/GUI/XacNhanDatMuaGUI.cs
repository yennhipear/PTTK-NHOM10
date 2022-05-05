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
using GUI.BUS;

namespace GUI.GUI
{
    public partial class XacNhanDatMuaGUI : Form
    {
        public XacNhanDatMuaGUI(DataGridView dsChon, string TongTien)
        {
           InitializeComponent();

            for (int i = 0; i < dsChon.Rows.Count; i++)
            {
              
                DSVacxinDaChon2_DataGridView.Rows.Add();
                DataGridViewRow dataRow = (DataGridViewRow)DSVacxinDaChon2_DataGridView.Rows[DSVacxinDaChon2_DataGridView.RowCount - 1];
                for (int j = 0; j < dsChon.ColumnCount; j++)
                {
                     dataRow.Cells[j].Value = dsChon.Rows[i].Cells[j].Value;
                }
            }

           ThanhTien_Label.Text = TongTien;
           ThanhTien_Label.Visible = true;

            HoTen_TextBox.Text = CurrentUser.HoTen;
            GioiTinh_TextBox.Text = CurrentUser.GioiTinh;
            NgaySinh_TextBox.Text = CurrentUser.NgaySinh.ToString();
            CMND_TextBox.Text = CurrentUser.Cmnd;
            Sdt_TextBox.Text = CurrentUser.Sdt;
            DiaChi_TextBox.Text = CurrentUser.DiaChi;
            Email_TextBox.Text = CurrentUser.Email;

            TGDM_Picker.Value = DateTime.Today;

        }

        private void Xacnhan_Button_Click(object sender, EventArgs e)
        {

            String MaKH, TinhTrang;
            DateTime NgayDM;
            List<CTPHIEUDMVX> DsCT = new List<CTPHIEUDMVX>();

            MaKH = CurrentUser.Ma;
         
            NgayDM = TGDM_Picker.Value;
            TinhTrang = "Chờ duyệt";

            // Duyệt qua danh sách vắc xin được chọn (DSVacxinChon_datagridview):
            foreach (DataGridViewRow row in DSVacxinDaChon2_DataGridView.Rows)
            {
             
                string maVacxin = row.Cells["MaVX"].Value.ToString();
                string SoLuong = row.Cells["soluong"].Value.ToString();

                int SL = Int32.Parse(SoLuong);
                CTPHIEUDMVX ct = new CTPHIEUDMVX(maVacxin, SL);
                DsCT.Add(ct);
            }

            PhieuDatMuaVacxinDTO model = new PhieuDatMuaVacxinDTO(MaKH, NgayDM, DsCT, TinhTrang);

            DatMuaVacxinBUS bus = new DatMuaVacxinBUS();
            // int newID = bus.LuuThongTinDatMua(model);
            int newID = 6;
            if (newID > 0)
            {
                MessageBox.Show("Đặt mua thành công. Mã phiếu đặt mua của bạn: " + newID.ToString(), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                (new ThanhToanGUI(DSVacxinDaChon2_DataGridView, long.Parse(ThanhTien_Label.Text), "DMVX")).Show();
                this.Close();
            }
            else
                MessageBox.Show("Đã xảy ra lỗi. Không thể đặt mua", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TGDK_Picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

