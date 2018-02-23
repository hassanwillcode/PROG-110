/* PROG 110
 * Midterm, Spring 2017
 * 
 */

using System;
using static System.Console;

class Midterm

{
    static void Main()
    {
        // Problem 1 -- enter the solution between the opening and closing brace
        {// start of problem 1
         
          WriteLine("\n\n*** PROBLEM 1 *** \n");
          const int INPUT_VALUE = 3;
          int userInput1;
          int userInput2;
          int userInput3;
          int sum = 0;
          int product = 0;
          int average = 0;


          Write("Enter number 1: ");
          userInput1 = Convert.ToInt32(ReadLine());
          Write("Enter number 2: ");
          userInput2 = Convert.ToInt32(ReadLine());
          Write("Enter number 3: ");
          userInput3 = Convert.ToInt32(ReadLine());

          // Calculate
          sum = userInput1 + userInput2 + userInput3;
          product = userInput1 * userInput2 * userInput3;
          average = sum / INPUT_VALUE;

          Write("\nSum = {0},", sum);
          Write("\nProduct = {0},", product);
          Write("\nAverage = {0}.00,", average);

      } // end of problem 1

        

            //Problem 2-- enter the solution between the opening and closing brace
            {// start of problem 2
                WriteLine("\n*** PROBLEM 2 *** \n");

                //const int MIN = 1;
                //const int MAX = 81;
                //string userInput ;
                //int count = 0;
                //Write("Enter your short message: ");
                //userInput = ReadLine();

                //// count = userInput.Count(char.IsLetter);
                //while (userInput )
                //{
                //    if (count => )
                //    {
                //        WriteLine("\nApproved");
                //    }

                //    else
                //    {
                //        WriteLine("\nRejected");
                //    }


                //}
                




            }// end of problem 2



            //Problem 3-- enter the solution between the opening and closing brace
            {// start of problem 3
                WriteLine("\n*** PROBLEM 3 ***\n");
                
                string userinput;
                double validnumber = 0;
                bool numberIsValid = false;


                WriteLine("Enter a month number: ");
                userinput = ReadLine();

                numberIsValid = double.TryParse(userinput, out validnumber);

                switch (validnumber)
                {
                    case 12:
                    case 1:
                    case 2:
                        WriteLine($"Month {userinput} is in Winter");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        WriteLine($"Month {userinput} is in Spring");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        WriteLine($"Month {userinput} is in Summer");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        WriteLine($"Month {userinput} is in Fall");
                        break;
                          default:
                        WriteLine($"{userinput} Month 0 is in no Season");
                        break;

                }

        


            }// end of problem 3



            //Problem 4-- enter the solution between the opening and closing brace
            {// start of problem 4
                WriteLine("\n*** PROBLEM 4 ***\n");
                
                            int numberOfChocolate = 0;
                            double todaysCostPerChocolate = 0;
                            decimal subTotal = 0;
                            decimal total = 0;
                            const decimal COST_PER_CHOCOLATE_0 = 0.00M;
                            const decimal COST_PER_CHOCOLATE_51 = 7.25M;   
                            const decimal COST_PER_CHOCOLATE_101 = 15.75M;
                            const decimal COST_PER_CHOCOLATE_102 = 21.50M;

                if (numberOfChocolate < 0)
                {
                    todaysCostPerChocolate = (double)COST_PER_CHOCOLATE_0;
                }
                else if (numberOfChocolate < 51)
                {
                    todaysCostPerChocolate = (double)COST_PER_CHOCOLATE_51;
                }
                else if (numberOfChocolate < 101)
                {
                    todaysCostPerChocolate = (double)COST_PER_CHOCOLATE_101;
                }

                else
                {
                    todaysCostPerChocolate = (double)COST_PER_CHOCOLATE_102;
                }

                            subTotal = numberOfChocolate * (decimal)todaysCostPerChocolate;


                            do
                            {
                                Write("\nHow many pieces? Enter any whole number or -999 to quit: ");
                                numberOfChocolate = Convert.ToInt32(ReadLine());

                  
                    

                        if (numberOfChocolate <= 0)
                        {
                            todaysCostPerChocolate = (double)COST_PER_CHOCOLATE_0;
                            total = numberOfChocolate * COST_PER_CHOCOLATE_0;
                            Write("At {0} pieces at {1:C} per piece, you've earned {2:C}.", numberOfChocolate, COST_PER_CHOCOLATE_0, total);
                        }
                        else if (numberOfChocolate < 51)
                        {
                            todaysCostPerChocolate = (double)COST_PER_CHOCOLATE_51;
                            total = numberOfChocolate * COST_PER_CHOCOLATE_51;
                            Write("At {0} pieces at {1:C} per piece, you've earned {2:C}.", numberOfChocolate, COST_PER_CHOCOLATE_51, total);
                        }
                        else if (numberOfChocolate < 101)
                        {
                            todaysCostPerChocolate = (double)COST_PER_CHOCOLATE_101;
                            total = numberOfChocolate * COST_PER_CHOCOLATE_101;
                            Write("At {0} pieces at {1:C} per piece, you've earned {2:C}.", numberOfChocolate, COST_PER_CHOCOLATE_101, total);
                        }

                        else
                        {
                            todaysCostPerChocolate = (double)COST_PER_CHOCOLATE_102;
                            total = numberOfChocolate * COST_PER_CHOCOLATE_102;
                            Write("At {0} pieces at {1:C} per piece, you've earned {2:C}.", numberOfChocolate, COST_PER_CHOCOLATE_102, total);
                        }
                    

                    Write("\nHow many pieces? Enter any whole number or -999 to quit: ");

                } while (ReadLine() == "-999");
                           
                
            }// end of problem 4


            //Problem 5-- rewrite the solution in the appropriate location
            // start of problem 5
                WriteLine("\n*** PROBLEM 5 ***\n");
            
            string days;
            string miles;

            double perDayTotal = 0;
            double perMileTotal = 0;
            double subtotal = 0;

            const double PERDAY = 19.99;
            const double PERMILE = .25;
            const double RENTALFEE = 1.75;
            double validNumber = 0;
            bool numbervalid = true;

            //Calculations

            



            while (numbervalid)
            {
                Write("Enter number of days: ");
                days = ReadLine();

                numbervalid = double.TryParse(days, out validNumber);
                perDayTotal = validNumber * PERDAY;

                if (!numbervalid)
                {
                    WriteLine("Invalid number of days.  Please re-enter. ");
                }

                else
                {
                  
                
            }

                while (numbervalid)
                {
                    Write("Enter number of miles: ");
                    miles = ReadLine();

                    numbervalid = double.TryParse(miles, out validNumber);
                    perMileTotal = validNumber * PERMILE;

                    if (!numbervalid)
                    {
                        WriteLine("Invalid number of miles.  Please re-enter. ");
                    }

                    else
                    {
                        subtotal = perDayTotal + perMileTotal + RENTALFEE;

                        WriteLine("Car rental at {0:C} per day for {3} days is {5:C}" +
                            "\nMileage at {1:C} per mile for {4} miles is {6:C}" +
                            "\nTotal cost including a fee of {2} is {7:C}",PERDAY,PERMILE,RENTALFEE,days,miles,perDayTotal,perMileTotal,subtotal);

                        
                    } 

                   
                }
            }
        
                           
                            
                              




                                // Challenge -- enter the solution between the opening and closing brace
                                //                      only if you have time, this will not count against you
                                // start of Challenge 
                                WriteLine("\n*** CHALLENGE PROBLEM ***\n");
                
                               // end of Challenge


                              // pause
                              Write("\nPress any key to continue... ");
                              ReadKey();

        }

    }




