using System;
using System.Collections.Generic;
using System.Text;

namespace Laba8
{
    public delegate void StrMod();
    class Sort
    {      
        public delegate void StrMod1(char[]str);
        public char[] str { get; set; }
        public Sort(string str)
        {
            this.str = str.ToCharArray();   
        }
        public void Sorting() => Sortingg(this.str);
        public static void Sortingg(char[] _str)
        {
            Console.WriteLine(_str);
            for (int i = 0; i<_str.Length; i++)
            {
                char key = _str[i];
                int j = i;
                while (j > 0 && Ok(key, _str[j - 1]) == 1)
                {
                    char tmp = _str[j];
                    _str[j] = _str[j-1];
                   _str[j - 1] = tmp;
                     j--;
                }
             _str[j] = key;
            }
            Console.WriteLine(_str);
        }

        public static int Ok(char key, char str)
        {
            return String.Compare(key.ToString(),str.ToString());
        }
    }
}
