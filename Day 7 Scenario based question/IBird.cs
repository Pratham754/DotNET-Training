// namespace MyConsoleApp.IBird
// {
//     /// <summary>
//     /// Interface for Singing behavior
//     /// </summary>
//     public interface ISing
//     {
//         void Sing()
//         {
//             System.Console.WriteLine("I am a Singing bird.");
//         }
//     }

//     /// <summary>
//     /// Interface for Dancing behavior
//     /// </summary>
//     public interface IDance
//     {
//         void Dance()
//         {
//             System.Console.WriteLine("I am a Dancing bird.");
//         }
//     }

//     /// <summary>
//     /// Class implementing both ISing and IDance interfaces
//     /// </summary>
//     public class Bird : ISing, IDance
//     {
//         public void Sing()
//         {
//             System.Console.WriteLine("Bird is singing.");
//         }
//         public void Dance()
//         {
//             System.Console.WriteLine("Bird is dancing.");
//         }

//         internal int MultiMath(int n, out int square, out int half)
//         {
//             throw new NotImplementedException();
//         }
//     }
// }