#pragma once
#pragma once

#include "stdafx.h"
#include <string>
#include <iostream>
#include <string>

using namespace std;

/*int * */void LongesteSequenceMaxSum(int n2[], int array_length) {
	int  partial_sums[10];
	int sequence[10];
	int index_secquece = 0;
	int max_sum = 0;
	int current_array_sum = 0;
	for (int index = 0; index < array_length;index++) {
		current_array_sum += n2[index];
		partial_sums[index] = current_array_sum;

		if (index >= 1) {
			int current_sum = abs(partial_sums[index - 1] + partial_sums[index]);
			if (current_sum >= max_sum)
			{
				max_sum = current_sum;
				sequence[index_secquece] = n2[index];
				index_secquece++;
				cout << to_string(n2[index]) + " ";
			}
		}
	}
	//return sequence;
}