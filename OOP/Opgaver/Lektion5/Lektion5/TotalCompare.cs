using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion5
{
    class TotalCompare : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (String.Compare(x.Firstname,y.Firstname) == 0)
            {
                if (String.Compare(x.Lastname, y.Lastname) == 0)
                {
                    return DateTime.Compare(x.BirthDate, y.BirthDate);
                }
                return String.Compare(x.Lastname, y.Lastname);
            }
            return String.Compare(x.Firstname, y.Firstname);
        }
    }
}
