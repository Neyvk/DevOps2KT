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
            Console.WriteLine("Press ESC to stop.");

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            while (true)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
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