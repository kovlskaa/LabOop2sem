#include <iostream>
#include "Line.h"
#include "Segm.h"
#include "Str.h"
#include "Small.h"
#include "Big.h"
using namespace std;

int main()
{
	/*
    int endX = 5, endY = 5, startX = 1, startY = 2;
    Segm segm(endX-startX, endY-startY);

    double len = segm.Len();
    double angle = segm.Angle();
	*/

    Big letter1("YbhLLb J");
    Small letter2("bjkbP");
    Big letter("789 KKKKK");
    int size1 = letter1.Len();
    int size2 = letter2.Len();

    letter1.Insert();
    letter2.Insert();
    letter.Insert();
}
