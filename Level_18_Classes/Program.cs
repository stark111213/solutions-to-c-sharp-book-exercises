// -------------------- Vin Fletcher's Arrows --------------------

using static System.Console;

WriteLine("Choose an arrow:\n");
WriteLine("1. Elite Arrow\n2. Beginner Arrow\n3. Marksman Arrow\n4. Custom");
Write("\n> ");
int choice = int.Parse(ReadLine()!);

Arrow arrow = choice switch
{
    1 => Arrow.CreateEliteArrow(),
    2 => Arrow.CreateBeginnerArrow(),
    3 => Arrow.CreateMarksmanArrow(),
    4 => CustomArrow()
};

Arrow CustomArrow()
{
    Write("Choose arrow head (steel, wood, obsidian): ");
    string arrowHead = ReadLine()!;

    Write("Choose fletching (plastic, turkey feathers, goose feathers): ");
    string fletching = ReadLine()!;

    Write("Choose shaft length (60 - 100): ");
    float shaftLength = float.Parse(ReadLine()!);

    ArrowHead ArrowHead = arrowHead switch
    {
        "steel" => ArrowHead.Steel,
        "wood" => ArrowHead.Wood,
        "obsidian" => ArrowHead.Obsidian
    };

    Fletching Fletching = fletching switch
    {
        "plastic" => Fletching.Plastic,
        "turkey feathers" => Fletching.TurkeyFeathers,
        "goose feathers" => Fletching.GooseFeathers
    };

    return new(ArrowHead, Fletching, shaftLength);
}

WriteLine();
WriteLine(arrow.ToString());
WriteLine("Cost: " + arrow.GetCost());

class Arrow
{
    public ArrowHead ArrowHead { get; }
    public Fletching Fletching { get; }
    public float ShaftLength { get; }

    public Arrow (ArrowHead ArrowHead, Fletching Fletching, float ShaftLength)
    {
        this.ArrowHead = ArrowHead;
        this.Fletching = Fletching;
        this.ShaftLength = ShaftLength;
    }

    public override string ToString()
    {
        return $"{ArrowHead} {Fletching} {ShaftLength}";
    }

    public float GetCost()
    {
        return (float)ArrowHead + (float)Fletching + ShaftLength * 0.05f;
    }

    public static Arrow CreateEliteArrow() => 
        new Arrow(ArrowHead.Steel, Fletching.Plastic, 95.0f);

    public static Arrow CreateBeginnerArrow() =>
        new Arrow(ArrowHead.Wood, Fletching.GooseFeathers, 75.0f);

    public static Arrow CreateMarksmanArrow() =>
        new Arrow(ArrowHead.Steel, Fletching.GooseFeathers, 65.0f);
}

enum ArrowHead { Steel = 10, Wood = 3, Obsidian = 5 }
enum Fletching { Plastic = 10, TurkeyFeathers = 5, GooseFeathers = 3 }
