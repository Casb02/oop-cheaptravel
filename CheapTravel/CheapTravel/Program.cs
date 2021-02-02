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
            Console.WriteLine("1 : print ticket");
            Console.WriteLine("2 : maak ticket");
            Console.WriteLine("3 : ticketlijst");


            while (true)
            {
                // Check user selection input
                string input = Console.ReadLine();

                //If input = 1 open user menu
                if (input == "1")
                {
                    Console.Clear();
                    Persoon p = new Persoon("Cas", "Boomkamp", "", "3840719", "Example@example.exm", "0612364444");
                    Reisinfo r = new Reisinfo("Vliegtuig", "Shiphol", "Manuel's huis", DateTime.Parse("12:00"), DateTime.Parse("14:00"));
                    Boekinggegevens b = new Boekinggegevens(DateTime.Parse("18-09-2020 14:00"), 1);

                    Brandstof br = new Brandstof("Kerosine", 100.00M, 10);
                    Vervoer v = new Vliegtuig(10M, br, 1000, "AB1234", "B3", "Economy", "8B");

                    Ticket ticket = new Ticket(r, p, b, v);
                    Ticketlijst tl = new Ticketlijst(1, ticket);
                    ticket.PrintTicket();

                    Console.ReadKey();
                    break;
                }
                // Print error if input is not an valid option
                else if(input == "2") {
                    Createticket.Create();
                    Menu();
                } else if(input == "3")
                {
                    Persoon p = new Persoon("Cas", "Boomkamp", "", "3840719", "Example@example.exm", "0612364444");
                    Reisinfo r = new Reisinfo("Vliegtuig", "Shiphol", "Manuel's huis", DateTime.Parse("12:00"), DateTime.Parse("14:00"));
                    Boekinggegevens b = new Boekinggegevens(DateTime.Parse("18-09-2020 14:00"), 1);

                    Brandstof br = new Brandstof("Kerosine", 100.00M, 10);
                    Vervoer v = new Vliegtuig(10M, br, 1000, "AB1234", "B3", "Economy", "8B");

                    Ticket ticket = new Ticket(r, p, b, v);
                    Ticketlijst tl = new Ticketlijst(1, ticket);
                    ticket.PrintTicket();

                    Console.ReadKey();
                    break;

                } else
                {
                    PrintError("De invoer: " + input + " is geen optie. Klik een toets om verder te gaan");
                    Console.ReadKey();
                    Menu();
                }
            }


        }


        // Create error message in red color
        public static void PrintError(string input)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: " + input);
            Console.ResetColor();
        }

    }
}
