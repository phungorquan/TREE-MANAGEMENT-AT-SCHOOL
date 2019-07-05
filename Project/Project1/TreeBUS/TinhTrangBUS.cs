using TreeDTO;
using TreeDAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBUS
{
    public class TinhTrangBUS
    {
        private TinhTrangDAL TTDal;
        public TinhTrangBUS()
        {
            TTDal = new TinhTrangDAL();
        }
        public List<TinhTrangDTO> selectTT()
        {
            return TTDal.selectTinhTrang();
        }
    }

}
