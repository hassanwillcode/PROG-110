using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Are_you_ready
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Let's get started!  Type something!");
            string whatTheUserTyped = Console.ReadLine();
            WriteLine("You typed:" + whatTheUserTyped + "!  Good job!");

            WriteLine("\nPress any key to continue...");
            ReadKey();
        }
    }
}
