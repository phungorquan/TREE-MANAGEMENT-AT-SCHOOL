using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDTO
{
    public class LoaiCayDTO
    {
        private int maLoaiCay;

        public int MaLoaiCayPT
        {
            get { return maLoaiCay; }
            set { maLoaiCay = value; }
        }
        private string tenLoaiCay;

        public string TenLoaiCayPT
        {
            get { return tenLoaiCay; }
            set { tenLoaiCay = value; }
        }
    }
}
