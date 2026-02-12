// using System;
// public class Program
// {
//     public static void CheckMail(string input)
//     {
//         if (string.IsNullOrWhiteSpace(input)) { Console.WriteLine("Email can't be empty"); return; }

//         if (input.Contains(' ')) { Console.WriteLine("Email cannot contain spaces"); return; }

//         int atIndex = input.IndexOf('@');
//         int lastAtIndex = input.LastIndexOf('@');

//         if (atIndex == -1 || atIndex != lastAtIndex) { Console.WriteLine("Email must contain exactly one '@'"); return; }

//         if (atIndex == 0 || atIndex == input.Length - 1) { Console.WriteLine("'@' cannot be first or last character"); return; }

//         int dotIndex = input.IndexOf('.', atIndex);

//         var words = input.Split('.');
//         foreach (var word in words)
//         {
//             if (word.Length < 1) { Console.WriteLine("There can't be more than 2 immediate '.'"); return; }
//         }

//         if (dotIndex == -1) { Console.WriteLine("Domain must contain '.' after '@'"); return; }

//         if (dotIndex == atIndex + 1) { Console.WriteLine("'.' cannot come immediately after '@'"); return; }
//         if (dotIndex == atIndex - 1) { Console.WriteLine("'.' cannot come immediately before '@'"); return; }

//         if (dotIndex == input.Length - 1) { Console.WriteLine("'.' cannot be last character"); return; }

//         if (input.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase)) Console.WriteLine("Valid Gmail address");
//         else Console.WriteLine("Invalid Email address");
//     }
//     public static void Main()
//     {
//         Console.Write("Enter the email address: ");
//         string input = Console.ReadLine() ?? "";
//         CheckMail(input);
//         return;
//     }
// }
