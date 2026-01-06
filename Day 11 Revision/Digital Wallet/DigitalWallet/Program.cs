// using System;
// using DigitalWallet.Core;

// namespace DigitalWalletApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             WalletData wallet1 = new WalletData();
//             wallet1.Balance = 1000m;

//             decimal copiedBalance = wallet1.Balance;
//             copiedBalance = copiedBalance + 500;

//             Console.WriteLine("Original Wallet Balance: " + wallet1.Balance);
//             Console.WriteLine("Copied Balance Value: " + copiedBalance);

//             WalletData wallet2 = new WalletData();
//             wallet2.RecentTransactions = new decimal[2];
//             wallet2.RecentTransactions[0] = 200;
//             wallet2.RecentTransactions[1] = 300;

//             decimal[] copiedTransactions = wallet2.RecentTransactions;
//             copiedTransactions[0] = 999;

//             Console.WriteLine("Original Transaction Value: " + wallet2.RecentTransactions[0]);
//             Console.WriteLine("Copied Transaction Value: " + copiedTransactions[0]);

//         }
//     }
// }


using System;

namespace DigitalWalletApp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 5000m;

            object boxedBalance = balance;   // BOXING

            Console.WriteLine("Boxed Balance: " + boxedBalance.GetType());
        }
    }
}