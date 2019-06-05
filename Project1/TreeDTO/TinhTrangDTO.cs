using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDTO
{
    public class TinhTrangDTO
    {
        private int maTinhTrang;

        public int MaTinhTrangPT
        {
            get { return maTinhTrang; }
            set { maTinhTrang = value; }
        }
        private string tenTinhTrang;

        public string TenTinhTrangPT
        {
            get { return tenTinhTrang; }
            set { tenTinhTrang = value; }
        }
    }
}
