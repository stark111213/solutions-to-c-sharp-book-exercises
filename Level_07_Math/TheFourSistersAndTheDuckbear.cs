partial class Program
{
    static void TheFourSistersAndTheDuckbear()
    {
        Write("Enter eggs: ");
        int eggs = int.Parse(ReadLine()!);

        int forSister = eggs / 4;
        int forDuckBear = eggs % 4;

        WriteLine($"\nEach sister gets {forSister} eggs.");
        WriteLine($"DuckBear gets {forDuckBear} eggs.");
    }
}