#include <iostream>
#include "stdio.h"
#include "classes.hpp"

using namespace std;

int main(int argc, char* argv[])
{
	dog dracs;
	dracs.speak();
	dracs.wag_tail ();
	std::cout << "Dracs is " << dracs.get_age() << " years old\n";
	//dracs.set_breed(shetland);
	//std::cout << "dracs is " << dracs.get_breed() << "\n";
	dog groot(8,15);
	groot.speak();
	std::cout << "Groot is " << groot.get_age() << " years old and " << groot.get_weight() << " pounds\n";
	return 0;
}
