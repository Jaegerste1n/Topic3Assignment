using System.Runtime.CompilerServices;

namespace Topic3Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string name, lastName, eyeColor, hairColor;
            int age = 77, height, weight;
            double inches, cm;


            name = "Chungy";
            lastName = "McFife";
            age = 427;     // autofill says This is a very old man
            height = 324;  // autofill says autofill says This is a very tall man
            cm = height * 2.54;
            weight = 94;   // rule of threes
            eyeColor = "Borange";
            hairColor = "Baldle";
            
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Let's talk about " + name + " " + lastName + ".");
            Console.WriteLine("It's " + height + " inches tall, or " + cm + "cm tall");
            Console.WriteLine("It's " + weight + " pounds heavy, or ");
            Console.WriteLine("That is a weight of all time.");
            Console.WriteLine("It's eyes are " + eyeColor + " and hair is " + hairColor);
            
            // This line is Tricky. Say HI!
            Console.WriteLine("If I add " + age + ", " + height + ", and " + weight + " I get " + (age + height + weight) + ".");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black; */

            int room, year;
            double price;
            string course, name;

            room = 29;
            price = 2.99;
            course = "Computer Science";
            year = 2027;
            name = "Bastian Halvorsen";

            Console.WriteLine("This is room #" + room + ".");
            Console.WriteLine("The price is $" + price + ".");
            Console.WriteLine("I am learning about " + course + ".");
            Console.WriteLine("");
            Console.WriteLine("My name is " + name + " and I will graduate in " + year + ".");



            double radius = 47;
            double area = double.Pi * radius * radius;
            const double Pi = 3.14;

            Console.WriteLine("The area of the circle is " + area + ".");


        }
    }
}
