using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Copyright text
            Console.WriteLine("-- Welkom terug bij Cheap Travel Tickets --\n (c) 1969\n");

            // Set window title
            Console.Title = "Cheap Travel app";

            // Ask the user to continue to the app
            Console.WriteLine("Klik een toets om te starten!");
            Console.ReadKey();

            // Open menu
            Menu();

        }


        //Menus lijst met functionaliteiten
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Kies een optie");
            Console.WriteLine("1 : Personen menu");


            while (true)
            {
                // Check user selection input
                string input = Console.ReadLine();

                //If input = 1 open user menu
                if (input == "1")
                {
                    
                    break;
                }
                // Print error if input is not an valid option
                else
                {
                    printError("De invoer: " + input + " is geen optie. Klik een toets om verder te gaan");
                    Console.ReadKey();
                    Menu();
                }
            }


        }


        // Create error message in red color
        public static void printError(string input)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: " + input);
            Console.ResetColor();
        }
    }
}
