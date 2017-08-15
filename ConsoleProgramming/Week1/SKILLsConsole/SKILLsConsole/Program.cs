using System; // Using declaration at top of script identifies libraries (Identified by a namespaces) used in script

namespace SKILLsConsole // useful for keeping track of/organizing class libraries
{
    class Program // this is a class It is an object that groups variables, types, methods and events
    {
       
        static void Main(string[] args) //This is the Main method. It is the first step into the program and thus can be thought of as the program controller or outline
        {
            //Console.WriteLine("Hello World!"); // Writes string in () to the console

            //HelloWorld(); // calls a hello World Method 
            //Console.WriteLine(HelloStringOuput()); // calls method that outputs hello world string to console.writeline command

            //ConsoleParrot.RunParrot(); // calls the console parrot program from homework

            //Console.WriteLine("\nPress any key to continue...\n"); // \n in a string tells program to write a new line 
            //Console.ReadKey(); //waits for a key press before continuing the program 

            //Week1.HelloWorld(); // calls hello world from a different class
            //Week1.TextColor(); //changes text color
            //Week1.WriteSomewhereElse(); // changes text position
            //Week1.ColorMove(); // changes color and position
            //Week1.MoveRatio(); // sets position based on window size
            
            Console.WriteLine("Press anykey to continue...");
            Console.ReadKey(true);
        }

        static void HelloWorld() //Runs Hello world as seperate method
        {
            Console.WriteLine("Hello World!"); // same code as above for writing to console
        }

        static string HelloStringOuput() // generates text for hello mwthod with string method not it says "string" not "void" for its return type
        {
            string temp = "hello World!"; // sets value for string

            return temp; // returns string (this is the ouput of this method)
        }
    }
}