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
           
            DataGridViewRow dataRow = new DataGridViewRow();

            for (int i = 0; i < dsChon.Rows.Count; i++)
            {
                dataRow = (DataGridViewRow)dsChon.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in dsChon.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                DSVacxinChon_Datagridview.Rows.Add(dataRow);
            }
            DSVacxinChon_Datagridview.AllowUserToAddRows = false;
            DSVacxinChon_Datagridview.Refresh();
            ThanhTien_Label.Text = TongTien.ToString();
            ThanhTien_Label.Visible = true;
        }
    }
}
