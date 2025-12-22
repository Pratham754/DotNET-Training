using System;

namespace MyConsoleApp.ConstructorEx
{
    /// <summary>
    /// Demonstrates constructor concepts including default, parameterized,
    /// and constructor chaining.
    /// </summary>
    #region Constructor Chaining

    public class Visitor
    {
        #region Properties

        /// <summary>
        /// Gets or sets the visitor Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the visitor name.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the visitor requirement.
        /// </summary>
        public string? Requirement { get; set; }

        /// <summary>
        /// Maintains a log of constructor execution history.
        /// </summary>
        public string? LogHistory { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor.
        /// Initializes the object and logs creation time.
        /// </summary>
        public Visitor()
        {
            LogHistory += $"Object created on {DateTime.Now}  {Environment.NewLine}.";
        }

        /// <summary>
        /// Parameterized constructor that initializes the Id.
        /// Demonstrates constructor chaining.
        /// </summary>
        /// <param name="id">Visitor Id</param>
        public Visitor(int id) : this()
        {
            LogHistory += $"Id created at {DateTime.Now}  {Environment.NewLine}.";
            this.Id = id;
        }

        /// <summary>
        /// Parameterized constructor that initializes Id and Name.
        /// Includes validation for inappropriate words.
        /// </summary>
        /// <param name="id">Visitor Id</param>
        /// <param name="name">Visitor Name</param>
        public Visitor(int id, string name) : this(id)
        {
            if (name.ToLower().Contains("Idiot"))
                throw new ArgumentException("Name cannot contain inappropriate words.");

            LogHistory += $"Name created at {DateTime.Now}  {Environment.NewLine}.";
            this.Name = name;
        }

        /// <summary>
        /// Parameterized constructor that initializes Id, Name, and Requirement.
        /// </summary>
        /// <param name="id">Visitor Id</param>
        /// <param name="name">Visitor Name</param>
        /// <param name="requirement">Visitor Requirement</param>
        public Visitor(int id, string name, string requirement) : this(id, name)
        {
            LogHistory += $"Requirement created at {DateTime.Now}  {Environment.NewLine}.";
            System.Console.WriteLine(LogHistory);
            this.Requirement = requirement;
        }

        #endregion
    }

    #endregion
}
