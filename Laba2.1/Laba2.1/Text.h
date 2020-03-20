#pragma once
#include <iostream>
#include <string>
#include <vector>
#include "Stroka.h"

using namespace std;

class Text {

	vector<Stroka>text;

public:
	void AddRows(Stroka str)
	{
		text.push_back(str);
	}

	void Delet(int i)
	{
		text.erase(text.begin() + i);
	}
	void Clear()
	{
		vector<Stroka> Ntext;
		text = Ntext;
	}
	int Dlina()
	{
		int len = 0;
		for (int i = 0; i < text.size(); i++)
		{
			len += text[i].Count();
		}
		return len / text.size();

	}
	float Golos()
	{
		float gol = 0, len = 0;
		string Gl = "aAeEyYuUiIoO";
		for (int i = 0; i < text.size(); i++)
		{
			for (int k = 0; k < Gl.size(); k++)
			{
				if (text[i].SymFind(Gl[k]))
					gol++;
			}
			len += text[i].Count();
		}
		return gol / len;
	};
	void DelRow(string str)
	{
		for (int i = 0; i < text.size(); i++)
		{
			if (text[i].Find(str))
				Delet(i);
		}
	}
};