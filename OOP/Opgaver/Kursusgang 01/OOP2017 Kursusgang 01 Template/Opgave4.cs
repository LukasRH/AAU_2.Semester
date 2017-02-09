using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2017_Kursusgang_01_Template
{
    class Opgave4
    {
        public void start()
        {
            Console.Write("Write number to get the squreroot:");
            double result = Math.Sqrt(int.Parse(Console.ReadLine()));
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
