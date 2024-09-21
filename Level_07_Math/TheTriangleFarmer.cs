partial class Program
{
    static void TheTriangleFarmer()
    {
        Write("Enter triangle base: ");
        double triangleBase = double.Parse(ReadLine()!);

        Write("Enter triangle height: ");
        double height = double.Parse(ReadLine()!);

        double area = (triangleBase * height) / 2;

        WriteLine("\nTriangle area: " + area);
    }
}
