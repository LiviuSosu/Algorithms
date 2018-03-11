using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Array
{
    public class Overlap
    {
        public void ov(List<int> array)
        {
            int vect = 4;
            do
            {
                array.RemoveAll(item => item == 0);
                for(int i=0;i<array.Count;i++)
                {
                    array[i] = array[i] - 1;
                }
                array.RemoveAll(item => item == 0);
            } while (array.Count % vect != 0);


            var c = array;
        }

    }
}
