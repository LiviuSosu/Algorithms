#pragma once

#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;

int LongestPositiveSequence(int n2[]) {
	int n[] = { 1,2,3,0,44,6,7,9,0,0,0,0,0,0,0,4,6};
	int count = 0;
	int count_max = 0;
	int pos_final = 0;

	for (int index = 0; index < (sizeof(n) / sizeof(n[0])) ;index++) {
		if (n[index]>0) {
			count++;
		}
		else {
			if (count>count_max) {
				count_max = count;
				count = 0;
				pos_final = index-1;
			}
		}
	}

	for (int i = (pos_final - count_max + 1); i <= pos_final; i++) {
		cout << to_string( n[i])+" ";
	}

	return count;
}

int TestArray(int *n) {
	return (sizeof(&n) / sizeof(&n[0]));
}