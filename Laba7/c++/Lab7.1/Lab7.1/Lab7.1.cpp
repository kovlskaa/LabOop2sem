#include <iostream>
#include "LinkedList.h"

int main()
{
    LinkedList list = LinkedList();

    list.AddNode(1);
    list.AddNode(2);
    list.Print();
    list.AddNode(3);
    list.Print();
    list.AddNode(20);
    list.AddNode(5);
    list.AddNode(6);
    list.AddNode(10);
    list.Print();

    cout <<"number of multiples of 5: "<< list.Find5() << endl;
    list.Remove();
    list.Print();
    return 0;
}
