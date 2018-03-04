using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.HouseNumbers
{
    class ThirdDay
    {
        public int Method1(int input, int rotations = 4)
        {
            int[] num = { 3, 2, 2, 4, 5 };

            int rot2 = num.Length % rotations;
            for(int i=0;i<rot2;i++)
            {
                int aux = num[i];
                num[i] = num[num.Length-i-1];
                num[num.Length - i-1] = aux;
            }

            return input;
        }
    }
}
