using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Fishing
{
    class Fishing
    {
        public void Fish()
        {
            List<List<int>> data = new List<List<int>>();
            data.Add(new List<int> { 1, 2, 1 });
            data.Add(new List<int> { 1, 2, 2 });
            data.Add(new List<int> { 3, 3, 3 });
            data.Add(new List<int> { 3, 4, 5 });
            data.Add(new List<int> { 7, 8, 7 });
            data.Add(new List<int> { 7, 8, 7 });
            data.Add(new List<int> { 8, 8, 7 });
            data.Add(new List<int> { 9, 9, 9 });
            data.Add(new List<int> { 1, 1, 2 });
            data.Add(new List<int> { 7, 7, 8 });

            List<Group> group = new List<Group>();
            Dictionary<int, List<int>> grp = new Dictionary<int, List<int>>();

            for(int pupil_id = 0; pupil_id < data.Count; pupil_id++)
            {
                for (int capture_id = 0; capture_id < 3; capture_id++)
                {
                    if(!grp.ContainsKey(data[pupil_id][capture_id]))
                    {
                        grp.Add(data[pupil_id][capture_id],new List<int>());
                    }
                    else
                    {
                        var list = grp[data[pupil_id][capture_id]];
                        if (!list.Contains (data[pupil_id][capture_id]))
                        {
                            if (!grp[data[pupil_id][capture_id]].Contains(pupil_id))
                            {
                                grp[data[pupil_id][capture_id]].Add(pupil_id);
                            }
                        }
                    }
                }
            }

       
        }
    }
}
