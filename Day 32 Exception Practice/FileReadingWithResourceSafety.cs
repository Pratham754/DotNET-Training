// using System;
// using System.IO;
// public class FileReadingWithResourceSafetyException(string message) : Exception(message) { }

// class FileReader
// {
//     static void Main()
//     {
//         string filePath = "data.txt";
//         System.Console.WriteLine(filePath);
//         StreamReader? reader = null;

//         // TODO:
//         // 1. Read file content
//         try
//         {
//             reader = new StreamReader(filePath);
//             string content = reader.ReadToEnd();
//             Console.WriteLine(content);
//         }
//         // 2. Handle FileNotFoundException
//         // 3. Handle UnauthorizedAccessException
//         catch (FileReadingWithResourceSafetyException){}

//         catch(Exception ex)
//         {
//             Console.WriteLine($"Error: {ex.Message}");
//         }
//         // 4. Ensure resource is closed properly
//         finally
//         {
//             if(reader != null)
//             {
//                 reader.Close();
//                 Console.WriteLine("File resource closed.");
//             }
//         }
//     }
// }