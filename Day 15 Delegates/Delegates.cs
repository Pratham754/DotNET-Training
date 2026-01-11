using System;

namespace MyConsoleApp
{
    public delegate string PrintMessage(string message);
    public class PrintingCompany
    {
        public PrintMessage? CustomerChoicePrintMessage { get; set;}

        public void Print(string message)
        {
            string messageToPrint = CustomerChoicePrintMessage(message);
            System.Console.WriteLine(messageToPrint);
        }
    }

    public class Delegates
    {
        public static void Main()
        {
            PrintingCompany printingCompany = new();
            printingCompany.CustomerChoicePrintMessage += new PrintMessage(HappyNewYear);
            printingCompany.Print("Pratham"); 
        }

        private static string Method1(string message) => "Hello " + message;

        private static string HappyNewYear(string message) => "Happy New Year " + message + "!";

        private static string HappyDiwali(string message) => "Happy Diwali " + message + "!";
    }
}