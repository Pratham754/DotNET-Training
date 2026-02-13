// using System;
// using System.Collections.Generic;

// public class UndoFeatureTextEditor
// {
//     public static void Main()
//     {
//         List<string> ops =  ["TYPE Hello","TYPE World","UNDO","TYPE CSharp"];
//         Stack<string> st = [];
//         foreach(var op in ops)
//         {
//             if(op.StartsWith("TYPE")) { string word = op.Split(' ')[1]; st.Push(word); }
//             else if(op == "UNDO" && st.Count > 0) st.Pop();
//         }
//         Console.WriteLine(string.Join(" ",st.Reverse()));
//     }
// }