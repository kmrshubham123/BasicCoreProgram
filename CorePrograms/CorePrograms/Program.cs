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
            Console.WriteLine("5:Factors of Number");
            Console.WriteLine("6:Quotient and Reminder");
            Console.WriteLine("7:Swap the Numbers");
            Console.WriteLine("8:Even and Odd number");
            Console.WriteLine("9:check no. is Vowel or Consonant");

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
                case 5:
                    Factors factors = new Factors();
                    Console.WriteLine("Enter Number to check its Factors:");
                    int inputfact = Convert.ToInt32(Console.ReadLine());
                    factors.Factor(inputfact);
                    break;
                case 6:
                    QuotientReminder quotientreminder = new QuotientReminder();
                    Console.WriteLine("Enter dividend: ");
                    int divi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter divisor : ");
                    int divis = Convert.ToInt32(Console.ReadLine());
                    quotientreminder.Calculate(divi, divis);
                    break;
                case 7:
                    SwapNum swapNum = new SwapNum();
                    Console.WriteLine("Enter Two Values to swap:");
                    int value1 = Convert.ToInt32(Console.ReadLine());
                    int value2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("values before swap is " + value1 + " and " + value2);
                    swapNum.swapValues(value1, value2);
                    break;
                case 8:
                    EvenOdd evenOdd = new EvenOdd();
                    Console.WriteLine("Enter number to check Odd and Even:");
                    int inputEvenOdd = Convert.ToInt32(Console.ReadLine());
                    evenOdd.Number(inputEvenOdd);
                    break;
                case 9:
                    VowelConsonant vowelConsonant = new VowelConsonant();
                    Console.WriteLine("Enter Alphabet to check vowel or consonant");
                    char inputVowel = Convert.ToChar(Console.ReadLine());
                    vowelConsonant.CheckVowel(inputVowel);
                    Console.ReadKey();
                    break;
            }

        }
    }
}
