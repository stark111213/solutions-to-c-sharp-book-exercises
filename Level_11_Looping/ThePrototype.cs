partial class Program
{
    static void ThePrototype()
    {
        int user1;

        do
        {
            Write("User1, enter a number between 0 and 100: ");
            user1 = int.Parse(ReadLine()!);
        }
        while (user1 > 100 || user1 < 0);

        Clear();

        Write("User2, guess the number. ");

        while (true)
        {
            int user2 = int.Parse(ReadLine()!);
            if (user2 == user1)
            {
                WriteLine("You guessed the number!");
                break;
            }
            else if (user2 > user1)
            {
                WriteLine($"{user2} is too high.");
            }
            else if (user2 < user1)
            {
                WriteLine($"{user2} is too low.");
            }
            Write("What is your next guess? ");
        }
    }
}