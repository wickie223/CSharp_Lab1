using System;

namespace Swichtendahl_Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Problem 1
            Console.WriteLine("Problem 1");
            int number1; //declare the first number to add
            int number2; //declare second number to add
            int sum; //declare sum of number1 and number2
            Console.Write("Please enter the first number to the equation: "); //first user prompt
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the second number to the equation: "); //second user prompt
            number2 = Convert.ToInt32(Console.ReadLine());
            sum = number1 + number2; //add numbers
            Console.WriteLine("Sum is {0}", sum); //display the sum
            Console.WriteLine();

            //Problem 2
            Console.WriteLine("Problem 2");
            int x = 1;
            int y = 2;
            int z = 3;
            int problem2 = (x + y) * (z + 10);
            Console.WriteLine(problem2);
            Console.WriteLine();
           
             // Problem 3
            Console.WriteLine("Problem 3");
            string name = "Friend";
            string greeting = "Hello";
            Console.WriteLine(greeting + " " + name);
            Console.WriteLine();

            // Problem 4
            Console.WriteLine("Problem 4");
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("\"Hello World!\"");
            Console.WriteLine("Hello\\World!");

        }
    }
}
