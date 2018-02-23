using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace GradedExcercise02_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int number1;
            int number2;
            int number3;
           




            // Write

            Write("Write Integer 1: ");
            number1 = int.Parse(ReadLine());


            Write("Write Integer 2: ");
            number2 = int.Parse(ReadLine());

            Write("Write Integer 3: ");
            number3 = int.Parse(ReadLine());


            // 
            if ( number1 == number2)

            {


                if (number1 == number3)
                {
                    WriteLine("All three are equal");
                }
                 else
                {
                    WriteLine("number 1 and number 2 are equal but not number 3");
                }
            }

            else
            {

                if (number3 == number2)


                {

                    WriteLine("number3 and number2 are equal");
                }


                else if (number1 == number3)
                {
                    WriteLine("number1 and number3 are equal");
                }

                else
                {

                    WriteLine("no two numbers equal");
                }
            }



            ReadKey();















        }

      
    }
}
