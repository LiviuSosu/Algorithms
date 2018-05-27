using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Problems.EuclidAlgorithm
{
    public class Euclid
    {
        //http://www.vcskicks.com/euclidean-gcd.php

        public int GCDRecursive(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            if (a > b)
                return GCDRecursive(a % b, b);
            else
                return GCDRecursive(a, b % a);
        }

        public int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
                return b;
            else
                return a;
        }

        //http://amir-shenodua.blogspot.ro/2012/06/extended-gcd-algorithm-extended.html

        public BigInteger[] Extended_GCD(BigInteger A, BigInteger B)
        {
            BigInteger[] result = new BigInteger[3];
            if (A < B) //if A less than B, switch them
            {
                BigInteger temp = A;
                A = B;
                B = temp;
            }
            BigInteger r = B;
            BigInteger q = 0;
            BigInteger x0 = 1;
            BigInteger y0 = 0;
            BigInteger x1 = 0;
            BigInteger y1 = 1;
            BigInteger x = 0, y = 0;
            while (r > 1)
            {
                r = A % B;
                q = A / B;
                x = x0 - q * x1;
                y = y0 - q * y1;
                x0 = x1;
                y0 = y1;
                x1 = x;
                y1 = y;
                A = B;
                B = r;
            }
            result[0] = r;
            result[1] = x;
            result[2] = y;
            return result;
        }
    }
}
