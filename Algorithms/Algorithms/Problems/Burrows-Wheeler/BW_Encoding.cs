using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Burrows_Wheeler
{
    public class BW_Encoding
    {
        public string Encoding(string _string)
        {
            string result = "";

            List<string> permutations = new List<string>();

            string aux = _string;
            permutations.Add(aux);
            for (int index=0; index < _string.Length-1; index++)
            {
                aux = aux.Substring(1, aux.Length-1) + aux[0];
                permutations.Add(aux);
            }

            permutations.Sort();

            for(int index=0;index<permutations.Count;index++)
            {
                result += permutations[index][permutations[index].Length-1];
            }

            return result;
        }
    }
}
