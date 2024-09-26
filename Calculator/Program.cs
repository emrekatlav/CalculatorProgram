using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string again = "y";

            Console.WriteLine("Hello, welcome to the calculator program!");
            while (again == "y")
            {
                decimal num1, num2, result = 0;
                string answer;
                bool validOperation = true;

                Console.WriteLine("Please enter your first number: ");
                if (!Decimal.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine("Please enter your second number: ");
                if (!Decimal.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine("What type of operation would you like to do?");
                Console.WriteLine("Please enter + for addition, - for subtraction, x for multiplication or / for division.");
                answer = Console.ReadLine().ToLower();

                switch (answer)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "x":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            validOperation = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please enter a valid operator (+, -, x, /).");
                        validOperation = false;
                        break;
                }

                if (validOperation)
                {
                    Console.WriteLine($"The result is: {result}");
                }

                Console.WriteLine("Do you want to make another operation? (y/n)");
                again = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Thank you for using the Calculator Program!");
            Console.ReadKey();
        }
    }
}
