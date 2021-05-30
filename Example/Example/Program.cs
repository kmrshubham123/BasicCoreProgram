using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            calculator calc = new Calculator(5, 5);
            calc.GetSum();
        }
    }
}
