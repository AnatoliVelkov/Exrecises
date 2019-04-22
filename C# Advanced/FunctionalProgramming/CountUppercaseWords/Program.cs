using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
            //Write a program that reads a line of text from the console.
            //Print all words that start with an uppercase letter in the
            //same order you receive them in the text.

        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, bool> upper = n => n[0] == n.ToUpper()[0];

            input.Where(upper).ToList().ForEach(n => Console.WriteLine(n));

            


        }
    }
}
