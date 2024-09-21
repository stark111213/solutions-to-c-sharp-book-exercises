partial class Program
{
    int AskForNumber(string text)
    {
        Console.Write(text);
        return int.Parse(Console.ReadLine()!);
    }

    int AskForNumberInRange(string text, int min, int max)
    {
        while (true)
        {
            int userInput = AskForNumber(text);
            
            if (userInput < min || userInput > max)
            {
                Console.WriteLine(("Out of range, try again.\n"));
                continue;
            }
            return userInput;
        }
    }
}