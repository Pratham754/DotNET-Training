using System;

namespace MyConsoleApp
{
    // Delegate created in another class
    public class DelegateDefinition
    {
        public delegate int DelegateAddFunctionName(int a, int b);
    }

    public class DelegateHolder
    {
        // Delegate property
        public DelegateDefinition.DelegateAddFunctionName? AddOperation { get; set; }
    }

    public class MathOperations
    {
        public static int AddNormal(int a, int b)
        {
            return a + b;
        }

        public static int AddWithExtra(int a, int b)
        {
            return a + b + 40;
        }
    }

    public class DelegateExample
    {
        public void DelegateEx1()
        {
            DelegateDefinition.DelegateAddFunctionName delegateVariable = new(AddFunction1);

            Console.WriteLine(delegateVariable(1, 2));
        }

        private int AddFunction1(int a, int b)
        {
            return a + b + 10;
        }
    }

    public class Delegates
    {
        public static void Main(string[] args)
        {
            DelegateHolder holder = new DelegateHolder();

            // Assign static method to delegate
            holder.AddOperation = MathOperations.AddWithExtra;

            // Invoke delegate safely
            int result = holder.AddOperation?.Invoke(5, 10) ?? 0;

            Console.WriteLine("Result: " + result);
        }
    }
}
