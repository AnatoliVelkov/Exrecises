using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamWon = 0;
            int teamLost = 0;
            int teamDraw = 0;

            for (int i = 0; i < 3; i++)
            {
                var result = Console.ReadLine().Split(':').ToArray();

                int inserted = int.Parse(result[0]);
                int allowed = int.Parse(result[1]);

                if (inserted>allowed)
                {
                    teamWon++;
                }
                else if (inserted<allowed)
                {
                    teamLost++;
                }
                else if (inserted==allowed)
                {
                    teamDraw++;
                }
            }

            Console.WriteLine($"Team won {teamWon} games.");
            Console.WriteLine($"Team lost {teamLost} games.");
            Console.WriteLine($"Drawn games: {teamDraw}");
        }
    }
}
