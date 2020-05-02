#include <iostream>
#include <stdio.h>
using namespace std;
int main()
{
	int i;
	int e;
	int max;

	cout << "Enter number1: ";
	cin >> e;

	cout << "Enter number2: ";
	cin >> max;

	for (i = 0; i <= max; i++) {
		cout << e <<"x"<< i << "=" << i * e << endl;
             // you can use + , - , * , /
	}
}
