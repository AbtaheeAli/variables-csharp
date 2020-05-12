using System;

namespace variables_csharp
{
    class Program
    {

        static void Main(string[] args)
        {

            var numberOfCupsOfCoffee = "one";

            var fullName = "Abtahee Ali";

            DateTime today = DateTime.Today;
            //Declaring the vars before writing to consoles

            Console.WriteLine($"Hello, my name is {fullName}. On {today.ToLongDateString()}, I had {numberOfCupsOfCoffee} cup of coffee.");

            Console.WriteLine("Hello, What is your name? ");
            var userName = Console.ReadLine();
            //Finding out the user's name

            if (userName == "Alice")
            {
                Console.WriteLine("Alice, it is nice to finally meet you after such a long time!");
            }
            else
            {
                Console.WriteLine($"It is nice meeting you, {userName}!");
                //greeting user and retrieving the name
            }

            Console.WriteLine($"{userName}, how old are you?");
            var firstNumberAsString = Console.ReadLine();
            //retrieving user age

            Console.WriteLine($"{userName}, how old will you be in ten years?");
            var secondNumberAsString = Console.ReadLine();
            //retrieving user age in ten years

            var firstNumber = double.Parse(firstNumberAsString);
            var secondNumber = double.Parse(secondNumberAsString);

            var sum = firstNumber + secondNumber;

            var difference = firstNumber - secondNumber;

            var product = firstNumber * secondNumber;

            var quotient = firstNumber / secondNumber;

            var remainder = firstNumber % secondNumber;

            Console.WriteLine($"{userName}, Here is a little fun fact: if you add your current age and the age you will be in ten years, you get {sum}. Be ready for more facts, {userName}!");
            //notifying user about what their age + their age in ten years will add up to

            Console.WriteLine($"{userName}, if you subtract your current age and the age you will be in ten years, you get {difference}");

            Console.WriteLine($"{userName}, if you multiply your current age and the age you will be in ten years, you get {product}");

            Console.WriteLine($"{userName}, if you divide your current age and the age you will be in ten years, you get {quotient}");

            Console.WriteLine($"{userName}, if you want to know the remainder of your current age and the age you will be in ten years, you get {remainder}");

            Console.WriteLine($"{userName}, I hope you enjoyed the fun facts! Have a good day!");
        }


    }
}
