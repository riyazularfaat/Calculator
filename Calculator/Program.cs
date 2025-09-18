using System;

namespace Calculator
{
    internal class Program
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter operation (+, -, *, /): ");
                char operation = Console.ReadLine()[0];
                double result = 0;
                switch (operation)
                {
                    case '+':
                        result = Program.Add((double)num1, (double) num2);
                        break;
                    case '-':
                        result = Program.Subtract((double)num1, (double)num2);
                        break;
                    case '*':
                        result = Program.Multiply((double)num1, (double)num2);
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = Program.Divide((double)num1, (double)num2);
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero\n");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Error: Invalid operation\n");
                        continue;
                }
                Console.WriteLine($"Result: {result}");
                Console.Write("\nDo you want to perform another calculation? (y/n): ");
                
                string choice = Console.ReadLine();
                if (choice.ToLower() != "y")
                {
                    break;
                }
                Console.WriteLine("\n");
            }

        }
    }
}
