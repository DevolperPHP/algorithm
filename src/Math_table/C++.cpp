#include <iostream>
#include <stdio.h>
using namespace std;
int main()
{
	int i;
	int e;
	int max;

	cout << "the number";
	cin >> e;

	cout << "how many number you want";
	cin >> max;

	for (i = 0; i <= max; i++) {
		cout << e <<"x"<< i << "=" << i * e << endl;
             // you can use + , - , * , /
	}
}
