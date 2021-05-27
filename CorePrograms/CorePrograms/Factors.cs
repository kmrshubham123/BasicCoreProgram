using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class Factors
    {
        public void Factor(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i + ",");
                }
            }
        }
    }
}
