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
    public partial class DangKyLichRanhGUI : Form
    {
        private int userID = 2;
        private int week;
        private DateTime firstDay = DateTime.Parse("2022-4-11");
        private DateTime curDay = DateTime.Today;
        public DangKyLichRanhGUI()
        {
            InitializeComponent();
            getWeek();
            showWeek();
            ThietLapDoWComboBox();
            ThietLapShiftComboBox();
        }
        private void getWeek()
        {
            week = (int)Math.Ceiling((double)curDay.Subtract(firstDay).Days / 7) + 1;
        }

        private void showWeek()
        {
            weekValLbl.Text = week.ToString();
        }

        private string getDoW(int d)
        {
            switch (d)
            {
                case 1:
                    return "Thứ hai";
                case 2:
                    return "Thứ ba";
                case 3:
                    return "Thứ tư";
                case 4:
                    return "Thứ năm";
                case 5:
                    return "Thứ sáu";
                case 6:
                    return "Thứ bảy";
            }
            return "";
        }
        private void ThietLapDoWComboBox()
        {
            List<string> dayStr = new List<string>();
            DateTime accDay = curDay;

            int i = 0;
            while(accDay.AddDays(i).DayOfWeek != DayOfWeek.Monday) { i++; }
            accDay = accDay.AddDays(i);
            for (i = 0; i < 6; ++i) {
                dayStr.Add(accDay.AddDays(i).ToString("dd/MM/yyyy") + " - " + getDoW((int)accDay.AddDays(i).DayOfWeek));
            }

            DataGridViewComboBoxColumn dowCol = new DataGridViewComboBoxColumn();
            dowCol.HeaderText = "Ngày";
            dowCol.Name = "dklrDay";
            dowCol.DataSource = dayStr;
            dklrDGV.Columns.Add(dowCol);
        }

        private void ThietLapShiftComboBox()
        {
            List<string> shiftStr = new List<string>{ "Sáng", "Chiều", "Tối" };
            DataGridViewComboBoxColumn shiftCol = new DataGridViewComboBoxColumn();
            shiftCol.HeaderText = "Ca";
            shiftCol.Name = "dklrShift";
            shiftCol.DataSource = shiftStr;
            shiftCol.FillWeight = 50;
            dklrDGV.Columns.Add(shiftCol);
        }

        private void dklrBtn_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("Xác nhận đăng ký?", "Xác nhận", MessageBoxButtons.YesNo);
            if (choose == DialogResult.Yes) {
                if(DangKyLichRanhBUS.dangKyLichRanh(userID, dklrDGV))
                {
                    MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                } else
                {
                    MessageBox.Show("Thông tin đăng ký không hợp lệ", "Lỗi", MessageBoxButtons.OK);
                }
            }
        }

        private void huyDklrBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
