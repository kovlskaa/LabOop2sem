#pragma once
#include <string>
#include <iostream>
#include <cctype>
using namespace std;

class Str
{
protected:
	string str;
public:
	
	Str(string);
	virtual int Len()=0;
	virtual void Insert()=0;
};

