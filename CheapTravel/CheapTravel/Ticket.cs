using System;

namespace CheapTravel
{
    class Ticket : IPrintable
    {
        public Reisinfo ReisInformatie { get; set; }
        public Persoon Persoon { get; set; }
        public Boekinggegevens Boekinggegevens { get; set; }
        public Vervoer Vervoer { get; set; }

        public Ticket(Reisinfo reisinfo, Persoon persoon, Boekinggegevens boekinggegevens, Vervoer vervoer)
        {
            ReisInformatie = reisinfo;
            Persoon = persoon;
            Boekinggegevens = boekinggegevens;
            Vervoer = vervoer;
        }

        public void PrintTicket()
        {
            PrintTitle("Boekingsgegevens");
            Console.WriteLine("Boeking datum: {0}", Boekinggegevens.Boekingdatum);
            Console.WriteLine("Reservering ID: {0}", Boekinggegevens.ID);
            Console.WriteLine(" ");
            PrintTitle("Persoonsgegevens");
            Console.WriteLine("Voornaam: {0}", Persoon.Voornaam);
            Console.WriteLine("Achternaam: {0}", Persoon.Achternaam);
            Console.WriteLine("Tussenvoegsel: {0}", Persoon.Tussenvoegsel);
            Console.WriteLine("BSN: {0}", Persoon.BSN);
            Console.WriteLine("Mail: {0}", Persoon.Mail);
            Console.WriteLine("Tel Nr: {0}", Persoon.Telefoon);
            Console.WriteLine(" ");
            PrintTitle("Reisinformatie");
            Console.WriteLine("Van: {0}\nNaar: {1}", ReisInformatie.StartLoc, ReisInformatie.EndLoc);
            Console.WriteLine("Vertrek: {0}\nAankomst: {1}", ReisInformatie.Depature, ReisInformatie.Arrival);
            Console.WriteLine(" ");
            PrintTitle("Factuur");
            Vervoer.Factuur();
            Console.WriteLine("------");
            Console.WriteLine("Prijs {0} ", Vervoer.Ticketpijs());


        }

        // Create header (maak hoofdstuk)
        public static void PrintTitle(string input)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(input);
            Console.ResetColor();
        }
    }

}
