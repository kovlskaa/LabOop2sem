using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    abstract class Line
    {
        public int CoordX {get; set;}
        public int CoordY { get; set; }
        public Line(int x, int y)
        {
            CoordX = x;
            CoordY = y;
        }
        public abstract double Len();
    }
}
