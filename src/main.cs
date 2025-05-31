using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            string? operation = "";
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Enter first number:");
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input. Exiting.");
                return;
            }
            result = double.Parse(input!);
            while (true)
            {
                Console.WriteLine("Enter operation (+, -, *, /) or 'c' to clear or 'q' to quit:");
                operation = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(operation))
                {
                    Console.WriteLine("Invalid operation. Exiting.");
                    return;
                }
                operation = operation.Trim().ToLower();
                if (operation == "q")
                {
                    Console.WriteLine("Exiting calculator.");
                    break;
                }
                if (operation == "c")
                {
                    result = 0;
                    Console.WriteLine("Cleared. Enter first number:");
                    string? inputFirst = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(inputFirst))
                    {
                        Console.WriteLine("Invalid input. Exiting.");
                        return;
                    }
                    result = double.Parse(inputFirst);
                    continue;
                }
                Console.WriteLine("Enter next number:");
                string? nextInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nextInput))
                {
                    Console.WriteLine("Invalid input. Exiting.");
                    return;
                }
                double next = double.Parse(nextInput);
                switch (operation)
                {
                    case "+":
                        result += next;
                        break;
                    case "-":
                        result -= next;
                        break;
                    case "*":
                        result *= next;
                        break;
                    case "/":
                        if (next != 0)
                            result /= next;
                        else
                            Console.WriteLine("Division durch 0 nicht erlaubt.");
                        break;
                    default:
                        Console.WriteLine("Unknown operation.");
                        break;
                }
                Console.WriteLine("Result: " + result);
            }
        }
    }
}
