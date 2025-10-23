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
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Q)
                {
                    Console.WriteLine("\nTimer stopped.");
                    break;
                }

                var nowTime = stopwatch.Elapsed;
                Console.Write($"\rtime: {nowTime:hh\\:mm\\:ss}");
                Thread.Sleep(1000);
            }
        }
    }
}