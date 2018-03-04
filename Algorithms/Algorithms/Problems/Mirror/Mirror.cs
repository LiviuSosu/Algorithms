using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Mirror
{
    public class Mirror
    {
        public bool Test(int number)
        {
            int sum = number + ComputeMirror(number);
            int x = ComputeMirror(sum);

            if (x==sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ComputeMirror(int number)
        {
            int result = 0;
            int aux = number;
            while(aux>0)
            {
                result = result * 10 + aux % 10;
                aux = aux / 10;
            }

            return result;
        }
    }
}
