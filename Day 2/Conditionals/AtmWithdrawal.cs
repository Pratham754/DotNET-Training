using System;

namespace Github
{
    /// <summary>
    /// This class simulates an ATM withdrawal process by validating
    /// card insertion, PIN correctness, and account balance.
    /// </summary>
    public class AtmWithdrawal
    {
        /// <summary>
        /// Attempts to withdraw money from an account based on ATM conditions.
        /// </summary>
        /// <param name="isCardInserted">Indicates whether the ATM card is inserted.</param>
        /// <param name="isPinValid">Indicates whether the entered PIN is valid.</param>
        /// <param name="accountBalance">The current account balance.</param>
        /// <param name="withdrawalAmount">The amount requested for withdrawal.</param>
        /// <returns>A message describing the result of the withdrawal attempt.</returns>
        public static string WithdrawMoney(bool isCardInserted, bool isPinValid, decimal accountBalance, decimal withdrawalAmount)
        {
            #region Card Validation Section
            // Check whether the card is inserted into the ATM
            if (isCardInserted)
            {
                #region PIN Validation Section
                // Check whether the entered PIN is valid
                if (isPinValid)
                {
                    #region Balance Verification Section
                    // Check if the account has sufficient balance
                    if (accountBalance >= withdrawalAmount)
                    {
                        // Deduct the withdrawal amount from the balance
                        accountBalance -= withdrawalAmount;

                        // Return success message with updated balance
                        return $"Withdrawal successful! New balance: {accountBalance:C}";
                    }
                    else
                    {
                        // Handle insufficient balance case
                        return "Insufficient balance for the requested withdrawal amount.";
                    }
                    #endregion
                }
                else
                {
                    // Handle invalid PIN case
                    return "Invalid PIN. Please try again.";
                }
                #endregion
            }
            else
            {
                // Handle case where card is not inserted
                return "Please insert your card to proceed.";
            }
            #endregion
        }
    }
}
