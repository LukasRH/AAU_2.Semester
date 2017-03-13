using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion5
{
    class Person : IComparable<Person>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; }
        public Person(string firstname, string lastname, DateTime birthDate)
        {
            Firstname = firstname;
            Lastname = lastname;
            BirthDate = birthDate;
        }

        public int CompareTo(Person other)
        {
            int compareResult = String.Compare(this.Firstname, other.Firstname);

            if (compareResult == 0)
            {
                compareResult = String.Compare(this.Lastname, other.Lastname);
            }

            return compareResult;
        }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + BirthDate;
        }
    }
}
