using System;

class Program
{
    static void Main()
    {
        double price, discount;
        int quantity;

        Console.Write("Enter Item Price: ");
        if (!double.TryParse(Console.ReadLine(), out price) || price < 0)
        {
            Console.WriteLine("Invalid price.");
            return;
        }

        Console.Write("Enter Quantity: ");
        if (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
        {
            Console.WriteLine("Invalid quantity.");
            return;
        }

        Console.Write("Enter Discount (%): ");
        if (!double.TryParse(Console.ReadLine(), out discount) || discount < 0)
        {
            Console.WriteLine("Invalid discount.");
            return;
        }

        double subtotal = price * quantity;
        double discountAmount = subtotal * discount / 100;
        double finalAmount = subtotal - discountAmount;

        Console.WriteLine("\n----- BILL -----");
        Console.WriteLine($"Subtotal: {Math.Round(subtotal, 2)}");
        Console.WriteLine($"Discount: {Math.Round(discountAmount, 2)}");
        Console.WriteLine($"Final Amount: {Math.Round(finalAmount, 2)}");
    }
}