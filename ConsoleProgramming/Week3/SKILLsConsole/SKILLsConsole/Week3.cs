using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics; // NOTE THAT timing examples will not work without this. 

namespace SKILLsConsole
{
    class Week3
    {
        public static void IntCopy_noCheck() // asks for a number expects an intiger and can fail
        {
            int userInput = 1;
            // bool result  = false;
            // Write user prompt to console
            Console.Write("Enter a number: ");

            userInput = int.Parse(Console.ReadLine()); // this will work if int is input but will throw an exception if int is not entered
                                                       // get for user input and assign to our userInput var
                                                       // int.TryParse(Console.ReadLine(), out int result);
                                                       // Respond to user input with "You typed: " followed by whatever the user typed
            Console.WriteLine("You typed: " + userInput);

        }

        public static void IntCopy_withCheck() // asks for intiger input and verifies input is intiger
        {
            int userInput;

            // Write user prompt to console
            Console.Write("Enter an intiger: ");

            bool result = int.TryParse(Console.ReadLine(), out userInput); // note that the maximum value for an int32 is 2,147,483,647. returns true if user puts int in.

            if (result) // Note that this could be rewritten as seperate method
            {
                Console.WriteLine("You typed: " + userInput);
            }
            else
            {
                Console.WriteLine("That is not an intiger");
            }
        }

        public static void DoubleCopy_withCheck() // asks for intiger input and verifies input is intiger
        {
            double userInput;

            // Write user prompt to console
            Console.Write("Enter a number: ");

            bool result = double.TryParse(Console.ReadLine(), out userInput); // note that the maximum value for an int32 is 2,147,483,647. returns true if user puts int in.

            if (result) // Note that this could be rewritten as seperate method
            {
                Console.WriteLine("You typed: " + userInput);
            }
            else
            {
                Console.WriteLine("That is not an intiger");
            }
        }

        public static void Addition()
        {
            int firstVal;

            Console.Write("Pick an number: ");

            bool result = int.TryParse(Console.ReadLine(), out firstVal); // note that the maximum value for an int32 is 2,147,483,647

            if (result)
            {
                int output = 5 + firstVal; // adds 5 to value entered
                Console.WriteLine("5 + " + firstVal + " = " + output); //writes line 
            }
            else
            {
                Console.WriteLine("You did not enter an intiger");
                Addition();
            }
            
        }

        // counter() is a public method that returns nothing, hence 'void'. This doesn't mean that it does nothing though. 
        public static void Counter()
        {
            // for loops are a special kind of logic in a C# program. It means do something for a certain number of times. 
            // The output of this for loop will write a number to the console each loop, counting from one to five. 
            for (int i = 1; i <= 5; i++) // in the () set up loop count var; provide loop conditions, i.e. loop as long as loop count var meets this condition; loop count change rule ++ is add one each loop and -- is subtract one each loop
            {
                Console.WriteLine(i);
            }
        }

        public static void CounterWhile()
        {
            int val = 1;
            // While loops are a special kind of logic in a C# program. They will continue to run some set of code for as long as a specified condition holds

            while (true) // when the condition is true, the code will run until break; command is issued. It is very important that you ensure that the code will break
            {
                if (Console.KeyAvailable) // this checks if a key has been pressed
                {
                    Console.ReadKey(true); // makes sure that the console readout pauses
                    Console.WriteLine("Counter stopped"); // give user information
                   
                    break; // kicks out of While loop
                }

                Console.WriteLine(val);

                val += 1; // add one to val
            }

            //    while (val<20) // this will run as long as val is less than 20
            //{
            //    Console.WriteLine(val);

            //    val += 1;
            //}
        }

        public static void VarPassExample() // This method takes an input and passes it to another function then waits for a returned value
        {
            Console.WriteLine("Please type a noun: "); //

            // without return variable
            string noun = Console.ReadLine(); // get user input
            RecieveAndReturn(noun);

            //string noun = Console.ReadLine(); // get user input 
            //string CatSent = RecieveAndReturn(noun); // pass user input to recieveandreturn method (below) and get new string
            //Console.WriteLine(CatSent); //print returned message 

            //// more compact version of above section 
            //string CatSent = RecieveAndReturn(Console.ReadLine()); //
            //Console.WriteLine(CatSent);

            //// even more compact version of the code above
            //Console.WriteLine(RecieveAndReturn(Console.ReadLine()));

        }

        static string RecieveAndReturn(string tmp) // takes a string as an input and returns a new string
        {
            string sentence = "The cat sat on the " + tmp + "."; // concatinate input string with this string

            return sentence; // return new string to whoever called this function
        }

        static void RecieveAndOutput(string tmp) // takes a string as an input and returns a new string
        {
            string sentence = "The cat sat on the " + tmp + "."; // concatinate input string with this string

            Console.WriteLine(sentence);
        }
    }

    public class TimingExamples
    {
        public static void timeCounter()
        {
            Stopwatch sw = new Stopwatch();
            while (true)
            {
                sw.Start();
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    sw.Stop();
                    Console.WriteLine("Timer stopped");
                    break;
                }

                sw.Stop();

                Console.WriteLine(sw.ElapsedMilliseconds);
            }
        }

        public static void deltaTime()
        {
            Stopwatch sw = new Stopwatch();

            decimal lastTime = 0;
            decimal now;

            while (true)
            {
                sw.Start();

                now = sw.ElapsedTicks; // 10,000 ticks in a milliseconds
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    sw.Stop();
                    Console.WriteLine("Timer stopped");
                    break;
                }
                sw.Stop();
                decimal deltaT = now - lastTime;
                lastTime = now;
                Console.WriteLine("deltaTime = " + deltaT);

            }
        }

    }
}
