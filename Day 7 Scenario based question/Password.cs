// using System;
// using System.Text;
// namespace MyConsoleApp
// {
//     public class Password
//     {
//         public static string CleanseAndInvert(string input)
//         {
//             // Rule 1: Null or length less than 6
//             if (string.IsNullOrEmpty(input) || input.Length < 6)
//                 return string.Empty;

//             // Rule 2: No space, digit, or special character
//             foreach (char c in input)
//             {
//                 if (!char.IsLetter(c))
//                     return string.Empty;
//             }

//             // Convert to lowercase
//             input = input.ToLower();

//             string s1 = "";
//             // Remove characters with even ASCII values
//             foreach (char c in input)
//             {
//                 if ((int)c % 2 != 0)
//                 {
//                     s1 += c;
//                 }
//             }

//             // Reverse the string
//             char[] reversed = s1.ToString().ToCharArray();
//             Array.Reverse(reversed);

//             // Convert even positioned characters to uppercase
//             for (int i = 0; i < reversed.Length; i += 2)
//             {
//                 reversed[i] = char.ToUpper(reversed[i]);
//             }

//             return new string(reversed);
//         }

//         static void Main()
//         {
//             // Console.WriteLine("Enter the word");
//             // string input = Console.ReadLine();

//             // string result = CleanseAndInvert(input);

//             // if (string.IsNullOrEmpty(result))
//             // {
//             //     Console.WriteLine("Invalid Input");
//             // }
//             // else
//             // {
//             //     Console.WriteLine("The generated key is - " + result);
//             // }

//             // System.String str = "Common Type System";

//             // int[][] data = new int[5][];
//             // data[0] = new int[] { 1, 2, 3 };
//             // data[1] = new int[] { 10, 20 };
//             // data[2] = new int[] { 7, 8, 9, 10 };
//             // data[3] = new int[] { 15, 25, 35 };
//             // data[4] = new int[] { 100, 200, 300, 400 };


//             // for (int i = 0; i < data.Length; i++)
//             // {
//             //     Console.Write("Row " + i + ": ");
//             //     foreach (var v in data[i]) Console.Write(v + " ");
//             //     Console.WriteLine();
//             // }

//             dynamic d = 10;
//             d  = "Pratham";
//             Console.WriteLine(d.GetType());
//             System.Console.WriteLine(d);
//         }
//     }
// }