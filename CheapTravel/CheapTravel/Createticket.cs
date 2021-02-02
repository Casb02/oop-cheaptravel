using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapTravel
{
    class Createticket
    {
        public static void Create()
        {
            Console.Clear();
            Console.WriteLine("Ticket aanmaken");


            var voornaam = Question("Voer naam in:");
            var achternaam = Question("Voer achternaam in:");
            var tussenvoegsel = Question("Voer tussenvoegsel in indien van toepassing\n anders een spatie:");
            var bsnnr = Question("Voer BSN in:");
            var mail = Question("Voer email in:");
            var teln = Question("Voer telefoon nr in:");
            Persoon p = new Persoon(voornaam, achternaam, tussenvoegsel, bsnnr, mail, teln);
            Console.WriteLine("Deze persoon heet: {0} {1}", p.Voornaam, p.Achternaam);
            Console.WriteLine("Druk een toets om verder te gaan.");

            Console.ReadKey();
            Console.Clear();

            var startloc = Question("Vertrek locatie:");
            var endloc = Question("Bestemming:");
            Reisinfo r = new Reisinfo("Vliegtuig", startloc, endloc, DateTime.Parse("12:00"), DateTime.Parse("14:00"));

            Console.WriteLine("Deze rit gaat van {0} naar {1}", r.StartLoc, r.EndLoc);
            Console.WriteLine("Druk een toets om verder te gaan en ticket te zien.");

            Console.ReadKey();
            Console.Clear();

            Boekinggegevens b = new Boekinggegevens(DateTime.Now, 1);

            Brandstof br = new Brandstof("Kerosine", 100.00M, 10);
            Vervoer v = new Vliegtuig(10M, br, 1000, "AB1234", "B3", "Economy", "8B");

            Ticket ticket = new Ticket(r, p, b, v);

            Ticketlijst tl = new Ticketlijst(2, ticket);
            ticket.PrintTicket();

            Console.ReadKey();

        }

        public static string Question(string question)
        {
            Console.WriteLine(question);
            string input = Console.ReadLine();

            while (true)
            {
                if (input == "")
                {
                    PrintError("Geen invoer!");
                    return "Error";
                } else
                {
                    return input;
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
