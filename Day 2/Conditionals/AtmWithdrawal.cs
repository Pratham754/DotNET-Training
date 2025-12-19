using System;
namespace Github
{
    public class AtmWithdrawal
    {
        public static string WithdrawMoney(bool isCardInserted, bool isPinValid, decimal accountBalance, decimal withdrawalAmount)
        {
            if (isCardInserted)
            {
                if (isPinValid)
                {
                    if (accountBalance >= withdrawalAmount)
                    {
                        accountBalance -= withdrawalAmount;
                        return $"Withdrawal successful! New balance: {accountBalance:C}";
                    }
                    else
                    {
                        return "Insufficient balance for the requested withdrawal amount.";
                    }
                }
                else
                {
                    return "Invalid PIN. Please try again.";
                }
            }
            else
            {
                return "Please insert your card to proceed.";
            }
        }
    }
}