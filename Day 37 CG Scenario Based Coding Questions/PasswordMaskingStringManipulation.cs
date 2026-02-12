// using System.Text;

// namespace PasswordMaskingStringManipulation
// {
//     public class Password
//     {
//         public static void Main()
//         {
//             Console.Write("Enter Password: ");
//             string input = Console.ReadLine();
//             if(input.Length < 3 ) {Console.WriteLine("Password Length Must Be Greater Than 3"); return;}

//             StringBuilder sb = new();
//             sb.Append(input[0]);
//             for(int i = 1; i < input.Length - 1; i++)
//             {
//                 sb.Append("*");
//             }
//             sb.Append(input[input.Length-1]);
//             System.Console.WriteLine("Masked Password: " + sb.ToString());
//         }
//     }
// }