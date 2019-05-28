using TreeDTO;
using TreeDAL;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBUS
{
    public class BaoCaoBUS
    {
        private BaoCaoDAL bcDAL;
        public BaoCaoBUS()
        {
            bcDAL = new BaoCaoDAL();

        }
        public void BCchamsoc(VattuDTO vattu)
        {
            bcDAL.BCchamsoc(vattu);
        }
        public void BCcay(CaycanhDTO tree)
        {
            bcDAL.BCcay(tree);
        }
    }
}
