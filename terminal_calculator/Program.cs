using System;
using System.Reflection.Metadata.Ecma335;
class Program
{
    static double Calculate(double num1, double num2, string operation)
    {
        switch (operation)
        {
            case "+":
                return num1 + num2;
            case "-":
                return num1 - num2;
            case "*":
                return num1 * num2;
            case "/":
                return num1 / num2;
            default:
                Console.WriteLine("Invalid input.");
                return double.NaN;
        }

    }

    static void Main(string[] args)
    {
        bool repeat = true;
        do // Loop to make program restart if user chooses to run it again.
        {
            double num1;
            double num2;
            Console.WriteLine("Please enter your first number: ");
            while (!Double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("\nInvalid Input.\n");
                Console.WriteLine("Please enter your first number: ");
            }
            Console.WriteLine("\nPlease enter your second number: ");
            while (!Double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("\nInvalid Input.\n");
                Console.WriteLine("Please enter your second number: ");
            }

            Console.WriteLine("\nWhat operation would you like to perform? (+, -, *, /): ");
            string operation = Console.ReadLine();
            if (operation == "/" && num1 == 0 || num2 == 0) // Prevent divide by zero.
            {
                Console.WriteLine("\nYou can't divide by zero.\n");
                continue;
            }
            double result = Calculate(num1, num2, operation);
            Console.WriteLine("\nThe answer is " + result + ".");
            Console.WriteLine("\nWould you like to run the calculator again? (y/n): ");
            string userRepeatChoice = Console.ReadLine();

            if (userRepeatChoice == "y")
            {
                Console.WriteLine("\n");
                continue;
            }
            else if (userRepeatChoice == "n")
            {
                repeat = false;
                Console.WriteLine("\nThank you for using the calculator! Closing now.");
            }
            else
            {
                Console.WriteLine("\nInvalid input\n");
                break;
            }
        } while (repeat == true);
    }
}