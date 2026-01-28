// using System;

// /// <summary>
// /// This program validates a username based on a fixed pattern
// /// and generates a password using ASCII values and course ID digits.
// /// </summary>
// #region Password Utility

// class PasswordGenerator
// {
//     #region Validation Logic

//     // Checks whether the given username follows the required format
//     static bool ValidateUsername(string userName)
//     {
//         // Username must be exactly 8 characters
//         if (userName.Length != 8)
//             return false;

//         // First four characters must be uppercase letters
//         for (int i = 0; i < 4; i++)
//         {
//             if (!char.IsUpper(userName[i]))
//                 return false;
//         }

//         // Fifth character must be '@'
//         if (userName[4] != '@')
//             return false;

//         // Last three characters must be digits
//         for (int i = 5; i < 8; i++)
//         {
//             if (!char.IsDigit(userName[i]))
//                 return false;
//         }

//         // Course ID must be between 101 and 115
//         int courseCode = int.Parse(userName.Substring(5, 3));
//         if (courseCode < 101 || courseCode > 115)
//             return false;

//         return true;
//     }

//     #endregion

//     #region Main Method

//     static void Main()
//     {
//         Console.WriteLine("Enter the username");
//         string userName = Console.ReadLine();

//         if (!ValidateUsername(userName))
//         {
//             Console.WriteLine(userName + " is an invalid username");
//             return;
//         }

//         int asciiTotal = 0;
//         for (int i = 0; i < 4; i++)
//         {
//             asciiTotal += (int)char.ToLower(userName[i]);
//         }

//         string courseDigits = userName.Substring(6, 2);

//         string password = "TECH_" + asciiTotal + courseDigits;

//         Console.WriteLine("Password: " + password);
//     }

//     #endregion
// }

// #endregion