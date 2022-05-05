using GUI.DAO;
using GUI.BUS;
using GUI.DTO;
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
        public DangKyTiemChungGUI(DataGridView dsChon, long TongTien)
        {
            InitializeComponent();

            // Copy data từ datagridview được truyền vào vô datagridview của form này         
            for (int i = 0; i < dsChon.Rows.Count; i++)
            {
                // Có bao nhiêu lần tiêm thì hiển thị bấy nhiêu dòng
                int slTiem = int.Parse(dsChon.Rows[i].Cells["Chon_SLTiem"].Value.ToString());
                for (int soDong = 0; soDong < slTiem; soDong++)
                {
                    DSVacxinChon_Datagridview.Rows.Add();
                    DataGridViewRow dataRow = (DataGridViewRow)DSVacxinChon_Datagridview.Rows[DSVacxinChon_Datagridview.RowCount - 1];
                    for (int j = 0; j < dsChon.ColumnCount; j++)
                    {
                        dataRow.Cells[j].Value = dsChon.Rows[i].Cells[j].Value;
                    }
                    dataRow.Cells["Chon_LanTiem"].Value = soDong + 1;

                }
            }
            //DSVacxinChon_Datagridview.Refresh();
            DSVacxinChon_Datagridview.CellValueChanged += DSVacxinChon_Datagridview_CellContentClick;
            ThanhTien_Label.Text = TongTien.ToString();
            ThanhTien_Label.Visible = true;

            // Thiết lập danh sách chi nhánh combobox
            ThietlapDSCNComboBox();

            DKNT_Checkbox.Enabled = true;
        
            NgaySinhNT_Picker.CustomFormat = "dd/MM/yyyy";
            NgaySinhNT_Picker.MaxDate = DateTime.UtcNow;
            NgaySinhNT_Picker.Checked = false;

            TGDK_Picker.CustomFormat = "dd/MM/yyyy";
            TGDK_Picker.MinDate = DateTime.UtcNow;
            TGDK_Picker.Checked = false;
        }

        private void ThietlapDSCNComboBox()
        {
            List<String> dsCN = ChiNhanhDAO.getInstance().LayDSTenCN();
            // Thêm cột combox là các tables và views
            DataGridViewComboBoxColumn chiNhanhCombobox = new DataGridViewComboBoxColumn();
            chiNhanhCombobox.HeaderText = "Chi nhánh";
            chiNhanhCombobox.Name = "Chon_ChiNhanh";
            chiNhanhCombobox.DataSource = dsCN;
            DSVacxinChon_Datagridview.Columns.Add(chiNhanhCombobox);
        }

        private void DSVacxinChon_Datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DSVacxinChon_Datagridview.Columns["Chon_ChiNhanh"] != null
                && e.ColumnIndex == DSVacxinChon_Datagridview.Columns["Chon_ChiNhanh"].Index
                && e.RowIndex >= 0
                && DSVacxinChon_Datagridview.Rows[e.RowIndex].Cells["Chon_ChiNhanh"].Value != null
                && Int32.Equals(DSVacxinChon_Datagridview.Rows[e.RowIndex].Cells["Chon_LanTiem"].Value, 1))
            {
                String eventMaGoiVX = DSVacxinChon_Datagridview.Rows[e.RowIndex].Cells[0].Value.ToString();
                object eventCN = DSVacxinChon_Datagridview.Rows[e.RowIndex].Cells["Chon_ChiNhanh"].Value.ToString();

                int i = e.RowIndex;
                while (i < DSVacxinChon_Datagridview.RowCount)
                {
                    String currentMaVX = DSVacxinChon_Datagridview.Rows[i].Cells[0].Value.ToString();
                    if (currentMaVX == eventMaGoiVX)
                    {
                        DSVacxinChon_Datagridview.Rows[i].Cells["Chon_ChiNhanh"].Value = eventCN;
                        ++i;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void DKChoNguoiThan_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
           TTNgTiem_Panel.Enabled = DKNT_Checkbox.Checked;
        }

        private void XacNhanButton_Click(object sender, EventArgs e)
        {
            String MaKH, HoTenNT, CMNDNT, DiaChiNT, GioiTinhNT, SDTNT, QUANHE, TinhTrang;
            DateTime NgayDK, NgSinhNT;
            List<CTPHIEUDKTC> DsCT = new List<CTPHIEUDKTC>();

            MaKH = CurrentUser.Ma;
            HoTenNT = HoTenNT_TextBox.Text;
            CMNDNT = CMNDNT_TextBox.Text;
            DiaChiNT = DiaChiNT_TextBox.Text;
            GioiTinhNT = GioiTinh_ComboBox.Text;
            SDTNT = SdtNT_TextBox.Text;
            QUANHE = QH_ComboBox.Text;

            NgayDK = TGDK_Picker.Value;
            NgSinhNT = NgaySinhNT_Picker.Value;
            TinhTrang = "Chờ duyệt";

            if (DKNT_Checkbox.Checked)
            {
                if (String.IsNullOrEmpty(HoTenNT) || String.IsNullOrEmpty(GioiTinhNT)
                    || String.IsNullOrEmpty(QUANHE) || !NgaySinhNT_Picker.Checked)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HoTenNT_TextBox.Focus();
                    return;
                }
            }

            if (!TGDK_Picker.Checked)
            {
                MessageBox.Show("Vui lòng chọn thời gian đăng ký tiêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TGDK_Picker.Focus();
                return;
            }

            // Duyệt qua danh sách vắc xin được chọn (DSVacxinChon_datagridview):
            foreach (DataGridViewRow row in DSVacxinChon_Datagridview.Rows)
            {
                if (row.Cells["Chon_ChiNhanh"].Value == null)
                {
                    MessageBox.Show("Vui lòng chọn chi nhánh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    row.Selected = true;
                    return;
                }

                string maGoiVacxin = row.Cells["Chon_Ma"].Value.ToString();
                int lanTiem = Convert.ToInt32(row.Cells["Chon_LanTiem"].Value);
                string tenCN = row.Cells["Chon_ChiNhanh"].Value.ToString();

                CTPHIEUDKTC ct = new CTPHIEUDKTC(maGoiVacxin, lanTiem, tenCN);
                DsCT.Add(ct);
            }
            
            PhieuDangKyTiemChungDTO model = new PhieuDangKyTiemChungDTO(MaKH, HoTenNT, CMNDNT, DiaChiNT, GioiTinhNT, SDTNT, QUANHE, NgayDK, NgSinhNT, DsCT, TinhTrang);

            DangKyTiemChungBUS bus = new DangKyTiemChungBUS();
            int newID = bus.LuuThongTinDangKy(model);
            //int newID = 10;
            if (newID > 0)
            {
                //MessageBox.Show("Đăng ký thành công. Mã phiếu đăng ký của bạn: " + newID.ToString(), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                (new ThanhToanGUI(DSVacxinChon_Datagridview, long.Parse(ThanhTien_Label.Text), "DKTC", newID.ToString())).Show();
                this.Close();
            }
            else
                MessageBox.Show("Đã xảy ra lỗi. Không thể thực hiện đăng ký", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TGDK_Picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void QH_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
