using System;

namespace FinancialApp
{
    static class FinancialCalculator
    {
        public static double CalculateCompoundInterest(double principal, double rate, int time = 1, int compoundingFrequency = 1)
        {
            return principal * Math.Pow(1 + (rate / compoundingFrequency), compoundingFrequency * time);
        }

        public static double CalculateCompoundInterest(double principal, double rate, int time)
        {
            return CalculateCompoundInterest(principal, rate, time, 1);
        }
    }

    class Programn
    {
        static void Main()
        {
            double amount1 = FinancialCalculator.CalculateCompoundInterest(10000, 0.05, 10);
            double amount2 = FinancialCalculator.CalculateCompoundInterest(principal: 10000, rate: 0.05, time: 10, compoundingFrequency: 12);
            Console.WriteLine($"Future Value (Annual): {Math.Round(amount1, 2)}");
            Console.WriteLine($"Future Value (Monthly): {Math.Round(amount2, 2)}");
        }
    }
}