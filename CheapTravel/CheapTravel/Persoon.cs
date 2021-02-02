namespace CheapTravel
{
    class Persoon
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Tussenvoegsel { get; set; }
        public string BSN { get; set; }
        public string Mail { get; set; }
        public string Telefoon { get; set; }

        public Persoon(string voornaam, string achternaam, string tussenvoegsel, string bsn, string mail, string telefoon)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            Tussenvoegsel = tussenvoegsel;
            BSN = bsn;
            Mail = mail;
            Telefoon = telefoon;
        }
    }
}
