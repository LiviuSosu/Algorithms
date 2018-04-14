using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Threading;
using Grapfs.Kruskal;
using Grapfs.BellmanFord;

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

            #region Prim & Kruskal
            /*
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
                    */

            int[,] L ={
                {-1,  5, -1, -1, -1,  3, -1, -1},
                { 5, -1,  2, -1, -1, -1,  3, -1},
                {-1,  2, -1,  6, -1, -1, -1, 10},
                {-1, -1,  6, -1,  3, -1, -1, -1},
                {-1, -1, -1,  3, -1,  8, -1,  5},
                { 3, -1, -1, -1,  8, -1,  7, -1},
                {-1,  3, -1, -1, -1,  7, -1,  2},
                {-1, -1, 10, -1,  5, -1,  2, -1}
            };
            #endregion

            #region Dijkstra
            //double[,] G = new double[4, 4];
            //G[0, 1] = 3;
            //G[0, 3] = 6;
            //G[1, 3] = 1;
            //G[1, 2] = 3;
            //G[3, 2] = 1;
            //Dijkstra.Dijkstra dist = new Dijkstra.Dijkstra(G, 4);

            //var item = dist.dist;

            //for (int i = 0; i < item.Length; i++)
            //{
            //    Console.WriteLine("Node " + i + " Path Distance = " + item[i]);
            //}
            #endregion

            #region BellmanFord
            //for (int i = 0; i < vertices.Length; i++)
            //{
            //    if (!Iterate())
            //        break;
            //}

            //foreach (var keyValue in memo)
            //{
            //    Console.WriteLine($"{keyValue.Key}: {keyValue.Value}");
            //}
            #endregion

            #region Floyd Warshall
            //int[,] graph = {
            //             { 0,   6,  cst, 11 },
            //             { cst, 0,   4, cst },
            //             { cst, cst, 0,   2 },
            //             { cst, cst, cst, 0 }
            //               };

            //FloydWarshall(graph, 4);
            #endregion
        }

        #region Floyd Warshall utils
        //http://www.csharpstar.com/floyd-warshall-algorithm-csharp/
        public const int cst = 9999;

        private static void Print(int[,] distance, int verticesCount)
        {
            Console.WriteLine("Shortest distances between every pair of vertices:");

            for (int i = 0; i < verticesCount; ++i)
            {
                for (int j = 0; j < verticesCount; ++j)
                {
                    if (distance[i, j] == cst)
                        Console.Write("cst".PadLeft(7));
                    else
                        Console.Write(distance[i, j].ToString().PadLeft(7));
                }

                Console.WriteLine();
            }
        }

        public static void FloydWarshall(int[,] graph, int verticesCount)
        {
            int[,] distance = new int[verticesCount, verticesCount];

            for (int i = 0; i < verticesCount; ++i)
                for (int j = 0; j < verticesCount; ++j)
                    distance[i, j] = graph[i, j];

            for (int k = 0; k < verticesCount; ++k)
            {
                for (int i = 0; i < verticesCount; ++i)
                {
                    for (int j = 0; j < verticesCount; ++j)
                    {
                        if (distance[i, k] + distance[k, j] < distance[i, j])
                            distance[i, j] = distance[i, k] + distance[k, j];
                    }
                }
            }

            Print(distance, verticesCount);
        }
        #endregion

        #region Bellman-Ford utils
        static string[] vertices = { "S", "A", "B", "C", "D", "E" };

        static List<Path> graph = new List<Path>()
        {
            new Path("S", "A", 4),
            new Path("S", "E", -5),
            new Path("A", "C", 6),
            new Path("B", "A", 3),
            new Path("C", "B", -2),
            new Path("D", "C", 3),
            new Path("D", "A", 10),
            new Path("E", "D", 8)
        };

        static Dictionary<string, int> memo = new Dictionary<string, int>()
        {
            { "S", 0 },
            { "A", int.MaxValue },
            { "B", int.MaxValue },
            { "C", int.MaxValue },
            { "D", int.MaxValue },
            { "E", int.MaxValue }
        };

        static bool Iterate()
        {
            bool doItAgain = false;

            foreach (var fromVertex in vertices)
            {
                Path[] edges = graph.Where(x => x.From == fromVertex).ToArray();
                foreach (var edge in edges)
                {
                    int potentialCost = memo[edge.From] == int.MaxValue ? int.MaxValue : memo[edge.From] + edge.Cost;
                    if (potentialCost < memo[edge.To])
                    {
                        memo[edge.To] = potentialCost;
                        doItAgain = true;
                    }
                }
            }
            return doItAgain;
        }
        #endregion

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
