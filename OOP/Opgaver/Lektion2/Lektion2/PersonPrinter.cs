using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion2
{
    class PersonPrinter
    {
        public void PrintPerson(Person person)
        {
            Console.WriteLine(person.Navn + ", " + person.alder + " år");
        }

        public void PrintFamily(Person person)
        {
            PrintPerson(person);
            if (person.Mor != null)
            {
                Console.Write("Mor: ");
                PrintPerson(person.Mor);
                if (person.Mor.Mor != null)
                {
                    Console.Write("Mormor: ");
                    PrintPerson(person.Mor.Mor);
                }
                if (person.Mor.Far != null)
                {
                    Console.Write("MorFar: ");
                    PrintPerson(person.Mor.Far);
                }
            }
            if (person.Far != null)
            {
                Console.Write("Far: ");
                PrintPerson(person.Far);
                if (person.Far.Far != null)
                {
                    Console.Write("FarFar: ");
                    PrintPerson(person.Far.Far);
                }
                if (person.Far.Mor != null)
                {
                    Console.Write("FarMor: ");
                    PrintPerson(person.Mor.Far);
                }
            }
        }
    }
}
