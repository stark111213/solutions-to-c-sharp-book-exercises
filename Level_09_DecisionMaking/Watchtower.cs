partial class Program
{
    static void Watchtower()
    {
        WriteLine("Enter enemy's coordinates.\n");

        Write("x: ");
        int x = int.Parse(ReadLine()!);

        Write("y: ");
        int y = int.Parse(ReadLine()!);

        if (x == 0 && y == 0)
        {
            WriteLine("\nThe enemy is here!");
            return;
        }

        string location = "";

        if (x == 0 && y > 0)
        {
            location = "north";
        }
        else if (x == 0 && y < 0)
        {
            location = "south";
        }
        else if (y == 0 && x > 0)
        {
            location = "east";
        }
        else if (y == 0 && x < 0)
        {
            location = "west";
        }
        else if (x > 0 && y > 0)
        {
            location = "northeast";
        }
        else if (x > 0 && y < 0)
        {
            location = "southeast";
        }
        else if (x < 0 && y < 0)
        {
            location = "southwest";
        }
        else if (x < 0 && y > 0)
        {
            location = "northwest";
        }

        Write($"\nThe enemy is to the {location}!\n");
    }
}