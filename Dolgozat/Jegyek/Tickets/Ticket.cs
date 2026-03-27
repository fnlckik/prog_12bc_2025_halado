namespace Tickets
{
    internal class Ticket
    {
        public Ticket(int row, int seat)
        {
            Row = row;
            Seat = seat;
        }

        public int Row { get; }
        public int Seat { get; }

        public override string ToString()
        {
            return $"Sor: {Row}, Szék: {Seat}";
        }
    }
}
