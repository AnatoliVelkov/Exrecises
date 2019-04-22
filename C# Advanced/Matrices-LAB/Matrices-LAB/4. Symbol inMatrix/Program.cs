using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Symbol_inMatrix
{
    class Program
    {
       //Write a program that reads N, number representing rows and cols of a matrix.
       //On the next N lines, you will receive rows of the matrix.
       //Each row consists of ASCII characters.After that, you will receive a symbol.
       //Find the first occurrence of that symbol in the matrix and print its position in the format: "({row}, {col})". 
       //If there is no such symbol print an error message "{symbol} does not occur in the matrix "
        static void Main()
        {
            int rowsAndCols = int.Parse(Console.ReadLine());

            char[][] matrix = new char[rowsAndCols][];
            bool contain = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row] = new char[rowsAndCols];
                var input= Console.ReadLine();

                for (int col = 0; col < rowsAndCols; col++)
                {
                    matrix[row][col] = input[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    if (matrix[row][col]==symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        contain = true;
                        break;
                    }
                }
            }
            if (contain==false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
