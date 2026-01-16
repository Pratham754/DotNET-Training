// namespace MyConsoleApp
// {
//     class Program
//     {
//         public static SortedDictionary<string, long> itemDetails = [];
//         public static SortedDictionary<string, long>? FindItemDetails(long SoldCount)
//         {
//             var res = itemDetails.Where(e => e.Value == SoldCount).ToDictionary(e => e.Key, e => e.Value);
//             if (res.Count == 0)
//                 return null;

//             return new SortedDictionary<string, long>(res);
//         }

//         public static List<String> FindMinandMaxSoldItems()
//         {
//             List<string> minmax = [];

//             if (itemDetails.Count == 0) return minmax;

//             var minItem = itemDetails.MinBy(e => e.Value);
//             var maxItem = itemDetails.MaxBy(e => e.Value);

//             minmax.Add(minItem.Key);
//             minmax.Add(maxItem.Key);

//             return minmax;
//         }

//         public static Dictionary<string, long> SortByCount()
//         {
//             return itemDetails
//             .OrderBy(e => e.Value)
//             .ToDictionary(e => e.Key, e => e.Value);
//         }

//         public static void Main()
//         {
//             //take inputs from user
//             itemDetails.Add("Apple", 50);
//             itemDetails.Add("Banana", 20);
//             itemDetails.Add("Orange", 75);

//             var minMax = FindMinandMaxSoldItems();
//             Console.WriteLine($"Min Sold: {minMax[0]}, Max Sold: {minMax[1]}");

//             var sorted = SortByCount();
//             Console.WriteLine("Sorted by count:");
//             foreach (var item in sorted)
//             {
//                 Console.WriteLine($"{item.Key} - {item.Value}");
//             }
//             System.Console.WriteLine("--------------------------------------");
//             var found = FindItemDetails(510);
//             System.Console.WriteLine(found == null ? "Invalid Sold Count" : found);
//         }
//     }
// }