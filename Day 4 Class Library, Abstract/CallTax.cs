using System;
namespace MyConsoleApp.TaxCalculation
{
    public class CallEmployee{
        public static void Main()
        {
            IndianEmployee emp1 = new(1,"Pratham",21,65000);
            double tax1 = emp1.CalculateTax();
            Console.WriteLine($"Employee: {emp1.EmployeeName}, Country: India, Tax: {tax1}");

            USEmployee emp2 = new(2,"John",25,70000);
            double tax2 = emp2.CalculateTax();
            Console.WriteLine($"Employee: {emp2.EmployeeName}, Country: USA, Tax: {tax2}");
        }

    }
}