using System;
using System.Linq;
using System.Collections.Generic;

namespace CatLady
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Cat> cats = new HashSet<Cat>();

            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (input[0]!="End")
            {
                string type = input[0];
                string name = input[1];
                double furSize = double.Parse(input[2]);

                cats.Add(new Cat(type, name, furSize));
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            string choice = Console.ReadLine();

            foreach (Cat item in cats.Where(a=>a.name==choice))
            {
                Console.WriteLine($"{item.type} {item.name} {item.furSize:f2}");
            }
        }
    }
}

