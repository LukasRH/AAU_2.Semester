using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave6
{
    class RefCompare
    {
        public void ValueComp(string a, string b)
        {
            bool state = (a == b);
            Console.WriteLine($"{a} == {b} : {state}");
        }
        public void ValueComp(int a, int b)
        {
            bool state = (a == b);
            Console.WriteLine($"{a} == {b} : {state}");
        }

        public void RefComp(ref string a, ref string b)
        {
            bool state = (a == b);
            Console.WriteLine($"{a} == {b} : {state}");
        }
        public void RefComp(ref int a, ref int b)
        {
            bool state = (a == b);
            Console.WriteLine($"{a} == {b} : {state}");
        }
    }
}
