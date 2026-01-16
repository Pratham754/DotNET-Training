// namespace MyConsoleApp
// {
//     public class EcommerceShop
//     {
//         public string? UserName { get; set; }
//         public double WalletBalance { get; set; }
//         public double TotalPurchaseAmount { get; set; }
//     }
//     public class InsufficientWalletBalanceException(string message) : Exception(message)
//     {
//     }
//     public class Program
//     {
//         public static EcommerceShop MakePayment(string? name, double balance, double amount)
//         {
//             if (balance < amount)
//             {
//                 throw new InsufficientWalletBalanceException("Insufficient balance in your digital wallet");
//             }

//             return new EcommerceShop
//             {
//                 UserName = name,
//                 WalletBalance = balance - amount,
//                 TotalPurchaseAmount = amount
//             };
//         }

//         public static void Main()
//         {
//             Program p = new();

//             Console.Write("Enter user name: ");
//             string? name = Console.ReadLine();

//             Console.Write("Enter wallet balance: ");
//             double balance = double.Parse(Console.ReadLine());

//             Console.Write("Enter purchase amount: ");
//             double amount = double.Parse(Console.ReadLine());

//             try
//             {
//                 EcommerceShop shop = MakePayment(name, balance, amount);
//                 Console.WriteLine("Payment successful");
//             }
//             catch (InsufficientWalletBalanceException ex)
//             {
//                 Console.WriteLine(ex.Message);
//             }
//         }
//     }
// }