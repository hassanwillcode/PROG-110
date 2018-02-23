//Hassan Farah
//WoodChuck

using System;
using static System.Console;

namespace WoodChuck
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChucks = 0;
            int userDays = 0;
            int woodValue = 0;

            float totalWood = 0;
            float averageWood;


            bool ChucksResult = false;
            bool DaysResult = false;

            const int MAX_DAYS = 10;
            const int MAX_CHUCKS = 100;

            WriteLine("\n***************** ACME Industries Rodent Sciences Division *****************" +
                "\n*                                                                          * " +
                "\n*                WOODCHUCK WOOD CHUCKING SIMULATION v. 1.0                 * " +
                "\n*                                                                          * " +
                "\n*                One row per woodchuck, one column per day                 * " +
                "\n*                                                                          * " +
                "\n**************************************************************************** ");

            while (!ChucksResult || userChucks < 1 || userChucks > MAX_CHUCKS)
            {
                Write("How many woodchucks would you like to simulate? (1-100): ");
                ChucksResult = int.TryParse(ReadLine(), out userChucks);
            }

            while (!DaysResult || userDays < 1 || userDays > MAX_DAYS)
            {
                Write("How many days would you like to simmulate? (1-10):\t ");
                DaysResult = int.TryParse(ReadLine(), out userDays);
            }

            //Array
            WriteLine();
            int[,] wood = new int[userChucks, userDays];

            //Random
            Random rand = new Random();

            for (int c = 0; c < userChucks; c++)
            {
                for (int d = 0; d < userDays; d++)
                {
                    wood[c, d] = rand.Next(1, 101);

                }

            }

            //Column 
            Write("     ");
            for (int ch = 1; ch <= userDays; ch++)
            {
                Write(String.Format("{0,7}", ch));
            }
            Write("\n");


            Write("     ");
            for (int ch = 1; ch <= userDays; ch++)
            {
                Write(String.Format("{0,7}","_____" ));
            }

            //Rows
            for (int row = 0; row < userChucks; row++)
            {
                WriteLine("\n");

                Write(String.Format("{0,3} |", row + 1));


                for (int column = 0; column < userDays; column++)
                {
                    woodValue = wood[row, column];

                    Write(String.Format("{0,7}", woodValue));
                }
            }

            WriteLine("\n");

            foreach (int x in wood)
            {
                totalWood = (totalWood + x);
            }

            averageWood = totalWood / (userDays * userChucks);

            Write(String.Format("\nTotal wood chucked:      " + "{0,20:N0}\n",totalWood));
            Write("Average woodchuck chuckage: "+ "{0,17:N2}\n", averageWood);

            //Debug pause
            WriteLine("\nPress any key....");
            ReadKey();
        }
    }
}
