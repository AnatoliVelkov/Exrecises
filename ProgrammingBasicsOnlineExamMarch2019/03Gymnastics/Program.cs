using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine();
            var device = Console.ReadLine();
            double rating = 0;

            //
            if (country=="Russia")
            {
                if (device=="ribbon")
                {
                    rating = 18.500;
                }
                else if (device == "hoop")
                {
                    rating = 19.100;
                }
                else if (device == "rope")
                {
                    rating = 18.600;
                }
            }

            if (country == "Bulgaria")
            {
                if (device == "ribbon")
                {
                    rating = 19.000;
                }
                else if (device == "hoop")
                {
                    rating = 19.300;
                }
                else if (device == "rope")
                {
                    rating = 18.900;
                }
            }

            if (country == "Italy")
            {
                if (device == "ribbon")
                {
                    rating = 18.700;
                }
                else if (device == "hoop")
                {
                    rating = 18.800;
                }
                else if (device == "rope")
                {
                    rating = 18.850;
                }
            }

            Console.WriteLine($"The team of {country} get {rating:f3} on {device}.");
            double percent=((double) 20 - rating) / 20 * 100;
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
