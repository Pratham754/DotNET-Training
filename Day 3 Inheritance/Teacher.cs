using System;
namespace MyConsoleApp
{
    public class Student(string name, string hometown, int age)
    {
        public string Name { get; set; } = name;
        public string Hometown { get; set; } = hometown;
        public int Age { get; set; } = age;
    }

    // High School Student inherits from Student
    public class HighSchoolStudent(string name, string hometown, int age, string gradeLevel) : Student(name, hometown, age)
    {
        public string GradeLevel { get; set; } = gradeLevel;
    }

    // Undergraduate Student inherits from Student
    public class UGStudent(string name, string hometown, int age, string major) : Student(name, hometown, age)
    {
        public string Major { get; set; } = major;
    }

    // Postgraduate Student inherits from Student
    public class PGStudent(string name, string hometown, int age, string researchTopic) : Student(name, hometown, age)
    {
        public string ResearchTopic { get; set; } = researchTopic;
    }

    // Class to store records of students
    public class StudentRecord(string recordName)
    {
        public string RecordName { get; set; } = recordName;
        public List<Student> RegisteredStudents { get; set; } = [];

        // Register a student to the record
        public void RegisterStudent(Student student)
        {
            RegisteredStudents.Add(student);
        }

        // Get all students in the record
        public List<Student> GetAllStudents()
        {
            return RegisteredStudents;
        }
    }

    // Class to manage multiple student records
    public class StudentManager
    {
        public List<StudentRecord> StudentRecords { get; set; } = [];

        // Add a new student record
        public void AddStudentRecord(StudentRecord record)
        {
            StudentRecords.Add(record);
        }

        // Get all student records
        public List<StudentRecord> GetAllStudentRecords()
        {
            return StudentRecords;
        }
    }

    // Main Program
    public class Program
    {
        public static void Main(string[] args)
        {
            var manager = new StudentManager();

            // Record for High School Students
            var highSchoolRecord = new StudentRecord("High School Students");
            highSchoolRecord.RegisterStudent(new HighSchoolStudent("John", "HP", 16, "10th Grade"));
            highSchoolRecord.RegisterStudent(new HighSchoolStudent("Amit", "UP", 17, "12th Grade"));

            // Record for Undergraduate Students
            var ugRecord = new StudentRecord("Undergraduate Students");
            ugRecord.RegisterStudent(new UGStudent("Sara", "MP", 19, "Computer Science"));
            ugRecord.RegisterStudent(new UGStudent("Raj", "JK", 20, "Mechanical Engineering"));

            // Record for Postgraduate Students
            var pgRecord = new StudentRecord("Postgraduate Students");
            pgRecord.RegisterStudent(new PGStudent("Maya", "DL", 24, "Artificial Intelligence"));
            pgRecord.RegisterStudent(new PGStudent("Vikram", "WB", 25, "Data Science"));

            manager.AddStudentRecord(highSchoolRecord);
            manager.AddStudentRecord(ugRecord);
            manager.AddStudentRecord(pgRecord);

            // Display all student records
            var allRecords = manager.GetAllStudentRecords();
            foreach (var record in allRecords)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Record: {record.RecordName}");
                Console.WriteLine("------------------------------");
                foreach (var student in record.GetAllStudents())
                {
                    Console.WriteLine($"{student.Name} - {student.Hometown} - Age {student.Age}");
                    if (student is HighSchoolStudent hsStudent)
                    {
                        Console.WriteLine($"Grade Level: {hsStudent.GradeLevel}");
                    }
                    if (student is UGStudent ugStudent)
                    {
                        Console.WriteLine($"Major: {ugStudent.Major}");
                    }
                    if (student is PGStudent pgStudent)
                    {
                        Console.WriteLine($"Research Topic: {pgStudent.ResearchTopic}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
