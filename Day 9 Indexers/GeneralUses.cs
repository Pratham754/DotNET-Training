// namespace MyConsoleApp
// {
//     public static class GeneralUses
//     {
//         public static int Rno; //static constructor will work with static variables only 
//         static GeneralUses() => Rno = 1; //static constructor are already public so no need to specify access modifier

//         public static int GetRno()
//         {
//             return Rno;
//         }
//     }

//     public class Program
//     {
//         public static void Main()
//         {
//             // GeneralUses.GetRno();
//             System.Console.WriteLine(GeneralUses.GetRno());
//         }
//     }
// }

// // static constructor is a distributed data type which is used to initialize static data members of the class

// // can we use this keyword in static class? 