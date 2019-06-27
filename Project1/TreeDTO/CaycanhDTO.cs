using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDTO
{
    public class CaycanhDTO
    {

//-------------------------------------------------------------------------//
//Thuoc Tinh
        private string maCayCanh; //Can Thiet
        private string tenCay;
        private int tinhTrang;
        private DateTime ngayTrong;
        private int maloaiCayCanh;
        private int  mavitri;

        //----------------------------------------------------------------------------//
        //Phuong Thuc
        public string MaCayCanhPT
        {
            get => maCayCanh;
            set => maCayCanh = value;
        }
        public string TenCayPT {
            get => tenCay;
            set => tenCay = value;
        }
        public int TinhTrangPT {
            get => tinhTrang;
            set => tinhTrang = value;
        }
        public DateTime NgayTrongPT {
            get => ngayTrong;
            set => ngayTrong = value;
        }

        public int MaLoaiCayCanhPT
        {
            get => maloaiCayCanh;
            set => maloaiCayCanh = value;
        }
        public int MaViTriPT
        {
            get => mavitri;
            set => mavitri = value;
        }

    }
}
