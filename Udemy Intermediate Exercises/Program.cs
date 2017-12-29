using System;

namespace Udemy_Intermediate_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Stoperica2();
        }


        /************************************
            Štoperica sa logikom izbornika (S)tart, (F)insih and (Q)uit
        *************************************/

        static void Stoperica2()
        {
            var stopWatch2 = new StopWatch();
            var endProgram = false;

            Console.WriteLine("Commands : (S)tart - (F)inish - (Q)uit");
            do
            {
                var input = Console.ReadKey().KeyChar.ToString().ToUpper();
            
                switch (input)
                {
                    case "S":
                        stopWatch2.Start();
                        break;
                    case "F":
                        stopWatch2.Stop();
                        Console.WriteLine("Duration time is {0} seconds.", stopWatch2.Duration().Seconds);
                        break;
                    case "Q":
                        endProgram = true;
                        break;
                }
            } while (!endProgram);
        }

        /*************************************
            Štoperica v1.0 SPACEBAR i ESC za izlaz
        **************************************/

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
