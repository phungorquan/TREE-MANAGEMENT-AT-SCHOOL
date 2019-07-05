using System;
using TreeDTO;
using TreeDAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBUS
{
    public class ChamSocThangBUS
    {
        private ChamSocThangDAL ThangDAL;

        public ChamSocThangBUS()
        {
            ThangDAL = new ChamSocThangDAL();
        }
        public bool them(ChamSocThangDTO thang)
        {
            bool result = ThangDAL.themThang(thang);
            return result;
        }
    }
}
