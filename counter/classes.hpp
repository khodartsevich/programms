#include <iostream>
#include "stdio.h"

using namespace std;

class counter
{
public:
	counter(){its_min=0; its_max=0; its_value=0;};
	~counter();
	void set_min (int minim) { its_min=minim; }
	int get_min() const { return its_min; }
	void set_max (int maxim) { its_max=maxim; }
	int get_max() const { return its_max; }
	void set_its_value (int value) { its_value=value; }
	int get_its_value() const { return its_value; }

private:
	int its_min;
	int its_max;
	int its_value;	
};

counter::~counter()
{
	cout << "it's destroyed\n";
}
