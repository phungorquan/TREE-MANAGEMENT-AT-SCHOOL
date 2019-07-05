using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDTO
{
    public class GiaVatTuDTO
    {
        private int magiavattu;
        private int giavattu;
        private int mavattu;


        public int MaGiaVatTuPT
        {
            get => magiavattu;
            set => magiavattu = value;
        }
        public int MaVatTuPTGV
        {
            get => mavattu;
            set => mavattu = value;
        }
        public int GiaVatTuPT
        {
            get => giavattu;
            set => giavattu = value;
        }

    }
}
