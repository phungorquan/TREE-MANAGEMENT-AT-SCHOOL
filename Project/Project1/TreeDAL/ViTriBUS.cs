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
        public bool themViTri(ViTriDTO viTri)
        {
            bool result = VTDal.themViTri(viTri);
            return result;
        }

        public bool xoaViTri(ViTriDTO viTri)
        {
            bool result = VTDal.xoaViTri(viTri);
            return result;
        }

        public bool suaViTri(ViTriDTO viTri)
        {
            bool result = VTDal.suaViTri(viTri);
            return result;
        }
        public List<ViTriDTO> selectVT()
        {
            return VTDal.selectViTri();
        }
    }
}
