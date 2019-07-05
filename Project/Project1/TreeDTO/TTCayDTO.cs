using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDTO
{
    public class TTCayDTO
    {
        private string matinhtrangthang;
        private DateTime thangtt;
        public string MaTinhTrangThangPT
        {
            get => matinhtrangthang;
            set => matinhtrangthang = value;
        }
        public DateTime ThangTTPT
        {
            get => thangtt;
            set => thangtt = value;
        }
    }
}
