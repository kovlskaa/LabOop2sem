#include "Segm.h"

Segm::Segm(int x, int y) :Line(x, y) {}

double Segm:: Len()
{
	return sqrt(pow(CoordX, 2) + pow(CoordY, 2));
}

double Segm:: Angle()
{
    return acos(CoordX / Len()) * (180 / 3.14);
}

int Segm::x()
{
    return CoordX;
}
int Segm::y()
{
    return CoordY;
}
