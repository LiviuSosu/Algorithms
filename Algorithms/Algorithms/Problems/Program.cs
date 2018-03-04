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
            SevethDay sd = new SevethDay();
            sd.Method2( 10);

            TriangleNumbers tn = new TriangleNumbers();
            int x= tn.Sequence(8);
            //////ThirdDay td = new ThirdDay();
            //////var c = td.Method1(567789,4);
            Console.WriteLine("Hello World!");
        }
    }
}
