#pragma once
#include "Line.h"

class Segm:public Line
{
public:
    Segm(int, int);
    double Len() override;
    double Angle();
    int x();
    int y();
};

