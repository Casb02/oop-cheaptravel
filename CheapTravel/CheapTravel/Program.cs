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
