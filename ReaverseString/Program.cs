using System;

namespace ReaverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Type your text and press enter
            Console.WriteLine("Enter a string that you want to Reverse:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string reverse = Console.ReadLine();

            // Print the value of the variable of Reverse function call, which will display the input value
            Console.WriteLine("Reverse string is: " + Common.ReverseString(reverse));

        }
    }
}
