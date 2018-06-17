using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMatching
{
    class Program
    {
        //source https://stackoverflow.com/questions/10338379/rabin-karp-string-matching-algorithm
        static void Main(string[] args)
        {
            string A = "String that contains a pattern.";
            string B = "pattern";
            RabinKarp RK = new RabinKarp();
            RK.Serach(A,B);

            KMP kmp = new KMP();
            var result = kmp.KMPSearch("bangladesh", "glade");
            var result1 = kmp.KMPSearch("ABABDABACDABABCABAB", "ABABCABAB");
        }
    }
}
