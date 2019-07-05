using System;
using TreeDAL;
using TreeDTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBUS
{
    public class GiaVatTuBUS
    {
        private GiaVatTuDAL GVDal;
        public GiaVatTuBUS()
        {
            GVDal = new GiaVatTuDAL();
        }
        public bool themGia(GiaVatTuDTO gia)
        {
            bool result = GVDal.themGia(gia);
            return result;
        }

        public bool xoaGia(GiaVatTuDTO gia)
        {
            bool result = GVDal.xoaGia(gia);
            return result;
        }

        public bool suaGia(GiaVatTuDTO gia)
        {
            bool result = GVDal.suaGia(gia);
            return result;
        }
        public List<GiaVatTuDTO> selectGiaVat()
        {
            return GVDal.selectGiaVat();
        }
    }
}
