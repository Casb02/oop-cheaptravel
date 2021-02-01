using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapTravel
{
    class Vervoer
    {
        public decimal PriceKm { get; set; }
        public Brandstof Brandstof { get; set; }
        public decimal Toeslag { get; set; }
        public int Afstand { get; set; }

        public virtual decimal TotalPrice()
        {
            throw new NotImplementedException();
        }
    }

    class Vliegtuig : Vervoer, IPrintable, IPrijs
    {
        public string Vluchtnummer { get; set; }
        public string Gate { get; set; }
        public string Stoeloptie { get; set; }
        public string Stoelnummer { get; set; }

        public override decimal TotalPrice()
        {
            var brandstofprijs = Afstand * PriceKm;

            var toeslagbrandstofprijs = Brandstof.Prijs / 100 * Brandstof.Procent;

            double chairfee;
            if (Afstand < 1000)
            {
                chairfee = 0.15 * Afstand;
            } else if (Afstand < 2000) {
                chairfee = 0.25 * Afstand;
            } else
            {
                chairfee = 0.3 * Afstand;
            }

            var chairfeeout = Convert.ToDecimal(chairfee);

            var total = toeslagbrandstofprijs + chairfeeout + brandstofprijs;
            return total;
        }

        public void PrintTicket()
        {
            Console.WriteLine("Manier van reizen: vliegen");
            Console.WriteLine("Vluchtnummer: {0}", Vluchtnummer);
            Console.WriteLine("Gate: {0}", Gate);
            Console.WriteLine("Stoel: {0}", Stoelnummer);
        }

    }

    class Trein : Vervoer, IPrijs, IPrintable
    {
        public string Klasse { get; set; }
        public string Spoor { get; set; }

        public override decimal TotalPrice()
        {
            var brandstofprijs = Afstand * PriceKm;
            var toeslagbrandstofprijs = Brandstof.Prijs / 100 * Brandstof.Procent;

            if (Klasse == "1")
            {
                toeslagbrandstofprijs = toeslagbrandstofprijs / 100 * 110;
            } else if (Klasse == "2")
            {
                toeslagbrandstofprijs = toeslagbrandstofprijs / 100 * 103;
            } else
            {
                toeslagbrandstofprijs = toeslagbrandstofprijs / 100 * 102;
            }

            var total = toeslagbrandstofprijs + brandstofprijs;
            return total;
        }
        public void PrintTicket()
        {
            Console.WriteLine("Manier van reizen: Trein");
            Console.WriteLine("Klasse: {0}", Klasse);
            Console.WriteLine("Spoor: {0}", Spoor);
        }
    }

    class Boot : Vervoer, IPrijs, IPrintable
    {
        public string Kade { get; set; }
        public string Catering { get; set; }
        public Hut Hut { get; set; }


        public override decimal TotalPrice()
        {
            var brandstofprijs = Afstand * PriceKm;
            var toeslagbrandstofprijs = Brandstof.Prijs / 100 * Brandstof.Procent;

            if (Catering == "Eten en drinken")
            {
                toeslagbrandstofprijs += 55;
            }
            else
            {
                toeslagbrandstofprijs += 15;
            }
            var total = toeslagbrandstofprijs + brandstofprijs;
            return total;
        }

        public void PrintTicket()
        {
            Console.WriteLine("Manier van reizen: Bootje");
            Console.WriteLine("Kade: {0}", Kade);
            Console.WriteLine("Catering: {0}", Catering);
            Console.WriteLine("Hut: {0}, {1}", Hut.Dek, Hut.Nummer);
        }
    }

    class Hut
    {
        public int Dek { get; set; }
        public int Nummer { get; set; }
    }
}
