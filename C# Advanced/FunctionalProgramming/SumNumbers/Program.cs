using System;
using System.Linq;

namespace SumNumbers
{
    class Program
    {
        //Write a program that reads a line of integers separated by ", ".
        //Print on two lines the count of numbers and their sum.
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
               .Split(',', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse);

            Console.WriteLine(input.Count());
            Console.WriteLine(input.Sum());
        }
    }
}
