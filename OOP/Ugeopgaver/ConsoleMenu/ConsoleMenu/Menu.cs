﻿using System;
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
        private readonly List<MenuItem> _menuItems = new List<MenuItem>();

        public Menu(string menutitle)
        {
            this.MenuTitle = menutitle;
        }

        public void AddMenuItem(string title, string content)
        {
            _menuItems.Add(new MenuItem(title, content));
        }

        public void Start()
        {
            _running = true;
            Console.CursorVisible = false;
            DrawMenu();
            do
            {
                HandleInput();
            } while (_running);
        }

        private  void DrawMenu()
        {
            Console.Clear();
            Console.Title = this.MenuTitle;
            CenterText(this.MenuTitle);

            foreach (MenuItem item in _menuItems)
            {
                CenterText(item.Title);
            }

            HighlightText(_menuItems[_menuItems.Count-1].Title, _menuItems.Count);
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
                    Console.ReadLine();
                    DrawMenu();
                    break;
                default:
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
            RemoveHighlight(_menuItems[Console.CursorTop-1].Title, Console.CursorTop);
            HighlightText(_menuItems[Console.CursorTop].Title, Console.CursorTop + 1);
        }

        private MenuItem GetSelectedMenuItem()
        {
            return _menuItems[Console.CursorTop-1];
        }

        private static void CenterText(string text)
        {
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.WriteLine(text);
        }

        private static void HighlightText(string text, int pos)
        {
            int startingPoint = (Console.WindowWidth - text.Length) / 2;
            int EndPoint = startingPoint + text.Length;
            Console.SetCursorPosition(startingPoint, pos);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(text);
            Console.ResetColor();
        }
        private static void RemoveHighlight(string text, int pos)
        {
            int StartingPoint = (Console.WindowWidth - text.Length) / 2;
            int EndPoint = StartingPoint + text.Length;
            Console.SetCursorPosition(StartingPoint, pos);
            Console.Write(text);
        }
    }
}
