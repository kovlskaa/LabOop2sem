#pragma once
#include "Node.h"
#include <iostream>
using namespace std;

class LinkedList
{
    Node* Head, * Tail;
    int count = 0;
public:
    void AddNode(int);
    //видалити елемент
    bool Remove(int);
    //знайти максимальний елемент
    int FindMax();
    //видалення елементів після максимального
    bool Remove();
    //знаходження кількості елементів, кратних 5
    int Find5();
    bool Contains(int);
    //надрукувати список
    void Print();
    //видалення списку
     void Clear();
};

