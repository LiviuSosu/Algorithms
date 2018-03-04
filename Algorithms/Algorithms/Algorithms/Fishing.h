#pragma once
#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;

int matrix[10][3] = {
	{1,2,1},
{1,2,2},
{3,3,3},
{3,4,5},
{7,8,7},
{7,8,7},
{8,8,7},
{9,9,9},
{1,1,2},
{7,7,8}
};

struct fish {
	int fish;
	int pupil;
};

fish a[10];

//void GetGroups() {
//	for (int i=0;i<10;i++)
//	{
//		for (int j=0;j<3;j++)
//		{
//			a[0].fish = 1;
//		}
//	}

	/*for (int i = 0; i < 10; i++) {
		cout << to_string(a[0].fish) << " " << to_string(a[0].pupil) << "\n";
	}*/
//}