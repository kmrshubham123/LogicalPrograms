using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs");
            Console.WriteLine("1.Fibonacci Series");
            Console.WriteLine("2.Perfect Number");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    Console.WriteLine("Enter Number:");
                    int inputFebonacii = Convert.ToInt32(Console.ReadLine());
                    fibonacciSeries.Fibbo();
                    break;
                case 2:
                    //Perfect
                    Perfect perfect = new Perfect();
                    Console.WriteLine("Enter number to check is perfect or not:");
                    int inputPerfect = Convert.ToInt32(Console.ReadLine());
                    int resultPerfect = perfect.Find_Factor(inputPerfect);
                    if (inputPerfect == resultPerfect)
                    {
                        Console.WriteLine("It is a Perfect Number");
                    }
                    else
                    {
                        Console.WriteLine("It is not a Perfect Number");
                    }
                    break;


            }
        }
    }
}

                    

