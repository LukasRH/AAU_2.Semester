using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    class MenuItem
    {
        public string Title;
        public string Content;

        public MenuItem(string title, string content)
        {
            this.Title = title;
            this.Content = content;
        }

        public void Select()
        {
            Console.Clear();
            Console.WriteLine($"{this.Title}\n\n{this.Content}\n\nPress Enter to return");
        }
    }
}
