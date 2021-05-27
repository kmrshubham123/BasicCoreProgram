using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class QuotientReminder
    {
        public void Calculate(int divident, int diviser)
        {
            float quotient = (divident / diviser);
            Console.WriteLine("Quotient is:" + quotient);
            int reminder = (divident % diviser);
            Console.WriteLine("Reminder is:" + reminder);
        }
    }
}
