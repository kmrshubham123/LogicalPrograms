using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class FibonacciSeries
    {
        int n1 = 0;
        int n2 = 1;
        int n3;
        int i;
        int len;
        public void Fibbo()
        {
            Console.WriteLine("Enter Length");
            len = int.Parse(Console.ReadLine());
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            
            for (i = 2; i < len; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }

    
        }
    }
}
