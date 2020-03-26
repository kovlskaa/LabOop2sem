#include "Vec.h"
#include <cmath>
Vec::Vec() {}
Vec::Vec(int i, int j)
{
	x = i;
	y = j;
}
Vec::Vec(Vec &v)
{
	x = v.x;
	y = v.y;
}
double Vec:: Len() 
{
	return sqrt(pow(x, 2)+pow(y, 2));
}
Vec Vec:: operator *(int k)
{
	Vec v0;
	v0.x = x * k;
	v0.y = y * k;
	return v0;
}
Vec Vec::operator -(Vec v)
{
	Vec v0;
	v0.x = x - v.x;
	v0.y = y - v.y;
	return v0;
}
