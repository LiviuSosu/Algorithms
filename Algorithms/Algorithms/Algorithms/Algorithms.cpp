// Algorithms.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

#include "NumberOfDigits.h"
#include "Sequences.h"
#include "LongestSequenceMaxiumSum.h"
#include "FibonacciDecomposition.h"
#include "MatrixUtils.h"
#include "StringPeriod.h"
#include "LastDigit.h"
#include <string>
#include <iostream>
#include <cstdio>
#include <stdio.h>


int main()
{
	//https://stackoverflow.com/questions/8617683/return-a-2d-array-from-a-function
	/*int a =  1711;
	int b =   169;
	cout << ReturnLastDigit(a,b);*/
	int n = 4;
	int a[4][4];
	int limit = n;
	int counter = 1;
	int index = 1;
	int j;
	for (int i = 0; i < n*n; i++)
	{
		// do top side
		for (j = 0; j < limit; j++)
			a[i][i + j] = index++;

		// do right side
		for (j = 1; j < limit; j++)
			a[i + j][n - 1 - i] = index++;

		// do bottom side
		for (j = limit - 2; j > -1; j--)
			a[n - 1 - i][i + j] = index++;

		// do left side
		for (j = limit - 2; j > 0; j--)
			a[i + j][i] = index++;
		
		limit -= 2;
	}

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			cout << to_string(a[i][j]) << " ";
		}
		cout << "\n";
	}
	cout << "\n";
	system("pause");
	return 0;
}

