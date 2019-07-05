using System;
using TreeDTO;
using TreeDAL;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBUS
{
    public class BCTinhTrangBUS
    {
        private BCTinhTrangDAL tinhTrangDAL;

        public BCTinhTrangBUS()
        {
            tinhTrangDAL = new BCTinhTrangDAL();
        }
        public bool them(BCTinhTrangDTO thang)
        {
            bool result = tinhTrangDAL.themBCTT(thang);
            return result;
        }
        public List<BCTinhTrangDTO> select()
        {
            return tinhTrangDAL.selectBCTT();
        }
    }
}
