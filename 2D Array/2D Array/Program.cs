using System;
using static System.Console;

namespace _2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] trolls = new string[2, 4]
               { { "pink", "red", "yellow", "green" }, {"brown","purple","black","blue"} };

            int row;
            int col;

            for(row = 0; row < trolls.GetLength(0); row++)
            {
                for(col = 0; col < trolls.GetLength(1); col++)
                {
                    WriteLine($"The  troll in row {row+1}, column {col+1} has {trolls[row,col]} hair.");
                }
            }
            //Debug 
            WriteLine("Press any key... ");
            ReadKey();
        }
    }
}
