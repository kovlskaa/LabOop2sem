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
            int startY = 1, startX = 1, endX = 2, endY = 2;
            Segm segm = new Segm(endX - startX, endY - startY);
            Line segm1 = new Segm(endX, endY);

            var len1 = segm1.Len();

            var len = segm.Len();
            var angle = segm.Angle();
        }
    }
}
