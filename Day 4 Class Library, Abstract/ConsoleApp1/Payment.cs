using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Payment
    {
        public decimal Amount { get; }
        protected Payment(decimal amount) => Amount = amount;
        public void PrintReceipt()
        {
            Console.WriteLine($"Receipt Amount: {Amount}");
        }

        public abstract void Pay();
    }

    class UPIPayment : Payment
    {
        public string UpiId { get; }
        public UPIPayment(decimal amount, string upiId) : base(amount) => UpiId = upiId;

        public override void Pay()
        {
            Console.WriteLine($"Paid amount: {Amount} using UPI Id: {UpiId}");
        }
    }
}
