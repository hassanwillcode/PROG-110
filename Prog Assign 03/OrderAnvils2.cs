/********************************************************************* 
*	Course:     PROG 110 
*	Instructor: Dennis Minium 
*	Term:       Spring 2017 
*
*	Programmer: Hassan Farah
*	Assignment: Prog Assignment 2 - Loops
*	
*	Description:
*	This program collects input from a user who is ordering anvils 
*	including name, address, and number of anvils required.  It
*	then calculates the total value of the order and displays
*	an invoice, subject to the following conditions:
*		
*	-   If the customer is a frequent shopper, they are entitled to an additional
*	    20% discount.
*	
*	-   For frequent shopper, a special promotion is in force only if they win the guessing game. The winner recieves a Unicycle.
*	
*	-   Pricing for the anvils is based on the volume of anvils purchased:
*	    1 - 9:  $780.50
*	    10-19:  $72.35
*	    20+:    $67.99
*
*/

using System;
using static System.Console;

namespace OrderAnvilsSolution
{
    class OrderAnvils2
    {
        static void Main(string[] args)
        {
            int numberOfAnvils = 0;
            string fullName;
            string streetAddress;
            string city;
            string stateAbbreviation;
            string zipCode;

            // Guessing Game
            int MIN = 1;
            int MAX = 11;
            int guess = 1;

            Random RandomClass = new Random();
            int randomNumber = 0;
            randomNumber = RandomClass.Next(MIN, MAX);

            bool loyaltyDiscount;

            decimal subTotal = 0;
            double tax = 0;
            double total = 0;
            double loyaltyDiscountAmt = 0;

            double todaysCostPerAnvil = 0;

            const double SALES_TAX = 0.0995;                  //9.95% sales tax. 
            const decimal COST_PER_ANVIL_LT_10 = 80.00M;    //'M' because it's a variable of type decimal
            const decimal COST_PER_ANVIL_LT_20 = 72.35M;
            const decimal COST_PER_ANVIL_GE_20 = 67.99M;
            const double LOYALTY_DISCOUNT_FACTOR = 0.15;    //15% discount

            const string ACME_BANNER_1 = "****************************************************************************";
            const string ACME_BANNER_2 = "************************ ACME Anvils Corporation ***************************";
            const string NEW_ORDER_BANNER = "******************************* NEW ORDER ********************************** ";

            //Welcome message

            WriteLine(ACME_BANNER_2);
            WriteLine("Supporting the animation industry for 70 years and counting!");

            //Countdown
            int countDown = 3;
            do
            {
                WriteLine("Countdown to Order ");

                for (int i = countDown; i < 4 && i > 0; i--)
                {
                    WriteLine($"{i}");
                    System.Threading.Thread.Sleep(1000); // It just counts down and gives the next number evry second
                }

                Write("\a" + NEW_ORDER_BANNER);

                //Collect input data

                WriteLine("\nSCRIPT: Hi, I'm Hassan. How many anvils would you like to order today?");
                Write("Number of anvils: ");
                numberOfAnvils = int.Parse(ReadLine());

                for (numberOfAnvils = 0; numberOfAnvils > 0;)
                {
                };

                WriteLine("\nSCRIPT: I can certainly help you with that.  Could you please give me your name and address?");
                Write("First and last name:\t");
                fullName = ReadLine();
                
                Write("Street address:\t\t");
                streetAddress = ReadLine();

                Write("City:\t\t\t");
                city = ReadLine();

                Write("State (2-letters):\t");
                stateAbbreviation = ReadLine();

                Write("Zip code:\t\t");
                zipCode = ReadLine();

                //Determine loyalty discount eligibility

                Write("\nSCRIPT: Are you a member of our Futility Club, the frequent shopper program that rewards persistence over results? (\"Y\" if yes)? ");
                loyaltyDiscount = ReadLine().ToUpper() == "Y" ? true : false;

                if (loyaltyDiscount)
                {
                   
                    WriteLine("\nSCRIPT: Excellent!  You’ll receive an AMAZING 15% discount on today’s purchase! " +
                              "\nWhat’s more, as a valued member of our loyalty program, you’ll have a chance " +
                              "\nto win a bonus gift in our exciting Members-Only Jet-Propelled Unicycle contest!" +
                              "\nPick a number between 1 and 10!");
                    guess = int.Parse(ReadLine());

                    if (guess == randomNumber )
                    {
                        WriteLine($"\nWoo hoo!  You guessed the secret number: {guess}.  An ACME JetPropelled Unicycle is headed your way! ");

                    }
                    else  
                    {
                            WriteLine($"Aww, too bad.  You guessed {guess}, but the secret number was {randomNumber}.  No unicycle.  What a loser.  Very sad. ");

                    }
 

                }
                else
                {
                    WriteLine("\nWhat’s wrong with you?  That just cost you a 15% discount and an \nopportunity to win a unicycle.  Sad. ");
                }

                //Calculate subtotal: price * qty

                if (numberOfAnvils < 10)
                {
                    todaysCostPerAnvil = (double)COST_PER_ANVIL_LT_10;
                }
                else if (numberOfAnvils < 20)
                {
                    todaysCostPerAnvil = (double)COST_PER_ANVIL_LT_20;
                }
                else
                {
                    todaysCostPerAnvil = (double)COST_PER_ANVIL_GE_20;
                }

                subTotal = numberOfAnvils * (decimal)todaysCostPerAnvil;

                //Subtract loyalty discount if applicable

                if (loyaltyDiscount)
                {
                    loyaltyDiscountAmt = (double)subTotal * -LOYALTY_DISCOUNT_FACTOR;
                }

                //Add tax and calculate final total

                tax = ((double)subTotal + loyaltyDiscountAmt) * SALES_TAX;
                total = (double)subTotal + tax + loyaltyDiscountAmt;

                //Display invoice

                Write("\nPress any key to display invoice. . .");
                ReadKey();
                Write("\n");

                WriteLine(ACME_BANNER_1);
                WriteLine(ACME_BANNER_2);
                WriteLine("CUSTOMER INVOICE");
                WriteLine("\nSHIP TO:");
                WriteLine($"\t\t{fullName}");
                WriteLine("\t\t" + streetAddress);
                WriteLine("\t\t{0}", city);
                WriteLine("\t\t{0}", stateAbbreviation);
                WriteLine("\t\t{0}", zipCode);

                WriteLine($"\nQuantity:\t\t\t{numberOfAnvils,10}");
                WriteLine($"Cost per anvil:\t\t\t{todaysCostPerAnvil,10:C}");
                WriteLine($"Subtotal: \t\t\t{subTotal,10:C}");

                //Taxable Amount

                double taxableAmount = 0;

                taxableAmount = (double)subTotal - loyaltyDiscountAmt;


                if (loyaltyDiscount)
                {
                    WriteLine($"Less 15% Futility Club: \t{loyaltyDiscountAmt,10:C}");
                    WriteLine($"Taxable amount: \t\t{taxableAmount,10:C}");
                }

                else
                {
                    WriteLine($"No discount for you! \t\t{"0.00",10}");
                    WriteLine($"Taxable amount: \t\t{taxableAmount,10:C}");
                }

                WriteLine($"Sales Tax: \t\t\t{tax,10:C}");
                WriteLine("\t\t\t\t__________");
                WriteLine($"TOTAL: \t\t\t\t{total,10:C}");

                // If guess is correct Free UniCycle

                if (guess == randomNumber)
                {
                    WriteLine("\nAnd congratulations on winning a FREE JET-PROPELLED UNICYCLE!!!");
                }

                

                WriteLine(ACME_BANNER_1);

                //Goodbye!

                WriteLine("\nSCRIPT: Your total today is {0:C}.  Thanks for shopping with Acme!", total);
                WriteLine("\nSCRIPT: And don\'t forget: Acme anvils fly farther, drop faster, and land harder than " +
                    "any other anvil on the market!");

            }while(ReadLine().ToUpper() == "Y");
            

            // Keep console window open at end of program.  Necessary for debug mode. 
            Write("\nPress any key to end program...");
            ReadKey();

        }
    }
}
