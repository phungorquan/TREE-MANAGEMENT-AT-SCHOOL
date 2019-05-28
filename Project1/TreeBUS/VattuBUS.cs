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
        public bool them(VattuDTO vattu)
        {
            bool result = vtDAL.themVatTu(vattu);
            return result;
        }

        public bool xoa(VattuDTO vattu)
        {
            bool result = vtDAL.xoaVatTu(vattu);
            return result;
        }

        public bool sua(VattuDTO vattu)
        {
            bool result = vtDAL.suaVatTu(vattu);
            return result;
        }

        public List<VattuDTO> select()
        {
            return null;
        }
    }
}
