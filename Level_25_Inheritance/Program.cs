// -------------------- Packing Inventory, Labeling Inventory --------------------

Pack pack = new(10, 10, 10);

while (true)
{
    Console.WriteLine(($"Weight: {pack.CurrentWeight}/{pack.MaxWeight} " +
        $"Volume: {pack.CurrentVolume}/{pack.MaxVolume} " +
        $"Number of items: {pack.MaxCount}/{pack.MaxItems}"));

    Console.WriteLine("Wanna add sum? (arrow, bow, rope, water, food ration, sword):");
    Console.Write("> ");
    string userInput = Console.ReadLine()!;

    InventoryItem userItem = userInput switch
    {
        "arrow" => new Arrow(),
        "bow" => new Bow(),
        "rope" => new Rope(),
        "water" => new Water(),
        "food ration" => new FoodRation(),
        "sword" => new Sword()
    };

    if (!pack.Add(userItem))
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Could not add this to the pack.");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine();

    pack.ToString();

    Console.WriteLine();
    Console.WriteLine();
}


// --------------- Classes --------------------
public class InventoryItem
{
    public double Weight { get; }
    public double Volume { get; }

    public InventoryItem(double weight, double volume)
    {
        Weight = weight;
        Volume = volume;
    }
}

public class Arrow : InventoryItem 
{ 
    public Arrow() : base(0.1, 0.05) { }
    public override string ToString() =>"Arrow";
}

public class Bow : InventoryItem 
{ 
    public Bow() : base(1, 4) { }
    public override string ToString() => "Bow";
}

public class Rope : InventoryItem 
{ 
    public Rope() : base(1, 1.5) { }
    public override string ToString() => "Rope";
}

public class Water : InventoryItem 
{ 
    public Water() : base(2, 3) { }
    public override string ToString() => "Water";
}

public class FoodRation : InventoryItem 
{ 
    public FoodRation() : base(1, 0.5) { }
    public override string ToString() => "Food Ration";
}

public class Sword : InventoryItem 
{ 
    public Sword() : base(5, 3) { }
    public override string ToString() => "Sword";
}

public class Pack
{
    public InventoryItem[] Items { get; set; }

    public double MaxWeight { get; }
    public double MaxVolume { get; }
    public int MaxItems { get; }

    public int MaxCount { get; private set; } = 0;
    public double CurrentWeight { get; private set; } = 0;
    public double CurrentVolume { get; private set; } = 0;

    public Pack(double maxWeight, double maxVolume, int maxItems)
    {
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
        MaxItems = maxItems;
        Items = new InventoryItem[MaxItems];
    }

    public override string ToString()
    {
        Console.Write("Items: ");
        foreach (InventoryItem i in Items)
        {
            Console.Write($"{i} ");
        }
        return "";
    }

    public bool Add(InventoryItem item)
    {
        if ((CurrentWeight + item.Weight) > MaxWeight)
        {
            return false;
        }
        if (CurrentVolume + item.Volume > MaxVolume)
        {
            return false;
        }
        if (MaxItems - MaxCount <= 0)
        {
            return false;
        }

        Items[MaxCount] = item;
        MaxCount++;
        CurrentVolume += item.Volume;
        CurrentWeight += item.Weight;

        return true;
    }
}