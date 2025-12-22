namespace MyConsoleApp.Account
{
    public class CallAccount
    {
        public static void Main()
        {
            Account acc = new(){ AccountId = 1, AccountName = "General Account" };
            var result = acc.GetAccountDetails();
            System.Console.WriteLine(result + "\n");

            SalesAccount salesAccount = new() { AccountId = 1, AccountName = "Balu", SalesInfo = "" };
            var result1=salesAccount.GetSalesAccountDetails();
            System.Console.WriteLine(result1 + "\n");

            PurchaseAccount purchaseAccount = new() { AccountId = 2, AccountName = "Kumar", PurchaseInfo = "" };
            var result2 = purchaseAccount.GetPurchaseAccountDetails();
            System.Console.WriteLine(result2);
        }
    }
}