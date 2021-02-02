namespace CheapTravel
{
    class Ticketlijst
    {
        public int ID { get; set; }
        public Ticket Ticket { get; set; }

        public Ticketlijst(int id, Ticket ticket)
        {
            id = ID;
            ticket = Ticket;
        }
    }
}
