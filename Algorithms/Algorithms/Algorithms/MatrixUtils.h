#pragma once

#include "stdafx.h"
#include <iostream>
#include <string>

#include <array>
using namespace std;

int Test() {
	return 27;
}

array<int, 5> fillarr(int arr[])
{
	array<int, 5> arr2;
	for (int i = 0; i<5; ++i) {
		arr2[i] = arr[i] * 2;
	}
	return arr2;
}

int** create2DArray(unsigned height, unsigned width)
{
	int** array2D = 0;
	array2D = new int*[height];

	for (int h = 0; h < height; h++)
	{
		array2D[h] = new int[width];

		for (int w = 0; w < width; w++)
		{
			// fill in some initial values
			// (filling in zeros would be more logic, but this is just for the example)
			array2D[h][w] = w + width * h;
		}
	}

	return array2D;
}