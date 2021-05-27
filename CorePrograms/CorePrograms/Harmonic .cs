using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class Harmonic
    {
        public float Calculate(int value)
        {
            float result = 0
                ;
            for (float i = 1; i <= value; i++)
            {
                result = result + (1 / i);
            }
            return result;
        }
    }
}
