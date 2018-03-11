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
            Translate tr = new Translate();
            var c = tr.Tra("Ana has many mere dar she is going to the piata to vanda them");
            Console.WriteLine("Hello World!");
        }
    }
}
