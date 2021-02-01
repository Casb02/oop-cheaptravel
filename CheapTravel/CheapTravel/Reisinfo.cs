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
        public string Depature { get; set; }
        public string Arrival { get; set; }

        public Reisinfo(string transport, string startloc, string endloc, string depature, string arrival)
        {
            Transport = transport;
            StartLoc = startloc;
            EndLoc = endloc;
            Depature = depature;
            Arrival = arrival;
        }
    }
    

}
