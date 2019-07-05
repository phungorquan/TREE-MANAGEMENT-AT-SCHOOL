using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDTO;
using TreeDAL;


namespace TreeBUS
{
    public class LichChamSocBUS
    {
        private LichChamSocDAL lichDAL;
        public LichChamSocBUS()
        {
            lichDAL = new LichChamSocDAL();
        }
        public bool themlich(LichchamsocDTO lich)
        {
            bool result = lichDAL.themLich(lich);
            return result;
        }
        public List<LichchamsocDTO> selectByKeyWord(string sKeyword)
        {
            return lichDAL.selectByKeyWord(sKeyword);
        }
    }
}
