using System;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int rhombSize = int.Parse(Console.ReadLine());
            int whiteSpace = rhombSize;

            for (whiteSpace=whiteSpace-1; whiteSpace > 0; whiteSpace--)
            {
                PrintRhombus(rhombSize, whiteSpace);
            
            }
            for (whiteSpace = 0; whiteSpace < rhombSize; whiteSpace++)
            {
                PrintRhombus(rhombSize, whiteSpace);

            }


        }
        static void PrintRhombus(int rhombSize, int whiteSpace)
        {
            for (int counter = whiteSpace; counter >= 0; counter--)
            {
                Console.Write(" ");
            }
            for (int counter = rhombSize-whiteSpace; counter > 0; counter--)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
