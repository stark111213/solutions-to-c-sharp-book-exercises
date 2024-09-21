class CaveGrid
{
    public Room[,] cave;

    // initialize the cave grid
    public CaveGrid(int caveRows, int caveColumns, int entranceX, int entranceY,
        int fountainX, int fountainY)
    {
        cave = new Room[caveRows, caveColumns];
        FountainRoom fountainRoom = new();

        // use the same empty room instance since they are not really used
        EmptyRoom emptyRoom = new();

        for (int row = 0; row < cave.GetLength(0); row++)
        {
            for (int column = 0; column < cave.GetLength(1); column++)
            {
                if (row == entranceX && column == entranceY)
                {
                    cave[row, column] = new Entrance();
                }
                else if (row == fountainX && column == fountainY)
                {
                    cave[row, column] = fountainRoom;
                }
                else
                {
                    cave[row, column] = emptyRoom;

                    // coordinates for empty room since they don't matter
                    cave[row, column].Row = 999;
                    cave[row, column].Column = 999;
                }
            }
        }

        // initialize coordinates for entrance and fountain
        // entrance
        cave[entranceX, entranceY].Row = entranceX;
        cave[entranceX, entranceY].Column = entranceY;

        // fountain
        cave[fountainX, fountainY].Row = fountainX;
        cave[fountainX, fountainY].Column = fountainY;
    }
}