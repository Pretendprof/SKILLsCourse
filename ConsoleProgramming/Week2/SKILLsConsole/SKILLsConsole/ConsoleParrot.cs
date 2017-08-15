using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
///  This class is an example of a solution to the first homework assignment. 
/// </summary>

namespace SKILLsConsole
{
    public class ConsoleParrot // Our class name for console parrot. Note that this is Public meaning it is accessable to other classes and static 
    {
        // This version exemplifies OOP by breaking methods out into smaller chuncks of program activity
        public static void RunParrot()
        {
            string userString = UserInput(); // calls a method to prompt user for string input 

            RespondToUser(userString); // calls a method to print string to console

            //RespondToUser(UserInput()); // combines two lines above into one for more streamlined code

            Console.Write("\nPress any key to continue."); //prompts user
            Console.ReadKey(); // waits for key press
        }

        // method prompts user for input and returns user input as a string
        static string UserInput()
        {
            Console.Write("Please enter some text: "); // prompt user

            string temp = Console.ReadLine(); // assign user input to string var

            return temp; // return user string input
        }

        // method to print a string to console with a message. Takes one string argument 
        static void RespondToUser(string s)
        {
            Console.WriteLine("\nYou wrote: " + s); // write message to screen using string passed in as argument
        }

        // this is an alternative version of the program. NOTE: this is equally correct, but may not be as useful in more complex settings
        public static void AltRunParrot()
        {
            Console.Write("Please enter some text: "); // prompt user

            string temp = Console.ReadLine(); // assign user input to string var

            Console.WriteLine("\nYou wrote: " + temp); // write message to screen using string provided by user
        }
    }
}
