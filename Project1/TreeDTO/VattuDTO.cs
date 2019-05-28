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
        //private int maVatTu; Can Thiet
        private string tenVatTu;
        private string ngayMua;
        private int soLuongMua;
        private string diaChiMua;
        private string loaiVatTu;
        private long giaTien;


        //----------------------------------------------------------------------------//
        //Phuong Thuc
        //public int Ma { get => ma; set => ma = value; }
        public string TenVatTuPT
        {
            get => tenVatTu;
            set => tenVatTu = value;
        }
        public string NgayMuaPT
        {
            get => ngayMua;
            set => ngayMua = value;
        }
        public int SoLuongMuaPT
        {
            get => soLuongMua;
            set => soLuongMua = value;
        }
        public string DiaChiMuaPT
        {
            get => diaChiMua;
            set => diaChiMua = value;
        }
        public string LoaiVatTuPT
        {
            get => loaiVatTu;
            set => loaiVatTu = value;
        }
        public long GiaTienPT
        {
            get => giaTien;
            set => giaTien = value;
        }


    }
}

