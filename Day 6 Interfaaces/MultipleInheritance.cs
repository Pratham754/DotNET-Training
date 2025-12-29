// namespace MyConsoleApp.IEater
// {
//     public class MultipleInheritance
//     {
//         public static void Main()
//         {
//             Visitor visitor = new();
//             visitor.EatNonVeg();
//             visitor.EatVeg();

//             IVegEater vegEater = visitor;
//             string vTaste = vegEater.getTaste();
//             System.Console.WriteLine(vTaste);

//             INonVegEater nonVegEater = visitor;
//             string nTaste = nonVegEater.getTaste();
//             System.Console.WriteLine(nTaste);
//         }
//     }
// }            