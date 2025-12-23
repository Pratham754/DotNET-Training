namespace MyConsoleApp.AddConstructor
{
    /// <summary>
    /// Parameterized constructor to add two numbers and display the result
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public class Adding(int a, int b)
    {
        public int A { get; set; } = a;
        public int B { get; set; } = b;
        public int C { get; } = a + b;
    }
}

// do example for set only property in constructor