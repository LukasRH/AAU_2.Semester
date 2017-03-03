using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekAsignment3_ConsoleMenu_SubMenus
{
    class InfiniteMenu : Menu
    {
        public InfiniteMenu(string title) : base(title)
        {
        }

        public InfiniteMenu(string title, params MenuItemBase[] items) : base(title, items)
        {
        }

        private bool _haveYouRunThisShitBefore = false;

        public override void Select()
        {
            if (_haveYouRunThisShitBefore)
            {
                base.Select();
            }
            else
            {
                _haveYouRunThisShitBefore = true;
                for (int i = 0; i < 6; i++)
                {
                    this.AddMenuItem(new InfiniteMenu($"Menu{i+1}"));
                }
                base.Select();
            }
        }
    }
}
