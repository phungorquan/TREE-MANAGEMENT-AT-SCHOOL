using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDTO
{
    public class BCTinhTrangDTO
    {
        private string macttinhtrangcay;
        private string matinhtrangthang;
        private string macay;
        private int maloaicay;
        private int matinhtrang;
        private DateTime ngaytrong;
        private string tenloaicay;
        private string tentinhtrang;
        private string tencay;
        public DateTime NgaytrongPT
        {
            get => ngaytrong;
            set => ngaytrong = value;
        }
        public string TenLoaiCayPT
        {
            get => tenloaicay;
            set => tenloaicay = value;
        }
        public string TenTinhTrangPT
        {
            get => tentinhtrang;
            set => tentinhtrang = value;
        }
        public string TenCayPT
        {
            get => tencay;
            set => tencay = value;
        }
        public string MaCTTinhTrangCayPT
        {
            get => macttinhtrangcay;
            set => macttinhtrangcay = value;
        }
        public string MaTinhTrangThangPT
        {
            get => matinhtrangthang;
            set => matinhtrangthang = value;
        }
        public string MaCayPT
        {
            get => macay;
            set => macay = value;
        }
        public int MaLoaiCayPT
        {
            get => maloaicay;
            set => maloaicay = value;
        }
        public int MaTinhTrangPT
        {
            get => matinhtrang;
            set => matinhtrang = value;
        }
    }
}
