using System;

namespace BranchingExerciseStep92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.Write("Package weight in pounds: "); double pkgWeight = Convert.ToDouble(Console.ReadLine());
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else if (pkgWeight <= 50)
            {
                Console.Write("Package height: "); double pkgHeight = Convert.ToDouble(Console.ReadLine());
                Console.Write("Package length: "); double pkgLength = Convert.ToDouble(Console.ReadLine());
                double sizeTotal = pkgHeight + pkgLength;

                if (sizeTotal > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else if (sizeTotal <= 50)
                {
                    double shipQuoteStep1 = sizeTotal * pkgWeight;
                    decimal shipQuote = Convert.ToDecimal(shipQuoteStep1) / 100;
                    Console.WriteLine("Congratulations! This can be shipped. Your price for shipping looks like: $" + shipQuote + ". Remember, if you're not shipping with Package Express, you're shipping with someone else!");
                }
            }
            else
            {
                Console.WriteLine("Something went wrong.");
            }
        }
    }
}
