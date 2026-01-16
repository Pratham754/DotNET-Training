// using System;

// namespace MyConsoleApp
// {
//     public class EstimateDetails
//     {
//         public float ConstructionArea { get; set; }
//         public float SiteArea { get; set; }
//     }

//     public class ConstructionEstimateException(string message) : Exception(message)
//     {
//     }

//     public class Program
//     {
//         public static EstimateDetails ValidateConstructionEstimate(float constructionArea, float siteArea)
//         {
//             if (constructionArea <= siteArea)
//             {
//                 return new EstimateDetails
//                 {
//                     ConstructionArea = constructionArea,
//                     SiteArea = siteArea
//                 };
//             }

//             throw new ConstructionEstimateException("Sorry your Construction Estimate is not approved");
//         }

//         public static void Main()
//         {
//             Program p = new();

//             Console.Write("Enter Construction Area: ");
//             float cArea = float.Parse(Console.ReadLine());

//             Console.Write("Enter Site Area: ");
//             float sArea = float.Parse(Console.ReadLine());

//             try
//             {
//                 EstimateDetails ed = ValidateConstructionEstimate(cArea, sArea);
//                 Console.WriteLine("Construction Estimate Approved");
//             }
//             catch (ConstructionEstimateException ex)
//             {
//                 Console.WriteLine(ex.Message);
//             }
//         }
//     }
// }