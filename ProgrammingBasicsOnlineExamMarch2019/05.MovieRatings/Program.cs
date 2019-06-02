using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            string highestMovie="";
            string lowerMovie="";
            double highestRating=1;
            double lowerRating=10;
            List<double> list = new List<double>();
            int movies = int.Parse(Console.ReadLine());

            for (int i = 0; i < movies; i++)
            {
                var inputMovie = Console.ReadLine();
                var inputRating = double.Parse(Console.ReadLine());
                list.Add(inputRating);

                if (highestRating<inputRating)
                {
                    highestRating = inputRating;
                    highestMovie = inputMovie;
                }
                if (lowerRating>inputRating)
                {
                    lowerRating = inputRating;
                    lowerMovie = inputMovie;
                }
            }
            Console.WriteLine($"{highestMovie} is with highest rating: {highestRating:f1}");
            Console.WriteLine($"{lowerMovie} is with lowest rating: {lowerRating:f1}");
            Console.WriteLine($"Average rating: {list.Average():f1}");
        }
    }
}
