#include <iostream>
#include <string>

using namespace std;

void increm(int, int&);
bool res(int, int, int);

int main()
{
	setlocale(LC_ALL, "UKR");

	int n, a, b, mask = 1;
	cout << "n = "; cin >> n;

	increm(mask, n);

	cout << n << endl;

	printf("Введiть числа, якi потрiбно порiвняти\n");
	cout << "a = "; cin >> a;
	cout << "b = "; cin >> b;

	if (res(mask, a, b) == true)
		cout << "true" << endl;
	else cout << "false" << endl;

	return 0;
}

void increm(int mask, int &n)
{
	while (n&mask) {
		n ^= mask;
		mask = mask << 1;
	}
	n ^= mask;
}

bool res(int mask, int a, int b)
{
	char res = '=';
	if (a ^ b) {

		mask = mask << sizeof(int) * 8 - 1;
		if (!(a & mask) && !(b & mask))
		{
			while (!(a & mask ^ b & mask))
				mask = mask >> 1;
			if ((a & mask) && !(b & 1))
				res = '>';
			else res = '<';
		}
		else if ((a & mask) && (b & mask))
		{
			while (!(~a & mask ^ ~b & mask))
				mask = mask >> 1;
			if ((~a & mask) && !(~b & 1))
				res = '<';
			else res = '>';
		}
		else if (!(a & mask) && (b & mask)) res = '>';
		else res = '<';
	}
	cout << a << res << b << endl;

	if ((res == '>'))
		return true;
	else return false;
}
