// using System;

// public class BankException(string s) : Exception(s)
// {
// }


// public class BankAccount
// {
//     static void Main()
//     {
//         int balance = 20000;

//         Console.WriteLine("Enter withdrawal amount:");
//         int amount = int.Parse(Console.ReadLine()!);

//         try
//         {
//             // 1. Throw exception if amount <= 0 
//             if (amount <= 0)
//             {
//                 throw new BankException("Withdrawal amount must be greater than zero.");
//             }

//             // 2. Throw exception if amount > balance
//             if (amount > balance)
//             {
//                 throw new BankException("Insufficient balance.");
//             }

//             // 3. Deduct amount if valid
//             balance -= amount;
//             Console.WriteLine($"Withdrawal successful. Remaining balance: {balance}");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Error: {ex.Message}");
//         }
//         finally
//         {
//             // 4. Log transaction
//             Console.WriteLine("Transaction attempt logged.");
//         }
//     }
// }
