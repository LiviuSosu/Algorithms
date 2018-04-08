using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapfs.Kruskal
{
    public class KGraph
    {
        public List<KEdge> Edgecoll = null;
        public KVertex[] vertcoll = null;
        KVertex v = null;
        public KGraph(int size)
        {
            vertcoll = new KVertex[size];
            for (int i = 0; i < size; i++)
            {
                v = new KVertex();
                v.Label = i.ToString();
                vertcoll[i] = v;
            }
        }
    }
}
