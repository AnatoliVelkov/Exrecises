using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayModification
{
    class Program
    {

        static void Main()
        {
            int rowsAndCols = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rowsAndCols][];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var readMatrix = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                matrix[row] = new int[rowsAndCols];
                matrix[row] = readMatrix;
            }


            var input = Console.ReadLine();
            while (input!="END")
            {
                List<string> commands = input.Split(' ').ToList();
                if (commands[0]=="Add")
                {
                    try
                    {
                        matrix[int.Parse(commands[1])][int.Parse(commands[2])] += int.Parse(commands[3]);
                    }
                    catch (System.IndexOutOfRangeException e)
                    {
                        System.Console.WriteLine("Invalid coordinates");
                        
                    }

                }
                if (commands[0] == "Subtract")
                {

                    try
                    {
                        matrix[int.Parse(commands[1])][int.Parse(commands[2])] -= int.Parse(commands[3]);
                    }
                    catch (System.IndexOutOfRangeException e)  
                    {
                        System.Console.WriteLine("Invalid coordinates");
                        
                    }

                }
                input = Console.ReadLine();
                

            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
