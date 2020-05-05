#pragma once
#include "Str.h"

class Big:public Str
{
public:
	Big(string);
	int Len() override;
	void Insert() override;
};

