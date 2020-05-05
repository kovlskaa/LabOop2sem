#include "Big.h"

Big::Big(string stroka) : Str(stroka) { }

int Big::Len()
{
	int len = 0;
	for (int i = 0; i < str.size(); i++)
	{
		if (isupper(str[i]))
			len++;
	}
	return len;
}

void Big::Insert()
{
	cout << str<<endl;
	int pos = 1;
	for (int i = 0; i < str.size() - 1; i++)
	{
		if (isupper(str[i]) && isupper(str[i + 1]))
		{
			str.insert(pos, "/");
			pos += 2;
			i++;
		}
		else pos++;
	}
	cout << str<<endl;
}