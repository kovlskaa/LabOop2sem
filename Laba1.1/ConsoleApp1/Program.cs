using System;

namespace oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть число для iнкрементацii");
            int n = int.Parse(Console.ReadLine()),
                mask = 1;

            Increm(ref n, mask);

            Console.WriteLine(n);

            Console.WriteLine("Введiть числа для порiвняння");

            int a = int.Parse(Console.ReadLine()),
                b = int.Parse(Console.ReadLine());

            bool result = false;

            result = Res(mask, a, b);

            Console.WriteLine($"{result}");
        }

        public static void Increm(ref int n, int mask)
        {
            while (Convert.ToBoolean(n & mask))
            {
                n ^= mask;
                mask = mask << 1;
            }
            n ^= mask;
        }

        public static bool Res(int mask, int a, int b)
        {
            char res = '=';
            if (Convert.ToBoolean(a ^ b))
            {

                mask = mask << sizeof(int) * 8 - 1;
                if (!Convert.ToBoolean(a & mask) && !Convert.ToBoolean(b & mask))
                {
                    while (!Convert.ToBoolean(a & mask ^ b & mask))
                        mask = mask >> 1;
                    if (Convert.ToBoolean(a & mask) && !Convert.ToBoolean(b & 1))
                        res = '>';
                    else res = '<';
                }
                else if (Convert.ToBoolean(a & mask) && Convert.ToBoolean(b & mask))
                {
                    while (!Convert.ToBoolean(~a & mask ^ ~b & mask))
                        mask = mask >> 1;
                    if (Convert.ToBoolean(~a & mask) && !Convert.ToBoolean(~b & 1))
                        res = '<';
                    else res = '>';
                }
                else if (!Convert.ToBoolean(a & mask) && Convert.ToBoolean(b & mask)) res = '>';
                else res = '<';
            }

            Console.WriteLine($"{a} {res} {b}");

            if ((res == '>'))
                return true;
            else return false;
        }
    }
}
