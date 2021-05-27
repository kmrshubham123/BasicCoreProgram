using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class PowerOfTwo
    {
        public int power(int value)
        {
            int temp = 1;
            for (int i = 1; i <= value; i++)
            {
                temp = temp * 2;
            }
            return temp;
        }
    }
}
