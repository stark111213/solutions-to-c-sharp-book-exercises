// -------------------- The Laws of Freach --------------------

partial class Program
{
    static void ArrayMinimum()
    {
        int[] array = { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
        int currentSmallest = int.MaxValue; // Start higher than anything in the array.

        foreach (int i in array)
        {
            if (i < currentSmallest)
            {
                currentSmallest = i;
            }
        }

        WriteLine(currentSmallest);
    }

    static void ArrayAverage()
    {
        int[] array = { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
        int total = 0;

        foreach (int i in array)
        {
            total += i;
        }

        float average = (float)total / array.Length;
        WriteLine(average);
    }
}