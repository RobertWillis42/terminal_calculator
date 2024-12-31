using System;
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
                if (num1 == 0 || num2 == 0)
                {
                    Console.WriteLine("Don't divide by zero!");
                    return double.NaN;
                }
                else
                {
                    return num1 / num2;
                }
             default:
                Console.WriteLine("Invalid input.");
                return double.NaN;
        }

    }

    static void Main(string[] args)
    {
        double num1;
        double num2;
        Console.WriteLine("What operation would you like to perform? (+, -, *, /): ");
        string operation = Console.ReadLine();
        Console.WriteLine("Please enter your first number: ");
        while (!Double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid Input.");
            Console.WriteLine("Please enter your first number: ");
        }
        Console.WriteLine("Please enter your second number: ");
        while (!Double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid Input.");
            Console.WriteLine("Please enter your second number: ");
        }
        Console.WriteLine("\n");
        Console.WriteLine(Calculate(num1, num2, operation));
    }
}