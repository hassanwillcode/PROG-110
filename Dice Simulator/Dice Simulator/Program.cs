//Hassan Farah
//Dice Simulator

using System;
using static System.Console;

namespace Dice_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sums = new int[13];

            int sum = 0;
            int dice01 = 0;
            int dice02 = 0;
            int input = 0;
            int rolls = 0;

            

            // Welcome Banner
            WriteLine("******************* ACME Industries Simulation Division ********************" +
                "\n*                                                                          *" +
                "\n*                     Dice Rolling Simulation v. 1.1                       *" +
                "\n*                                                                          *" +
                "\n*                 One row per possible roll of two dice                    *" +
                "\n*                                                                          *" +
                "\n****************************************************************************");

            Write("\nHow many rolls would you like to simulate? >> ");
            input = Convert.ToInt32(ReadLine());

            //Dice
            Random rand = new Random();
            for (int i = 0; i < input; i++)
            {
                dice01 = rand.Next(1, 7);
                dice02 = rand.Next(1, 7);

                sum = dice01 + dice02;
                sums[sum] += 1;
            }

            WriteLine("Roll" +"\t"+ "Count");

            //
            for (int i = 2; i <= 12; i++)
            {
                Write(i + "\t" + "{0}\n", sums[i]);

            }

            foreach (int x in sums)
            {
                
                rolls = (rolls + x);
               

            }

            WriteLine("\t" +rolls);

            


            //Debug pause
            WriteLine("\nPress any key....");
            ReadKey();

        }
    }
}
