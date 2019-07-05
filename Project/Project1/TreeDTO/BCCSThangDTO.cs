using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDTO
{
    public class BCCSThangDTO
    {
        private string mactchiphithang;
        private string machiphithang;
        private string tenvattu;
        private int mavattu;
        private int sophieumua;
        private long tongtrigia;
        private double tyle;
        public string MaCTChiPhiThangPT
        {
            get => mactchiphithang;
            set => mactchiphithang = value;
        }
        public string TenVatTuPT
        {
            get => tenvattu;
            set => tenvattu = value;
        }
        public string MaChiPhiThangPT
        {
            get => machiphithang;
            set => machiphithang = value;
        }
        public int MaVatTuPT
        {
            get => mavattu;
            set => mavattu = value;
        }
        public int SoPhieuMuaPT
        {
            get => sophieumua;
            set => sophieumua = value;
        }
        public long TongTriGiaPT
        {
            get => tongtrigia;
            set => tongtrigia = value;
        }
        public double TyLePT
        {
            get => tyle;
            set => tyle = value;
        }
    }
}
