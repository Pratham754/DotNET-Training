// namespace MyConsoleApp
// {
//     public class Threads
//     {
//         public static void Main()
//         {
//             Thread t1 = new Thread(Task1);
//             Thread t2 = new Thread(Task2);
//             t1.Start();
//             t2.Start();
//         }

//         private static void Task2(object? obj)
//         {
//             System.Console.WriteLine("Even numbers:");
//             for(int i = 0; i < 100; i += 2)
//             {
//                 System.Console.Write(i + " ");
//                 Thread.Sleep(100);
//             }
//         }

//         private static void Task1(object? obj)
//         {
//             System.Console.WriteLine("Odd numbers:");
//             for(int i = 1; i < 100; i += 2)
//             {
//                 System.Console.Write(i + " ");
//                 Thread.Sleep(200);
//             }
//         }
//     }
// }