using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapfs.Kruskal
{
    public class KEdge
    {
        public KVertex V1 { get; set; }
        public KVertex V2 { get; set; }
        public int weight { get; set; }
        public KEdge(KVertex src, KVertex dest, int wt)
        {
            V1 = src;
            V2 = dest;
            weight = wt;
        }
        public KEdge()
        {

        }
    }
}
