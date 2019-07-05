using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDTO
{
    public class ThamSoDTO
    {
        private int sotientoida;
        private int socaytoida;
        public int SoTienToiDaPT
        {
            get => sotientoida;
            set => sotientoida = value;
        }
        public int SoCayToiDaPT
        {
            get => socaytoida;
            set => socaytoida = value;
        }
    }
}
