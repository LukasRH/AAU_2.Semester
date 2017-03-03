﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekAsignment3_ConsoleMenu_SubMenus
{
    abstract class MenuItemBase
    {
        protected MenuItemBase(string title)
        {
            this.Title = title;
        }
        public virtual string Title { get; }
        public abstract void Select();
    }
}
