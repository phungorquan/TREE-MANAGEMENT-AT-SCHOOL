using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDTO
{
    public class BaoCaoDTO
    {
        //-------------------------------------------------------------------------//
        //Thuoc Tinh
        //private int maVatTu; Can Thiet

       
        private int soPhieuMua;
       
        private long tongGiaTriVatTu;
        private int tyle;


        //----------------------------------------------------------------------------//
        //Phuong Thuc
        //public int Ma { get => ma; set => ma = value; }
    
        public int SoPhieuMuaPT
        {
            get => soPhieuMua;
            set => soPhieuMua = value;
        }
        public long TongGiaTriVatTuPT
        {
            get => tongGiaTriVatTu;
            set => tongGiaTriVatTu = value;
        }
        public int tylePT
        {
            get => tyle;
            set => tyle = value;
        }
    }
}
