using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekAsignment3_ConsoleMenu_SubMenus
{
    class YouFuckedUp : MenuItemBase
    {
        public YouFuckedUp(string title, Exception e) : base(title)
        {
            this.content = e;
        }

        private readonly Exception content;

        public override void Select()
        {
            Console.Clear();
            Console.WriteLine($"{Title}\n");
            Console.WriteLine(content.Message);
            Console.ReadLine();
        }
    }
}
