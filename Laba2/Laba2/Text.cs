using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    class Text
    {
        public Stroka[] text;

        public Text()
        {
            text = new Stroka[0];
        }
        public void AddRow(string str1)
        {
            Array.Resize(ref text, text.Length + 1);
            text[text.Length - 1] = new Stroka(str1);
        }
        public void Output()
        {
            foreach (Stroka i in text)
                Console.WriteLine(i.str);

        }
        public void Delete(int n)
        {


            for (int i = n; i < text.Length - 1; i++)
            {
                text[i] = text[i + 1];

            }

            Array.Resize(ref text, text.Length - 1);
        }
        public void Clear()
        {
            text = new Stroka[0];
        }
        public int Dlina()
        {
            int k = 0;
            foreach (Stroka i in text)
                k += i.str.Length;
            return k / text.Length;
        }
        public float Golos()
        {
            float gol = 0, k = 0;
            string golosni = "AEYUIOeyuioa";
            foreach (Stroka i in text)
            {
                for (int h = 0; h < i.str.Length; h++)
                    for (int j = 0; j < golosni.Length; j++)
                    {
                        if (golosni[j] == i.str[h])
                            gol++;

                    }
                k += i.str.Length;
            }
            return gol / k;
        }
        public void DelRow(string str)
        {
            int n = 0;
            foreach (Stroka i in text)
            {
                if (i.str.IndexOf(str) != -1)
                {
                    for (int k = n; k < text.Length - 1; k++)
                    {
                        text[k] = text[k + 1];
                    }
                    Array.Resize(ref text, text.Length - 1);
                }
                n++;
            }
        }
    }
}