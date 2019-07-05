using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDTO
{
    public class DonViTinhDTO
    {

        private int madonvitinh;
        private string tendonvitinh;

        public int MaDonViTinhPT
        {
            get => madonvitinh;
            set => madonvitinh = value;
        }
        public string TenDonViTinhPT
        {
            get => tendonvitinh;
            set => tendonvitinh = value;
        }
    }
}
