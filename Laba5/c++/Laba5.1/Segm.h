#pragma once
#include "Line.h"
#define _USE_MATH_DEFINES
#include <cmath>

class Segm:public Line
{
public:
    Segm(int, int);
    double Len() override;
    double Angle();
    int x();
    int y();
};

