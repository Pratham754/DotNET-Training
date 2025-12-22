using System;

namespace Github
{
    /// <summary>
    /// Displays a description based on the entered grade.
    /// </summary>
    public class GradeDescription
    {
        static void Main()
        {
            #region Input
            Console.Write("Enter the grade (E, V, G, A, F): ");
            char grade = Char.ToUpper(Console.ReadLine()[0]);
            #endregion

            #region Processing
            switch (grade)
            {
                case 'E':
                    Console.WriteLine("Excellent");
                    break;
                case 'V':
                    Console.WriteLine("Very Good");
                    break;
                case 'G':
                    Console.WriteLine("Good");
                    break;
                case 'A':
                    Console.WriteLine("Average");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
            #endregion
        }
    }
}
