#pragma once

#include "stdafx.h"
#include <iostream>
#include <string>

#include <array>
using namespace std;


int matrix[5][5] = {
	{ 1,2,1,3,2 },
{ 4,5,6,7,8 },
{ 2,1,6,2,3 },
{ 5,2,1,3,2 },
{ 1,2,6,1,3 }
};
int n = 5;

//sum of elements on principal diagonal
int Sum1() {
	int sum = 0;
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < n; j++) {
			if (i == j)
			{
				sum += matrix[i][j];
			}
		}
	}
	return sum;
}

//sum of elements on secondary diagonal
int Sum2() {
	int sum = 0;
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < n; j++) {
			if (i+1==n-j)
			{
				sum += matrix[i][j];
			}
		}
	}
	return sum;
}

//sum of elements above elements on principal diagonal
int Sum3() {
	int sum = 0;
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < n; j++) {
			if (j-i>=1)
			{
				sum += matrix[i][j];
			}
		}
	}
	return sum;
}

//sum of elements bellow on principal diagonal
int Sum4() {
	int sum = 0;
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < n; j++) {
			if (i - j >= 1)
			{
				sum += matrix[i][j];
			}
		}
	}
	return sum;
}

//sum of elements above on secondary diagonal
int Sum5() {
	int sum = 0;
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < n; j++) {
			if (j<=n-i-2)
			{
				sum += matrix[i][j];
			}
		}
	}
	return sum;
}

//sum of elements bellow on secondary diagonal
int Sum6() {
	int sum = 0;
	for (int i = 0; i < n; i++) {
		for (int j = n-1; j > 0; j--) {
			if (i+j>n-1)
			{
				sum += matrix[i][j];
			}
		}
	}
	return sum;
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
