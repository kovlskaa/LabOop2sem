using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    class Masiv
    {
        private int[,] masiv = { { 12, 2, 3, 0 }, { 1, 4, 9, 5 }, { 1, 2, 3, 4 }, { 1, 2, 5, 6 } };

        public bool Error = false;

        public int this[int i, int j]
        {
            get
            {
                if (Perevirka(i, j))
                {
                    return masiv[i, j];
                }

                else
                {
                    Error = true;
                    return 0;
                }
            }
        }
        private bool Perevirka(int i, int j)
        {
            if ((i >= 0) && (j >= 0) && (i < masiv.GetLength(0)) && (j < masiv.GetLength(1)))
                return true;
            else return false;
        }
        public int RosmirR
        {
            get
            {
                return masiv.GetLength(0);
            }
        }
        public int RosmirC
        {
            get
            {
                return masiv.GetLength(1);
            }
        }

    }
}
