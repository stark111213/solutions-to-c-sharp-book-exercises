// -------------------- Colored Items --------------------


ColoredItem<Sword> sword = new(new Sword(), ConsoleColor.Blue);
ColoredItem<Bow> bow = new(new Bow(), ConsoleColor.DarkRed);
ColoredItem<Axe> axe = new(new Axe(), ConsoleColor.Green);

sword.Display();
bow.Display();
axe.Display();


public class Sword { }
public class Bow { }
public class Axe { }

public class ColoredItem<T>
{
    public T Item { get; } 
    ConsoleColor Color { get; }

    public ColoredItem(T item, ConsoleColor color)
    {
        Item = item;
        Color = color;
    }

    public void Display()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(Item);
    }
}