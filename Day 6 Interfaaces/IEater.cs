// namespace MyConsoleApp.IEater
// {
//     public interface IVegEater
//     {
//         void EatVeg()
//         {
//             System.Console.WriteLine("Eating vegetarian food.");
//         }
//         string getTaste();
//     }

//     public interface INonVegEater
//     {
//         void EatNonVeg()
//         {
//             System.Console.WriteLine("Eating non-vegetarian food.");
//         }
//         string getTaste();
//     }
    
//     public class Visitor : IVegEater, INonVegEater
//     {
//         public void EatVeg()
//         {
//             System.Console.WriteLine("Person is eating vegetarian food.");
//         }
//         public void EatNonVeg()
//         {
//             System.Console.WriteLine("Person is eating non-vegetarian food.");
//         }
         
//         string IVegEater.getTaste()
//         {
//             return "Vegetarian food mehhhh.";
//         }
//         string INonVegEater.getTaste()
//         {
//             return "Non-Vegetarian food yayyyyy.";
//         }
//     }
// }