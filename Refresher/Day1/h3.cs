using System;

interface IShippingCost
{
    double CalculateCost(double weight, double distance);
}

class StandardPackage : IShippingCost
{
    public double CalculateCost(double weight, double distance)
    {
        return (weight * 10) + (distance * 2);
    }
}

class ExpressPackage : IShippingCost
{
    public double CalculateCost(double weight, double distance)
    {
        return (weight * 15) + (distance * 3);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Package Type (Standard/Express): ");
        string packageType = Console.ReadLine().Trim().ToLower();

        Console.Write("Enter Weight (kg): ");
        if (!double.TryParse(Console.ReadLine(), out double weight) || weight <= 0 || weight > 1000)
        {
            Console.WriteLine("Invalid weight.");
            return;
        }

        Console.Write("Enter Distance (km): ");
        if (!double.TryParse(Console.ReadLine(), out double distance) || distance <= 0 || distance > 5000)
        {
            Console.WriteLine("Invalid distance.");
            return;
        }

        IShippingCost shipping;

        if (packageType == "standard")
        {
            shipping = new StandardPackage();
        }
        else if (packageType == "express")
        {
            shipping = new ExpressPackage();
        }
        else
        {
            Console.WriteLine("Invalid package type.");
            return;
        }

        double cost = shipping.CalculateCost(weight, distance);

        Console.WriteLine("\n----- Shipping Details -----");
        Console.WriteLine($"Package Type : {packageType}");
        Console.WriteLine($"Shipping Cost: ₹{Math.Round(cost, 2)}");
    }
}