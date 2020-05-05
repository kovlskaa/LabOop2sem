using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Лінії:
координати початку та кінця, конструктор з параметрами, метод
обчислення довжини лінії

Відрізки:
конструктор з параметрами, метод обчислення кута між
відрізком та віссю ОХ, методи отримання даних об’єкту

Описати класи, об’єкт похідного класу;
вивести дані об’єкта; обчислити і вивести довжину та кут з віссю ОX*/
namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {

            Big letter1 = new Big("TTYVBNV N N4545N N");
            Small letter2 = new Small("ftfjhb h jgjhg");

            int size1 = letter1.Len();
            int size2 = letter2.Len();

            letter1.Insert();
            letter2.Insert();
            Console.ReadKey();
        }
    }
}
