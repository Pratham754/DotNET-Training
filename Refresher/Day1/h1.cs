using System;

interface IBillCalculator
{
    double CalculateBill(double units, double rate, double fixedCharge);
}

class ResidentialCustomer : IBillCalculator
{
    public double CalculateBill(double units, double rate, double fixedCharge)
    {
        return (units * rate) + fixedCharge;
    }
}

class CommercialCustomer : IBillCalculator
{
    public double CalculateBill(double units, double rate, double fixedCharge)
    {
        // Commercial customers pay 10% extra on usage charges
        double usageCost = units * rate;
        return (usageCost * 1.10) + fixedCharge;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Customer Type (Residential/Commercial): ");
        string customerType = Console.ReadLine().Trim().ToLower();

        Console.Write("Enter Units Consumed: ");
        if (!double.TryParse(Console.ReadLine(), out double units) || units < 0)
        {
            Console.WriteLine("Invalid units consumed.");
            return;
        }

        Console.Write("Enter Rate per Unit: ");
        if (!double.TryParse(Console.ReadLine(), out double rate) || rate < 0)
        {
            Console.WriteLine("Invalid rate.");
            return;
        }

        Console.Write("Enter Fixed Charges: ");
        if (!double.TryParse(Console.ReadLine(), out double fixedCharge) || fixedCharge < 0)
        {
            Console.WriteLine("Invalid fixed charges.");
            return;
        }

        IBillCalculator calculator;

        if (customerType == "residential")
        {
            calculator = new ResidentialCustomer();
        }
        else if (customerType == "commercial")
        {
            calculator = new CommercialCustomer();
        }
        else
        {
            Console.WriteLine("Invalid customer type.");
            return;
        }

        double bill = calculator.CalculateBill(units, rate, fixedCharge);

        Console.WriteLine("\n----- Electricity Bill -----");
        Console.WriteLine($"Customer Type : {customerType}");
        Console.WriteLine($"Total Bill    : {Math.Round(bill, 2)}");
    }
}