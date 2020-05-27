using System;
using System.Collections.Generic;
using System.Text;

namespace laba7
{
    class List<T>
    {
        Node Head;
        Node Tail;
        int count;
        //включення елементу
        public void Put(int data)
        {
            Node node = new Node(data);
            if (Head == null)
            {
                Head = node;
                Tail = Head;
            }
            else
            {
                node.Next = Head.Next;
                Head.Next = node;
                if (node.Next == null)
                    Tail = node;
            }
            count++;
        }
        //видалити елемент
        public bool Remove(int value)
        {
            Node previous = null;
            Node current = Head;

            while (current != null)
            {
                if (current.data.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            Tail = previous;
                    }
                    else
                    {
                        Head = Head.Next;
                        if (Head == null)
                            Tail = null;
                    }
                    count--;
                    return true;
                }
                previous = current;
                current = current.Next;

            }
            return false;
        }
        //знайти максимальний елемент
        private int FindMax()
        {
            Node current = Head;
            int max = current.data;
            while (current != null)
            {
                if (max < current.data)
                    max = current.data;
                current = current.Next;
            }
            return max;
        }
        //видалення елементів після максимального
        public bool Remove()
        {
            int value = FindMax();
            Node current = Head;
            int n = 0;
            while (current != null)
            {
                n++;
                if (current.data.Equals(value))
                {
                    current.Next = null;
                    Tail = current;
                    count = n;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        //знаходження кількості елементів, кратних 5
        public int Find5()
        {
            int count = 0;
            Node current = Head;
            while (current != null)
            {
                if (current.data % 5 == 0)
                {
                    count++;
                }
                current = current.Next;
            }
            return count;
        }
        public bool Contains(T value)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.data.Equals(value))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        //надрукувати список
        public void Print()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write($"{current.data} ");
                current = current.Next;
            }
            Console.WriteLine();
        }
        //видалення списку
        public void Clear()
        {
            Head = null;
            Tail = null;
            count = 0;
        }
    }
}
