using Problems.Array;
using Problems.HouseNumbers;
using Problems.Numbers;
using System;
using System.Collections.Generic;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fishing.Fishing f = new Fishing.Fishing();
            //f.Fish();
            //Soldiers.Soldiers soldiers = new Soldiers.Soldiers();
            //soldiers.Group();
            //Mirror.Mirror mirror = new Mirror.Mirror();
            //mirror.Test(1353);
            //Ages.Ages ages = new Ages.Ages();
            //ages.GetExtremes();
            //SevethDay sd = new SevethDay();
            //var c =sd.NewNumber(1234);

            //TriangleNumbers tn = new TriangleNumbers();
            //int x= tn.Sequence(8);
            //ThirdDay td = new ThirdDay();
            //var c = td.Method1("567789", 8);
            //Overlap ov = new Overlap();
            //List<int> param = new List<int>() { 0,0,0,2,2,2,3,1,1,1,0,0,0,2,2,2,3,1,1,1,0,0,0 };
            //ov.ov(param);
            //Translate tr = new Translate();
            //var c = tr.Tra("Ana has many mere dar she is going to the piata to vanda them");
            //string x = "";
            //rec("43881796",5,x);

            //Recursion.Recursion recursion = new Recursion.Recursion();
            //string str = "hat";
            //char[] arr = str.ToCharArray();
            //recursion.GetPer(arr);

            //Recursion.Queens queens = new Recursion.Queens();
            //int N = Convert.ToInt32(Console.ReadLine());
            //int[,] board = new int[N, N];
            //if (!queens.theBoardSolver(board, 0))
            //{
            //    Console.WriteLine("Solution not found.");
            //}
            //queens.printBoard(board);
            //XII.Numbers numbers = new XII.Numbers();
            //numbers.GetNumber(4);
            //HanoiTowers.Hanoi h = new HanoiTowers.Hanoi();
            //char startPeg = 'A'; // start tower in output
            //char endPeg = 'C'; // end tower in output
            //char tempPeg = 'B'; // temporary tower in output
            //int totalDisks = 5; // number of disks
            //h.solveTowers(totalDisks, startPeg, endPeg, tempPeg);

            //EuclidAlgorithm.Euclid euclid = new EuclidAlgorithm.Euclid();
            //var euclidResult = euclid.Extended_GCD(30,40);
            Encoding.Encoding encoding = new Encoding.Encoding();
            //var c = encoding.EncodingChart();
            string alpfabet = "abcde";
            var c = encoding.ChopString(alpfabet);
           
        }

        static void rec(string nr, int p,  string result)
        {
            int max;
           if(p>0)
            {
                max = 1;
                for(int i=2; i<8 - p +1;i++) //??
                {
                    if (nr[i]>nr[max])
                    {
                        max = 1;
                    }
                }
                result = result + nr[max];
                rec(nr, p - 1, result);
            }
        }
    }
}
