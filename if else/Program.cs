
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace If_else_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }

        }

        private static bool MainMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                True();
                return true;
            }
            else if (result == "2")
            {
                False();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;

            }
        }

        private static void True()
        {
            Console.WriteLine("True");
            Console.ReadLine();
        }

        private static void False()
        {
            Console.WriteLine("False");
            Console.ReadLine();
        }
    }
}