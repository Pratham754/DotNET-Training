using System;
using System.Collections.Generic;
using System.Linq;

#region CreatorStats
/// <summary>
/// Represents engagement statistics for a content creator.
/// </summary>
public class CreatorStats
{
    /// <summary>
    /// Name of the content creator.
    /// </summary>
    public string CreatorName { get; set; }

    /// <summary>
    /// Weekly likes received by the creator.
    /// </summary>
    public double[] WeeklyLikes { get; set; }
}
#endregion

#region Program
/// <summary>
/// Manages creator engagement tracking and analytics.
/// </summary>
public class StreamBuzz
{
    #region EngagementBoard
    /// <summary>
    /// Stores all registered creators and their engagement data.
    /// </summary>
    public static List<CreatorStats> EngagementBoard = [];
    #endregion

    #region RegisterCreator
    /// <summary>
    /// Registers a new creator into the engagement board.
    /// </summary>
    public static void RegisterCreator(CreatorStats record)
    {
        EngagementBoard.Add(record);
    }
    #endregion

    #region GetTopPostCounts
    /// <summary>
    /// Determines how many weekly posts meet or exceed a like threshold per creator.
    /// </summary>
    public static Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string, int> result = [];

        foreach (var creator in records)
        {
            int count = creator.WeeklyLikes.Count(l => l >= likeThreshold);
            if (count > 0)
            {
                result.Add(creator.CreatorName, count);
            }
        }

        return result;
    }
    #endregion

    #region CalculateAverageLikes
    /// <summary>
    /// Calculates the average number of likes across all creators and weeks.
    /// </summary>
    public static double CalculateAverageLikes()
    {
        double total = 0;
        int count = 0;

        foreach (var creator in EngagementBoard)
        {
            foreach (var like in creator.WeeklyLikes)
            {
                total += like;
                count++;
            }
        }

        return count == 0 ? 0 : total / count;
    }
    #endregion

    #region Main
    /// <summary>
    /// Program entry point for StreamBuzz engagement dashboard.
    /// </summary>
    public static void Main()
    {
        Program program = new Program();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Register Creator");
            Console.WriteLine("2. Show Top Posts");
            Console.WriteLine("3. Calculate Average Likes");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice:");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreatorStats creator = new();

                    Console.WriteLine("Enter Creator Name:");
                    creator.CreatorName = Console.ReadLine();

                    creator.WeeklyLikes = new double[4];
                    Console.WriteLine("Enter weekly likes (Week 1 to 4):");

                    for (int i = 0; i < 4; i++)
                    {
                        creator.WeeklyLikes[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    program.RegisterCreator(creator);
                    Console.WriteLine("Creator registered successfully\n");
                    break;

                case 2:
                    Console.WriteLine("Enter like threshold:");
                    double threshold = Convert.ToDouble(Console.ReadLine());

                    var result = program.GetTopPostCounts(EngagementBoard, threshold);

                    if (result.Count == 0)
                    {
                        Console.WriteLine("No top-performing posts this week");
                    }
                    else
                    {
                        foreach (var item in result)
                        {
                            Console.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                    Console.WriteLine();
                    break;

                case 3:
                    double average = program.CalculateAverageLikes();
                    Console.WriteLine("Overall average weekly likes: " + average);
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                    running = false;
                    break;
            }
        }
    }
    #endregion
}
#endregion