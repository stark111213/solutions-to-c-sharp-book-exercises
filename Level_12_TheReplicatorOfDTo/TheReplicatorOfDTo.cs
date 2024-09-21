partial class Program
{
    static void TheReplicatorOfDTo()
    {
        int[] array = new int[5];

        for (int i = 0; i < 5; i++)
        {
            int a = int.Parse(ReadLine()!);
            array[i] = a;
        }

        int[] array1 = new int[5];

        for (int i = 0; i < 5; i++)
        {
            array1[i] = array[i];
        }

        Write("array1:");
        foreach (int i in array)
        {
            Write(i);
        }

        Write("\narray2:");
        foreach (int i in array1)
        {
            Write(i);
        }
    }
}