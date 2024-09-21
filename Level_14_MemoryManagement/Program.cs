// -------------------- Hunting the Manticore --------------------

int manticore = 10;
int city = 15;

int round = 1;
int damage = round;

int player1 = 0, player2 = 0;


Program p = new();

p.SetManticoreLocation(ref player1);
Clear();
WriteLine("Player 2, it is your turn.");

// -------------------- Game Loop --------------------

while (true)
{
    p.SetDamage(ref round, ref damage);
    p.State(ref round, ref city, ref manticore, ref damage);
    p.Player2(ref player2);
    p.DamageAssess(ref player1, ref player2, ref damage, ref manticore, ref city);

    ++round;

    if (manticore <= 0)
    {
        ForegroundColor = ConsoleColor.Green;
        WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        break;
    }
    else if (city <= 0)
    {
        ForegroundColor = ConsoleColor.DarkRed;
        WriteLine("The City has been destroyed! You lost!");
        break;
    }
}
