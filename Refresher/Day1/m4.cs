using System;

class Program
{
    static void Main()
    {
        double openingBalance, deposits, withdrawals;

        Console.Write("Enter Opening Balance: ");
        if (!double.TryParse(Console.ReadLine(), out openingBalance) || openingBalance < 0)
        {
            Console.WriteLine("Invalid opening balance.");
            return;
        }

        Console.Write("Enter Total Deposits: ");
        if (!double.TryParse(Console.ReadLine(), out deposits) || deposits < 0)
        {
            Console.WriteLine("Invalid deposits.");
            return;
        }

        Console.Write("Enter Total Withdrawals: ");
        if (!double.TryParse(Console.ReadLine(), out withdrawals) || withdrawals < 0)
        {
            Console.WriteLine("Invalid withdrawals.");
            return;
        }

        double availableBalance = openingBalance + deposits;

        if (withdrawals > availableBalance)
        {
            Console.WriteLine("Error: Withdrawal exceeds available balance.");
            return;
        }

        double finalBalance = availableBalance - withdrawals;

        Console.WriteLine($"\nFinal Balance: {Math.Round(finalBalance, 2)}");
    }
}