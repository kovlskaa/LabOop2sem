#include "LinkedList.h"

void LinkedList::AddNode(int data)
{
    Node* node = new Node(data);
    if (Head == NULL)
    {
        Head = node;
        Tail = node;
    }
    else
    {
        node->Next = Head->Next;
        Head->Next = node;
        if (node->Next == NULL)
            Tail = node;
    }
    count++;
}
bool LinkedList:: Remove(int value)
{
    Node* previous = NULL;
    Node* current = Head;

    while (current != NULL)
    {
        if (current->data == value)
        {
            if (previous != NULL)
            {
                previous->Next = current->Next;
                if (current->Next == NULL)
                    Tail = previous;
            }
            else
            {
                Head = Head->Next;
                if (Head == NULL)
                    Tail = NULL;
            }
            count--;
            return true;
        }
        previous = current;
        current = current->Next;

    }
    return false;
}
//знайти максимальний елемент
int LinkedList:: FindMax()
{
    Node* current = Head;
    int max = current->data;
    while (current != NULL)
    {
        if (max < current->data)
            max = current->data;
        current = current->Next;
    }
    return max;
}
//видалення елементів після максимального
bool LinkedList::Remove()
{
    int value = FindMax();
    Node* current = Head;
    int n = 0;
    while (current != NULL)
    {
        n++;
        if (current->data == value)
        {
            current->Next = NULL;
            Tail = current;
            count = n;
            return true;
        }
        current = current->Next;
    }
    return false;
}
//знаходження кількості елементів, кратних 5
int LinkedList::Find5()
{
    int count = 0;
    Node* current = Head;
    while (current != NULL)
    {
        if (current->data % 5 == 0)
        {
            count++;
        }
        current = current->Next;
    }
    return count;
}
bool LinkedList::Contains(int value)
{
    Node* current = Head;
    while (current != NULL)
    {
        if (current->data == value)
        {
            return true;
        }
        current = current->Next;
    }
    return false;
}
//надрукувати список
void LinkedList::Print()
{
    Node* current = Head;
    while (current != NULL)
    {
        cout << current->data << " ";
        current = current->Next;
    }
    cout << endl;
}
void LinkedList:: Clear()
{
    Head = NULL;
    Tail = NULL;
    count = 0;
}