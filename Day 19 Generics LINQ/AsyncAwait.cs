// namespace MyConsoleApp
// {
//     public class AsyncAwait
//     {
//         public static async Task AsyncMethod()
//         {
//             System.Console.WriteLine("Task Started");
//             await Task.Delay(3000);
//             System.Console.WriteLine("Task Completed After 3 Seconds!");
//         }

//         public async Task CallMethod()
//         {
//             string? result = await FetchDataAsync("https://jsonplaceholder.typicode.com/todos");
//             System.Console.WriteLine(result);
//             await AsyncMethod();
//         }

//         private static async Task<string?> FetchDataAsync(string v)
//         {
//             using HttpClient client = new();
//             var response = await client.GetStringAsync(v);
//             return response;
//         }

//         public static void Main()
//         {
//             AsyncAwait function = new();
//             function.CallMethod();
//             Console.ReadLine();

//         }
//     }
// }