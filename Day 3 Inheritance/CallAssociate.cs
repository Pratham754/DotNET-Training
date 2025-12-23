namespace MyConsoleApp.CallAssociate
{
    /// <summary>
    /// Represents a call associate with details like Id, Name, and Rank.
    /// </summary>
    public class CallAssociate
    {
        #region Fields

        private int id;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the unique identifier for the call associate.
        /// Ensures the ID is greater than zero; otherwise, it throws an ArgumentException.
        /// </summary>
        public int Id
        {
            set
            {
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    id = 0;
                    throw new System.ArgumentException("Employee Id must be greater than zero.");
                }
            }
        }

        /// <summary>
        /// Gets the name of the call associate.
        /// </summary>
        public string? Name { get; }

        /// <summary>
        /// Gets the rank of the call associate.
        /// </summary>
        public string? Rank { get; }

        /// <summary>
        /// Logs any history or errors related to the call associate's creation.
        /// </summary>
        public string? LogHistory { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor for the CallAssociate class.
        /// Initializes with default values.
        /// </summary>
        public CallAssociate() : this(0, string.Empty, string.Empty)
        {
        }

        /// <summary>
        /// Parameterized constructor for the CallAssociate class.
        /// Initializes the associate with the specified id, name, and rank.
        /// </summary>
        /// <param name="id">The unique identifier for the associate.</param>
        /// <param name="name">The name of the associate.</param>
        /// <param name="rank">The rank of the associate.</param>
        public CallAssociate(int id, string name, string rank)
        {
            // Initialize LogHistory if any invalid inputs are detected
            if (id <= 0)
                LogHistory += $"Invalid Id provided at {DateTime.Now}  {Environment.NewLine}.";

            if (string.IsNullOrWhiteSpace(name))
                LogHistory += $"Invalid Name provided at {DateTime.Now}  {Environment.NewLine}.";

            if (string.IsNullOrWhiteSpace(rank))
                LogHistory += $"Invalid Rank provided at {DateTime.Now}  {Environment.NewLine}.";

            // If there are any log history entries, throw an exception
            if (LogHistory != null && LogHistory.Length > 0)
                throw new ArgumentException(LogHistory);

            // Set properties if valid
            Id = id;
            Name = name;
            Rank = rank;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Displays the details of the call associate.
        /// </summary>
        /// <returns>A string containing the associate's Id, Name, and Rank.</returns>
        public string DisplayDetails()
        {
            return $"Id: {id}, Name: {Name}, Rank: {Rank}";
        }

        #endregion
    }
}
