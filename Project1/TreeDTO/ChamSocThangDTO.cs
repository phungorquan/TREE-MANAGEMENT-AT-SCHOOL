using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDTO
{
    public class ChamSocThangDTO
    {
        private string machiphithang;
        private DateTime thang;
        public string MaChiPhiThangPT
        {
            get => machiphithang;
            set => machiphithang = value;
        }
        public DateTime ThangPT
        {
            get => thang;
            set => thang = value;
        }
    }
}
