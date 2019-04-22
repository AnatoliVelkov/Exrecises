using System;
using System.Linq;

namespace SortEvenNumbers
{
    class Program
    {
        //Write a program that reads one line of integers separated by ", ". 
        //Then print the even numbers of that sequence sorted in increasing order.

        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n=>n);

            Console.WriteLine(string.Join(", ",input));

        }
    }
}
