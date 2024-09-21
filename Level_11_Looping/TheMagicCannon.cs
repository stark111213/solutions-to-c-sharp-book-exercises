partial class Program
{
    static void TheMagicCannon()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine($"{i, 3}. Fire and Electric");
            }
            else if (i % 3 == 0)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"{i, 3}. Fire");
            }
            else if (i % 5 == 0)
            {
                ForegroundColor = ConsoleColor.Cyan;
                WriteLine($"{i, 3}. Electric");
            }
            else
            {
                ForegroundColor = ConsoleColor.White;
                WriteLine($"{i, 3}. Normal");
            }
        }
    }
}