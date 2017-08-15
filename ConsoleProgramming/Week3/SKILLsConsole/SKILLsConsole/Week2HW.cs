using System;
using System.Collections.Generic;
using System.Text;

namespace SKILLsConsole
{
    class Week2HW
    {
        public static void DIYParticipant()
        {
            ParticipantHW p1 = new ParticipantHW();

            Console.WriteLine("Participant Name? ");
            p1.Name = Console.ReadLine();

            Console.WriteLine("Participant Height? ");
            p1.Height = Console.ReadLine();

            Console.WriteLine("Participant Age? ");
            p1.Age = Console.ReadLine();

            Console.WriteLine("Participant Favorite Color? (red, green, yellow) ");
            p1.FavColor = Console.ReadLine();

            Console.WriteLine("You Entered:\n");
            Console.WriteLine("Participant Name: " + p1.Name);

            PickColor(p1.FavColor);
            
            Console.WriteLine("Favorite Color: " + p1.FavColor);

            PickColor("gray");
            
            Console.WriteLine("Age: " + p1.Age);
            Console.WriteLine("Height: " + p1.Height + "m");
        }

        public static void PickColor(string c)
        {
            if (c.Equals("red", StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (c.Equals("green", StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (c.Equals("yellow", StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (c.Equals("gray", StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Color selection error. Check Participant Data for valid color selection");
            }
            
        }
    }

    class ParticipantHW
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Height { get; set; }
        public string FavColor { get; set; }
    }
}
