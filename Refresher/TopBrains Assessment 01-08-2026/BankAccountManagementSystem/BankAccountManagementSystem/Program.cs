using System.Security.Principal;

namespace BankAccountManagementSystem
{
    public class Account
    {
        private string name;
        private double balance;

        public Account(string name, double initialBalance){
            this.name = name;
            this.balance = initialBalance;
        }

        public double deposit(double amount){
            balance += amount;
            return balance;
        }

        public double getBalance(){
            return balance;
        }

        public void setName(string newName){
            name = newName;
        }

        public string getName(){
            return name;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Alok Mittal", 1250.00);
            Console.WriteLine(account1.getBalance());

            Account account2 = new Account("John Doe", 500);
            Console.WriteLine(account2.getName());
            Console.WriteLine(account2.getBalance());

            Account account3 = new Account("Riya", 1200.5);
            Console.WriteLine(account3.deposit(50));
            Console.WriteLine(account3.getBalance());

            account3.setName("Riya Amit Mehta ");
            Console.WriteLine(account3.getName());
        }
    }
}
