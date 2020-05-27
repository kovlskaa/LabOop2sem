using System;
using System.Reflection.Metadata;

namespace laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Put(1);
            list.Put(2);
            list.Put(11);
            list.Put(10);
            list.Put(20);
            list.Print();

            int n = list.Find5();
            Console.WriteLine(n);
            list.Remove();
            list.Print();
            Console.WriteLine(list.Find5());
            list.Clear();
            list.Print();


        }
    }
}

