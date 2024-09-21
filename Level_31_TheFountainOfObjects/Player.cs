class Player
{
    public int Row { get; set; }
    public int Column { get; set; }

    public void MoveNorth()
    {
        if (Row > 0)
        {
            Row--;
        }
    }
    public void MoveSouth(int southBound)
    {
        if (Row < southBound - 1)
        {
            Row++;
        }
    }
    public void MoveWest()
    {
        if (Column > 0)
        {
            Column--;
        }
    }
    public void MoveEast(int rightBound)
    {
        if (Column < rightBound - 1)
        {
            Column++;
        }
    }
}
