// using System;
// using System.Collections.Generic;

// public class InventoryDetectDuplicateSerials
// {
//     public static void Main()
//     {
//         List<string> serials = ["S1", "S2", "S1", "S3", "S2", "S2"];
//         HashSet<string> seen = [], addedToDuplicates = [];
//         List<string> duplicates = [];

//         foreach (var serial in serials)
//         {
//             if (!seen.Add(serial))
//             {
//                 if (addedToDuplicates.Add(serial)) duplicates.Add(serial);
//             }
//         }

//         Console.WriteLine(string.Join(", ", duplicates));
//     }
// }