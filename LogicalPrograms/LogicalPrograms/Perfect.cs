using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Perfect
    {

        public int Find_Factor(int value)
        {
            int sum = 0;
            for (int i = 1; i < value; i++)
            {
                if (value % i == 0)
                    sum = sum + i;
            }
            return sum;
        }


    }
    
}
