// using System;

// public class LeaderboardTopKScores
// {
//     public static void Main()
//     {
//         List<(string name, int score)> players = [("Raj",80),("Anu",95),("Vikram",95),("Meena",70)];
//         int k = 3;
//         var result = players.OrderByDescending(p => p.score).ThenBy(p => p.name).Take(k).ToList();
//         foreach(var topper in result){ Console.Write(topper+" "); }
//     }
// }