#include "stdafx.h"
#include "CppUnitTest.h"
#include "C:\Users\lsosu\Work\Proiecte\Personale\Algorithms\Repo\Algorithms\Algorithms\Algorithms\Sequences.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace AlgorithmsTest
{		
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(TestMethod1)
		{
			// TODO: Your test code here
		}

	public: 
		TEST_METHOD(TestMethod2)
		{
			int a[] = { 1,2,3 };
			Assert::IsTrue(TestArray(a) == 1);
		}
	};

}