// using System;
// namespace MyConsoleApp
// {
//     public class User
//     {
//         public string? Name { get; set; }
//         public string? Password { get; set; }
//         public string? ConfirmationPassword { get; set; }
//     }

//     public class PasswordMismatchException(string message) : Exception(message)
//     {
//     }

//     public class Program
//     {
//         public static User ValidatePassword(string name, string password, string confirmationPassword)
//         {
//             if (!password.Equals(confirmationPassword, StringComparison.Ordinal))
//                 throw new PasswordMismatchException("Password entered does not match");

//             return new User
//             {
//                 Name = name,
//                 Password = password,
//                 ConfirmationPassword = confirmationPassword
//             };
//         }

//         public static void Main()
//         {
//             Program p = new();

//             Console.Write("Enter name: ");
//             string? name = Console.ReadLine() ?? "";

//             Console.Write("Enter password: ");
//             string? pass = Console.ReadLine() ?? "";

//             Console.Write("Confirm password: ");
//             string? confirm = Console.ReadLine() ?? "";

//             try
//             {
//                 User u = ValidatePassword(name, pass, confirm);
//                 Console.WriteLine("Registered Successfully");
//             }
//             catch (PasswordMismatchException ex)
//             {
//                 Console.WriteLine(ex.Message);
//             }
//         }
//     }
// }