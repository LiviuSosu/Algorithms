using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Array
{
    public class Translate
    {
        public string[] Tra(string text)
        {
            string[] words = text.Split(' ');
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("mere","apples");
            dictionary.Add("dar", "but");
            dictionary.Add("piata", "marketplace");
            dictionary.Add("vanda", "sell");
            List<string> result = new List<string>();

            for(int i=0;i< words.Length;i++)
            {
                if (dictionary.ContainsKey(words[i]))
                {
                    words[i] = dictionary[words[i]];
                }
            }

            return words;
        }
    }
}
