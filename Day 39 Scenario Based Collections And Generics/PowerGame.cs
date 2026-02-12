// using System;
// using System.Collections.Generic;

// public class Test
// {
//     public static string powerGame(int N, long[] A)
//     {
//         Stack<long> st = [];
//         for (int i = 0; i < N; i++)
//         {
//             long current = A[i];
//             if (st.Count > 0 && current >= st.Peek()) st.Pop();
//             else
//             {
//                 if (st.Count > 0)
//                 {
//                     long summed = st.Pop() + current;
//                     st.Push(summed);
//                 }
//                 else st.Push(current);
//             }
//         }
//         return (st.Count == 0) ? "NO": "YES " + st.Peek();
//     }

//     public static void Main()
//     {
//         int N = Convert.ToInt32(Console.ReadLine());
//         long[] A = new long[N];
//         string[] tokens = Console.ReadLine().Split();
//         for (int i = 0; i < N; i++)
//         {
//             A[i] = Convert.ToInt64(tokens[i]);
//         }
//         Console.WriteLine(powerGame(N, A));
//     }
// }