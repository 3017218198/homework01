using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            Console.BackgroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Hello World!");
            System.Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("Hello World!");
            /* 
             * 1.reset the background color to defalut (black)
             * 2.reset the foreground color to default (white)
             */
            Console.BackgroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("Hello World!");
        }
    }
}
