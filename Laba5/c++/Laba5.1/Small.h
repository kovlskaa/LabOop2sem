#pragma once
#include "Str.h"

class Small:public Str
{
public: 
	Small(string);
	int Len() override;
	void Insert() override;
};

