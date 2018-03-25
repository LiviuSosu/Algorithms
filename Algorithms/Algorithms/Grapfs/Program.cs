using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Prim_sAlgorithm.Prim(graph, 5);
        }
    }
}
