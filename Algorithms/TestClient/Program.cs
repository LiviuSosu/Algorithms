using Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers ba = new Numbers();

            var c= ba.GetRelatedNumbers(2,100);

        }
    }
}
