using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Threading;
using Grapfs.Kruskal;

namespace Grapfs
{
    //http://www.koderdojo.com/blog/depth-first-search-algorithm-in-csharp-and-net-core
    class Program
    {
        static void Main(string[] args)
        {
            //var vertices = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var edges = new[]{Tuple.Create(1,2), Tuple.Create(1,3),
            //    Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
            //    Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
            //    Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)};

            //var graph = new Graph<int>(vertices, edges);
            //var algorithms = new BreadthFirstSearch();

            //Console.WriteLine(string.Join(", ", algorithms.BFS(graph, 1)));

            int[,] graph = {
    { 0, 2, 0, 6, 0 },
    { 2, 0, 3, 8, 5 },
    { 0, 3, 0, 0, 7 },
    { 6, 8, 0, 0, 9 },
    { 0, 5, 7, 9, 0 },
};

            // Prim_sAlgorithm.Prim(graph, 5);

            int k = 1;
            int vert = 7;
            int e = 0;
            KGraph objGraph = new KGraph(vert);
            KVertex[] vertcoll = objGraph.vertcoll;
            KEdge[] result = new KEdge[vert];

            List<KEdge> edgecoll = new List<KEdge>();
            KEdge objEdge = new KEdge();

            for (int i = 0; i < vert; i++)
            {
                for (int j = i; j < vert; j++)
                {
                    if (i != j)
                    {
                        Console.WriteLine("KEdge weight from src{0} to destn{1}", i, j);
                        int wt = int.Parse(Console.ReadLine());
                        if (wt == 0) continue;
                        objEdge = new KEdge(vertcoll[i], vertcoll[j], wt);
                        edgecoll.Add(objEdge);
                        k++;
                    }
                }
            }

            //edgecoll.ToList().OrderBy(p => p.weight).ToList();

            objGraph.Edgecoll = edgecoll.ToList().OrderBy(p => p.weight).ToList();//edgecoll.OrderBy(g=>g.weight).ToList();

            KSubsets[] sub = new KSubsets[vert];
            KSubsets subobj;
            for (int i = 0; i < vert; i++)
            {
                subobj = new KSubsets();
                subobj.parent = vertcoll[i];
                subobj.rank = 0;
                sub[i] = subobj;
            }
            k = 0;
            while (e < vert - 1)
            {
                objEdge = objGraph.Edgecoll.ElementAt(k);
                KVertex x = find(sub, objEdge.V1, Array.IndexOf(objGraph.vertcoll, objEdge.V1), objGraph.vertcoll);
                KVertex y = find(sub, objEdge.V2, Array.IndexOf(objGraph.vertcoll, objEdge.V2), objGraph.vertcoll);
                if (x != y)
                {
                    result[e] = objEdge;
                    Union(sub, x, y, objGraph.vertcoll);
                    e++;
                }
                k++;


            }

            for (int i = 0; i < e; i++)
            {
                Console.WriteLine("edge from src:{0} to dest:{1} with weight:{2}", result[i].V1.Label, result[i].V2.Label, result[i].weight);
            }
            return;

        }

        private static void Union(KSubsets[] sub, KVertex xr, KVertex yr, KVertex[] vertex)
        {
            KVertex x = find(sub, xr, Array.IndexOf(vertex, xr), vertex);
            KVertex y = find(sub, yr, Array.IndexOf(vertex, yr), vertex);

            if (sub[Array.IndexOf(vertex, x)].rank < sub[Array.IndexOf(vertex, y)].rank)
            {
                sub[Array.IndexOf(vertex, x)].parent = y;
            }
            else if (sub[Array.IndexOf(vertex, x)].rank > sub[Array.IndexOf(vertex, y)].rank)
            {
                sub[Array.IndexOf(vertex, y)].parent = x;
            }
            else
            {
                sub[Array.IndexOf(vertex, y)].parent = x;
                sub[Array.IndexOf(vertex, x)].rank++;
            }
        }

        private static KVertex find(KSubsets[] sub, KVertex vertex, int k, KVertex[] vertdic)
        {
            if (sub[k].parent != vertex)
            {
                sub[k].parent = find(sub, sub.ElementAt(k).parent, Array.IndexOf(vertdic, sub.ElementAt(k).parent), vertdic);// find(sub, vertex, Array.IndexOf(vertdic,vertex),vertdic);//sub.Select(j => j.parent).Where(v => v.Label == vertex.Label).FirstOrDefault();
            }

            return sub[k].parent;
        }

    }
}
