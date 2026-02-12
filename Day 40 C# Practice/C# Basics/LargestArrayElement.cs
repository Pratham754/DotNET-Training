// using System;

// public class Program
// {
//     public static void FindMax(int[] arr)
//     {
//         int largest = int.MinValue;
//         foreach (int num in arr)
//         {
//             if (num > largest)largest = num;
//         }
//         Console.WriteLine(largest);
//     }

//     public static void Main()
//     {
//         Console.Write("Enter number of elements: ");
//         int n = int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter space separated numbers:");
//         string input = Console.ReadLine() ?? "";
//         int[] arr = Array.ConvertAll(input.Split(' '), int.Parse);
//         FindMax(arr);
//     }
// }