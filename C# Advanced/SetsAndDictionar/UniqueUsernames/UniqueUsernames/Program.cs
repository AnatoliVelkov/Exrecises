using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueUsernames
{
    //On the first line you will be given an integer N.On the next N lines you will receive one username per line.
    //Write a simple program that reads from the console a sequence of N usernames and keeps a collection only of the unique ones. 
    //Print the collection on the console in order of insertion
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hash = new HashSet<string>();
            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var name = Console.ReadLine();
                hash.Add(name);
            }
            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
        }
    }
}
