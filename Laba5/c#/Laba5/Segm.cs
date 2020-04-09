using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    class Segm : Line
    {
        public Segm(int i, int j) : base(i, j) { }
        public override double Len()
        {
            return Math.Sqrt(Math.Pow(CoordX, 2) + Math.Pow(CoordY, 2));
        }
        public double Angle()
        {
            return Math.Acos(CoordX / Len()) * (180 / Math.PI);
        }
    }
}
