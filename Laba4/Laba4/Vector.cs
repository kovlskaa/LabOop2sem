using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Vector
    {      
        public int CoordX { get; set; }
        public int CoordY { get; set; }

        public Vector() { }
        public Vector(int i, int j)
        {
           CoordX = i;
           CoordY = j;
        }
        public Vector(Vector vec0) : this(vec0.CoordX, vec0.CoordY) { }
        
        public double Dlina()
        {
            return Math.Sqrt(Math.Pow(CoordX, 2)+ Math.Pow(CoordY, 2));
        }      
        public static Vector operator *(Vector v, int k)
        {
            return new Vector(v.CoordX*k,v.CoordY*k);
        }
        public static Vector operator *(int k, Vector v)
        {
            return new Vector(v.CoordX * k, v.CoordY * k);
        }
        public static Vector operator -(Vector v3, Vector v2)
        {
            return new Vector(v3.CoordX-v2.CoordX, v3.CoordY - v2.CoordY);
        }
    }
}
