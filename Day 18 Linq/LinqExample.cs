// using System.Runtime.InteropServices;
// using System.Security.Cryptography.X509Certificates;

// namespace MyConsoleApp
// {
//     public class LinqExample
//     {
//         public LinqExample()
//         {
//             string[] names = ["AAA", "B", "C", "Madam", "noon"];

//             // foreach (var v in names)
//             // {
//             //     if (v == "B")
//             //         System.Console.WriteLine("Exists");
//             // }

//             // var findNames = from n in names
//             //                 orderby n descending
//             //                 select IsPalindrome(n);


//             var findNames = from n in names
//                             orderby n descending
//                             select new LinqStudent() { Name = n };

//             foreach (var v in findNames)
//             {
//                 System.Console.WriteLine(v.Name);
//             }
//         }
//         public static string IsPalindrome(string name)
//         {
//             string reversedName = new(name.Reverse().ToArray());

//             if (reversedName.ToLower() == name.ToLower())
//             {
//                 return "Palindrome";
//             }
//             return "nope";
//         }
//     }

//     public class LinqStudent
//     {
//         public LinqStudent()
//         {
//         }

//         public object? Name { get; set; }
//     }


//     internal class MyProcess
//     {
//         public MyProcess()
//         {
//         }

//         public object? Name { get; set; }
//         public int Id { get; internal set; }
//     }
//     public class Program
//     {

//         public static void LinqExample2()
//         {
//             var proCollection = from p in System.Diagnostics.Process.GetProcesses() select new MyProcess() { Name = p.ProcessName, Id = p.Id };
//             foreach (var v in proCollection)
//             {
//                 System.Console.WriteLine($"Process Name: {v.Name}       Id: {v.Id}");
//             }
//         }

//         // Anonymous datatype, ms will create its own class, will be used within this scope, dynamically 
//         public static void LinqExample3()
//         {
//             var proCollection = from p in System.Diagnostics.Process.GetProcesses() select new { Name = p.ProcessName, Id = p.Id };
//             foreach (var v in proCollection)
//             {
//                 System.Console.WriteLine($"Process Name: {v.Name}       Id: {v.Id}");
//             }
//         }

//         public static void Main()
//         {
//             // LinqExample lq = new();
//             // LinqExample2();
//             LinqExample3();

//         }
//     }


// }

// // model: whatever class we create is a model
// // view model: to display a model we create view model
// // anonymous: we dont need to create another model, creating an object on the fly


// // create class, in it mark1 mark2 