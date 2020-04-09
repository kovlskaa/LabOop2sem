#pragma once

class Line
{
	public:
	int CoordX, CoordY;
	Line(int, int);
	virtual double Len()=0;
};