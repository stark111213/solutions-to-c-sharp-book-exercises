public class Color
{
    public int R { get; } // red
    public int G { get; } // green
    public int B { get; } // blue

    public Color(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }

    public static Color White => new(255, 255, 255);
    public static Color Black => new(0, 0, 0);
    public static Color Red => new(255, 0, 0);
    public static Color Orange => new(255, 165, 0);
    public static Color Yellow => new(255, 255, 0);
    public static Color Green => new(0, 128, 0);
    public static Color Blue => new(0, 0, 255);
    public static Color Purple => new(128, 0, 128);
}


/* Code for main method

Color custom = new(1, 1, 1);
Color yellow = Color.Yellow;

WriteLine($"{custom.R} {custom.G} {custom.B}");
WriteLine($"{yellow.R} {yellow.G} {yellow.B}");

*/