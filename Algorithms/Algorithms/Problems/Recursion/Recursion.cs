using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Recursion
{
    public class Recursion
    {
        public int Fibbonaci(int position)
        {
            if (position == 0)
            {
                return 1;
            }
            if (position == 1)
            {
                return 1;
            }
            else
            {
                return Fibbonaci(position - 2) + Fibbonaci(position - 1);
            }
        }

        #region permutation of a string
        public  void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }

        public  void GetPer(char[] list)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x);
        }

        public void GetPer(char[] list, int k, int m)
        {
            if (k == m)
            {
                Console.WriteLine(list);
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }
        #endregion
    }
}
