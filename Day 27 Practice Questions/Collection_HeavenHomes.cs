using System;
using System.Collections.Generic;

#region Apartment
class Apartment
{
    // Stores apartment number and rent
    private Dictionary<string, double> apartmentRentMap = new();

    /// <summary>
    /// Adds apartment number and its rent.
    /// </summary>
    public void AddApartment(string apartmentNo, double rent)
    {
        apartmentRentMap[apartmentNo] = rent;
    }

    /// <summary>
    /// Calculates total rent within the given range.
    /// </summary>
    public double CalculateTotalRent(double minRent, double maxRent)
    {
        double sum = 0;

        foreach (var item in apartmentRentMap)
        {
            if (item.Value >= minRent && item.Value <= maxRent)
            {
                sum += item.Value;
            }
        }

        return sum;
    }
}
#endregion

#region HeavenHome
class HeavenHome
{
    /// <summary>
    /// Application entry point.
    /// </summary>
    public static void Main()
    {
        Apartment apartment = new();

        Console.WriteLine("Enter number of details to be added");
        int count = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the details (Apartment number: Rent)");
        for (int i = 0; i < count; i++)
        {
            string input = Console.ReadLine();
            string[] data = input.Split(':');

            apartment.AddApartment(data[0], double.Parse(data[1]));
        }

        Console.WriteLine("Enter the range to filter the details");
        double minRent = double.Parse(Console.ReadLine());
        double maxRent = double.Parse(Console.ReadLine());

        double totalRent = apartment.CalculateTotalRent(minRent, maxRent);

        if (totalRent > 0)
        {
            Console.WriteLine(
                $"Total Rent in the range {minRent:F1} to {maxRent:F1} USD:{totalRent:F1}"
            );
        }
        else
        {
            Console.WriteLine("No apartments found in this range");
        }
    }
}
#endregion