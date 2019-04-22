using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSumOf2x2Submatrix
{
    class Program
    {
      //Write program that read a matrix from console and print the sum for each column.
      //On first line you will get matrix rows.On the next rows lines,
      //you will get elements for each column separated with a space. 

        static void Main()
        {

            var input = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[input[0], input[1]];
            int result = 0;
            

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var columns = Console.ReadLine().Split(new char[] { ' ' }).Select(int.Parse).ToArray();
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columns[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    result += matrix[row, col];
                }
                Console.WriteLine(result);
                result = 0;
            }
        }
    }
}
