// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace MyConsoleApp
// {
//     #region Models

//     public class Employee(
//         string employeeId,
//         string name,
//         string department,
//         double salary,
//         DateTime joiningDate)
//     {
//         public string EmployeeId { get; set; } = employeeId;
//         public string Name { get; set; } = name;
//         public string Department { get; set; } = department;
//         public double Salary { get; set; } = salary;
//         public DateTime JoiningDate { get; set; } = joiningDate;
//     }

//     #endregion

//     #region Interfaces

//     public interface IEmployee
//     {
//         string EmployeeId { get; set; }
//         string Name { get; set; }
//         string Department { get; set; }
//         double Salary { get; set; }
//         DateTime JoiningDate { get; set; }
//     }

//     public interface IHRManager
//     {
//         static abstract void AddEmployee(string name, string dept, double salary);

//         SortedDictionary<string, List<Employee>> GroupEmployeesByDepartment();

//         double CalculateDepartmentSalary(string department);

//         List<Employee> GetEmployeesJoinedAfter(DateTime date);
//     }

//     #endregion

//     #region Services

//     public class HRManager : IHRManager
//     {
//         // Shared in-memory employee list
//         private static readonly List<Employee> _employees = [];
//         private static int _employeeCounter = 1;

//         /// <summary>
//         /// Adds a new employee with auto-generated EmployeeId.
//         /// </summary>
//         public static void AddEmployee(string name, string dept, double salary)
//         {
//             string employeeId = $"E{_employeeCounter:000}";
//             _employeeCounter++;

//             _employees.Add( new Employee(employeeId,name,dept,salary,DateTime.Now));
//         }

//         /// <summary>
//         /// Groups employees by department.
//         /// </summary>
//         public SortedDictionary<string, List<Employee>> GroupEmployeesByDepartment()
//         {
//             return new SortedDictionary<string, List<Employee>>(
//                 _employees
//                     .GroupBy(e => e.Department)
//                     .ToDictionary(g => g.Key, g => g.ToList())
//             );
//         }

//         /// <summary>
//         /// Calculates total salary for a given department.
//         /// </summary>
//         public double CalculateDepartmentSalary(string department)
//         {
//             return _employees
//                 .Where(e =>
//                     e.Department.Equals(department, StringComparison.OrdinalIgnoreCase))
//                 .Sum(e => e.Salary);
//         }

//         /// <summary>
//         /// Returns employees who joined after a specific date.
//         /// </summary>
//         public List<Employee> GetEmployeesJoinedAfter(DateTime date)
//         {
//             return _employees
//                 .Where(e => e.JoiningDate > date)
//                 .ToList();
//         }
//     }

//     #endregion

//     #region Application Entry Point

//     public class Program
//     {
//         /// <summary>
//         /// Entry point of the Employee Management console application.
//         /// </summary>
//         public static void Main()
//         {
//             HRManager manager = new();
//             bool running = true;

//             while (running)
//             {
//                 Console.WriteLine("\n=== Employee Management System ===");
//                 Console.WriteLine("1. Add Employee");
//                 Console.WriteLine("2. Group Employees by Department");
//                 Console.WriteLine("3. Calculate Department Salary");
//                 Console.WriteLine("4. Get Employees Joined After Date");
//                 Console.WriteLine("5. Exit");
//                 Console.Write("Enter your choice: ");

//                 string? choice = Console.ReadLine();
//                 Console.WriteLine();

//                 switch (choice)
//                 {
//                     case "1":
//                         Console.Write("Employee Name: ");
//                         string name = Console.ReadLine()!;

//                         Console.Write("Department: ");
//                         string dept = Console.ReadLine()!;

//                         Console.Write("Salary: ");
//                         double salary = double.Parse(Console.ReadLine()!);

//                         HRManager.AddEmployee(name, dept, salary);
//                         Console.WriteLine("Employee added successfully.");
//                         break;

//                     case "2":
//                         var grouped = manager.GroupEmployeesByDepartment();

//                         foreach (var group in grouped)
//                         {
//                             Console.WriteLine($"\nDepartment: {group.Key}");
//                             foreach (var emp in group.Value)
//                             {
//                                 Console.WriteLine(
//                                     $"ID: {emp.EmployeeId}, Name: {emp.Name}, " +
//                                     $"Salary: {emp.Salary}, Joined: {emp.JoiningDate:dd-MM-yyyy}"
//                                 );
//                             }
//                         }
//                         break;

//                     case "3":
//                         Console.Write("Enter Department Name: ");
//                         string department = Console.ReadLine()!;

//                         double totalSalary = manager.CalculateDepartmentSalary(department);
//                         Console.WriteLine(
//                             $"Total Salary for {department}: {totalSalary}"
//                         );
//                         break;

//                     case "4":
//                         Console.Write("Enter Date (yyyy-mm-dd): ");
//                         DateTime date = DateTime.Parse(Console.ReadLine()!);

//                         var employees = manager.GetEmployeesJoinedAfter(date);

//                         if (employees.Count == 0)
//                         {
//                             Console.WriteLine("No employees found.");
//                         }
//                         else
//                         {
//                             foreach (var emp in employees)
//                             {
//                                 Console.WriteLine(
//                                     $"ID: {emp.EmployeeId}, Name: {emp.Name}, " +
//                                     $"Department: {emp.Department}, Joined: {emp.JoiningDate:dd-MM-yyyy}"
//                                 );
//                             }
//                         }
//                         break;

//                     case "5":
//                         running = false;
//                         Console.WriteLine("Exiting application.");
//                         break;

//                     default:
//                         Console.WriteLine("Invalid choice. Try again.");
//                         break;
//                 }
//             }
//         }
//     }

//     #endregion
// }