#include "Exp.h"
#include <stdexcept>
Exp::Exp(int a, int d, int c)
{
    this->a = a;
    this->d = d;
    this->c = c;
}

float Exp::Result()
{
    if ((float)(1 - (a / 4)) <= 0)
        throw invalid_argument("Подлогарифмическое значение меньше либо равно нулю");
    float znam = (float)log(1 - a / 4);
    if (znam == 0)
        throw invalid_argument("Деление на ноль");
    return (2 * c - d / 23) / znam;
}
