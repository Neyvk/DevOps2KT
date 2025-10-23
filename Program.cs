using System;
using System.Threading;

class Timer
{
    static void Main()
    {
        Console.WriteLine("Timer started.");
        Console.WriteLine("Ctrl + C to stop.");

        var startTime = DateTime.Now;

        while (true)
        {
            var nowTime = DateTime.Now - startTime;
            Console.Write($"\rtime: {nowTime:hh\\:mm\\:ss}");
            Thread.Sleep(1000);
        }
    }
}
