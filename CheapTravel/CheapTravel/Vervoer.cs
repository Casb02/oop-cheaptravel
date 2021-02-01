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
        public String Afstand { get; set; }
    }

    class Vliegtuig : Vervoer
    {
        public string Vluchtnummer { get; set; }
        public string Gate { get; set; }
        public string Stoeloptie { get; set; }
        public string Stoelnummer { get; set; }
    }

    class Trein : Vervoer
    {
        public string Klasse { get; set; }
        public string Spoor { get; set; }
    }

    class Boot : Vervoer
    {
        public string Kade { get; set; }
        public string Catering { get; set; }
        public Hut Hut { get; set; }
    }

    class Hut
    {
        public int Dek { get; set; }
        public int Nummer { get; set; }
    }
}
