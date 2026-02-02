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
    /// Represents a student with marks and calculated average.
    /// </summary>
    class Student(string? name, double marks1, double marks2)
    {
        public string? Name { get; set; } = name;
        public double Marks1 { get; set; } = marks1;
        public double Marks2 { get; set; } = marks2;

        public double Average => (Marks1 + Marks2) / 2;
    }

    #endregion

    #region Program

    class Program
    {
        #region Events

        /// <summary>
        /// Event raised when a student requires improvement.
        /// </summary>
        public event NotifyStudent? ImprovementRequired;

        /// <summary>
        /// Event raised when a student achieves distinction.
        /// </summary>
        public event NotifyStudent? DistinctionAchieved;

        #endregion

        #region Entry Point

        /// <summary>
        /// Application entry point.
        /// </summary>
        static void Main()
        {
            // Create Program instance
            Program app = new Program();

            // Execute application workflow
            app.Run();
        }

        #endregion

        #region Application Flow

        /// <summary>
        /// Controls the overall application flow.
        /// </summary>
        void Run()
        {
            var students = GetStudents();

            SubscribeNotifications();

            DisplayTopStudents(students, count: 5);

            EvaluateStudents(students);
        }

        #endregion

        #region Data Initialization

        /// <summary>
        /// Creates and returns the list of students.
        /// </summary>
        List<Student> GetStudents()
        {
            return
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
        }

        #endregion

        #region Event Subscription

        /// <summary>
        /// Subscribes handlers to student notification events.
        /// </summary>
        void SubscribeNotifications()
        {
            ImprovementRequired += (name, average) =>
                Console.WriteLine($"{name}, your average is {average:F2}. You require improvement!");

            DistinctionAchieved += (name, average) =>
                Console.WriteLine($"{name}, congratulations! You achieved distinction with {average:F2}");
        }

        #endregion

        #region Display Logic

        /// <summary>
        /// Displays the top-performing students.
        /// </summary>
        void DisplayTopStudents(List<Student> students, int count)
        {
            var topStudents = students
                .OrderByDescending(s => s.Average)
                .Take(count);

            Console.WriteLine("Top Students:\n");
            Console.WriteLine($"{"Name",-10} {"Marks1",8} {"Marks2",8} {"Average",10}");
            Console.WriteLine(new string('-', 40));

            foreach (var student in topStudents)
            {
                Console.WriteLine(
                    $"{student.Name,-10} {student.Marks1,8} {student.Marks2,8} {student.Average,10:F2}");
            }
        }

        #endregion

        #region Evaluation Logic

        /// <summary>
        /// Evaluates students and raises appropriate events.
        /// </summary>
        void EvaluateStudents(List<Student> students)
        {
            Console.WriteLine("\n--- Student Notifications ---\n");

            foreach (var student in students)
            {
                if (student.Average < 75)
                {
                    ImprovementRequired?.Invoke(student.Name!, student.Average);
                }
                else if (student.Average > 90)
                {
                    DistinctionAchieved?.Invoke(student.Name!, student.Average);
                }
            }
        }

        #endregion
    }

    #endregion
}

namespace PracticeSessions
{
    public delegate void Notify();
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public int CompareTo(Student? other)
        {
            return other.Marks.CompareTo(this.Marks);
        }

        public event Notify OnNotify;

        public void NeedImpovement()
        {
            Console.WriteLine("Need Impovement");
        }

        public void GoodStudent()
        {
            Console.WriteLine("Good Student");
        }

        public void AverageStudent()
        {
            Console.WriteLine("Average Student");
        }

        public void SendNotification(Student s)
        {
            OnNotify = null;

            if (s.Marks <= 500)
            {
                OnNotify = NeedImpovement;
            }
            else if (s.Marks >= 560)
            {
                OnNotify = GoodStudent;
            }
            else
            {
                OnNotify = AverageStudent;
            }
            OnNotify?.Invoke();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            List<Student> students = new List<Student>();
            students.Add(new Student
            {
                Name = "Vishwajeet",
                Marks = 500
            });
            students.Add(new Student
            {
                Name = "Thiluck",
                Marks = 450
            });
            students.Add(new Student
            {
                Name = "Pratham",
                Marks = 550
            });
            students.Add(new Student
            {
                Name = "Harsha",
                Marks = 600
            });
            students.Add(new Student
            {
                Name = "Annu",
                Marks = 560
            });
            students.Sort();
            int rank = 1;
            foreach(Student student in students)
            {
                Console.Write($"Rank = {rank++} Name = {student.Name}, Marks = {student.Marks}, Remarks: ");
                s.SendNotification(student);
                Console.WriteLine();
            }
        }
    }
}