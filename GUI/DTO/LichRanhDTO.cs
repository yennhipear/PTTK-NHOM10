using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DTO
{
    class LichRanhDTO
    {
        public int userID;
        public int weekID;
        public List<List<int>> regArr;
        public LichRanhDTO(int userID, int weekID, List<List<int>> dklrArr)
        {
            this.userID = userID;
            this.weekID = weekID;
            regArr = new List<List<int>>();
            for(int i = 0; i < dklrArr.Count; ++i)
            {
                regArr.Add(new List<int>(dklrArr[i]));
            }
        }
    }
}
