using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMatching
{
    class RabinKarp
    {
        public void Serach(string @string, string pattern)
        {
            ulong siga = 0;
            ulong sigb = 0;
            ulong Q = 100007;
            ulong D = 256;
            for (int i = 0; i < pattern.Length; i++)
            {
                siga = (siga * D + @string[i]) % Q;
                sigb = (sigb * D + pattern[i]) % Q;
            }
            if (siga == sigb)
            {
                Console.WriteLine(string.Format(">>{0}<<{1}", @string.Substring(0, pattern.Length), @string.Substring(pattern.Length)));
                return;
            }
            ulong pow = 1;
            for (int k = 1; k <= pattern.Length - 1; k++)
                pow = (pow * D) % Q;

            for (int j = 1; j <= @string.Length - pattern.Length; j++)
            {
                siga = (siga + Q - pow * @string[j - 1] % Q) % Q;
                siga = (siga * D + @string[j + pattern.Length - 1]) % Q;
                if (siga == sigb)
                {
                    if (@string.Substring(j, pattern.Length) == pattern)
                    {
                        Console.WriteLine(string.Format("{0}>>{1}<<{2}", @string.Substring(0, j),
                                                                            @string.Substring(j, pattern.Length),
                                                                            @string.Substring(j + pattern.Length)));
                        return;
                    }
                }
            }
            Console.WriteLine("Not copied!");
        }
    }
}
