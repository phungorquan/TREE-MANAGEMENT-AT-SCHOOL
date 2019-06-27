using TreeDTO;
using TreeDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBUS
{
    public class VattuBUS
    {
        private VattuDAL vtDAL;

        public VattuBUS()
        {
            vtDAL = new VattuDAL();
        }
        public bool themvattu(VattuDTO vattu)
        {
            bool result = vtDAL.themVatTu(vattu);
            return result;
        }

        public bool xoavattu(VattuDTO vattu)
        {
            bool result = vtDAL.xoaVatTu(vattu);
            return result;
        }

        public bool suavattu(VattuDTO vattu)
        {
            bool result = vtDAL.suaVatTu(vattu);
            return result;
        }

        public List<VattuDTO> selectvattu()
        {
            return vtDAL.selectVatTu();
        }
    }
}
