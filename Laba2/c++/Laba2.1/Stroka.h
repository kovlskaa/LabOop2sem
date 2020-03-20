#pragma once
#include <iostream>
#include <string>

using namespace std;

class Stroka
{
	string str;

public:
	void Str(string str1)
	{
		str = str1;
	}
	int Count()
	{
		return str.size();
	}
	bool SymFind(char n)
	{
		bool flag = false;
		for (int i = 0; i < Count(); i++)
		{
			if (str[i] == n)
				flag = true;
		}
		return flag;
	}
	bool Find(string str1)
	{
		bool flag = false;
		if (str.find(str1))
			flag = true;

		return flag;
	}
};

