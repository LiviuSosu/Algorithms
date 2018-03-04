using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Numbers
{
    class TriangleNumbers
    {
        public int Sequence(int k)
        {
            int i = 1;
            int tri = 1;

            while (tri<k)
            {
                i++;
                tri = tri + i;
            }

            return i;
        }
    }
}
