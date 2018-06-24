using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Encoding
{
    class Encoding
    {
        private string alpfabet = "abcdefghijklmnopqrstuvwxyz";

        public void Coding()
        {
            int k = 0;
            for (int i=0; i < alpfabet.Length; i++)
            {
                for (int j = i; j < alpfabet.Length; j++)
                {
                    string result = alpfabet.Substring(i,j-k+1);
                    Console.WriteLine(result);
                }
                k++;
            }
        }
    }
}
