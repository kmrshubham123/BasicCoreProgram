using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class Largest
    {
        public void GreaterNumber(int number1, int number2, int number3)
        {
            if (number1 > number2 & number1 > number3)
            {
                Console.WriteLine(number1 + "is Largest No.");
            }
            else if (number2 > number1 & number2 > number3)
            {
                Console.WriteLine(number2 + "is Largest No.");
            }
            else
            {
                Console.WriteLine(number3 + "is Largest No.");
            }

        }

    }
}