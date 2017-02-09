using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2017_Kursusgang_01_Template
{
    class Opgave6
    {
        private double DegreesToRadian(double degrees)
        {
            if (degrees >= 0 && degrees <= 360)
            {
                return degrees * (Math.PI / 180);
            }
            else
            {
                throw new ArgumentException("Not a vaild value", "degrees");
            }
        }

        private double RadiansToDegrees(double radians)
        {
            if (radians >= 0 && radians <= 360)
            {
                return radians * (180 / Math.PI);
            }
            else
            {
                throw new ArgumentException("Not a vaild value", "radians");
            }
        }

        public void start()
        {
            Console.Write("Radians or Degrees: ");
            string type = Console.ReadLine().ToLower();

            if (type == "radians")
            {
                Console.Write("Radians: ");
                double degrees = RadiansToDegrees(double.Parse(Console.ReadLine()));
                Console.WriteLine($"Degrees: {degrees}");
            }
            else
            {
                Console.Write("Degrees: ");
                double degrees = DegreesToRadian(double.Parse(Console.ReadLine()));
                Console.WriteLine($"Radians: {degrees}");
            }
            Console.ReadLine();
        }
    }
}
