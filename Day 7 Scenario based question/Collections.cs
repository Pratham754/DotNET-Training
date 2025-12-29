// using System.Collections;

// namespace MyConsoleApp
// {
//     public class Collections
//     {
//         public void Sample1()
//         {
//             ArrayList myList = [];
//             myList.Add(10);
//             myList.Add("Hello");
//             myList.Add(25.5);

//             foreach ( var item in myList)
//             {
//                 System.Console.WriteLine(item);
//             }

//             Stack myStack = [];
//             myStack.Push(1);
//             myStack.Push(2);
//             myStack.Push("Stack Item");
//             myStack.Pop();

//             Queue q = [];
//             q.Enqueue("First");
//             q.Enqueue(2);
//             q.Enqueue(3.5);
//             q.Dequeue();

//             // Generics Example

//             List<string> names = [];
//             names.Add("Alice");
//             names.Add("Charlie");
//             names.Add("Bob");

//             names.Sort();
//             foreach (var name in names)
//             {
//                 System.Console.WriteLine(name);
//             }
//         }

//         public static void Main()
//         {
//             Collections col = new();
//             col.Sample1();
//         }
//     }
// }