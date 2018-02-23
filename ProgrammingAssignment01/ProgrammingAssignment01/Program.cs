using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ProgrammingAssignment01
{
    class Program
    {
        static void Main(string[] args)
        {  // Variables
            const double priceofAnvil = 78.50;
            const double taxRate = 9.5;
            double anvil;
            double Subtotal;
            string FirstLastName;
            string StreetAddress;
            string City;
            string State;
            string ZipCode;

            //Write
            WriteLine("*** Welcome *** \nAcme Anvils Corporation,\nSupporting the animation industry for 70 years and counting!!");
             
            WriteLine("Hi, I'm Hassan Farah.  How many anvils would you like to order today?");

            Write("Number of anvils:");
            anvil = double.Parse(ReadLine());

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
            WriteLine("{0, 28}", FirstLastName);
            WriteLine("{0, 28}", StreetAddress);
            WriteLine("{0, 18}", City);
            WriteLine("{0, 10}", State);
            WriteLine("{0, 18}", ZipCode);

            WriteLine("Quantity ordered: {0, 20}", anvil);
            WriteLine("Cost per anvil: {0, 20}", priceofAnvil.ToString("C"));
            WriteLine("Subtotal: {0, 20}", (anvil * priceofAnvil) .ToString("C"));

















            ReadKey();
        }
    }
}
