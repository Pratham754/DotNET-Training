namespace MyConsoleApp
{
    public class AppCustomException : Exception
    {
        public override string Message => HandleBase(base.Message);

        private string HandleBase(string sysMessage)
        {
            System.Console.WriteLine(sysMessage);
            return "Internal Exception Occurred. Please contact Administrator.";
        }
    }

    public class Program
    {
        public static void Main()
        {
            try
            {
                int result = Divide(10, 0);
                System.Console.WriteLine(result);
            }
            catch (AppCustomException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        public static int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch
            {
                throw new AppCustomException();
            }
        }
    }
}
