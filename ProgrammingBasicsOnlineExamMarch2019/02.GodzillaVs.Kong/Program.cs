using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _02.GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int countStats = int.Parse(Console.ReadLine());
            decimal priceForOneItem = decimal.Parse(Console.ReadLine());
            decimal priceForMovie = 0;


            decimal dekor = budget * (decimal)0.1;
            decimal clothing = countStats * priceForOneItem;

           
            if (countStats > 150)
            {
                clothing = clothing * (decimal)0.9;
                priceForMovie = dekor + clothing;
            }
            else
            {
                priceForMovie = dekor + clothing;
            }


            if (priceForMovie > budget)
            {
                decimal total = priceForMovie - budget;
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {total:f2} leva more.");
            }
            else if (budget >= priceForMovie)
            {
                decimal total = budget - priceForMovie;
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {total:f2} leva left.");
            }

        }
    }
}
