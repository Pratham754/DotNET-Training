// namespace MyConsoleApp
// {

//     public class Program
//     {
//         public static List<int> NumbersList = [];
//         public static void AddNumbers(int numbers)
//         {
//             NumbersList.Add(numbers);
//         }

//         public static double GetGPAScored()
//         {
//             if (NumbersList.Count == 0)
//                 return -1;

//             int credit = 3;
//             int totalCredits = NumbersList.Count * credit;

//             int sum = NumbersList.Sum(n => n * credit);

//             return (double)sum / totalCredits;
//         }

//         public static char GetGradeScored(double gpa)
//         {
//             if (gpa < 5 || gpa > 10)
//                 return '\0';

//             if (gpa == 10)
//                 return 'S';
//             else if (gpa >= 9)
//                 return 'A';
//             else if (gpa >= 8)
//                 return 'B';
//             else if (gpa >= 7)
//                 return 'C';
//             else if (gpa >= 6)
//                 return 'D';
//             else
//                 return 'E';
//         }
//         public static void Main()
//         {
//             Console.WriteLine("Enter number of subjects:");
//             int n = int.Parse(Console.ReadLine());

//             if (n <= 0)
//             {
//                 Console.WriteLine("No Numbers Available");
//                 return;
//             }

//             Console.WriteLine("Enter the numbers:");
//             for (int i = 0; i < n; i++)
//             {
//                 int num = int.Parse(Console.ReadLine());
//                 AddNumbers(num);
//             }

//             double gpa = GetGPAScored();

//             if (gpa == -1)
//             {
//                 Console.WriteLine("No Numbers Available");
//                 return;
//             }

//             Console.WriteLine($"GPA Scored: {gpa:F2}");

//             char grade = GetGradeScored(gpa);

//             if (grade == '\0')
//             {
//                 Console.WriteLine("Invalid GPA");
//             }
//             else
//             {
//                 Console.WriteLine($"Grade Scored: {grade}");
//             }
//         }
//     }
// }