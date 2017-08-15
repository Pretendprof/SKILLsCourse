using System;
using System.Collections.Generic;
using System.Text;

namespace SKILLsConsole
{
    public class OutputColor
    {
        public static void textColor()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Is this what you expected?");
        }

       
    }

    public class ParticipantMaker
    {

        public static void DefineParticipants()
        {
            Participant p1 = new Participant();
            Participant p2 = new Participant();

            p1.Name = "Sussie";
            p1.Age = "28";
            p1.Height = "1.7";
            p1.FavColor = "Blue";

            p2.Name = "Mohammad";
            p2.Age = "24";
            p2.Height = "1.9";
            p2.FavColor = "Purple";

            Console.WriteLine("Participant 1: " + p1.Name + " Participant 2: " + p2.Name);

            ParticipantOutput(p1, p2);
        }

        protected static void ParticipantOutput(Participant p1, Participant p2)
        {
            Console.WriteLine("\nWhich participnt do you want to know about?");

            string temp = Console.ReadLine();

            if (temp.Equals(p1.Name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Favorite Color: " + p1.FavColor);
                Console.WriteLine("Age: " + p1.Age);
                Console.WriteLine("Height: " + p1.Height + "m");
            }
            else if (temp.Equals(p2.Name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Favorite Color: " + p2.FavColor);
                Console.WriteLine("Age: " + p2.Age);
                Console.WriteLine("Height: " + p2.Height + "m");
            }
            else
            {
                Console.WriteLine("Participant Name not availible, Please try again");
                ParticipantOutput(p1, p2);
            }
        }
    }

    public class Participant
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Height { get; set; }
        public string FavColor { get; set; }
    }
}
