using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.HouseNumbers
{
    class ThirdDay
    {
        public string Method1(string input, int rotations)
        {
            int rot2 = rotations - (input.Length % rotations);
            string result = input.Substring(rot2 ) + input.Substring(0, rot2);
            return result;
        }
    }
}
