using System;
namespace Github
{
    public class Calculator
    {
        public static string Calculate(decimal num1, decimal num2, char operation)
        {
            decimal result;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    return $"Result: {result}";
                case '-':
                    result = num1 - num2;
                    return $"Result: {result}";
                case '*':
                    result = num1 * num2;
                    return $"Result: {result}";
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        return $"Result: {result}";
                    }
                    else
                    {
                        return "Error: Division by zero is not allowed.";
                    }
                default:
                    return "Invalid operation. Please use +, -, *, or /.";
            }
        }
    }
}