using Basic;
using System.Collections.Generic;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers ba = new Numbers();
            List<int> numbers = new List<int>() { 1,3,4,8,7};
            var c= ba.MultipleSum(numbers, 5);
        }
    }
}
