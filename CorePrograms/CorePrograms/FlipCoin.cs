using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class FlipCoin
    {
        public int heads = 0;
        public int tails = 0;


        public void HeadsTailsPercentage()
        {
            Console.WriteLine("Enter How many times you want to Flip a coin :- ");
            int FlipNumber = Convert.ToInt32(Console.ReadLine());

            for (int coinFlip = 0; coinFlip <= FlipNumber; coinFlip++)
            {
                Random random = new Random();
                double FlipCoin = random.NextDouble();
                if (FlipCoin < 0.5)
                    tails++;
                else
                    heads++;
            }
            double PercentageTails = (tails*100) / FlipNumber;
            double PercentageHeads = (heads*100) / FlipNumber;
            Console.WriteLine("Percentage of Heads:-" +PercentageHeads);
            Console.WriteLine("Percentange of Tails:-" +PercentageTails);

        }
    }
}
