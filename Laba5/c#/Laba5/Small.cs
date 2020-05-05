using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    class Small : Str
    {
        public Small(string stroka) : base(stroka) { }

        override public int Len()
        {
            int len = 0;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (Char.IsLower(stroka[i]))
                    len++;
            }
            return len;
        }
        public override void Insert()
        {
            Console.WriteLine(stroka);
            char[] str = stroka;
            int pos = 1;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (Char.IsLower(str[i]) && Char.IsLower(str[i + 1]))
                {
                    Array.Resize(ref str, str.Length + 1);
                    for (int j = str.Length - 1; j > pos; j--)
                        str[j] = str[j - 1];
                    str[pos] = '\\';
                    pos += 2;
                    i++;
                }
                else pos++;
            }

            stroka = str;
            Console.WriteLine(stroka);
        }
    }
}
