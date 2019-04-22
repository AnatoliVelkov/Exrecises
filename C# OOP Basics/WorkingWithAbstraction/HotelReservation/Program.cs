using System;
using System.Linq;
using System.Collections.Generic;

namespace HotelReservation
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            double price = double.Parse(input[0]);
            int days = int.Parse(input[1]);
            string season=input[2];
            string discount="";
            decimal result=0;

            PrintPrice(price, days, season, input, discount, result);


        }

        static void PrintPrice(double price, int days, string season, List<string> input, string discount, decimal result)
        {
            

            switch (season)
            {
                case "Autumn":
                    result = (decimal)price * (decimal)days * (decimal)1.00;
                    break;
                case "Spring":
                    result = (decimal)price * (decimal)days * (decimal)2.00;
                    break;
                case "Winter":
                    result = (decimal)price * (decimal)days * (decimal)3.00;
                    break;
                case "Summer":
                    result = (decimal)price * (decimal)days * (decimal)4.00;
                    break;
            }

            if (input.Count > 3)
            {
                discount = input[3];
                switch (discount)
                {
                    case "VIP":
                        result =result * (decimal)0.8;
                        Console.WriteLine($"{result:f2}");
                        break;

                    case "SecondVisit":
                        result = result * (decimal)0.9;
                        Console.WriteLine($"{result:f2}");
                        break;
                }
                
            }
            else
            {
                Console.WriteLine($"{result:f2}");
            }
        }
    }
}
