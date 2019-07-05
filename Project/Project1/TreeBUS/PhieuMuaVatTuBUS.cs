using TreeDTO;
using TreeDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBUS
{
    public class PhieuMuaVatTuBUS
    {
        private PhieuMuaVatTuDAL phieuDal;
        public PhieuMuaVatTuBUS()
        {
            phieuDal = new PhieuMuaVatTuDAL();
        }
        public bool themPhieu(PhieuMuaVatTuDTO phieu)
        {
            bool result = phieuDal.themPhieu(phieu);
            return result;
        }

        public List<PhieuMuaVatTuDTO> selectPhieu()
        {
            return phieuDal.selectPhieu();
        }
    }
}
