using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = int.Parse(Console.ReadLine());
            int countOfTickets=0;
            int countOfProducts=0;

            while (true)
            {
                var input = Console.ReadLine();
                if (input=="End")
                {
                    break;
                }
                if (input.Length > 8)
                {
                    int first = input[0];
                    int second = input[1];
                    money = money - (first + second);
                    if (money < 0)
                    {
                        break;
                    }
                    countOfTickets++;
                }

                if (input.Length <= 8)
                {
                    int first = input[0];
                    money = money - first;
                    if (money < 0)
                    {
                        break;
                    }
                    countOfProducts++;
                }

            }
            Console.WriteLine($"{countOfTickets}");
            Console.WriteLine($"{countOfProducts}");
        }
    }
}
