using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapTravel
{
    class Brandstof
    {
        public string Naam { get; set; }
        public decimal Prijs { get; set; }
        public int Procent { get; set; }

        public Brandstof(string naam, decimal prijs, int procent)
        {
            Naam = naam;
            Prijs = prijs;
            Procent = procent;
        }
    }
}
