using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Queue<T>
    {
        public delegate void Error(string mess);
        public event Error Overflow;

        private int front = 0;
        private int end  = -1;
        public int count { get; set; }
        public T[] array;
        public Queue(int size)
        {
            array = new T[size];
        }
        // додавання до черги
        public void Enqueue(T data)
        {
            if (array.Length > count)
            {
                array[++end] = data;
                count++;              
            }
            else
                Overflow?.Invoke("черга переповнена");
        }
        //видалення з черги
        public void Dequeue()
        {
            if (count == 0)
                throw new ArgumentNullException("черга пуста");

            for (int i = front; i < count - 1; i++)
                array[i] = array[i + 1];

            array[end--] = default;
            count--;

        }
    }
}
