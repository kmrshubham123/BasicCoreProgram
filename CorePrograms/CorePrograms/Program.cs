using System;

namespace CorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#### Welcome to Basic Core Programs ####");

            Console.WriteLine("1:Flip Coin to check Head or tail");
            Console.WriteLine("2:Check a year is Leap Year or Not");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.HeadsTailsPercentage();
                    break;
             
                case 2:
                    LeapYear leap = new LeapYear();
                    leap.LeapYr();
                    break;

            }

        }
    }
}
