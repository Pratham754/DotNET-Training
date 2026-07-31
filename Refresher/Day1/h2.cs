using System;

class Employee
{
    public string Name { get; set; }
    public double HoursWorked { get; set; }
    public double HourlyRate { get; set; }
}

class PayrollCalculator
{
    public double CalculateRegularPay(Employee emp)
    {
        if (emp.HoursWorked <= 40)
            return emp.HoursWorked * emp.HourlyRate;

        return 40 * emp.HourlyRate;
    }

    public double CalculateOvertimePay(Employee emp)
    {
        if (emp.HoursWorked > 40)
        {
            double overtimeHours = emp.HoursWorked - 40;
            return overtimeHours * emp.HourlyRate * 1.5;
        }

        return 0;
    }

    public double CalculateGrossSalary(Employee emp)
    {
        return CalculateRegularPay(emp) + CalculateOvertimePay(emp);
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();

        Console.Write("Enter Employee Name: ");
        emp.Name = Console.ReadLine();

        Console.Write("Enter Hours Worked: ");
        if (!double.TryParse(Console.ReadLine(), out double hours) || hours < 0 || hours > 168)
        {
            Console.WriteLine("Invalid hours worked.");
            return;
        }

        emp.HoursWorked = hours;

        Console.Write("Enter Hourly Rate: ");
        if (!double.TryParse(Console.ReadLine(), out double rate) || rate <= 0)
        {
            Console.WriteLine("Invalid hourly rate.");
            return;
        }

        emp.HourlyRate = rate;

        PayrollCalculator payroll = new PayrollCalculator();

        double regularPay = payroll.CalculateRegularPay(emp);
        double overtimePay = payroll.CalculateOvertimePay(emp);
        double grossSalary = payroll.CalculateGrossSalary(emp);

        Console.WriteLine("\n----- Payroll Details -----");
        Console.WriteLine($"Employee Name : {emp.Name}");
        Console.WriteLine($"Regular Pay   : {Math.Round(regularPay, 2)}");
        Console.WriteLine($"Overtime Pay  : {Math.Round(overtimePay, 2)}");
        Console.WriteLine($"Gross Salary  : {Math.Round(grossSalary, 2)}");
    }
}