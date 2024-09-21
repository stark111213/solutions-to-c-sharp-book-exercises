partial class Program
{
    static void RepairingTheClocktower()
    {
        Write("Enter a number: ");
        int number = int.Parse(ReadLine()!);

        WriteLine(number % 2 == 0 ? "Tick" : "Tock");
    }
}