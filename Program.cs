using System;
using System.Diagnostics;
using System.Threading;

namespace TimerApp
{
    static class Timer
    {
        static void Main()
        {
            Console.WriteLine("Timer started.");
            Console.WriteLine("Press 'q' to quit.");

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            while (true)
            {

                var nowTime = stopwatch.Elapsed;
                Console.Write($"\rtime: {nowTime:hh\\:mm\\:ss}");
                Thread.Sleep(1000);
            }
        }
    }
}