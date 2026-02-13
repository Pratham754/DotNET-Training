// using System;
// using System.Collections.Generic;

// public class MetroTicketingPeakHourCount
// {
//     public static int CountRegularTicketsDuringPeakHours(Queue<(TimeSpan entryTime, string ticketType)> q)
//     {
//         int count = 0;
//         TimeSpan peakStart = new(8, 0, 0);
//         TimeSpan peakEnd = new(10, 0, 0);
//         while (q.Count > 0)
//         {
//             var (entryTime, ticketType) = q.Dequeue();

//             if (ticketType == "Regular" && entryTime >= peakStart && entryTime <= peakEnd) count++;
//         }
//         return count;
//     }
//     public static void Main(string[] args)
//     {
//         Queue<(TimeSpan entryTime, string ticketType)> q = new();
//         q.Enqueue((new TimeSpan(7, 30, 0), "Regular"));
//         q.Enqueue((new TimeSpan(8, 15, 0), "Regular"));
//         q.Enqueue((new TimeSpan(9, 45, 0), "Regular"));
//         q.Enqueue((new TimeSpan(10, 30, 0), "Regular"));
//         q.Enqueue((new TimeSpan(8, 30, 0), "Student"));
//         q.Enqueue((new TimeSpan(9, 0, 0), "Regular"));
//         q.Enqueue((new TimeSpan(11, 0, 0), "Regular"));

//         int result = CountRegularTicketsDuringPeakHours(q);
//         Console.WriteLine(result);
//     }
// }