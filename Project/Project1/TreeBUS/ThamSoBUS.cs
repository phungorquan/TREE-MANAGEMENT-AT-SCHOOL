using TreeDTO;
using TreeDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBUS
{
    public class ThamSoBUS
    {
        private ThamSoDAL ThamsoDAL;
        public ThamSoBUS()
        {
            ThamsoDAL = new ThamSoDAL();

        }
        public bool suaThamSo(ThamSoDTO ThamSo)
        {
            bool result = ThamsoDAL.suaThamSo(ThamSo);
            return result;
        }
        public List<ThamSoDTO> selectThamSo()
        {
            return ThamsoDAL.selectThamSo();
        }
    }
}
