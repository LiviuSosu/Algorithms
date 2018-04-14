using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapfs.BellmanFord
{
    public class Path
    {
        public string From;
        public string To;
        public int Cost;

        public Path(string from, string to, int cost)
        {
            From = from;
            To = to;
            Cost = cost;
        }
    }
}
