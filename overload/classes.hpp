#include <iostream>

using namespace std;

enum breed {golden, cairn, dandie, shetland, doberman, lab};

class mammal
{
public:
	mammal() { its_age=2; its_weight=5; } 
	~mammal() {};

	int get_age () const { return its_age; }
	void set_age (int age) { its_age=age; }
	int get_weight () const { return its_weight; }
	void set_weight (int weight) { its_weight=weight; }

	void speak () const { cout << "mammal sound\n"; }
	void sleep () const { cout << "mammal sleep\n"; }
	
protected:
	int its_age;
	int its_weight;
	
};

class dog: public mammal
{
public:
	dog():its_breed(golden){cout << "created dog 1\n";};
	dog(int age, int weight);
	~dog();
	breed get_breed () const { return its_breed; }
	void set_breed (breed br) { its_breed=br; }
	void wag_tail () const { cout << "tail wadding\n";}
	void beg_for_food () const { cout << "begging for food\n";}
	
private:
	breed its_breed;
};


dog::dog(int age, int weight)
{
	its_age=age;
	its_weight=weight;
	cout << "created dog 2 \n";
}

dog::~dog()
{
	cout << "dogs destroyed \n";
}
