#pragma once

#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;

void FibonacciDecomposition(int n) {
	int fibonacci[100] = {  };
	fibonacci[0] = 1;
	fibonacci[1] = 1;
	int index = 2;
	int current_term = 1;

	while (current_term <= n) {
		current_term = fibonacci[index-2] + fibonacci[index-1];
		fibonacci[index] = current_term;
		index++;
	}

	if (n == fibonacci[index-2]) {
		cout << to_string(fibonacci[index-2]);
	}
	else {
		int first = fibonacci[index - 2];
		cout << to_string(first) << " + ";
		int temp = n - first;
		for (int i = index; i > 0; i--) {
			if (fibonacci[i] <= temp & fibonacci[i]>0) {
				int second = fibonacci[i];
				cout << to_string(second) << " + "+to_string(temp- second);
				break;
			}
		}

	}
}

int * GenerateFibbonaciSequence(int n) {
	int fibonacci[100];

	fibonacci[0] = 1;
	fibonacci[1] = 1;
	fibonacci[2] = 65;

	return fibonacci;
}