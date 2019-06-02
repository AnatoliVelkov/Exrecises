using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OscarsWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string hall = Console.ReadLine();
            int countOfPeople = int.Parse(Console.ReadLine());
            double price=0;

            if (movie== "A Star Is Born")
            {
                if (hall== "normal")
                {
                    price = countOfPeople * 7.5;
                }
                else if (hall == "luxury")
                {
                    price = countOfPeople * 10.5;
                }
                else if (hall== "ultra luxury")
                {
                    price = countOfPeople * 13.5;
                }
            }
            if (movie == "Bohemian Rhapsody")
            {
                if (hall == "normal")
                {
                    price = countOfPeople * 7.35;
                }
                else if (hall == "luxury")
                {
                    price = countOfPeople * 9.45;
                }
                else if (hall == "ultra luxury")
                {
                    price = countOfPeople * 12.75;
                }
            }
            if (movie == "Green Book")
            {
                if (hall == "normal")
                {
                    price = countOfPeople * 8.15;
                }
                else if (hall == "luxury")
                {
                    price = countOfPeople * 10.25;
                }
                else if (hall == "ultra luxury")
                {
                    price = countOfPeople * 13.25;
                }
            }
            if (movie == "The Favourite")
            {
                if (hall == "normal")
                {
                    price = countOfPeople * 8.75;
                }
                else if (hall == "luxury")
                {
                    price = countOfPeople * 11.55;
                }
                else if (hall == "ultra luxury")
                {
                    price = countOfPeople * 13.95;
                }
            }
            Console.WriteLine($"{movie} -> {price:f2} lv.");
        }
    }
}
