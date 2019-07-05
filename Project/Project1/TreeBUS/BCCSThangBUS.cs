using System;
using TreeDTO;
using TreeDAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBUS
{
    public class BCCSThangBUS
    {
        private BCCSThangDAL ChiphiDAL;

        public BCCSThangBUS()
        {
            ChiphiDAL = new BCCSThangDAL();
        }
        public bool them(BCCSThangDTO thang)
        {
            bool result = ChiphiDAL.themChiPhi(thang);
            return result;
        }
        public List<BCCSThangDTO> select()
        {
            return ChiphiDAL.selectChiPhi();
        }
    }
}
