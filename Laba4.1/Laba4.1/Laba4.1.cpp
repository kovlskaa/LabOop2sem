﻿#include <iostream>
#include "Vec.h"
/*Вектори: координати кінця вектору,
конструктор за умовчанням,
конструктор з параметрами,
конструктор копіювання,
метод обчислення довжини вектору,
методи отримання даних вектору,
перевантаження операторів множення,
вирахування.

Описати клас, три об'єкти V1,
V2, V3, використовуючи різні
конструктори; "збільшити" у
2 рази об’єкт V3; "вирахувати"
з об’єкта V3 об’єкт V2 і
результат "помістити" до об’єкта V1;
результат дій вивести на екран*/

int main()
{
	Vec v1;
	Vec v2(4, 3);
	Vec v3(v2);

	v3 = v3.operator*(2);
	v1 = v3.operator-(v2);
}
