// using System;

// namespace Generics
// {
//     public class Object
//     {
//         public string? ObjName { get; set; }
//     }
//     public class Student
//     {
//         public string? Name { get; set; }
//     }

//     public class UGStudent : Student
//     {
//         public int HighSchoolMarks { get; set; }
//     }

//     public class MyGlobalType<T, K>
//     {
//         public string GetDataType(T t, K k)
//         {
//             return typeof(T).Name + " " + typeof(K).Name;
//         }
//     }
// }

// namespace MyConsoleApp
// {
//     using System.Reflection.Metadata.Ecma335;
//     using System.Security.Cryptography.X509Certificates;
//     using Generics;

//     public class CallerClass
//     {
//         public static void Main()
//         {
//             UGStudent ugStudent = new();
//             Object obj = new();

//             MyGlobalType<UGStudent, Object> myGlobalType = new();

//             var result = myGlobalType.GetDataType(ugStudent, obj);
//             Console.WriteLine(result);

//             Run();
//         }

//         public static void Run()
//         {
//             Action<string> logger = message => System.Console.WriteLine($"[LOG]: {message} at {DateTime.Now}");
//             logger("Appliication started");

//             Func<int, int, string> multiplyResult = (x,y) => 
//             {
//                 return $"{x} * {y} is {x*y}";
//             };
//             var res = multiplyResult(4,5);
//             System.Console.WriteLine(res);

//             Predicate<int> isEven = number => number % 2 == 0;
//             bool check = isEven(10);
//             System.Console.WriteLine("The number is Even? " + check);
//         }
//     }
// }