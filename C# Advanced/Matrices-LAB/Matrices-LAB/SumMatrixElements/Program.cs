using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMatrixElements
{
    class Program
    {
        // Write program that read a matrix from console and print:
       //•	Count of rows
      //•	Count of columns
     //•	Sum of all matrix’s elements
    //On first line you will get matrix sizes in format[rows, columns]

        static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[input[0], input[1]];
            int result = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var columns = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                result += columns.Sum();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columns[col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(result);

        }
    }
}
