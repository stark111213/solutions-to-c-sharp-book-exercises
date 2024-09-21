partial class Program
{
    void State(ref int round, ref int city, ref int manticore, ref int damage)
    {
        WriteLine("-----------------------------------------------------------");
        WriteLine($"STATUS: Round: {round} City: {city}/15 Manticore: {manticore}/10");
        WriteLine($"The cannon is expected to deal {damage} damage this round.");
    }

/*    void Player1(ref int player1)
    {
        do
        {
            Write("Player 1, how far away from the city do you want to station the Manticore? ");
            player1 = int.Parse(ReadLine()!);
        }
        while (player1 > 100 || player1 < 0);
    }*/

    void SetManticoreLocation(ref int manticore)
    {
        Random random = new();
        manticore = random.Next(101);
    }

    void SetDamage(ref int round, ref int damage)
    {
        if (round % 3 == 0 && round % 5 == 0)
        {
            damage = 10;
        }
        else if (round % 3 == 0)
        {
            damage = 3;
        }
        else if (round % 5 == 0)
        {
            damage = 5;
        }
        else
        {
            damage = round;
        }
    }

    void Player2(ref int player2)
    {
        Write("Enter desired cannon range: ");
        player2 = int.Parse(ReadLine()!);
    }

    void DamageAssess(ref int player1, ref int player2, ref int damage, 
        ref int manticore, ref int city)
    {
        if (player2 == player1)
        {
            manticore -= damage;

            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine("That round was a DIRECT HIT!");
            ForegroundColor = ConsoleColor.White;
        }
        else if (player2 > player1)
        {
            city -= damage;

            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("That OVERSHOT the target.");
            ForegroundColor = ConsoleColor.White;
        }
        else if (player2 < player1)
        {
            city -= damage;

            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("That round FELL SHORT of the target.");
            ForegroundColor = ConsoleColor.White;
        }
    }
}