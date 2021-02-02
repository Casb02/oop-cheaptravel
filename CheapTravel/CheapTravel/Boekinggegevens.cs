using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapTravel
{
    class Boekinggegevens
    {
        public DateTime Boekingdatum { get; set; }
        public int ID { get; set; }

        public Boekinggegevens(DateTime boekdatum, int id)
        {
            Boekingdatum = boekdatum;
            ID = id;
        }
    }
}
