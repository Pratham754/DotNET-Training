// using System.ComponentModel;

// namespace MyConsoleApp.IBird
// {
//     public class CallBird
//     {
//         public static void Main()
//         {
//             Bird bird = new();
//             bird.Sing();
//             bird.Dance();

//             int a = int.MaxValue;
//             int b = 1;
//             Add(a, b);
//             // Console.WriteLine($"Addition is: {add}");
//             int n = 10;
//             MultiMath(n, out int square, out int half);
//             Console.WriteLine($"For n={n}, Square={square}, Half={half}");
//         }

//         public static int MultiMath(int n, out int sqrValue, out int halfValue)
//         {
//             sqrValue = n * n;
//             halfValue = n / 2;
//             return n * n * n;
//         }

//         public static int Add(int a, int b)
//         {
//             checked
//             {
//                 int c = a + b;
//                 return c;
//             }
//         }
//     }
// }