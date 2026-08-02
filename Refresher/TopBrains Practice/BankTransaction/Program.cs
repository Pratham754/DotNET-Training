using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTransaction
{
    public class Program
    {
        public int Transactions(int initial, int[] transactions)
        {
            int balance = initial;
            foreach (int i in transactions)
            {
                if(i < 0)
                {
                    if (balance >= i) balance -= i;
                    else continue;
                }
                else
                {
                    balance += i;
                }
            }
            return balance;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int finalBalance = program.Transactions(5000,new int[]{1000,-4000,-500,2000,-5000,500 });

            Console.WriteLine(finalBalance);
        }
    }
}
