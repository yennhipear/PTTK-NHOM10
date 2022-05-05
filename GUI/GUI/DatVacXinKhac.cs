using GUI.BUS;
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
using System.Data.SqlClient;

namespace GUI.GUI
{
    public partial class DatVacXinKhac : Form
    {
        public DatVacXinKhac()
        {
            InitializeComponent();
        }

        private VacxinNgoaiDTO vxn;

        private void ThemVacxinVaoDSChon_button_Click(object sender, EventArgs e)
        {
            string TenVXN, LoaiVXN, HangVXN;
            TenVXN = txtTenVacxin.Text;
            LoaiVXN = txtLoaiVacxin.Text;
            HangVXN = txtHangVacxin.Text;

            string SoLuong = numericSoLuong.ToString();

            if (String.IsNullOrEmpty(TenVXN) || String.IsNullOrEmpty(LoaiVXN)
                    || String.IsNullOrEmpty(HangVXN))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenVacxin.Focus();
                return;
            }

            vxn = new VacxinNgoaiDTO(TenVXN, LoaiVXN, HangVXN, SoLuong);

            DatMuaVacxinBUS bus = new DatMuaVacxinBUS();
            int newID = bus.LuuThongTinVacxinNgoai(vxn);
            vxn.MaVacxinNgoai = newID.ToString();
            if (newID > 0)
            {
                MessageBox.Show("Thêm vacxin thành công!" , "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Đã xảy ra lỗi. Không thể thêm vacxin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

         

        }

        public VacxinNgoaiDTO LayThongTinVacxinNgoai()
        { 
            return vxn;
        }
    

        private void txtTenVacxin_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
