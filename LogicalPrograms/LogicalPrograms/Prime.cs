using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Prime
    {
        public void PrimeNumber(int value)
        {
            int reminder = 0;
            for (int i = 2; i <= value / 2; i++)
            {
                if (value % i == 0)
                {
                    reminder = 0;
                }
                else
                {
                    reminder = 1;
                }
            }
            if (reminder == 0)
            {
                Console.WriteLine("It is not a Prime Number");
            }
            else
            {
                Console.WriteLine("It is a Prime Number");
            }
        }
    }
}
