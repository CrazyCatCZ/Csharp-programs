using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter operator: ");
            string operatorInput = Console.ReadLine();

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = default;
            switch (operatorInput)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - +num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Result is: {0}", result);
        }
    }
}
