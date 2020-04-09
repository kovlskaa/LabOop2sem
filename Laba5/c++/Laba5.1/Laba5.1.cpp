#include <iostream>
#include "Line.h"
#include "Segm.h"

using namespace std;

int main()
{
    int endX = 5, endY = 5, startX = 1, startY = 2;
    Segm segm(endX-startX, endY-startY);

    double len = segm.Len();
    double angle = segm.Angle();
}
