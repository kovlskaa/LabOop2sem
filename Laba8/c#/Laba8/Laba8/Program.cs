using System;
using Library;

namespace Laba8
{
    class Program
    {
        static void Main(string[] args)
        {
            //екземплярна версія
            Sort sort = new Sort("!@*&^#$$$.//");
            StrMod strmod = sort.Sorting;
            strmod();
            //статична версія
            Sort.StrMod1 strMod1 = Sort.Sortingg;
            char[] str1 = "4asdf6546".ToCharArray();
            strMod1(str1);

            //черга на основі масиву
            Queue<int> queue = new Queue<int>(3);

            queue.Overflow += mes => Console.WriteLine(mes);
            try
            {
                queue.Enqueue(1);
                queue.Enqueue(2);

                queue.Enqueue(3);
                queue.Dequeue();
                queue.Enqueue(4);
                queue.Enqueue(5);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
    }

}
