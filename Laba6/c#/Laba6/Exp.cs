using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6
{
    class Exp
    {
        private int a, c, d;
        public Exp(int a, int d, int c)
        {
            this.a = a;
            this.d = d;
            this.c = c;
        }
        public float Result()
        {
            if ((float)(1 - a / 4) <= 0)
                throw new Exception("Пiдлогарифмiчне значення менше чи дорiвнює 0");

            float znam = (float)Math.Log(1 - a / 4);

            if (znam == 0)
                throw new DivideByZeroException("Знаменник дорiвнює нулю");
            return (2 * c - d / 23) / znam;
        }

    }
}
