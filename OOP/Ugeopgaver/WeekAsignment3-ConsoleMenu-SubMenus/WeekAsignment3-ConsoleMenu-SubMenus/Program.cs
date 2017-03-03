using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekAsignment3_ConsoleMenu_SubMenus
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu Menu = new Menu("My Awesome Menu");

            Menu.AddMenuItem("point 1", "Bob the builder was here!");
            Menu.AddMenuItem("point 2", "Bob the builder have yet to come here!");
            Menu.AddMenuItem("point a bit longer", "Bob the builder will never come here!");

            Menu.Start();
        }
    }
}
