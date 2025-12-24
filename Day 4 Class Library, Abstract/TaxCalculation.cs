using System;

namespace MyConsoleApp.TaxCalculation
{
    #region Abstract Employee
    /// <summary>
    /// Base class for employees with tax calculation logic.
    /// </summary>
    public abstract class Employee(int employeeID, string? employeeName, int age, double basicSalary)
    {
        public int EmployeeID { get; set; } = employeeID;
        public string? EmployeeName { get; set; } = employeeName;
        public int Age { get; set; } = age;
        public double BasicSalary { get; set; } = basicSalary;

        /// <summary>
        /// Calculates tax for the employee.
        /// </summary>
        public abstract double CalculateTax();
    }
    #endregion

    #region Indian Employee
    /// <summary>
    /// Employee with Indian tax rules.
    /// </summary>
    public class IndianEmployee(int employeeID, string employeeName, int age, double basicSalary)
        : Employee(employeeID, employeeName, age, basicSalary)
    {
        public override double CalculateTax()
        {
            return (BasicSalary * 10) / 100;
        }
    }
    #endregion

    #region US Employee
    /// <summary>
    /// Employee with US tax rules.
    /// </summary>
    public class USEmployee(int employeeID, string employeeName, int age, double basicSalary)
        : Employee(employeeID, employeeName, age, basicSalary)
    {
        public override double CalculateTax()
        {
            return (BasicSalary * 15) / 100;
        }
    }
    #endregion
}
