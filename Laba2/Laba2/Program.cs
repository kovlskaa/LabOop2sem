using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Клас-рядок, який містить методи, необхідні для роботи методів класу-контейнера. Клас-контейнер, який є абстракцією тексту та складається з об’єктів класу-рядка та методів
додавання рядка до тексту, 
видалення рядка з тексту, 
очищення тексту, 
отримання середньої довжини рядка, 
повернення відсотка голосних літер у тексті, 
видалення рядків, що містять заданий підрядок.*/
namespace Laba_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            text.AddRow("asv ufwkso");
            text.AddRow("jfndd");
            text.AddRow("jaeas vr");
            text.AddRow("65465465");
            text.Dlina();
            text.Golos();
            text.DelRow("as v");
            text.Delete(0);
            text.Clear();
            text.Output();
            Console.ReadLine();
        }
    }
}