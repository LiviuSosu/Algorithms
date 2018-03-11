using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.HouseNumbers
{
    class SevethDay
    {
        public int NewNumber(int n)
        {
            int result = 0;
            int curr_max = MaxDigit(n);

            int finalResult=n;
    
            while (finalResult > 10)
            {
                int copy = finalResult;
                finalResult = 0;
                while (copy > 0)
                {
                    int h = copy % 10;
                    result = result * 10 + curr_max - h;
                    copy = copy / 10;
                }

                curr_max = MaxDigit(result);
                finalResult = result;
                if (finalResult %10 ==0)
                {
                    finalResult = finalResult / 10;
                }
                result = 0;
            }

            return finalResult;
        }

        public int MaxDigit (int number)
        {
            int maxDigit = number % 10;
            while (number>0)
            {
                int aux = number % 10;
                if(aux>maxDigit)
                {
                    maxDigit = aux;
                }

                number = number / 10;
            }

            return maxDigit;
        }
    }
}
