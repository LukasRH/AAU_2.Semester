using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekAsignment3_ConsoleMenu_SubMenus
{
    class DRNyhederMenu : Menu
    {
        public DRNyhederMenu() : base("DR Nyheder")
        {
            for(int i = 0; i < _drNyheder.Length/2; i++)
            {
                AddMenuItem(new RssMenu(_drNyheder[i,1], _drNyheder[i,0]));
            }   
        }

        private readonly string[,] _drNyheder = new string[,]
        {
            {"http://www.dr.dk/nyheder/service/feeds/allenyheder", "Alle Nyheder"},
            {"http://www.dr.dk/nyheder/service/feeds/indland", "Indland"},
            {"http://www.dr.dk/nyheder/service/feeds/udland", "Udland"},
            {"http://www.dr.dk/nyheder/service/feeds/penge", "Penge"},
            {"http://www.dr.dk/nyheder/service/feeds/politik", "Politik"},
            {"http://www.dr.dk/nyheder/service/feeds/kultur", "Kultur"},
            {"http://www.dr.dk/nyheder/service/feeds/levnu", "Lev Nu"},
            {"http://www.dr.dk/nyheder/service/feeds/viden", "Viden"},
            {"http://www.dr.dk/nyheder/service/feeds/sporten", "Sporten"},
            {"http://www.dr.dk/nyheder/service/feeds/vejret", "Vejret"}
        };

    }
}
