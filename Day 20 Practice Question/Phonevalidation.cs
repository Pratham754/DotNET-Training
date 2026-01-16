// using System;

// namespace MyConsoleApp
// {
//     public class User
//     {
//         public string? Name { get; set; }
//         public string? PhoneNumber { get; set; }
//     }

//     public class InvalidPhoneNumberException(string message) : Exception(message)
//     {
//     }

//     public class Program
//     {
//         public static User ValidatePhoneNumber(string name, string phoneNumber)
//         {
//             if (phoneNumber != null && phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit))
//             {
                
//                 return new User
//                 {
//                     Name = name,
//                     PhoneNumber = phoneNumber
//                 };
//             }

//             throw new InvalidPhoneNumberException("Invalid phone number");
//         }

//         public static void Main()
//         {
//             Program p = new();

//             Console.Write("Enter name: ");
//             string? name = Console.ReadLine() ?? "";

//             Console.Write("Enter phone number: ");
//             string? phone = Console.ReadLine() ?? "";

//             try
//             {
//                 User u = ValidatePhoneNumber(name, phone);
//                 Console.WriteLine("User Verified");
//             }
//             catch (InvalidPhoneNumberException ex)
//             {
//                 Console.WriteLine(ex.Message);
//             }
//         }
//     }
// }