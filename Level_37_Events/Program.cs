// -------------------- Charberry Trees --------------------

Thread thread1 = new Thread(CountTo100);
thread1.Start();
Thread thread2 = new Thread(CountTo100);
thread2.Start();
thread1.Join();
thread2.Join();
Console.WriteLine("Main Thread Done");
void CountTo100()
{
    for (int index = 0; index < 100; index++)
        Console.WriteLine(index + 1);
}