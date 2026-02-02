using System;
using System.Collections.Generic;
using System.Linq;

namespace MyConsoleApp
{
    #region Delegates

    /// <summary>
    /// Represents a notification action for a student.
    /// </summary>
    delegate void NotifyStudent(string name, double average);

    #endregion

    #region Models

    /// <summary>
    /// Represents a student with marks, average, and notification events.
    /// </summary>
    class Student
    {
        #region Properties

        public string Name { get; set; }
        public double Marks1 { get; set; }
        public double Marks2 { get; set; }

        /// <summary>
        /// Calculates and returns the average marks.
        /// </summary>
        public double Average => (Marks1 + Marks2) / 2;

        #endregion

        #region Events

        /// <summary>
        /// Raised when the student requires improvement.
        /// </summary>
        public event NotifyStudent? ImprovementRequired;

        /// <summary>
        /// Raised when the student achieves distinction.
        /// </summary>
        public event NotifyStudent? DistinctionAchieved;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new student with marks.
        /// </summary>
        public Student(string name, double marks1, double marks2)
        {
            Name = name;
            Marks1 = marks1;
            Marks2 = marks2;
        }

        #endregion

        #region Evaluation Logic

        /// <summary>
        /// Evaluates the student using a Func delegate and raises events accordingly.
        /// </summary>
        public void Evaluate(Func<Student, string> evaluationLogic)
        {
            string result = evaluationLogic(this);

            if (result == "Improvement")
                ImprovementRequired?.Invoke(Name, Average);
            else if (result == "Distinction")
                DistinctionAchieved?.Invoke(Name, Average);
        }

        #endregion
    }

    #endregion

    #region Program

    class Program
    {
        #region Entry Point

        /// <summary>
        /// Application entry point.
        /// </summary>
        public static void Main()
        {
            var students = GetStudents();
            SubscribeEvents(students);
            DisplayTopStudents(students, 5);
            EvaluateStudents(students);
            DemonstrateDelegates(students);
        }

        #endregion

        #region Data Initialization

        /// <summary>
        /// Creates and returns the list of students.
        /// </summary>
        static List<Student> GetStudents() =>
        [
            new("Harsh", 85, 91),
            new("Ali", 75, 80),
            new("Tillu", 95, 92),
            new("Annu", 88, 87),
            new("Vishu", 92, 94),
            new("Om", 38, 40),
            new("Pratham", 98, 96),
            new("Swaraj", 75, 73),
            new("Rohith", 76, 56)
        ];

        #endregion

        #region Event Subscription

        /// <summary>
        /// Subscribes notification handlers for each student.
        /// </summary>
        static void SubscribeEvents(List<Student> students)
        {
            foreach (var s in students)
            {
                s.ImprovementRequired += (name, avg) =>
                    Console.WriteLine($"{name}, average {avg:F2} – needs improvement.");

                s.DistinctionAchieved += (name, avg) =>
                    Console.WriteLine($"{name}, average {avg:F2} – distinction achieved!");
            }
        }

        #endregion

        #region Evaluation

        /// <summary>
        /// Evaluates students using Func delegate rules.
        /// </summary>
        static void EvaluateStudents(List<Student> students)
        {
            Console.WriteLine("\n--- Student Evaluation ---\n");

            // FUNC delegate determines evaluation result
            Func<Student, string> evaluationRule = s =>
            {
                if (s.Average < 75) return "Improvement";
                if (s.Average > 90) return "Distinction";
                return "Normal";
            };

            students.ForEach(s => s.Evaluate(evaluationRule));
        }

        #endregion

        #region Display Logic

        /// <summary>
        /// Displays the top-performing students.
        /// </summary>
        static void DisplayTopStudents(List<Student> students, int count)
        {
            Console.WriteLine("\nTop Students:\n");

            var top = students
                .OrderByDescending(s => s.Average)
                .Take(count);

            Console.WriteLine($"{"Name",-10} {"Marks1",8} {"Marks2",8} {"Average",10}");
            foreach (var s in top)
                Console.WriteLine($"{s.Name,-10} {s.Marks1,8} {s.Marks2,8} {s.Average,10:F2}");
        }

        #endregion

        #region Delegate Demonstrations

        /// <summary>
        /// Demonstrates Action and Predicate delegates.
        /// </summary>
        static void DemonstrateDelegates(List<Student> students)
        {
            Console.WriteLine("\n--- Action Delegate Examples ---\n");

            // ACTION: perform an operation
            Action<Student> printStudent =
                s => Console.WriteLine($"{s.Name}: {s.Average:F2}");

            students.ForEach(printStudent);

            Console.WriteLine("\n--- Predicate Delegate Examples ---\n");
            
            // PREDICATE: filter condition
            Predicate<Student> isTopStudent = s => s.Average > 90;

            Console.WriteLine("Top Students (>90):");
            students.FindAll(isTopStudent)
                    .ForEach(s => Console.WriteLine($"  {s.Name}"));
        }

        #endregion
    }

    #endregion
}