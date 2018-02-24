#pragma once
#include "stdafx.h"
#include <iostream>

#include "Utils.h"

using namespace std;

//return last digit of a pow b
int ReturnLastDigit(int a, int b) {
	int lastDigit= GetFirstDigit(a);

	int prod = 1;
	for (int index = 0; index < b; index++) {
		prod = prod *lastDigit;
		if (prod>=10)
		{
			prod = prod % 10;
		}
	}
	return prod;
}