using System;
using System.Collections.Generic;
using System.Text;

namespace SKILLsConsole
{
    class calculatorApp
    {
        public static void calcRun()
        {
            // get user input (number, operator, number)
            int val1 = userNumInput("first"); // FUnction gets an int value from the user
            int val2 = userNumInput("second");
            int output = userOperatorInput(val1, val2);
            // perform operation

            Console.WriteLine("The answer is: " + output);
        }
        static int userNumInput(string number)
        {
            int userVal = 0;

            while (true)
            {
                Console.Write("Enter " + number + " Number: ");
                bool result = int.TryParse(Console.ReadLine(), out userVal); // note that the maximum value for an int32 is 2,147,483,647

                if (result)
                {
                    Console.WriteLine(userVal);
                    break;
                }
                else
                {
                    Console.WriteLine("That is not an intiger, try again");
                }
            }
            return userVal;
        }

        static int userOperatorInput(int val1, int val2)
        {
            string userOp;

            Console.Write("Specify Operation (+,-,*,/): ");

            userOp = Console.ReadLine();

            int tmp;

            switch (userOp) // also demonstrate object encapselation
            {
                case "+":
                    tmp = val1 + val2;
                    return tmp;
                //break;
                case "-":
                    tmp = val1 - val2;
                    return tmp;
                // break;
                case "/":
                    tmp = val1 / val2;
                    return tmp;
                //break;
                case "*":
                    tmp = val1 * val2;
                    return tmp;
                //break;
                default:
                    Console.WriteLine("Invalid Operator. Try again.");
                    return userOperatorInput(val1, val2);
                    //break;
            }
        }
    }
}
