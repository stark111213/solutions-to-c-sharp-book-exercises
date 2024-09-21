// -------------------- Room Coordinates --------------------

Coordinate a = new(1, 2);
Coordinate b = new(2, 3);
Coordinate c = new(5, 4);

Console.WriteLine($"a and c adjacent: {Coordinate.IsAdjacent(b, a)}");


struct Coordinate
{
    public int Row { get; }
    public int Column { get; }
    public Coordinate (int row, int column)
    {
        Row = row;
        Column = column;
    }
    public static bool IsAdjacent(Coordinate a, Coordinate b)
    {
        if (((a.Row - b.Row == 1) || (b.Row - a.Row == 1)) && 
            (a.Column - b.Column == 1) || (b.Column - a.Column == 1))
        {
            return true;
        }
        return false;
    }
}
