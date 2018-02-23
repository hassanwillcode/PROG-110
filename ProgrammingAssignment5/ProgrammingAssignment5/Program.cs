/********************************************************************* 
*	Course:     PROG 110 
*	Instructor: Dennis Minium 
*	Term:       Spring 2017 
*
*	Programmer: Hassan Farah
*	Assignment: Prog Assignment 5 

*/

using System;
using static System.Console;

namespace Hw4._2HowMuchWood
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            //Banner Method

            PrintSessionBanner();

            //Run Sumulation

            int[,] array = RunSimulations(rand);

            //Print Matrix

            PrintMatrix(array);

            //Print Summary

            PrintSummary(array);
            

        }
        private static void PrintSessionBanner()
        {
            WriteLine("***************** ACME Industries Rodent Sciences Division *****************");
            WriteLine("*                                                                          *");
            WriteLine("*                WOODCHUCK WOOD CHUCKING SIMULATION v. 1.0                 *");
            WriteLine("*                                                                          *");
            WriteLine("*                One row per woodchuck, one column per day                 *");
            WriteLine("*                                                                          *");
            WriteLine("****************************************************************************");
        }
        private static int GetSimulationPrameter(string prompt, int min, int max)
        {
            bool isValidInt;
            int input;

            Write(prompt);
            isValidInt = int.TryParse(ReadLine(), out input);
            while (input < min || input > max)
            {
                Write($"Try again.  Enter a number between {min} and {max}: ");
                int.TryParse(ReadLine(), out input);
            }


            return input;
        }
        private static int[,] RunSimulations(Random rand)
        {
            int chucks = GetSimulationPrameter("Enter number of woodchucks for this simulation (1-100): ", 1, 100);
            int days = GetSimulationPrameter("Enter number of days for this simulation (1-10): ", 1, 10);

            int[,] array = new int[chucks, days];

            for (int c = 0; c < chucks; c++)
            {
                for (int d = 0; d < days; d++)
                {
                    array[c, d] = rand.Next(1, 101);
                }
            }
            return array;
        }
        private static void PrintMatrix(int[,] array)
        {
            int row;
            int col;

            const int COL_WIDTH = 6;

            Write("\n      "); 

            for (col = 0; col < array.Length; col++)
            {
                Write($"{col + 1,COL_WIDTH:N0}");
            }

            Write("\n       ");
            for (col = 0; col < array.GetLength(1); col++)
            {
                Write("_____ ");
            }

            for (row = 0; row < array.GetLength(0); row++)
            {
                Write($"\n{row + 1,3} | ");
                for (col = 0; col < array.GetLength(1); col++)
                {
                    Write(array[row, col] == 0 ? "     -" : $"{array[row, col],COL_WIDTH:N0}");
                }
            }
        }
        private static void PrintSummary(int[,] array)
        {
            float avgTotal = 0;
            int sumTotal = 0;
            foreach (int element in array)
            {
                sumTotal += element;
            }
            avgTotal = (float)sumTotal / (array.GetLength(1) * array.GetLength(0));

            WriteLine($"\n\nTotal wood chucked:\t\t{sumTotal,10:N0}");
            WriteLine($"Average woodchuck chuckage:\t{avgTotal,10:N}");

            WriteLine("\nPress any key to wrap it up...");
            ReadKey();
        }
    }
}
