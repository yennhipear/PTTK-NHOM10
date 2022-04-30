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
using GUI.DTO;

namespace GUI.GUI
{
    public partial class XuLyPhieuDKTC : Form
    {
        private XuLyPhieuDKTCBUS xuLyPhieuDKTCBUS;
        public XuLyPhieuDKTC(String maPDK)
        {
            InitializeComponent();
            NgaySinhNT_Picker.CustomFormat = "dd/MM/yyyy";
            NgaySinhKH_Picker.CustomFormat = "dd/MM/yyyy";
            TGDK_Picker.CustomFormat = "dd/MM/yyyy";

            xuLyPhieuDKTCBUS = new XuLyPhieuDKTCBUS();

            PhieuDangKyTiemChungDTO phieuDangKy = xuLyPhieuDKTCBUS.LayThongTinPhieuDKTC(maPDK);

            HoTenKH_TextBox.Text = phieuDangKy.HoTenKH;
            SdtKH_TextBox.Text = phieuDangKy.SDTKH;
            DiaChiKH_TextBox.Text = phieuDangKy.DiaChiKH;
            NgaySinhKH_Picker.Text = phieuDangKy.NgSinhKH.ToShortDateString();
            GioiTinhKH_ComboBox.Text = phieuDangKy.GioiTinhKH;

            HoTenNT_TextBox.Text = phieuDangKy.HoTenNT;
            SdtNT_TextBox.Text = phieuDangKy.SDTNT;
            DiaChiNT_TextBox.Text = phieuDangKy.DiaChiNT;
            NgaySinhNT_Picker.Text = phieuDangKy.NgSinhNT.ToShortDateString();
            GioiTinhNT_ComboBox.Text = phieuDangKy.GioiTinhNT;
            QuanHe_Combobox.Text = phieuDangKy.QUANHE;

            TGDK_Picker.Text = phieuDangKy.NgayDK.ToShortDateString();

            if (String.IsNullOrEmpty(phieuDangKy.HoTenNT) == false)
                DKNT_Checkbox.Checked = true;

            if (DKNT_Checkbox.Checked == true)
                TTNT_Panel.Enabled = true;

            DSVacxinChon_Datagridview.DataSource = xuLyPhieuDKTCBUS.LayCTPhieuDKTC(maPDK);
        }


    }
}
