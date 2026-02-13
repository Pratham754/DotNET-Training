// using System;
// using System.Collections.Generic;

// public class CustomerSupportMergeTwoTicketStreams
// {
//     public static List<int> MergeSortedTicketStreams(List<int> a, List<int> b)
//     {
//         List<int> merged = new(a.Count + b.Count);
//         int i = 0, j = 0;

//         while (i < a.Count && j < b.Count)
//         {
//             if (a[i] <= b[j]) { merged.Add(a[i]); i++; }
//             else { merged.Add(b[j]); j++; }
//         }

//         while (i < a.Count) merged.Add(a[i++]);
//         while (j < b.Count) merged.Add(b[j++]);
//         return merged;
//     }

//     public static void Main()
//     {
//         List<int> a = [ 1, 4, 7 ];
//         List<int> b = [ 2, 3, 8 ];

//         var result = MergeSortedTicketStreams(a, b);
//         Console.WriteLine(string.Join(", ", result));
//     }
// }