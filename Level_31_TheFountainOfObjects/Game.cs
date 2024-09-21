class Game
{
    //cave length
    private static int caveRows = 4;
    private static int caveColumns = 4;

    // entrance location
    private static int entranceX = 0;
    private static int entranceY = 0;

    // fountain location
    private static int fountainX = 0;
    private static int fountainY = 1;

    bool fountainActive = false;
    bool win = false;

    // to print game text based on location and game state
    string? line; 

    Player p = new();
    CaveGrid cave = new(caveRows, caveColumns, entranceX, entranceY,
                                        fountainX, fountainY);

    public void Run()
    {

        while (!win)
        {
            DisplayHeader();
            DisplayText();
            if (fountainActive && p.Row == entranceX && p.Column == entranceY)
            {
                ForegroundColor = ConsoleColor.Green;
                line = "The Fountain of Objects has been reactivated, " +
                    "and you have escaped with your life!\r\nYou win!";

                win = true;

                Clear();
                DisplayHeader();
                DisplayText();
            }
            else
            {
                AskForNextMove();
                Clear();
            }
        }

        void DisplayHeader()
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine($"---------------------------------------------------------");
            WriteLine($"You are in the room at (Row={p.Row}, Column={p.Column}).");
        }
        void DisplayText()
        {
            if (p.Row == entranceX && p.Column == entranceY && fountainActive == false)
            {
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("You see light coming from the cavern entrance.");
            }
            else if (p.Row == fountainX && p.Column == fountainY && fountainActive == false)
            {
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("You hear water dripping in this room. The Fountain of Objects is here!");
            }
            else if (fountainActive)
            {
                if (fountainActive && p.Row == entranceX && p.Column == entranceY)
                {
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine(line);
                }
                else
                {
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine(line);
                    ForegroundColor = ConsoleColor.White;
                }
            }
        }

        void AskForNextMove()
        {
            WriteLine($"What do you want to do?");
            ForegroundColor = ConsoleColor.Cyan;
            string input = ReadLine()!;

            switch (input)
            {
                case "move north":
                    p.MoveNorth();
                    break;
                case "move south":
                    p.MoveSouth(caveRows);
                    break;
                case "move west":
                    p.MoveWest();
                    break;
                case "move east":
                    p.MoveEast(caveColumns);
                    break;
                case "enable fountain":
                    if (p.Row == fountainX && p.Column == fountainY)
                    {
                        fountainActive = TryActivateFountain();
                    };
                    break;
            }
        }

        bool TryActivateFountain()
        {
            Room currentRoom = cave.cave[fountainX, fountainY];
            if (currentRoom is FountainRoom fountainRoom)
            {
                fountainRoom.FountainState = true;
                line = "You hear the rushing waters from the Fountain of Objects. " +
                    "It has been reactivated!";
                return true;
            }
            return false;
        }
    }
}