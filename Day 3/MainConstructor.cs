using System;
using MyConsoleApp.ConstructorEx;
using MyConsoleApp.AddConstructor;
namespace MyConsoleApp
{
    public class MainConstructor
    {
        public static void Main(string[] args)
        {
            try
            {
                Visitor visitor = new(2,"Pratham","Wants to learn C#");
                Console.WriteLine($"Id: {visitor.Id}, Name: {visitor.Name}, Requirement: {visitor.Requirement}");

                Adding adding = new(12,18);
                System.Console.WriteLine(adding.C);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}