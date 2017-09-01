using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class Numbers : BasicAlgorithms
    {
        /*Related numbers:
        Two numbers are related if ther sum of divizors are the same.
        */

        public List<int> GetRelatedNumbers(int number1, int number2)
        {
            List<int> relatedNumbers = new List<int>();

            List<int> sumsOfDivizorsNumbers = new List<int>();
            for (int i=number1;i<=number2;i++)
            {
               for (int j = i+1; j <= number2-1; j++)
                {
                    if (( GetNumberDivisorSum(i)== GetNumberDivisorSum(j) )&& (GetNumberDivisorSum(i) >0))
                    {
                        relatedNumbers.Add(i);
                        relatedNumbers.Add(j);
                    }
                }
            }

            return relatedNumbers;
        }

        public List<int> MultipleSum(List<int> numbers, int number)
        {
            List<int> result = new List<int>();
            int sum = 0;
            bool found = false;
            for (int i=0; i<numbers.Count;i++)
            {
                for(int j=i;j<numbers.Count;j++)
                {
                    result.Add(numbers[j]);
                    sum = sum + numbers[j];
                    if(sum % number == 0 )
                    {
                        found = true;
                        break;
                    }
                }
                if (found == true)
                {
                    break;
                }
                else
                {
                    sum = 0;
                    result = new List<int>();
                }
            }
            return result;
        }

        private int GetNumberDivisorSum(int number)
        {
            int sum = 0;

            for (int i = 2; i <= number / 2; i++)
            {
                if(number % i==0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
