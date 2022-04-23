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
        public List<List<dynamic>> regArr;
        public LichRanhDTO(int userID, List<List<dynamic>> dklrArr)
        {
            this.userID = userID;
            regArr = new List<List<dynamic>>();
            for(int i = 0; i < dklrArr.Count; ++i)
            {
                regArr.Add(new List<dynamic>(dklrArr[i]));
            }
        }
    }
}
