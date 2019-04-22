using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryDiagonal
{
    class Program
    {
        //Write a program that finds the sum of matrix primary diagonal.
        //•	On the first line, you are given the integer N – the size of the square matrix
        //•	The next N lines holds the values for every row – N numbers separated by a space
        static void Main()
        {
            int rowsAndCols = int.Parse(Console.ReadLine());

            int[][] matrix =new int[rowsAndCols][];
            int result = 0;
            int index = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row] = new int[rowsAndCols];

                matrix[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                result += matrix[row][index];
                index++;
            }
            Console.WriteLine(result);
        }
    }
}
