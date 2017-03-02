using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion4
{
    class Filter : PersonFilter
    {
        public override bool Match(Person person, int MinAge, int MaxAge)
        {
            return person.alder >= MinAge && person.alder <= MaxAge;
        }

        public override bool Match(Person person, string Name)
        {
            return person.Navn == Name;
        }

        public override bool Match(Person person, Type Type)
        {
            return person.GetType() == Type;
        }
    }
}
