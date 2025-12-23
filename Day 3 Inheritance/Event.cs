using System;

namespace MyConsoleApp
{
    /// <summary>
    /// Represents an employee participating in competitions.
    /// Uses a primary constructor for initialization.
    /// </summary>
    public class Employee(string name, string email, int rank = 0)
    {
        #region Properties

        /// <summary>
        /// Gets or sets the employee name.
        /// </summary>
        public string Name { get; set; } = name;

        /// <summary>
        /// Gets or sets the employee email.
        /// </summary>
        public string Email { get; set; } = email;

        /// <summary>
        /// Gets or sets the employee rank in a competition.
        /// </summary>
        public int Rank { get; set; } = rank;

        #endregion
    }

    /// <summary>
    /// Represents a competition with registered employees.
    /// </summary>
    public class Competition(string competitionName)
    {
        #region Properties

        /// <summary>
        /// Gets or sets the competition name.
        /// </summary>
        public string CompetitionName { get; set; } = competitionName;

        /// <summary>
        /// Gets or sets the list of registered employees.
        /// </summary>
        public List<Employee> RegisteredEmployees { get; set; } = [];

        #endregion

        #region Methods

        /// <summary>
        /// Registers an employee for the competition.
        /// </summary>
        /// <param name="Employee">Employee to register</param>
        public void RegisterEmployee(Employee Employee)
        {
            RegisteredEmployees.Add(Employee);
        }

        /// <summary>
        /// Retrieves the top three winners based on rank.
        /// </summary>
        /// <returns>Sorted list of winning employees</returns>
        public List<Employee> GetWinners()
        {
            var winners = new List<Employee>();

            foreach (var emp in RegisteredEmployees)
            {
                if (emp.Rank >= 1 && emp.Rank <= 3)
                {
                    winners.Add(emp);
                }
            }

            winners.Sort((a, b) => a.Rank.CompareTo(b.Rank));
            return winners;
        }

        #endregion
    }

    /// <summary>
    /// Holds competition details along with its winners.
    /// </summary>
    public class CompetitionDetails(Competition competition)
    {
        #region Properties

        /// <summary>
        /// Gets or sets the competition.
        /// </summary>
        public Competition Competition { get; set; } = competition;

        /// <summary>
        /// Gets or sets the winners of the competition.
        /// </summary>
        public List<Employee> Winners { get; set; } = competition.GetWinners();

        #endregion
    }

    /// <summary>
    /// Manages multiple competitions and their results.
    /// </summary>
    public class CompetitionManager
    {
        #region Properties

        /// <summary>
        /// Gets or sets the list of competitions.
        /// </summary>
        public List<Competition> Competitions { get; set; } = [];

        #endregion

        #region Methods

        /// <summary>
        /// Adds a competition to the manager.
        /// </summary>
        /// <param name="competition">Competition to add</param>
        public void AddCompetition(Competition competition)
        {
            Competitions.Add(competition);
        }

        /// <summary>
        /// Retrieves results for all competitions.
        /// </summary>
        /// <returns>List of competition results</returns>
        public List<CompetitionDetails> GetAllCompetitionResults()
        {
            var results = new List<CompetitionDetails>();

            foreach (var competition in Competitions)
            {
                results.Add(new CompetitionDetails(competition));
            }

            return results;
        }

        #endregion
    }

    /// <summary>
    /// Entry point of the application.
    /// Demonstrates competition registration and result display.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var manager = new CompetitionManager();

            // Competition 1
            var math = new Competition("Math Olympiad");
            math.RegisterEmployee(new Employee("John", "john@gmail.com", 1));
            math.RegisterEmployee(new Employee("Amit", "amit@gmail.com", 4));

            // Competition 2
            var science = new Competition("Science Quiz");
            science.RegisterEmployee(new Employee("Sara", "sara@gmail.com", 2));
            science.RegisterEmployee(new Employee("Raj", "raj@gmail.com", 3));

            manager.AddCompetition(math);
            manager.AddCompetition(science);

            var results = manager.GetAllCompetitionResults();

            foreach (var result in results)
            {
                Console.WriteLine($"Competition: {result.Competition.CompetitionName}");
                Console.WriteLine("Winners:");

                foreach (var winner in result.Winners)
                {
                    Console.WriteLine($"{winner.Name} - Rank {winner.Rank}");
                }

                Console.WriteLine();
            }
        }
    }
}
