// // As a HOD, I want to schedule exam for every semester and assign Examiner to each exam

// using System;

// namespace MyConsoleApp
// {
//     public class Employee
//     {
//         public int EmployeeId { get; set; }
//     }

//     public class Examiner : Employee
//     {
//         public int ExaminerId { get; set; }
//         public string? ExaminerName { get; set; }
//     }

//     public class HOD : Employee
//     {
//         public int HODId { get; set; }
//         public string? HODName { get; set; }
//     }

//     public class Student
//     {
//         public int StudentId { get; set; }
//         public string? StudentName { get; set; }
//         public int Semester { get; set; }
//     }

//     public class Exam
//     {
//         public int ExamId { get; set; }
//         public string? Subject { get; set; }
//         public DateTime ExamDate { get; set; }
//         public Examiner? AssignedExaminer { get; set; }
//     }
// }