using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion4
{
    abstract class PersonFilter
    {
        public abstract bool Match(Person person, string Name);
        public abstract bool Match(Person person, int MinAge, int MaxAge);
        public abstract bool Match(Person person, Type Type);
        public virtual List<Person> Filter(List<Person> people, string Name)
        {
            List<Person> result = new List<Person>();
            foreach (Person person in people)
            {
                if (Match(person, Name))
                    result.Add(person);
            }
            return result;
        }
        public virtual List<Person> Filter(List<Person> People, int MinAge, int MaxAge)
        {
            List<Person> result = new List<Person>();
            foreach (Person person in People)
            {
                if (Match(person, MinAge, MaxAge))
                    result.Add(person);
            }
            return result;
        }
        public virtual List<Person> Filter(List<Person> People, Type Type)
        {
            List<Person> result = new List<Person>();
            foreach (Person person in People)
            {
                if (Match(person, Type))
                    result.Add(person);
            }
            return result;
        }
    }
}
