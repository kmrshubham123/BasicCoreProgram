using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Programming
{
    public class calculator : IArithmetic
    {
        readonly int VALUE_ONE;
        readonly int VALUE_TWO;

        public calculator (int valueOne, int valueTwo)
        {
            VALUE_ONE = valueOne;
            VALUE_TWO = valueTwo;
        }
        public void GetSum()
        {
            int result = VALUE_ONE * VALUE_TWO;
            Console.WriteLine("result");
        }
    }
}
