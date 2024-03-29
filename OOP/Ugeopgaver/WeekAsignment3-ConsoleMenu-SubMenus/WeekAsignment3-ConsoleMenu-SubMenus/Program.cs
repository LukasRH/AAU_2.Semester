﻿//20166653 Lukas Rønsholt
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekAsignment3_ConsoleMenu_SubMenus
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("My Awesome Menu");

            menu.AddMenuItem(new MenuItem("Punkt1"));
            menu.AddMenuItem(new MenuItem("Punkt2"));
            Menu underMenu = new Menu("undermenu", new MenuItem("Punkt1"), new MenuItem("Punkt1"));
            menu.AddMenuItem(underMenu);
            menu.AddMenuItem(new InfiniteMenu("Infinite Menu"));
            menu.AddMenuItem(new FileSystemMenu("Browse my C-Drive", new DirectoryInfo("c:\\")));
            menu.AddMenuItem(new Menu("RSS Menu",new RssMenu("Computer Weekly RSS", "http://www.computerweekly.com/rss/IT-hardware.xml"), new DRNyhederMenu()));

            menu.Start();
        }
    }
}
