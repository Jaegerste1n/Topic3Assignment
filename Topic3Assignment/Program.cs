using System.Runtime.CompilerServices;

namespace Topic3Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, lastName, eyeColor, hairColor;
            int age, height, weight;

            name = "Chungy";
            lastName = "McFife";
            age = 427;     // autofill says This is a very old man
            height = 324;  // autofill says autofill says This is a very tall man
            weight = 94;   // rule of threes
            eyeColor = "Borange";
            hairColor = "Baldle";
            
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Let's talk about " + name + " " + lastName + ".");
            Console.WriteLine("It's " + height + " inches tall, or ");
            Console.WriteLine("It's " + weight + " pounds heavy, or ");
            Console.WriteLine("That is a weight of all time.");
            Console.WriteLine("It's eyes are " + eyeColor + " and hair is " + hairColor);
            
            // This line is Tricky. Say HI!
            Console.WriteLine("If I add " + age + ", " + height + ", and " + weight + " I get " + (age + height + weight) + ".");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
