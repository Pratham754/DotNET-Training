namespace MyCons9oleApp
{
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Count(c => c.Equals(' ')) + 1;
        }
    }

    public class MainProgram
    {
        public static void Main()
        {
            string input = "Let us go";
            System.Console.WriteLine(input.WordCount());
        }
    }
}