using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDTO
{
    public class VattuDTO
    {
        //-------------------------------------------------------------------------//
        //Thuoc Tinh
      
        private int mavattu;
        private string tenvattu;
        private string diachiban;



        //----------------------------------------------------------------------------//
        //Phuong Thuc
        public string TenVatTuPT
        {
            get => tenvattu;
            set => tenvattu = value;
        }
        public int MaVatTuPT
        {
            get => mavattu;
            set => mavattu = value;
        }
        public string DiaChiBanPT
        {
            get => diachiban;
            set => diachiban = value;
        }
    }
}

