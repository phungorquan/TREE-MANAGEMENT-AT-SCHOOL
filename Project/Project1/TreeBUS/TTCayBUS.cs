using System;
using TreeDTO;
using TreeDAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBUS
{
    public class TTCayBUS
    {
        private TTrangDAL TTDAL;
        public TTCayBUS()
        {
            TTDAL = new TTrangDAL();
        }
        public bool themlich(TTCayDTO tt)
        {
            bool result = TTDAL.themTT(tt);
            return result;
        }
    }
}
