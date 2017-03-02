using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> plist = new List<Person>();
            plist.Add(new Employee("Lasse","Lundbo",21));
            plist.Add(new Person("Lukas", "Rønsholt", 20));
            plist.Add(new Person("Gustav", "Brodersen", 21));
            plist.Add(new Employee("Magnus", "Boisen", 20));
            plist.Add(new Employee("Alex", "Russer", 20));

            PersonFilter pfilter = new Filter();
            List<Person> filteredList = pfilter.Filter(plist,typeof(Person));

            foreach (Person person in filteredList)
            {
                Console.WriteLine(person + "\n");
            }

            Console.ReadLine();

        }
    }
}
