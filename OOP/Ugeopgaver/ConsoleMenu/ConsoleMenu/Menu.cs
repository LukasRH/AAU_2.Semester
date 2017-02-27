using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    class Menu
    {
        public string MenuTitle;
        private bool _running = false;
        private List<MenuItem> _MenuItems = new List<MenuItem>();

        public Menu(string menutitle)
        {
            this.MenuTitle = menutitle;
        }

        public void AddMenuItem(string Title, string Content)
        {
            _MenuItems.Add(new MenuItem(Title, Content));
        }

        public void Start()
        {
            _running = true;
            do
            {
                DrawMenu();
                HandleInput();
            } while (_running);
        }

        private  void DrawMenu()
        {
            Console.Title = this.MenuTitle;
            CenterText(this.MenuTitle);

            foreach (MenuItem item in _MenuItems)
            {
                CenterText(item.Title);
            }
        }

        private static void CenterText(String text)
        {
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.WriteLine(text);
        }

        private void HandleInput()
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            switch (cki.Key)
            {
                case ConsoleKey.Backspace:
                case ConsoleKey.Escape:
                    _running = false;
                    break;
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;
                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;
                case ConsoleKey.Enter:
                    GetSelectedMenuItem().Select();
                    break;
                default:
                    break;
            }
        }

        private void MoveUp()
        {

        }

        private void MoveDown()
        {

        }

        private MenuItem GetSelectedMenuItem()
        {
            return new MenuItem("Test", "Test");
        }
    }
}
