using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setsof_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> firstHash = new HashSet<string>();
            HashSet<string> secHash = new HashSet<string>();
            HashSet<string> result = new HashSet<string>();

            var len = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < len[0]; i++)
            {
                var dig = Console.ReadLine();
                firstHash.Add(dig);
                
            }

            for (int i = 0; i < len[1]; i++)
            {
                var dig = Console.ReadLine();
                secHash.Add(dig);

            }
            if (firstHash.Count > secHash.Count)
            {
                foreach (var item in secHash)
                {
                    if (firstHash.Contains(item))
                    {
                        result.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in firstHash)
                {
                    if (secHash.Contains(item))
                    {
                        result.Add(item);
                    }
                }
            }

            foreach (var item in result)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
