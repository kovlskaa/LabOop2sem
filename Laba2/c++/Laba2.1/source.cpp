#include "Stroka.h"
#include "Text.h"

/*����-�����, ���� ������ ������, �������� ��� ������ ������ �����-����������. ����-���������, ���� � ����������� ������ �� ���������� � �ᒺ��� �����-����� �� ������
��������� ����� �� ������,
��������� ����� � ������,
�������� ������,
��������� �������� ������� �����,
���������� ������� �������� ���� � �����,
��������� �����, �� ������ ������� �������.*/
int main() {

	Stroka str1, str2, str3;
	Text text;
	str1.Str("jhg");
	str2.Str("jhgcvgdfg");
	str3.Str("eeeeyyyy454yye");
	text.AddRows(str1);
	text.AddRows(str2);
	text.AddRows(str3);
	text.Dlina();
	text.Golos();
	text.DelRow("454");
	text.Delet(0);
	text.Clear();
	return 0;
}