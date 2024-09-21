// -------------------- The Repeating Stream --------------------

RecentNumbers recentNumbers = new();
Thread thread = new(recentNumbers.Infinite);


class RecentNumbers
{
    List<int> lastTwoRandomInts = new();

    public void Infinite()
    {
        Random r = new();
        for(;;)
        {
            int random = r.Next(10);
            lastTwoRandomInts.Add(random);
            Console.WriteLine(random);
            Thread.Sleep(1000);
        }
    }
}