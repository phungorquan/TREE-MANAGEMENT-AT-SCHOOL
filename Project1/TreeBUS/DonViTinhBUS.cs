using System;
using TreeDAL;
using TreeDTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBUS
{
    public class DonViTinhBUS
    {
        private DonViTinhDAL DonviDal;
        public DonViTinhBUS()
        {
            DonviDal = new DonViTinhDAL();
        }
        public List<DonViTinhDTO> selectDonVi()
        {
            return DonviDal.selectDonViTinh();
        }
    }
}
