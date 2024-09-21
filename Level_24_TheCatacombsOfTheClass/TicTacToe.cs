internal class TicTacToe
{
    private bool turn = true; // true - X, false - O
    private char X = 'X';
    private char O = 'O';

    private bool win = false;

    Board board = new();

    public void Init()
    {
        board.InitializeBoard();
    }

    public char Turn(ref bool turn)
    {
        if (turn == true)
        {
            // turn = false;
            return X;
        }
        else
        {
            // turn = true;
            return O;
        }
    }

    public void GameLoop()
    {
        Init();
        while(!win)
        {
            char temp = Turn(ref turn);

            PlayerColor(ref temp);
            WriteLine($"It is {temp}'s turn.");
            ForegroundColor = ConsoleColor.White;

            board.RenderBoard();

            Write("What square do you want to play in?");
            ConsoleKey key = ReadKey().Key;

            if (EmptyOrNot(ref key, ' '))
            {
                ChoiceSwitch(ref key, temp);
                if (turn == true)
                {
                    turn = false;
                }
                else
                {
                    turn = true;
                }
            }
            Winner(ref win, ref temp);
            if (!win)
            {
                Clear();
            }
            else
            {
                Clear();
                board.RenderBoard();
                PlayerColor(ref temp);
                WriteLine($"\n{temp} won!");
            }
        }
    }

    void PlayerColor(ref char Player)
    {
        if (Player == 'X')
        {
            ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            ForegroundColor = ConsoleColor.Blue;
        }
    }

    void Winner(ref bool win, ref char Player)
    {
        // 7 8 9 row
        if (board._board[2, 0] == Player &&
            board._board[2, 1] == Player &&
            board._board[2, 2] == Player)
        {
            WriteLine($"\n\n{Player} won!");
            win = true;
        }
        // 4 5 6 row
        else if (board._board[1, 0] == Player &&
            board._board[1, 1] == Player &&
            board._board[1, 2] == Player)
        {
            WriteLine($"\n\n{Player} won!");
            win = true;
        }
        // 1 2 3 row
        else if (board._board[0, 0] == Player &&
            board._board[0, 1] == Player &&
            board._board[0, 2] == Player)
        {
            WriteLine($"{Player} won!");
            win = true;
        }
        // 1 4 7 column
        else if (board._board[2, 0] == Player &&
            board._board[1, 0] == Player &&
            board._board[0, 0] == Player)
        {
            WriteLine($"{Player} won!");
            win = true;
        }
        // 2 5 8 column
        else if (board._board[2, 1] == Player &&
            board._board[1, 1] == Player &&
            board._board[0, 1] == Player)
        {
            WriteLine($"{Player} won!");
            win = true;
        }
        // 3 6 9 column
        else if (board._board[2, 2] == Player &&
            board._board[1, 2] == Player &&
            board._board[0, 2] == Player)
        {
            WriteLine($"{Player} won!");
            win = true;
        }
        // 1 5 9 diagonal
        else if (board._board[2, 0] == Player &&
            board._board[1, 1] == Player &&
            board._board[0, 2] == Player)
        {
            WriteLine($"{Player} won!");
            win = true;
        }
        // 3 5 7 diagonal
        else if (board._board[2, 2] == Player &&
            board._board[1, 1] == Player &&
            board._board[0, 0] == Player)
        {
            WriteLine($"{Player} won!");
            win = true;
        }
    }

    bool EmptyOrNot(ref ConsoleKey choice, char comparee) 
    {
        return choice switch
        {
            ConsoleKey.NumPad1 => board._board[2, 0] == comparee,
            ConsoleKey.NumPad2 => board._board[2, 1] == comparee,
            ConsoleKey.NumPad3 => board._board[2, 2] == comparee,
            ConsoleKey.NumPad4 => board._board[1, 0] == comparee,
            ConsoleKey.NumPad5 => board._board[1, 1] == comparee,
            ConsoleKey.NumPad6 => board._board[1, 2] == comparee,
            ConsoleKey.NumPad7 => board._board[0, 0] == comparee,
            ConsoleKey.NumPad8 => board._board[0, 1] == comparee,
            ConsoleKey.NumPad9 => board._board[0, 2] == comparee,
        };
    }

    void ChoiceSwitch(ref ConsoleKey choice, char Player)
    {
        switch (choice)
        {
            case ConsoleKey.NumPad1:
                board._board[2, 0] = Player;
                break;
            case ConsoleKey.NumPad2:
                board._board[2, 1] = Player;
                break;
            case ConsoleKey.NumPad3:
                board._board[2, 2] = Player;
                break;
            case ConsoleKey.NumPad4:
                board._board[1, 0] = Player;
                break;
            case ConsoleKey.NumPad5:
                board._board[1, 1] = Player;
                break;
            case ConsoleKey.NumPad6:
                board._board[1, 2] = Player;
                break;
            case ConsoleKey.NumPad7:
                board._board[0, 0] = Player;
                break;
            case ConsoleKey.NumPad8:
                board._board[0, 1] = Player;
                break;
            case ConsoleKey.NumPad9:
                board._board[0, 2] = Player;
                break;
        }
    }
}

internal class Board
{
    public char[,] _board = new char[3, 3];

    public void InitializeBoard()
    {
        for (int i = 0; i < _board.GetLength(0); i++)
        {
            for (int j = 0; j < _board.GetLength(1); j++)
            {
                _board[i, j] = ' ';
            }
        }
    }

    public void RenderBoard()
    {
        WriteLine($" {_board[0, 0]} | {_board[0, 1]} | {_board[0, 2]} ");
        WriteLine("---+---+---");
        WriteLine($" {_board[1, 0]} | {_board[1, 1]} | {_board[1, 2]} ");
        WriteLine("---+---+---");
        WriteLine($" {_board[2, 0]} | {_board[2, 1]} | {_board[2, 2]} ");
    }
}
