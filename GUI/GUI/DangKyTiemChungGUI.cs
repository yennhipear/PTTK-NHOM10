using GUI.DAO;
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
            DSVacxinChon_Datagridview.AllowUserToAddRows = false;
            DSVacxinChon_Datagridview.Refresh();
            DSVacxinChon_Datagridview.CellValueChanged += DSVacxinChon_Datagridview_CellContentClick;
            ThanhTien_Label.Text = TongTien.ToString();
            ThanhTien_Label.Visible = true;

            // Thiết lập danh sách chi nhánh combobox
            ThietlapDSCNComboBox();

            DKNT_Checkbox.Enabled = true;
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

        private void GiamHo_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
           TTNgTiem_Panel.Enabled = DKNT_Checkbox.Checked;
        }
    }
}
