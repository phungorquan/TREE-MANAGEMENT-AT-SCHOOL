using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDTO
{
    public class ViTriDTO
    {
        private int maViTri;
        private string tenViTri;
        private int soluong;
        public int MaViTriPT
        {
            get { return maViTri; }
            set { maViTri = value; }
        }
        public int SoLuongPT
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public string TenViTriPT
        {
            get { return tenViTri; }
            set { tenViTri = value; }
        }
    }
}
