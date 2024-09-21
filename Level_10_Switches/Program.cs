// -------------------- Buying Inventory, Discounted Inventory --------------------

using static System.Console;

WriteLine("The following items are available:");
WriteLine("1 – Rope\r\n2 – Torches\r\n3 – Climbing Equipment\r\n4 – Clean Water\r\n" +
          "5 – Machete\r\n6 – Canoe\r\n7 – Food Supplies");

Write("\nWhat number do you want to see the price of? ");
int choice = int.Parse(ReadLine()!);

Write("What's your name? ");
string name = ReadLine()!;

string item = choice switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
};

int price = item switch
{
    "Rope" => 10,
    "Torches" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supplies" => 1
};

string pluralSuffix = item switch
{
    "Rope" => "s",
    "Climbing Equipment" => "s",
    "Clean Water" => "s",
    "Machete" => "s",
    "Canoe" => "s",
    _ => ""
};

price = name == "Dude" ? price / 2 : price;

WriteLine($"\n{item} cost{pluralSuffix} {price} gold.");
