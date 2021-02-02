using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapTravel
{
    class Reisinfo
    {
        public string Transport { get; set; }
        public string StartLoc { get; set; }
        public string EndLoc { get; set; }
        public DateTime Depature { get; set; }
        public DateTime Arrival { get; set; }

        public Reisinfo(string transport, string startloc, string endloc, DateTime depature, DateTime arrival)
        {
            Transport = transport;
            StartLoc = startloc;
            EndLoc = endloc;
            Depature = depature;
            Arrival = arrival;
        }
    }
    

}
