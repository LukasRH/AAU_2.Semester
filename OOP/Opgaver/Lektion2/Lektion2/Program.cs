using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Lukas = new Person("Lukas", "Rønsholt")
            {
                alder = 20,
                Mor = new Person("Lisbeth", "Rønsholt")
                {
                    alder = 45,
                    Mor = new Person("Vibeke", "Rønsholt")
                    {
                        alder = 74
                    },
                    Far = new Person("Hans", "Rønsholt")
                    {
                        alder = 80
                    }
                },
                Far = new Person("Claus", "Wiliams")
                {
                    alder = 47,
                    Mor = new Person("Lini", "Hansen")
                    {
                        alder = 74
                    },
                    Far = new Person("Jørgen", "Hansen")
                    {
                        alder = 80
                    }
                }
            };
        }
    }
}
