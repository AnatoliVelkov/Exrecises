using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsTickets = 0;
            int standartTickets = 0;
            int kidsTickets = 0;

            while (true)
            {
                int students = 0;
                int standard = 0;
                int kids = 0;
                var movie = Console.ReadLine();
                if (movie=="Finish")
                {
                    break;
                }
                int capacity = int.Parse(Console.ReadLine());
                for (int i = 0; i < capacity; i++)
                {
                    var inputTickets = Console.ReadLine();
                    if (inputTickets=="End")
                    {
                        break;
                    }
                    if (inputTickets=="student")
                    {
                        studentsTickets++;
                        students++;
                    }
                    else if (inputTickets == "standard")
                    {
                        standartTickets++;
                        standard++;
                    }
                    else if (inputTickets == "kid")
                    {
                        kidsTickets++;
                        kids++;
                    }
                }

                double percent = ((double)(students + standard + kids)/capacity)  *100;
                Console.WriteLine($"{movie} - {percent:f2}% full.");
            }
            Console.WriteLine($"Total tickets: {standartTickets+studentsTickets+kidsTickets}");
            double totalPercent = (studentsTickets / (double)(standartTickets + studentsTickets + kidsTickets)) * 100;
            Console.WriteLine($"{totalPercent:f2}% student tickets.");
            totalPercent = (standartTickets / (double)(standartTickets + studentsTickets + kidsTickets)) * 100;
            Console.WriteLine($"{totalPercent:f2}% standard tickets.");
            totalPercent = (kidsTickets / (double)(standartTickets + studentsTickets + kidsTickets)) * 100;
            Console.WriteLine($"{totalPercent:f2}% kids tickets.");
        }
    }
}
