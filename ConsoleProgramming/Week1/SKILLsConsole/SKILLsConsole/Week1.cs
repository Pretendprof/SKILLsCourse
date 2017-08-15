using System;
using System.Collections.Generic;
using System.Text;

namespace SKILLsConsole
{
    class Week1
    {
        public static void HelloWorld() //Runs Hello world as seperate method
        {
            Console.WriteLine("Hello World!"); // same code as above for writing to console
        }

        public static void TextColor()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen; // sets text background to dark green
            Console.ForegroundColor = ConsoleColor.Yellow; // sets text color to yellow

            Console.WriteLine("Is this what you expected?"); // writes line with yellow text

            // Note that if the method ends like this you will display whatever text is written next with these settings. Need to decide how to handle this (same method, by the other text?)
        }

        public static void WriteSomewhereElse()
        {
            Console.SetCursorPosition(20, 26);

            Console.WriteLine("how about here?");
        }

        public static void ColorMove()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(20, 26);

            Console.Write("Yellow");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(20, 0);

            Console.Write("Blue");

        }

        public static void MoveRatio()
        {
            Console.SetCursorPosition(Console.WindowWidth/2, Console.WindowHeight/3);

            Console.WriteLine("Half way across and 1/3 down");

        }

    }
}
