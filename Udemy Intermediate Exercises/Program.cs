using System;

namespace Udemy_Intermediate_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Stoperica();
        }



        static void Stoperica()
        {
            var stopWatch = new StopWatch();

            Console.WriteLine("Press <Spacebar> to start stopwatch");
            do
            {
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    stopWatch.Start();
                    Console.WriteLine("Counting");

                    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                    {
                        stopWatch.Stop();
                        Console.WriteLine(stopWatch.Duration().Seconds);
                    }
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
