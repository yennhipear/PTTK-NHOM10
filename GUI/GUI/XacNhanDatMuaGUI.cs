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
    public partial class XacNhanDatMuaGUI : Form
    {
        public XacNhanDatMuaGUI(DataGridView dsChon, long TongTien)
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

            ThanhTien_Label.Text = TongTien.ToString();
           ThanhTien_Label.Visible = true;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new ThanhToanGUI()).Show();
            this.Close();
        }
    }
}
