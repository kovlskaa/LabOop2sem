using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Базовий клас "Рядки": віртуальні функції обчислення довжини і вставки символу.

Похідний клас "Великі літери": значення рядка, конструктор з параметром, 
віртуальні функції обчислення довжини і вставки через символ символу ‘/’.

Похідний клас "Малі літери": значення рядка, конструктор з параметром, 
віртуальні функції обчислення довжини і вставки через символ символу ‘\’

Описати класи, об’єкти цих класів; обчислити та вивести довжину; вивести оброблені
рядки, використовуючи поліморфізм (вказівну/посилання базового класу)*/
namespace Laba5
{
    abstract class Str
    {
        protected char[] stroka { get; set; }

        public Str(string str)
        {
            stroka = str.ToCharArray();
        }
        public abstract int Len();
        public abstract void Insert();
    }
   
}