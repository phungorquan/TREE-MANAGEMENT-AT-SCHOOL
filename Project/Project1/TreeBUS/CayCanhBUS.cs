using TreeDTO;
using TreeDAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBUS
{
    public class CayCanhBUS
    {
        private CayCanhDAL CayDAL;
      
        public CayCanhBUS()
        {
            CayDAL = new CayCanhDAL();
        }
        public bool them(CaycanhDTO cayCanh)
        {
            bool result = CayDAL.themCay(cayCanh);
            return result;
        }

        public bool xoaCay(CaycanhDTO cayCanh)
        {
            bool result = CayDAL.xoaCay(cayCanh);
            return result;
        }

        public bool suaCay(CaycanhDTO cayCanh)
        {
            bool result = CayDAL.suaCay(cayCanh);
            return result;
        }

        public List<CaycanhDTO> select()
        {
            return CayDAL.selectCay();
        }
        public List<CaycanhDTO> selectByKeyWord(string sKeyword)
        {
            return CayDAL.selectByKeyWord(sKeyword);
        }
    }
}
