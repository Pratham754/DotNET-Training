namespace MyConsoleApp.Account
{
    /// <summary>
    /// Base class representing a general account.
    /// </summary>
    public class Account
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unique identifier for the account.
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// Gets or sets the name of the account.
        /// </summary>
        public string? AccountName { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Retrieves the details of the base account.
        /// </summary>
        /// <returns>A string containing the account ID details.</returns>
        public string GetAccountDetails()
        {
            return $"I am base account. My Id is {AccountId}";
        }

        #endregion
    }

    /// <summary>
    /// Represents a sales-specific account that inherits from the base account.
    /// </summary>
    public class SalesAccount : Account
    {
        #region Properties

        /// <summary>
        /// Gets or sets sales account-specific information.
        /// </summary>
        public string? SalesInfo { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Retrieves details for the sales account.
        /// </summary>
        /// <returns>A string with both base account and sales-specific details.</returns>
        public string GetSalesAccountDetails()
        {
            // Get base account details
            string? info = base.GetAccountDetails();

            // Append sales-specific information
            info += "\n" + "This is sales account specific info.";

            return info;
        }

        #endregion
    }

    /// <summary>
    /// Represents a purchase-specific account that inherits from the base account.
    /// </summary>
    public class PurchaseAccount : Account
    {
        #region Properties

        /// <summary>
        /// Gets or sets purchase account-specific information.
        /// </summary>
        public string? PurchaseInfo { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Retrieves details for the purchase account.
        /// </summary>
        /// <returns>A string with both base account and purchase-specific details.</returns>
        public string GetPurchaseAccountDetails()
        {
            // Get base account details
            string? info = base.GetAccountDetails();

            // Append purchase-specific information
            info += "\n" + "This is purchase account specific info.";

            return info;
        }

        #endregion
    }
}
