using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Reverse
    {
        public int Number;
        public int Rev;
        public int Remainder;
        public void ReverseNumber()
        {
            Console.WriteLine("Enter Number :"); 
            Number = int.Parse(Console.ReadLine());
            Rev = 0; 
            while (Number!= 0) 
            {
                Remainder = Number % 10; 
                Rev = (Rev * 10) + Remainder;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse No. is {0}", Rev);
            Console.ReadLine();
        }
    }
}
