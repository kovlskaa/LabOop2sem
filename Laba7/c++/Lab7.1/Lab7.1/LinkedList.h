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
    //�������� �������
    bool Remove(int);
    //������ ������������ �������
    int FindMax();
    //��������� �������� ���� �������������
    bool Remove();
    //����������� ������� ��������, ������� 5
    int Find5();
    bool Contains(int);
    //����������� ������
    void Print();
    //��������� ������
     void Clear();
};

