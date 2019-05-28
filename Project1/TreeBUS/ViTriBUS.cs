using System;
using TreeDAL;
using TreeDTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBUS
{
    public class ViTriBUS
    {
        private ViTrDAL VTDal;
        public ViTriBUS()
        {
            VTDal = new ViTrDAL();
        }
        public List<ViTriDTO> selectVT()
        {
            return VTDal.selectViTri();
        }
    }
}
