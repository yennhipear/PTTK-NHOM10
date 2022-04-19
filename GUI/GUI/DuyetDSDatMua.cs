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
    public partial class DuyetDSDatMua : Form
    {
        public DuyetDSDatMua()
        {
            InitializeComponent();
            List<string> vaccineNames = new List<string> { "Moderna", "Pfizer-BioNTech", "Varivax", "Tetanus" };
        }
    }
}
