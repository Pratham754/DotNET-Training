// using System;
// class Program
// {
//     public static void ReverseString(string input)
//     {
//         char[] reversed = new char[input.Length];
//         for (int i = 0; i < input.Length; i++)
//         {
//             reversed[i] = input[input.Length - 1 - i];
//         }
//         Console.WriteLine(new string(reversed));
//     }
//     public static void Main()
//     {
//         string input = Console.ReadLine() ?? "";
//         ReverseString(input);
//     }
// }