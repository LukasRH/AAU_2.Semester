using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion5
{
    class BirthDatePersonComparer : IComparer<Person>
    {
        public int Compare(Person one, Person two)
        {
            return DateTime.Compare(one.BirthDate, two.BirthDate);
        }
    }
}
