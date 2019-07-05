using System;
using TreeDAL;
using TreeDTO;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBUS
{
    public class LoaiCayBUS
    {
        private LoaiCayDAL LCDal;
        public LoaiCayBUS()
        {
            LCDal = new LoaiCayDAL();
        }
        public List<LoaiCayDTO> selectLoaiCay()
        {
            return LCDal.selectLoaiCay();
        }
    }
}
