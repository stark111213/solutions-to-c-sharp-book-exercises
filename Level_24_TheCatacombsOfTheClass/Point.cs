internal class Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public Point() : this(0, 0) { }

}

/* Code for main method

Point p = new(2, 3);
Point p1 = new(-4, 0);

WriteLine($"({p.X}, {p.Y})");
WriteLine($"({p1.X}, {p1.Y})");
*/