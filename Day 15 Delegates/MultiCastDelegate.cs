using System;

namespace MyConsoleApp
{
    public delegate string MyDelegate(string message);

    public class PrintingCompany
    {
        public MyDelegate? MultiCastPrintMessage { get; set; }

        public void Print(string message)
        {
            if (MultiCastPrintMessage == null)
                return;

            foreach (MyDelegate handler in MultiCastPrintMessage.GetInvocationList())
            {
                string result = handler(message);
                Console.WriteLine(result);
            }
        }
    }

    public class MultiCastDelegate
    {
        public static void Main()
        {
            MyDelegate d = Method1;
            d += Method2;
            d += Method3;

            // This calls all three methods
            d("Hello");
        }

        private static string Method1(string message)
        {
            Console.WriteLine("A: " + message);
            return "A: " + message;
        }

        private static string Method2(string message)
        {
            Console.WriteLine("B: " + message);
            return "B: " + message;
        }

        private static string Method3(string message)
        {
            Console.WriteLine("C: " + message);
            return "C: " + message;
        }
    }
}
