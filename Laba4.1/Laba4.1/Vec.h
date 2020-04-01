#pragma once
#include <iostream>

using namespace std;

class Vec
{
private:
	int x = 1, y = 1;

public:
	Vec();
	Vec(int i, int j);
	Vec(Vec&);
	int CoordX();
	int CoordY();
	float Len();
	Vec operator *(int k);
	Vec operator -(Vec v);
};


