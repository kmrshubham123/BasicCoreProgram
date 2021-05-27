using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class LeapYear
    {
        public void LeapYr()
        {
            Console.WriteLine("Enter a year to check if it is leap year or not in YYYY format : ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine(year + " is a leap year");
            else
                Console.WriteLine(year + " is not a leap year");
        }
    }
}
