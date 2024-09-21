// -------------------- War Preparations --------------------


Sword basic = new(Materials.Iron, Gemstones.None, 10, 3);
Sword v1 = basic with { material = Materials.Steel };
Sword v2 = basic with { material = Materials.Binarium, gemstone = Gemstones.Bitstone };

Console.WriteLine(basic);
Console.WriteLine(v1);
Console.WriteLine(v2);

public record Sword(Materials material, Gemstones gemstone, double length,
    double crossguardWidth);

public enum Materials { Wood, Bronze, Iron, Steel, Binarium }
public enum Gemstones { None, Emerald, Amber, Sapphire, Diamond, Bitstone }
