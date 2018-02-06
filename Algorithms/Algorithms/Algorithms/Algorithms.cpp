// Algorithms.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

#include "NumberOfDigits.h"
#include "Sequences.h"
#include "LongestSequenceMaxiumSum.h"
#include "FibonacciDecomposition.h"
#include "MatrixUtils.h"
#include <string>
#include <iostream>
#include <cstdio>

using namespace std;

int main()
{
	//https://stackoverflow.com/questions/8617683/return-a-2d-array-from-a-function
	int n[] = { 1,2,3,0,44 };
	array<int, 5> a = fillarr(n);

	int height = 15;
	int width = 10;
	int** my2DArray = create2DArray(height, width);

	printf("Array sized [%i,%i] created.\n\n", height, width);

	// print contents of the array2D
	printf("Array contents: \n");

	for (int h = 0; h < height; h++)
	{
		for (int w = 0; w < width; w++)
		{
			printf("%i,", my2DArray[h][w]);
		}
		printf("\n");
	}

	cout << to_string(Test());
	cout << "\n";
	system("pause");
    return 0;
}

