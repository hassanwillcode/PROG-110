using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MyFirstProgram_9._18._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Let's Get Started! Type Something!");
            string WhatTheUserTyped = ReadLine();
            WriteLine("You type " + WhatTheUserTyped + " ! Good Job!");


            ReadKey();
        }
    }
}
