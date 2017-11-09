#include <iostream>
#include "stdio.h"
#include "classes.hpp"

using namespace std;

int main(int argc, char* argv[])
{
	int minim;
	int maxim;
	int value;
	counter ccount;
	
	cout << "enter min value\n";
	cin >> minim;
	ccount.set_min(minim);
	cout << "min value is " << ccount.get_min() << "\n";
	
	cout << "enter max value\n";
	cin >> maxim;
	ccount.set_max(maxim);
	cout << "max value is " << ccount.get_max() << "\n";
	
	ccount.set_its_value(minim);
	cout << "value is " << ccount.get_its_value() << "\n";
	
	value=ccount.get_its_value();
	
	if (value<maxim)
	{	value++;	}
	else
	{
		value=minim;
	}
	ccount.set_its_value(value);
	cout << "value is " << ccount.get_its_value() << "\n";
	
	system("pause");
	return 0;
}
