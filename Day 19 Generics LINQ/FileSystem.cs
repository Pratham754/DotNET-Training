// namespace MyConsoleApp
// {
//     public class FileSystem
//     {
//         public static void Main()
//         {
//             string[] lines = [ "first line", "second line", "third line" ];
//             string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
//             using StreamWriter outputFile = new(Path.Combine(docPath));
//             foreach (string line in lines)
//             {
//                 outputFile.WriteLine(line);
//             }
//         }
//     }
// } 