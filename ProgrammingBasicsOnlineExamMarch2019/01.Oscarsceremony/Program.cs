using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Oscarsceremony
{
    class Program
    {
        static void Main(string[] args)
        {
            var rentHall = double.Parse(Console.ReadLine());

            double statuettes=rentHall-((rentHall*30)/100);
            double cattering = statuettes - ((statuettes * 15) / 100);
            double music = cattering - ((cattering * 50) / 100);

            double result =rentHall+ statuettes + cattering + music;

            Console.WriteLine($"{result:f2}");

        }
    }
}
