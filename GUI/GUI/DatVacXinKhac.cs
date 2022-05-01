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

        private void label7_Click(object sender, EventArgs e)
        {

        }



        private void DatVacXinKhac_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string TenVXN, LoaiVXN, HangVXN;
            TenVXN = txtTenVacxin.Text;
            LoaiVXN = txtLoaiVacxin.Text;
            HangVXN = txtHangVacxin.Text;

            if (String.IsNullOrEmpty(TenVXN) || String.IsNullOrEmpty(LoaiVXN)
                    || String.IsNullOrEmpty(HangVXN))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenVacxin.Focus();
                return;
            }

            VacxinNgoaiDTO model = new VacxinNgoaiDTO(TenVXN, LoaiVXN, HangVXN);
         
         
        }
    
    }
}
