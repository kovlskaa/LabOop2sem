#include "Small.h"

Small::Small(string stroka) : Str(stroka) { }

int Small:: Len()
{
		int len = 0;
		for (int i = 0; i < str.size(); i++)
		{
			if (islower(str[i]))
				len++;
		}
		return len;
}

void Small:: Insert()
{
	cout << str<<endl;
	int pos = 1;
	for (int i = 0; i < str.size() - 1; i++)
	{
		if (islower(str[i]) && islower(str[i + 1]))
		{
			str.insert(pos, "\\");
				pos += 2;
				i++;
		}
		else pos++;
	}
	cout << str<<endl;
}
