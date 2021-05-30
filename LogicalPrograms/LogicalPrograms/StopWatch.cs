using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{

    class StopWatch
    {
       public void Stopwatch()
        {
            Console.WriteLine("Press S to start STOPWATCH ");
            string Input = Console.ReadLine();
            DateTime S = DateTime.Now;
            if (Input=="S" || Input=="s")
            {
                Console.WriteLine("=======StopWatch Started======");
                DateTime now = DateTime.Now;
                S = now;
            }
            Console.WriteLine("Press ENTER to Stop StopWatch");
            while ((Console.ReadKey(true).Key != ConsoleKey.Enter))
            {
                break;
            }
            DateTime EndTime = DateTime.Now;
            TimeSpan Duration = S.Subtract(EndTime);
            Console.WriteLine($"Total Time is :{Duration.ToString(@"hh\:mm\:ss")}");

       }
    }
}
