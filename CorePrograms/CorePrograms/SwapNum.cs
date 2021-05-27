using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class SwapNum
    {
        public void swapValues(int FirstNum, int SecondNum)
        {
            FirstNum = FirstNum + SecondNum;
            SecondNum = FirstNum - SecondNum;
            FirstNum = FirstNum - SecondNum;
            Console.WriteLine("after Swapping values: " + FirstNum + " and " + SecondNum);

        }
    }
}
