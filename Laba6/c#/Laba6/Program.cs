using System;

namespace Laba6
{
    class Program
    {
        static void Main(string[] args)
        {

            Exp[] exp  = new Exp[5];
            float[] result = new float[5];
            string[] LogMess = new string[1];

            try
            {
                int val = Int32.Parse("45o");
                exp[0] = new Exp(GetRandom(), GetRandom(), val);
                result[0] = exp[0].Result();

            }
            catch (FormatException ex)
            {
                LogMess[0] = ex.Message;
            }
            for (int i = 1; i < 6; i++)
            {
                try
                {
                    exp[i] = new Exp(GetRandom(), GetRandom(), GetRandom());
                    result[i] = exp[i].Result();
                }

                catch (Exception ex)
                {
                    Array.Resize(ref LogMess, LogMess.Length + 1);
                    LogMess[LogMess.Length - 1] = ex.Message;
                }

            }
        }
        static int GetRandom()
        {
            Random random = new Random();
            int value = random.Next(-10,10);
            return value;
        }
    }
}
