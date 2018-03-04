using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Soldiers
{
    class Soldiers
    {
        string[] names =  { "Chirila", "Macarie","Coza","Domsa","Lador","Orlea","Hila","Pacurar"};
        char[] grades = { 'S', 'S', 'G', 'G', 'S', 'G', 'S', 'G' };

        List<string> soldiers = new List<string>();
        List<string> sergents = new List<string>();

        public void Group()
        {
            for (int i = 0; i < names.Length; i++)
            {
                if(grades[i]=='S')
                {
                    soldiers.Add(names[i]);
                }
                else
                {
                    sergents.Add(names[i]);
                }
            }

            var c = DisplayList(soldiers);
            var d = DisplayList(sergents);
        }

        private List<string> DisplayList(List<string> list)
        {
            List<string> group = new List<string>();
            for (int i = 0; i < list.Count / 2; i++)
            {
                group.Add(list[i]);
                group.Add(list[list.Count-1-i]);
            }
            //for (int i = list.Count - 1; i >= (list.Count / 2); i--)
            //{
                
            //}

            return group;
        }
    }
}
