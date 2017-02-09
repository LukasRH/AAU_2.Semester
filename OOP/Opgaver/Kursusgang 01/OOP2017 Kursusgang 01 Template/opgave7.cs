using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2017_Kursusgang_01_Template
{
    class opgave7
    {
        public void group()
        {
            int i = 0; List<string> members = new List<string>();
            while (true)
            {
                Console.Write($"Enter the name of groupmember #{++i}: ");
                string member = Console.ReadLine();
                if (member == "")
                {
                    break;
                }
                else
                {
                    members.Add(member);
                }
            }

            members.Sort();

            foreach (string member in members)
            {
                Console.WriteLine(member);
            }

            Console.ReadLine();
        }
    }
}
