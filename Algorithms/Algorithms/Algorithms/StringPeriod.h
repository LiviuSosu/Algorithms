#pragma once
#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;

string Test(string input) {
	bool periodic = false;
	string aux = "";
	string aux2 = "";
	for (int per = 2; per <= input.length() / 2; per++)
	{
		if (input.length()%per==0)
		{
			periodic = true;
			aux = input.substr(0,per);
		}
	}
	return aux;
}