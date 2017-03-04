using System;
using System.IO;

namespace WeekAsignment3_ConsoleMenu_SubMenus
{
    partial class FileSystemMenu : Menu
    {
        private class FileMenuItem : MenuItemBase
        {
            public FileMenuItem(FileInfo file) : base(file.Name)
            {
                this._file = file;
            }

            private readonly FileInfo _file;

            public override void Select()
            {
                Console.Clear();
                Console.WriteLine($"{Title} Properties\n");
                Console.WriteLine("{0, -20} {1,-30}","Type:",_file.Extension);
                Console.WriteLine("{0, -20} {1,-30}","Location:",_file.FullName);
                Console.WriteLine();
                Console.WriteLine("{0, -20} {1,-30}","Size:",_file.Length);
                Console.WriteLine();
                Console.WriteLine("{0, -20} {1,-30}","Created:",_file.CreationTime);
                Console.WriteLine("{0, -20} {1,-30}","Modified:", _file.LastWriteTime);
                Console.WriteLine("{0, -20} {1,-30}","Accessed:",_file.LastAccessTime);
                Console.ReadLine();
            }
        }
    }
}
