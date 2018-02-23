/********************************************************************* 
*	Course:     PROG 110 
*	Instructor: Dennis Minium 
*	Term:       Fall 2017 
*
*	Programmer: Hassan Farah
*	Assignment: Prog Assignment 2 - Decisions 
*	
* 
*/

using System;
using static System.Console;

namespace OrderAnvilsProject
{
    class OrderAnvils
    {
        static void Main(string[] args)
        {
            string fullName;
            string streetAddress;
            string city;
            string stateAbbreviation;
            string zipCode;
            string futilityClub;
            string freeItem = null;

            int numberOfAnvils = 0;
            decimal subTotal = 0;
            double tax = 0;
            double total = 0;
            decimal discount = 0;
            decimal costPerAnvil = 0;

            const decimal FUTILITY_CLUB_DISCOUNT = 0.2M;  //Eligable Club Discount of 20%
            const double SALES_TAX = 0.1;          //10% sales tax.  Ouch.
            const string ACME_BANNER = "*** ACME Anvils Corporation ***";

            //Part 1: Welcome message

            WriteLine(ACME_BANNER);
            WriteLine("Supporting the animation industry for 70 years and counting!");

            //Part 2: Collect input data
            WriteLine("\nSCRIPT: Hi, I'm Hassan Farah.  How many anvils would you like to order today?");
            Write("Number of anvils: ");
            numberOfAnvils = int.Parse(ReadLine());

            WriteLine("\nSCRIPT: I can certainly help you with that.  Could you please give me your name and address?");
            Write("First and last name:\t");
            fullName = ReadLine();

            Write("Street address:\t\t");
            streetAddress = ReadLine();

            Write("City:\t\t\t");
            city = ReadLine();

            Write("State (2-letters):\t");
            stateAbbreviation = ReadLine().ToUpper();

            Write("Zip code:\t\t");
            zipCode = ReadLine();

            //Part 3: Futility Club 

            Write("\nAre you a member of our Futility Club frequent shopper program ('Y' if yes)? ");
            futilityClub = ReadLine().ToUpper();

            if (futilityClub == "Y")
            {
                discount = FUTILITY_CLUB_DISCOUNT * subTotal;

                Write("\nGot it, thanks.\nToday only, we're offering an appreciation gift with each order.\nWould you like a free dehydrated boulder (enter ‘D’) or a free bat suit (enter ‘B’)?");
                freeItem = ReadLine().ToUpper();
            }

            else
            {
                WriteLine("\nGot it, thanks.");
            }

            Write("\nPress any key to display invoice. . .");
            ReadKey();
            Write("\n");

            //Part 4: Price of Anvill

            if (numberOfAnvils <= 9)
            {
                costPerAnvil = 78.5M;
            }
            else if (numberOfAnvils <= 19)
            {
                costPerAnvil = 70.0M;
            }

            else if (numberOfAnvils >= 20)
            {
                costPerAnvil = 68.25M;
            }
            //Part 5: Calculate amounts

            subTotal = numberOfAnvils * costPerAnvil;
            discount = subTotal * FUTILITY_CLUB_DISCOUNT;
            tax = (double)(subTotal - discount) * SALES_TAX;
            total = (double)(subTotal - discount) + tax;

            //Part 6: Display invoice

            WriteLine("*******************************");
            WriteLine(ACME_BANNER);
            WriteLine("Customer INVOICE");
            WriteLine("\nSHIP TO:");
            WriteLine($"\t{fullName}");
            WriteLine("\t" + streetAddress);
            WriteLine("\t{0}", city);
            WriteLine("\t{0}", stateAbbreviation);
            WriteLine("\t{0}", zipCode);

            WriteLine($"\nQuantity:\t{numberOfAnvils,22}");
            WriteLine($"Cost per anvil:\t{costPerAnvil,22:C}"); ;
            WriteLine($"Subtotal: \t{subTotal,22:C}");

            if (futilityClub == "Y")
            {
                WriteLine($"Less 20% Futility Club: \t{discount,4:C}");
            }

            else;

            WriteLine($"Sales Tax: \t{tax,22:C}");
            WriteLine($"\t\t            __________");
            WriteLine($"TOTAL: \t\t{total,22:C}");
            WriteLine("*********************************");


            //Part 7: Goodbye!

            if (freeItem == "D")
            {
                WriteLine("\nBOUNUS: Along with today's order, you'll receive a FREE DEHYDRATED BOULDER!");
            }

            else if (freeItem == "B")
            {
                WriteLine("\nBOUNUS: Along with today's order, you'll receive a FREE BAT SUIT!");
            }


                WriteLine("\nSCRIPT: Your total today is {0:C}.  Thanks for shopping with Acme!",total);
            WriteLine("\nAnd don\'t forget: Acme anvils fly farther, drop faster, and land harder than " +
                "any other anvil on the market!");

            // Keep console window open at end of program.  Necessary for debug mode. 

            Write("\nPress any key to end program...");
            ReadKey();

        }
    }
}
