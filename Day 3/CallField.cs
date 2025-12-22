namespace MyConsoleApp.FieldEx
{
    public class CallField
    {
        public static void Main(string[] args)
        {
            Employee emp = new()
            {
                Id = 1
            };
            System.Console.WriteLine(emp.DisplayEmpDetails());
        }
    }
}
