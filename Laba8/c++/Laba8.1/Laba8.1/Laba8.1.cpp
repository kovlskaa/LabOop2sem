#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

string Sorting(string);
int Ok(char, char);

int main()
{
    //сортировка символов
    string str1 = "1075498555";
    string str2 = "asduy!)?tgf";

    string (*operation)(string) = Sorting;
    string str1_new = (operation)(str1);

    operation(str2);
}
string Sorting(string _str)
{
    cout << _str << endl;
    for (int i = 0; i < _str.size(); i++)
    {
        char key = _str[i];
        int j = i;
        while (j > 0 && Ok(key, _str[j - 1]) == 1)
        {
            swap(_str[j], _str[j - 1]);
            j--;
        }
        _str[j] = key;
    }
    cout << _str << endl;
    cout << endl;
    return _str;
}

int Ok(char key, char str)
{
    return key > str;
}
