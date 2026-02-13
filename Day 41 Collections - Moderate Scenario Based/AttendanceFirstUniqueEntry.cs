// using System;

// public class AttendanceFirstUniqueEntry
// {
//     public static void Main()
//     {
//         List<int> entries = [10, 20, 10, 30, 20, 40];
//         HashSet<int> entered = [];
//         List<int> firstTime = [];
//         foreach (var entry in entries) { if (entered.Add(entry)) firstTime.Add(entry); }
//         foreach (var entry in firstTime) Console.Write(entry + " ");

//         // LINQ
//         Console.WriteLine();
//         var firstEntry = entries.Distinct().ToList();
//         foreach (var entry in firstEntry) Console.Write(entry + " ");
//     }
// }