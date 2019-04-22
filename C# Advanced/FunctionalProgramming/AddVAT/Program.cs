using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        //Write a program that reads one line of double prices separated by ", ";. Print the prices with added VAT for all of
        //them.Format them to 2 signs after the decimal point.The order of the prices must be the same.
        //VAT is equal to 20% of the price.

        static void Main()
        {
            var input = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(n => double.Parse(n) * 1.2);
                
            foreach (var item in input)
            {
                Console.WriteLine($"{item:f2}");
            }
            
        }
    }
}
