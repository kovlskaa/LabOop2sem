using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Вектори: координати кінця вектору,
конструктор за умовчанням,
конструктор з параметрами,
конструктор копіювання, 
метод обчислення довжини вектору, 
методи отримання даних вектору,
перевантаження операторів множення,
вирахування.

Описати клас, три об'єкти V1,
V2, V3, використовуючи різні
конструктори; "збільшити" у
2 рази об’єкт V3; "вирахувати"
з об’єкта V3 об’єкт V2 і
результат "помістити" до об’єкта V1; 
результат дій вивести на екран*/
namespace Laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vec1 = new Vector();
            Vector vec2 = new Vector(4, 3);
            Vector vec3 = new Vector(vec2);
            var len3 = vec3.Dlina();
            vec3 = vec3 * 2;
            vec3 = 2 * vec3;
            var lenN3 = vec3.Dlina();
            //var x = vec3.CoordX;
            vec1 = vec3 - vec2;
        }
    }
}
