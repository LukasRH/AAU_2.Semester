using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekAsignment3_ConsoleMenu_SubMenus
{
    partial class FileSystemMenu : Menu
    {
        protected FileSystemMenu(DirectoryInfo directory) : this(directory.Name, directory)
        {
        }

        public FileSystemMenu(string title, DirectoryInfo directory) : base(title)
        {
            this._directory = directory;
        }
    
        private readonly DirectoryInfo _directory;
        private bool _firstrun = true;

        public override void Select()
        {
            if (_firstrun)
            {
                try
                {
                    _firstrun = false;
                    foreach (DirectoryInfo directory in _directory.GetDirectories())
                    {
                        AddMenuItem(new FileSystemMenu(directory));
                    }
                    foreach (FileInfo file in _directory.GetFiles())
                    {
                        AddMenuItem(new FileMenuItem(file));
                    }
                    SortMenuItems();
                    base.Select();
                }
                catch (UnauthorizedAccessException e)
                {
                    new YouFuckedUp("Access Denied!", e).Select();
                }
                
            }
            else
            {
                base.Select();
            }
        }
    }
}
