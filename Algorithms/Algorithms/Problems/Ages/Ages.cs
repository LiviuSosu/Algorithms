using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Ages
{
    public class Ages
    {
        List<int> data = new List<int>() {1991,1998,2000,2002,1978,1978,2002 };
        public List<int> GetExtremes()
        {
            List<int> youngestPersons = new List<int>();
            List<int> oldestPersons = new List<int>();
            int min = data[0];
            int max = data[0];
            youngestPersons.Add(0);
            oldestPersons.Add(0);

            for (int i=1;i<data.Count;i++)
            {
                if(data[i]<min)
                {
                    min = data[i];
                    youngestPersons =new List<int>();
                
                }
                if (data[i] == min)
                {
                    youngestPersons.Add(i);
                }

                if (data[i] > max)
                {
                    max = data[i];
                    oldestPersons = new List<int>();

                }
                if (data[i] == max)
                {
                    oldestPersons.Add(i);
                }
            }
            return youngestPersons;

        }
    }
}
