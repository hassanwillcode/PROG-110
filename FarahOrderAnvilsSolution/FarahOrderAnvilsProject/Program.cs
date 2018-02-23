using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FarahOrderAnvilsProject
{
    class OrderAnvils
    {
        static void Main(string[] args)
        {
            // Variables
            const double PRICEOFANVIL = 78.50;
            const double TAXRATE = 9.5;
            int anvil;
            string FirstLastName;
            string StreetAddress;
            string City;
            string State;
            string ZipCode;

            //Write
            WriteLine("*** Welcome *** \nAcme Anvils Corporation,\nSupporting the animation industry for 50 years and counting!");


            WriteLine("Hi, I'm Hassan Farah.  How many anvils would you like to order today?");

            Write("Number of anvils:");
            anvil = int.Parse(ReadLine());

            WriteLine("I can certainly help you with that.  Could you please give me your name and address? First ");

            Write("First and last name:");
            FirstLastName = ReadLine();

            Write("Street address:");
            StreetAddress = ReadLine();

            Write("City:");
            City = ReadLine();

            Write("State (2-letters):");
            State = ReadLine();

            Write("Zip code:");
            ZipCode = ReadLine();

            WriteLine("Press any key to display invoice. . .\n*******************************");
            WriteLine("*** ACME Anvils Corporation ***\nCustomer Invoice");
            WriteLine("SHIP TO:");
            WriteLine("       {0}", FirstLastName);
            WriteLine("       {0}", StreetAddress);
            WriteLine("       {0}", City);
            WriteLine("       {0}", State);
            WriteLine("       {0}", ZipCode);

            WriteLine("Quantity ordered: {0, 10}", anvil);
            WriteLine("Cost per anvil:   {0, 10}", PRICEOFANVIL.ToString("C"));
            WriteLine("Subtotal:         {0, 10}", (anvil * PRICEOFANVIL).ToString("C"));
            WriteLine("Sales Tax:        {0, 10}", (TAXRATE * (anvil * PRICEOFANVIL) / 100).ToString("C"));
            WriteLine("                   _________");
            WriteLine("TOTAL:            {0, 10}", (anvil * PRICEOFANVIL + TAXRATE * (anvil * PRICEOFANVIL) / 100).ToString("C"));
            WriteLine("**********************************");

            WriteLine("Your total today is " + (anvil * PRICEOFANVIL + TAXRATE * (anvil * PRICEOFANVIL) / 100).ToString("C") + ". Thanks for shopping with Acme! ");

            WriteLine("And don't forget: Acme anvils fly farther, drop faster, and land harder than  any other anvil on the market!");

            WriteLine("Press any key to end program...");










            ReadKey();
        }
    }
}
