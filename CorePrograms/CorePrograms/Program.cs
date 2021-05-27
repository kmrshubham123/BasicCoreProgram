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
            Console.WriteLine("3:Power of 2");
            Console.WriteLine("4.Harmonic Number");

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

                case 3:
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    Console.WriteLine("Enter the number to check its 2's power=");
                    int input = Convert.ToInt32(Console.ReadLine());
                    int result = powerOfTwo.power(input);
                    Console.WriteLine("result is=" + result);
                    break;

                case 4:
                    Harmonic harmonic = new Harmonic();
                    Console.WriteLine("Enter number =");
                    int harInput = Convert.ToInt32(Console.ReadLine());
                    float resultHar = harmonic.Calculate(harInput);
                    Console.WriteLine(" result=" + resultHar);
                    break;


            }

        }
    }
}
