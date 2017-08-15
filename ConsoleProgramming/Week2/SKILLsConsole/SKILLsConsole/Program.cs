using System; // Using declaration at top of script identifies libraries (Identified by a namespaces) used in script

namespace SKILLsConsole // useful for keeping track of/organizing class libraries
{
    class Program // this is a class It is an object that groups variables, types, methods and events
    {
       
        static void Main(string[] args) //This is the Main method. It is the first step into the program and thus can be thought of as the program controller or outline
        {

            //Week2.inputLogic();
            //Week2.inputLogicTOUpper();
            //Week2.howAreYou();
            //Week2.howAreYouSwitch();
            //ClassMaker.DefineMat();
            //Week2HW.DIYParticipant();

            Week2.PickTextColor();

            Console.WriteLine("\nPress any key to continue...\n"); // \n in a string tells program to write a new line 
            Console.ReadKey(); //waits for a key press before continuing the program 
        }

    }
}