#include <iostream>
#include <random>
#include <ctime>
#include "Exp.h"

int main()
{
    srand(time(NULL));
    Exp* exp[4];
    double* result = new double[4];
    string* LogMess = new string[5];

    try
    {
        int val = 4;
        exp[0] = new Exp(0, 2, 2);
        result[0] = exp[0]->Result();
    }
    catch (invalid_argument& err)
    {
        LogMess[0] = err.what();
    }
    for (int i = 1; i < 4; i++)
    {
        try
        {
            exp[i] = new Exp(rand() % 10 - 5, rand() % 10 - 5, rand() % 10 - 5);
            result[i] = exp[i]->Result();
            LogMess[i] = "Success";
        }
        catch (invalid_argument& err)
        {
            LogMess[i] = err.what();
        }
    }
}
