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

        public virtual decimal Ticketpijs()
        {
            throw new NotImplementedException();
        }

        public virtual void Factuur()
        {
            throw new NotImplementedException();
        }
    }

    class Vliegtuig : Vervoer, IPrintable, IPrijs, IFactuur
    {
        public string Vluchtnummer { get; set; }
        public string Gate { get; set; }
        public string Stoeloptie { get; set; }
        public string Stoelnummer { get; set; }

        public Vliegtuig(decimal pricekm, Brandstof brandstof, int afstand, string vlucht, string gate, string stoelop, string stoelnr)
        {
            PriceKm = pricekm;
            Brandstof = brandstof;
            Toeslag = Chairfee();
            Afstand = afstand;
            Vluchtnummer = vlucht;
            Gate = gate;
            Stoeloptie = stoelop;
            Stoelnummer = stoelnr;
        }

        private decimal Chairfee()
        {
            double chairfee;
            if (Afstand < 1000)
            {
                chairfee = 0.15 * Afstand;
            }
            else if (Afstand < 2000)
            {
                chairfee = 0.25 * Afstand;
            }
            else
            {
                chairfee = 0.3 * Afstand;
            }

            var chairfeeout = Convert.ToDecimal(chairfee);
            return chairfeeout;
        }

        public override decimal Ticketpijs()
        {
            var brandstofprijs = Afstand * PriceKm;

            var toeslagbrandstofprijs = Brandstof.Prijs / 100 * Brandstof.Procent;

            var chairfeeout = Chairfee();

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

        public override void Factuur()
        {
            var brandstofprijs = Afstand * PriceKm;
            var brandstofprijstotal = brandstofprijs.ToString("0.00");

            var toeslagbrandstofprijs = Brandstof.Prijs / 100 * Brandstof.Procent;
            var toeslagbrandstofprijstotal = toeslagbrandstofprijs.ToString("0.00");

            int tprijs = Convert.ToInt32(Ticketpijs());
            var ebtw = tprijs / 121 * 100;
            var btw = ebtw /100 * 21;

            Console.WriteLine("Brandstof: " + brandstofprijstotal + " \nCO2: " + toeslagbrandstofprijstotal + " \nEconomy : " + Chairfee().ToString() + " \nTotal excl. BTW: {0} \nBTW: {1}", ebtw, btw);
        }
    }

    class Trein : Vervoer, IPrijs, IPrintable, IFactuur
    {
        public string Klasse { get; set; }
        public string Spoor { get; set; }

        public Trein(decimal pricekm, Brandstof brandstof, decimal toeslag, int afstand, string klas, string spoor)
        {
            PriceKm = pricekm;
            Brandstof = brandstof;
            Toeslag = toeslag;
            Afstand = afstand;
            Klasse = klas;
            Spoor = spoor;
        }

        public override decimal Ticketpijs()
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

        public override void Factuur()
        {
            throw new NotImplementedException();
        }
    }

    class Boot : Vervoer, IPrijs, IPrintable, IFactuur
    {
        public string Kade { get; set; }
        public string Catering { get; set; }
        public Hut Hut { get; set; }

        public Boot(decimal pricekm, Brandstof brandstof, decimal toeslag, int afstand, string kade, string catering, Hut hut)
        {
            PriceKm = pricekm;
            Brandstof = brandstof;
            Toeslag = toeslag;
            Afstand = afstand;
            Kade = kade;
            Catering = catering;
            Hut = hut;
        }

        public override decimal Ticketpijs()
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

        public override void Factuur()
        {
            throw new NotImplementedException();
        }
    }

    class Hut
    {
        public int Dek { get; set; }
        public int Nummer { get; set; }
    }
}
