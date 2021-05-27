using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class EvenOdd
    {
        public void Number(int value)
        {
            if (value % 2 == 0)
            {
                Console.WriteLine(value + " is Even No.");
            }
            else
            {
                Console.WriteLine(value + " Is Odd No.");
            }
        }
    }
}

