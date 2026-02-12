// using System;

// namespace EqualSum
// {
//     public class EqualSumProgram
//     {
//         public static string equalSums(string s)
//         {
//             if (string.IsNullOrEmpty(s)) return "-404";

//             int totalSum = 0;
//             foreach (char c in s)
//             {
//                 totalSum += c - 'a' + 1;
//             }

//             int leftSum = 0;
//             for (int i = 0; i < s.Length; i++)
//             {
//                 int currentVal = s[i] - 'a' + 1;
//                 int rightSum = totalSum - leftSum - currentVal;
//                 if (leftSum == rightSum)
//                 {
//                     return s[i].ToString();
//                 }
//                 leftSum += currentVal;
//             }
//             return "-404";
//         }

//         public static void Main()
//         {
//             string s = Console.ReadLine() ?? "";
//             Console.WriteLine(equalSums(s));
//         }
//     }
// }