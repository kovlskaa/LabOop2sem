#include "Stroka.h"
#include "Text.h"

/*Клас-рядок, який містить методи, необхідні для роботи методів класу-контейнера. Клас-контейнер, який є абстракцією тексту та складається з об’єктів класу-рядка та методів
додавання рядка до тексту,
видалення рядка з тексту,
очищення тексту,
отримання середньої довжини рядка,
повернення відсотка голосних літер у тексті,
видалення рядків, що містять заданий підрядок.*/
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