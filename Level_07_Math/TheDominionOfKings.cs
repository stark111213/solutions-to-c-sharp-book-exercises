partial class Program
{
    static void TheDominionOfKings()
    {
        Write("How many provinces: ");
        int provinces = int.Parse(ReadLine()!);

        Write("How many duchies: ");
        int duchies = int.Parse(ReadLine()!);

        Write("How many estates: ");
        int estates = int.Parse(ReadLine()!);

        WriteLine($"\nPoint Total: {estates * 1 + duchies * 3 + provinces * 6}");
    }
}