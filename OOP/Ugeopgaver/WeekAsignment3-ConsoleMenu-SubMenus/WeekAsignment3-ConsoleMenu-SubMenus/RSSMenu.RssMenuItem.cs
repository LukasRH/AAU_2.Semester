using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;

namespace WeekAsignment3_ConsoleMenu_SubMenus
{
    partial class RssMenu : Menu
    {
		private class RssMenuItem : MenuItemBase
		{
		    public RssMenuItem(SyndicationItem item) : base(item.Title.Text)
		    {
		        _content = item.Summary.Text;
		    }

		    private readonly string _content;

		    public override void Select()
		    {
		        Console.Clear();
		        Console.WriteLine(Title);
		        Console.WriteLine();
		        Console.WriteLine(_content);
		        Console.ReadLine();
		    }
		}
    }
}
