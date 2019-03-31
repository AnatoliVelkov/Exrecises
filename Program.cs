using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearTax = int.Parse(Console.ReadLine());

            double result = 0;

            double shoes = (double)yearTax * 0.6;
            double equipment = shoes * 0.8;
            double ball = equipment * 0.25;
            double accesories = ball * 0.2;

            result = yearTax + shoes + equipment + ball + accesories;
            Console.WriteLine($"{result:f2}");
        }
    }
}
