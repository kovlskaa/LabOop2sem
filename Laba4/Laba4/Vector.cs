using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Vector
    {
        private int x, y;
        public Vector() { }
        public Vector(int i, int j)
        {
           x = i;
           y = j;
        }
        public Vector(Vector vec0) : this(vec0.x, vec0.y) { }
        public double Dlina()
        {
            return Math.Sqrt(Math.Pow(x, 2)+ Math.Pow(y, 2));
        }
         public int X()
        {
            return x;
        }
        public int Y()
        {
            return y;
        }
        public static Vector operator *(Vector v, int k)
        {
            return new Vector(v.X()*k,v.Y()*k);
        }
        public static Vector operator -(Vector v3, Vector v2)
        {
            return new Vector(v3.x-v2.x, v3.y - v2.y);
        }
    }
}
