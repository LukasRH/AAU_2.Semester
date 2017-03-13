using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lektion5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Lukas = new Person("Lukas","Rønsholt",new DateTime(1997,01,29));
            Person Gustav = new Person("Gustav", "Brodersen", new DateTime(1996, 02, 22));
            Person Rasmus = new Person("Rasmus", "Nielsen", new DateTime(1996, 05, 13));
            Person Lasse = new Person("Lasse","Lundbo", new DateTime(1996,03,20));

            BirthDatePersonComparer bdayComparer = new BirthDatePersonComparer();

            List<Person> personList = new List<Person>();
            personList.Add(Lukas);
            personList.Add(Gustav);
            personList.Add(Rasmus);
            personList.Add(Lasse);

            Console.WriteLine("Before Sort");
            foreach (Person person in personList)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
            personList.Sort(bdayComparer);
            Console.WriteLine("After Sort");
            foreach (Person person in personList)
            {
                Console.WriteLine(person);
            }
            Console.ReadLine();
        }
    }
}
