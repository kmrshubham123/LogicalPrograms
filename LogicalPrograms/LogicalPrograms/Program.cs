using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs");
            Console.WriteLine("1. Fibonacci Series.");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    Console.WriteLine("Enter Number:");
                    int inputFebonacii = Convert.ToInt32(Console.ReadLine());
                    fibonacciSeries.Fibbo();
                    break;
            }
        }

    }
}
