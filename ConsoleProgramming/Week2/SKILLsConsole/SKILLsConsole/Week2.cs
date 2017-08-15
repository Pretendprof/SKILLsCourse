using System;
using System.Collections.Generic;
using System.Text;

namespace SKILLsConsole
{
    public class Week2
    {
        public static void inputLogic()
        {
            Console.Write("type \"hello\": "); // prompt input from user
            string userInput = Console.ReadLine(); // get input from user

            if (userInput == "hello") // condition under which first response is given
            {
                Console.WriteLine("Hello to you!"); // when user types "hello" do this
            }
            else // if input is not exactly hello then do this
            {
                Console.WriteLine("You did not the follow instructions well");
                // inputLogic(); will force user to provide correct input
            }
        }

        public static void inputLogicTOUpper()
        {
            Console.Write("type \"Hello\": ");
            string userInput = Console.ReadLine();

            if (userInput.ToUpper() == "HELLO") // Converts user input to uppercase when checking user input this ensures that case doesn't matter. 
            // if (userInput.Equals("hello", StringComparison.CurrentCultureIgnoreCase)) // alternative way to get around case differences
            {
                Console.WriteLine("Hello to you!");
            }
            else // if user types anything other than "hello"
            {
                Console.WriteLine("You did not the follow instructions well");
                // inputLogicTOUpper(); // use this force user to provide correct input will loop function until user enters correct input
            }
        }

        public static void howAreYou()  // asks user how they are and gives response to user
        {
            string userInput;

            Console.WriteLine("How are you?"); // asks for user input
            userInput = Console.ReadLine().ToUpper(); // 

            if (userInput.Equals("GOOD", StringComparison.OrdinalIgnoreCase)) // if user types 'good' case doesn't matter (if comes across this then does next line)
            {
                Console.WriteLine("Glad to hear it");
            }
            else if (userInput.Equals("BAD", StringComparison.OrdinalIgnoreCase)) // if previous if was false then checks if user typed 'bad'
            {
                Console.WriteLine("I'm sorry to hear that");
            }
            else if (userInput.Equals("FINE", StringComparison.OrdinalIgnoreCase)) // if last 2 checks came up false checks if user typed 'fine'
            {
                Console.WriteLine("okay");
            }  
            else // if none of the checked responses turn out true, then it does this. 
            {
                Console.WriteLine("I'm a computer I don't have feelings");
            }
        }

        public static void howAreYouSwitch() // same as howAreYou() but using switch statements, this is often faster and can sometimes result in easier to read code. 
        {
            string userInput;

            Console.WriteLine("How are you?");
            userInput = Console.ReadLine().ToUpper();

            switch (userInput) // set switch condition based on user input
            {
                case "GOOD": // do this when switch case is 'good'
                    Console.WriteLine("Glad to hear it");
                    break; // break acts to kick the code out of the switch statement
                case "BAD": // do this when switch case is 'bad'
                    Console.WriteLine("I'm sorry to hear that");
                    break;
                case "FINE":
                    Console.WriteLine("okay");
                    break;
                default: // do this when switch case is not listed
                    Console.WriteLine("I'm a computer I don't have feelings");
                    break;
            }
        }

        public static void PickTextColor()
        {
            Console.Write("Pick a text Color ('red', 'blue', 'yellow'): ");
            string tmpInput = Console.ReadLine();

            if (tmpInput.Equals("red", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You choose Red!");

            }
            else if (tmpInput.Equals("blue", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You choose Blue!");

            }
            else if (tmpInput.Equals("yellow", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You choose Yellow!");

            }
            else
            {
                Console.WriteLine("That is not a valid slection. Please try again: ");
                PickTextColor();

            }

            Console.ResetColor();

            //note you can add repitition
            //CheckRepeat();


        }

        public static void CheckRepeat()
        {
            Console.WriteLine("Would you like to pick another color (y or n)?");

            string tmpAns = Console.ReadLine();

            if (tmpAns.Equals("y", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.Clear();
                PickTextColor();
            }
            else if (tmpAns.Equals("n", StringComparison.CurrentCultureIgnoreCase))
            {

            }
            else
            {
                Console.WriteLine("Invalid answer");
                CheckRepeat();
            }
        }
    }

    public class ClassMaker
    {
        public static void DefineMat() // this function defines two materials (see material class below) and then prints some info about them to the screen
        {
            Material m1 = new Material(); // new material m1
            Material m2 = new Material(); // new material m2

            m1.Type = "Steel"; // give it a name
            m1.Density = 8.04; // give it a density value
            m1.Strength = 200; // give it a strength
            m1.Color = "Blue"; // give it a color

            m2.Type = "Plastic";
            m2.Density = 0.94;
            m2.Strength = 53;
            m2.Color = "Red";

            Console.WriteLine("Material 1: " + m1.Type + " Material 2: " + m2.Type); // print name of each to console
            Console.WriteLine("Material 1 Strenght:" + m1.Strength.ToString()); // print material 1 strength to screen
            Console.WriteLine("Material 2 Strenght:" + m2.Strength.ToString()); // print material 2 strength to screen

        }

    }

    public class Material
    {
        public string Type { get; set; } // to store name of material
        public double Density { get; set; } // to store a density property
        public int Strength { get; set; } // to store a strength property
        public string Color { get; set; } // to store color
    }
}

