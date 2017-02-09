using System;

namespace OOP2017_Kursusgang_01_Template
{
    class Opgave3
    {
        public string UserInput(string prompt)
        {
            string result;
            Console.Write(prompt + ": ");
            result = Console.ReadLine();
            return result;
        }

        public void Start()
        {
            Random r = new Random();
            int tal = r.Next(1, 10);

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            string fornavn = UserInput("Skriv dit fornavn");
            string efternavn = UserInput("Skriv dit efternavn");
            Console.Clear();
            Console.WriteLine("Hello {0} {1}", fornavn, efternavn);
            string gæt = UserInput("Gæt en tal mellem 1 og 10");

            if (gæt == tal.ToString())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Rigtigt");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nope {0}", tal);
            }
                
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            

        }
    }
}