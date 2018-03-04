using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.HouseNumbers
{
    class SevethDay
    {
        public int Method2(int n)
        {
            int rot = n / 9;
            int rot2 = n % 9;


            string result="";
            for(int i = 0;i<=rot+1;i++)
            {
                result += (rot2 ).ToString();
            }
            return 0;
        }
    }
}
