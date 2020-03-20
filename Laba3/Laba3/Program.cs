using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Клас інкапсулює двовимірний масив з елементів цілого типу.
Створити двовимірний індексатор, що повертає відповідне значення
масиву та запобігає порушенню границі масиву. 
Створити властивість, доступну для читання закритих елементів-даних, що
зберігають розміри масиву*/
namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            Masiv masiv = new Masiv();

            var value1 = masiv[0, 3];

            var row = masiv.RosmirR;
            var col = masiv.RosmirC;

            Console.ReadKey();
        }
    }
}
