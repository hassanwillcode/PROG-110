using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            const int LIMIT = 5000;           // parameters I gave it
            string numberString;          // It takes what the user write even if number or letter
            int number = 0;               // the input the user inputs and can later convert it 

            // Writing
            WriteLine("Write any Number");           // instructions on what to type
            numberString = ReadLine();
            number = Convert.ToInt32(numberString);    // Converts what the user inputs in to integers

            // Decition
            if (number > LIMIT)                        // if the amout the user inputs is larger that 5,000 write Error Message
            {
                WriteLine("Error Message");
            }

            else
            {
                WriteLine("Approved");              // If less than the parameter (5,000) the write Approved

            }

            ReadKey();                // write to be read
        }

    }
}
