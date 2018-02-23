/********************************************************************* 
*	Course:     PROG 110 
*	Instructor: Dennis Minium 
*	Term:       Spring 2017 
*
*	Programmer: Hassan Farah
*	Assignment: Prog Assignment 4.2 - How much wood could a wood chuck chuck? 
*	
*	Description:
*	------------
*	This program was commissioned by groundhogs to help simulate their efficiency.
*	
* 
*	Revision    Date               Release Comment 
*	--------     ----------        ------------------------------------------------------ 
*	1.0         05/11/2017         Initial Release 
*/

using System;
using static System.Console;

namespace Hw4._2HowMuchWood
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] woodChuckProduction;

            int numOfWoodchuck;
            int numOfDays;

            int numRows = 0;
            int numCols = 0;

            //const int MAX_ROWS = 100;
            //const int MAX_COLS = 10;
            const int COL_WIDTH = 6;

            int row;        //Used as dimension 0 subscript
            int col;        //Used as dimension 1 subscript
            int sumTotal = 0;
            float avgTotal = 0;

            Random rand = new Random();

            //Session Banner Method

            PrintSessionBanner();

            sumTotal = 0;
            avgTotal = 0;

            //Get simulation parameters

            numOfWoodchuck = GetSimulationPrameter($"\nEnter number of woodchucks for this simulation: ", 1, 100);
            numOfDays = GetSimulationPrameter($"\nEnter number of days for this simulation: ", 1, 10);

            //Write($"Enter number of woodchucks for this simulation (1-{MAX_ROWS}):\t ");
            //int.TryParse(ReadLine(), out numRows);
            //while (numRows < 1 || numRows > MAX_ROWS)
            //{
            //    Write($"Try again.  Enter a number between 1 and {MAX_ROWS}: ");
            //    int.TryParse(ReadLine(), out numRows);
            //}

            //Write($"Enter number of days for this simulation (1-{MAX_COLS}):\t ");
            //int.TryParse(ReadLine(), out numCols);
            //while (numCols < 1 || numCols > MAX_COLS)
            //{
            //    Write($"Try again.  Enter a number between 1 and {MAX_COLS} ");
            //    int.TryParse(ReadLine(), out numCols);
            //}

            //Fill out simulation array
            woodChuckProduction = new int[numRows, numCols];
            for (row = 0; row < numRows; row++)
            {
                for (col = 0; col < numCols; col++)
                {
                    woodChuckProduction[row, col] = rand.Next(1, 101);
                }
            }

            //Calculate total and average for the entire simulation
            sumTotal = 0;
            foreach (int element in woodChuckProduction)
            {
                sumTotal += element;
            }
            avgTotal = (float)sumTotal / (numRows * numCols);

            //Write Column Headings
            Write("\n      "); //No heading over first column
            for (row = 0; row < numCols; row++)
            {
                Write($"{row + 1,COL_WIDTH:N0}");
            }

            Write("\n       ");
            for (col = 0; col < woodChuckProduction.GetLength(1); col++)
            {
                Write("_____ ");
            }

            //Print simulation matrix
            for (row = 0; row < woodChuckProduction.GetLength(0); row++)
            {
                Write($"\n{row + 1,3} | ");
                for (col = 0; col < woodChuckProduction.GetLength(1); col++)
                {
                    Write(woodChuckProduction[row, col] == 0 ? "     -" : $"{woodChuckProduction[row, col],COL_WIDTH:N0}");
                }
            }

            WriteLine($"\n\nTotal wood chucked:\t\t{sumTotal,10:N0}");
            WriteLine($"Average woodchuck chuckage:\t{avgTotal,10:N}");

            WriteLine("\nPress any key to wrap it up...");
            ReadKey();

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

        private static int runsimulation(int rand)
        {
            int array;

            //woodchuckproduction = new int[numrows, numcols];
            //for (row = 0; row < numrows; row++)
            //{
            //    for (col = 0; col < numcols; col++)
            //    {
            //        woodchuckproduction[row, col] = rand.next(1, 101);
            //    }
            //}

            //return array;
        }

    }
}
