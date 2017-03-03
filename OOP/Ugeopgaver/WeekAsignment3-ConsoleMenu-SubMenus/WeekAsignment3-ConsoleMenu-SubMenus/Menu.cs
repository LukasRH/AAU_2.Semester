﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekAsignment3_ConsoleMenu_SubMenus
{
    class Menu : MenuItemBase
    {
        private bool _running = false;
        private readonly List<MenuItemBase> _menuItems = new List<MenuItemBase>();

        private const ConsoleColor Black = ConsoleColor.Black;
        private const ConsoleColor White = ConsoleColor.White;


        public Menu(string title) : base(title)
        {}

        public void AddMenuItem(string title, string content)
        {
            _menuItems.Add(new MenuItem(title, content));
        }

        public void AddSubMenu()
        {
            
        }

        public void Start()
        {
            _running = true;
            Console.CursorVisible = false;
            Console.ForegroundColor = Black;
            DrawMenu();
            do
            {
                HandleInput();
            } while (_running);
        }

        private void DrawMenu()
        {
            Console.Clear();
            Console.Title = this.Title;
            CenterText(this.Title);

            foreach (MenuItemBase item in _menuItems)
            {
                CenterText(item.Title);
            }

            HighlightText(_menuItems[_menuItems.Count - 1].Title, _menuItems.Count);
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
                    SelectMenuItem();
                    break;
                default:
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    break;
            }
        }

        private void MoveUp()
        {
            if (Console.CursorTop - 2 < 0) return;
            RemoveHighlight(_menuItems[Console.CursorTop - 1].Title, Console.CursorTop);
            HighlightText(_menuItems[Console.CursorTop - 2].Title, Console.CursorTop - 1);
        }

        private void MoveDown()
        {
            if (Console.CursorTop >= _menuItems.Count) return;
            RemoveHighlight(_menuItems[Console.CursorTop - 1].Title, Console.CursorTop);
            HighlightText(_menuItems[Console.CursorTop].Title, Console.CursorTop + 1);
        }

        private void SelectMenuItem()
        {
            Console.ForegroundColor = White;
            GetSelectedMenuItem().Select();
            Console.ReadLine();
            Console.Title = Title;
            DrawMenu();
        }

        private MenuItemBase GetSelectedMenuItem()
        {
            return _menuItems[Console.CursorTop - 1];
        }

        private static void CenterText(string text)
        {
            Console.ResetColor();
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Black;
        }

        private static void Highlightcolor(bool state = true)
        {
            if (state)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }

        private static void HighlightText(string text, int pos)
        {
            int startingPoint = (Console.WindowWidth - text.Length) / 2;
            Console.SetCursorPosition(startingPoint, pos);
            Highlightcolor();
            Console.Write(text);
            Highlightcolor(false);
        }
        private static void RemoveHighlight(string text, int pos)
        {
            int startingPoint = (Console.WindowWidth - text.Length) / 2;
            Console.SetCursorPosition(startingPoint, pos);
            Console.ResetColor();
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public override void Select()
        {
            this.Start();
        }
    }
}
