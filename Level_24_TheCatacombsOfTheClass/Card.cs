internal class Card
{
    public CardColors Color { get; }
    public CardRank CardRank { get; }

    public Card(CardColors color, CardRank cardRank)
    {
        Color = color;
        CardRank = cardRank;
    }

    void IsNumberOrSymbolCard()
    {
        if ((int)CardRank < 11)
        {
            WriteLine("Number Card");
        }
        else
        {
            WriteLine("Symbol Card");
        }
    }
}

enum CardColors { Red, Green, Blue, Yellow }
enum CardRank
{
    One = 1,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Dollar,
    Percent,
    Caret,
    Ampersand
}

/* Code for main method

for (int i = 0; i < 4; i++)
{
    CardColors color = (CardColors)i;
    ForegroundColor = color switch
    {
        CardColors.Red => ConsoleColor.DarkRed,
        CardColors.Green => ConsoleColor.DarkGreen,
        CardColors.Blue => ConsoleColor.DarkBlue,
        CardColors.Yellow => ConsoleColor.Yellow
    };

    for (int j = 1; j <= 14; j++)
    {
        CardRank rank = (CardRank)j;
        Card card = new(color, rank);

        WriteLine($"The {color} {rank}");
    }

    WriteLine();
}

*/