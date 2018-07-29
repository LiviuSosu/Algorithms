using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Fibonnaci
{
    public class Index
    {
        //Determine from the Fibonacci sequence the index of an element so that the element from the sequence is divideble with a number of the shape 2^n
        public int ReturnIndex(int index)
        {
            double _index = -1;
            double power = index - 2;
            _index = Math.Pow(2, power);
            _index = _index * 3;
 
            return (int)_index;
        }
    }
}
