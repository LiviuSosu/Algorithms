#pragma once

#include "stdafx.h"
#include <iostream>
using namespace std;

int NumberOfDigits(int n) {
	int counter = 0;
	switch (n)
	{
	case 1:
		for (int index = 0; index <= 12; index++) {
			if (index >= 0 && index <= 9) {
				counter++;
			}
		}
		break;
	case 2:
		for (int index = 0; index <= 102; index++) {
			if (index >= 10 && index <= 99) {
				counter++;
			}
		}
		break;
	case 3:
		for (int index = 0; index <= 1002; index++) {
			if (index >= 100 && index <= 999) {
				counter++;
			}
		}
		break;
	default:
		return -1;
		break;
	}
	return counter;
}

int NumberOfDigits2(int limit) {
	int counter = 0;
	for (int i = 0; i <= limit; i++) {
		if (i < 10) {
			counter =counter + 1;
			cout << i; cout << " ";
		}
		if ((i >= 10 && i <= 99) ) {
			counter = counter + 2;
			cout << i; cout << " ";
		}

		if (counter > limit) {
			return i;
		}
	}
}