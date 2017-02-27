using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 4;
            string Sa = "bob", Sb = "bob";
            RefCompare comp = new RefCompare();
            comp.ValueComp(a,b);
            comp.ValueComp(Sa,Sb);
            comp.RefComp(ref a, ref b);
            comp.RefComp(ref Sa, ref Sb);
            Console.ReadLine();
        }
    }
}
