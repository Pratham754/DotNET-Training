// using System;

// class BonusCalculator
// {
//     static void Main()
//     {
//         int[] salaries = { 5000, 0, 7000 };
//         int bonus = 3000;

//         // TODO:
//         // 1. Loop through salaries
//         foreach (int salary in salaries)
//         {
//             try
//             {
//                 // 2. Divide bonus by salary
//                 int finalBonus = bonus / salary;
//                 System.Console.WriteLine("your bonus is: " + finalBonus);
//             }
//             // 3. Handle DivideByZeroException
//             catch (DivideByZeroException)
//             {
//                 System.Console.WriteLine("Bro no salary what bro??");
//             }
//         }
//         // 4. Continue processing remaining employees

//     }
// }