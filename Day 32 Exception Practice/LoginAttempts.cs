// using System;

// // Custom exception
// public class LoginAttemptsExceeded(string message) : Exception(message){}

// public class LoginAttempt
// {
//     public static void Main()
//     {
//         int attempts = 0;
//         int maxAttempts = 3;
//         string original = "Pratham";

//         try
//         {
//             while (true)
//             {
//                 Console.Write("Enter password: ");
//                 string password = Console.ReadLine()!;

//                 if (password == original)
//                 {
//                     Console.WriteLine("Login Successful.");
//                     break;
//                 }
//                 else
//                 {
//                     attempts++;
//                     Console.WriteLine("Invalid password. Remaining attempts: " + (maxAttempts - attempts));
//                 }

//                 if (attempts >= maxAttempts)
//                 {
//                     throw new LoginAttemptsExceeded(
//                         "Failed logging in 3 times. Try again later.");
//                 }
//             }
//         }
//         catch (LoginAttemptsExceeded ex)
//         {
//             Console.WriteLine($"Error: {ex.Message}");
//             Console.WriteLine("Application terminated.");
//         }
//     }
// }