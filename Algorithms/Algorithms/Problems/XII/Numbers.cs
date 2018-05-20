using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.XII
{
    public class Numbers
    {
        public List<int> GetNumber(int n)
        {
            List<int> arr = new List<int>() { 3,4,5,6,7,8,9,10,11,12,13,14,15,16};
            List<int> result = new List<int>() { 1,2};

            for (int i = 0; i < n-1; i++)
            {
                double _count = Math.Pow(2, i);

                var c1 = GetFirstNElements(arr, (int)_count);
                result = ConcatenateLists(c1, result);

                var c2 = GetFirstNElements(arr, (int)_count);
                result = ConcatenateLists(result, c2);
            }


            return result;
        }

        private List<int> GetFirstNElements(List<int> numbers, int n)
        {
            List<int> result = new List<int>();
            for (int i=0; i<n;i++)
            {
                result.Add(numbers[i]);
            }

            numbers.RemoveRange(0,n);
            return result;
        }

        private List<int> ConcatenateLists(List<int> list1, List<int> list2)
        {
            List<int> result = new List<int>();
            for (int i=0;i<list1.Count;i++)
            {
                result.Add(list1[i]);
            }

            for (int i = 0; i < list2.Count; i++)
            {
                result.Add(list2[i]);
            }

            return result;
        }
    }
}
