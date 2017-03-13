using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WeekAsignment3_ConsoleMenu_SubMenus
{
    partial class RssMenu : Menu
    {
        public RssMenu(string url) : this(url, url, null)
        {
        }

        public RssMenu(string title, string url) : this(title, url, null)
        {
        }

        public RssMenu(string title, string url, params MenuItemBase[] items) : base(title, items)
        {
            XmlReader reader = XmlReader.Create(url);
            _feed = SyndicationFeed.Load(reader);
            reader.Close();
        }

        private readonly SyndicationFeed _feed;
        private bool _firstRun = true;

        public override void Select()
        {
            if (_firstRun)
            {
                _firstRun = false;
                foreach (SyndicationItem item in _feed.Items)
                {
                    AddMenuItem(new RssMenuItem(item));
                }
                base.Select();
            }
            else
            {
                base.Select();
            }
        }
    }
}
