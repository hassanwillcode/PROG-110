using System;
using static System.Console;

namespace _2D_Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] values = new int[3, 4]
               { { 11,12,13,14 },{21,22,23,24 },{31,32,33,34} };

            int row;
            int col;

            for (row = 0; row < values.GetLength(0); row++)
            {
                for (col = 0; col < values.GetLength(1); col++)
                {
                    WriteLine($"[{row},{col}] {values[row, col]}");
                }
            }
            //Debug 
            WriteLine("Press any key... ");
            ReadKey();
        }
    }
}
