// using System;

// /// <summary>
// /// Base class representing a user.
// /// </summary>
// public class User
// {
//     public int Id { get; set; }
//     public string? Name { get; set; }
// }

// /// <summary>
// /// Student inherits from User.
// /// </summary>
// public class Student : User
// {
// }

// /// <summary>
// /// Employee inherits from User.
// /// </summary>
// public class Employee : User
// {
//     public string? Designation { get; set; }
// }

// /// <summary>
// /// Examiner evaluates exams.
// /// </summary>
// public class Examiner : Employee
// {
//     public void EvaluateExam()
//     {
//         Console.WriteLine($"Examiner is {Name}");
//     }
// }

// /// <summary>
// /// Represents an academic semester.
// /// </summary>
// public class Semester
// {
//     public int SemesterNo { get; set; }
// }

// /// <summary>
// /// Represents an exam.
// /// </summary>
// public class Exam
// {
//     public int ExamId { get; set; }
//     public DateTime ExamDate { get; set; }
//     public string? ExamRoom { get; set; }
//     public Examiner? AssignedExaminer { get; set; }
// }

// /// <summary>
// /// Holds scheduled exam details.
// /// </summary>
// public class ExamSchedule
// {
//     public Semester Semester { get; set; } = new();
//     public Exam Exam { get; set; } = new();

//     public void DisplaySchedule()
//     {
//         Console.WriteLine($"Semester: {Semester.SemesterNo}");
//         Console.WriteLine($"Exam ID: {Exam.ExamId}");
//         Console.WriteLine($"Date: {Exam.ExamDate:yyyy-MM-dd}");
//         Console.WriteLine($"Room: {Exam.ExamRoom}");
//         Console.WriteLine($"Examiner: {Exam.AssignedExaminer?.Name}");
//     }
// }

// /// <summary>
// /// Head of Department.
// /// </summary>
// public class HOD : Employee
// {
//     public ExamSchedule ScheduleExam(Semester semester, Exam exam)
//     {
//         Console.WriteLine($"HOD {Name} scheduled exam for Semester {semester.SemesterNo}");
//         return new ExamSchedule { Semester = semester, Exam = exam };
//     }

//     public void AssignExaminer(Exam exam, Examiner examiner)
//     {
//         exam.AssignedExaminer = examiner;
//         Console.WriteLine($"Examiner {examiner.Name} assigned to Exam {exam.ExamId}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         HOD hod = new();
//         Console.Write("Enter HOD ID: ");
//         int.TryParse(Console.ReadLine(), out int hodId);
//         hod.Id = hodId;

//         Console.Write("Enter HOD Name: ");
//         hod.Name = Console.ReadLine();
//         hod.Designation = "HOD";

//         Semester semester = new();
//         Console.Write("\nEnter Semester Number: ");
//         int.TryParse(Console.ReadLine(), out int semNo);
//         semester.SemesterNo = semNo;

//         Examiner examiner = new();
//         Console.Write("\nEnter Examiner ID: ");
//         int.TryParse(Console.ReadLine(), out int exId);
//         examiner.Id = exId;

//         Console.Write("Enter Examiner Name: ");
//         examiner.Name = Console.ReadLine();
//         examiner.Designation = "Examiner";

//         Exam exam = new();
//         Console.Write("\nEnter Exam ID: ");
//         int.TryParse(Console.ReadLine(), out int examId);
//         exam.ExamId = examId;

//         Console.Write("Enter Exam Date (yyyy-mm-dd): ");
//         DateTime.TryParse(Console.ReadLine(), out DateTime date);
//         exam.ExamDate = date;

//         Console.Write("Enter Exam Room: ");
//         exam.ExamRoom = Console.ReadLine();

//         hod.AssignExaminer(exam, examiner);
//         ExamSchedule schedule = hod.ScheduleExam(semester, exam);

//         schedule.DisplaySchedule();
//     }
// }
