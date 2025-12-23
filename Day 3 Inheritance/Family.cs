namespace MyConsoleApp
{
    /// <summary>
    /// Represents a Father class demonstrating method overriding.
    /// </summary>
    public class Father
    {
        #region Methods

        /// <summary>
        /// Returns the interest of the father.
        /// Marked virtual to allow overriding in derived classes.
        /// </summary>
        /// <returns>A string describing the father's interest.</returns>
        public virtual string InterestOn()
        {
            return "I am interested in investing in real estate.";
        }

        #endregion

        /// <summary>
        /// Represents a Son class inheriting from Father.
        /// Demonstrates method overriding.
        /// </summary>
        public class Son : Father
        {
            #region Methods

            /// <summary>
            /// Overrides the father's interest with the son's interest.
            /// </summary>
            /// <returns>A string describing the son's interest.</returns>
            public override string InterestOn()
            {
                return "I am interested in football.";
            }

            #endregion
        }
    }
}
