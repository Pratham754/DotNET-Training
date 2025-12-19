// Search with Goto: Implement a deep-nested loop search that uses goto to exit all levels instantly upon finding a result.
using System;

namespace Github
{
    public class SearchWithGoto
    {
        static void Main(string[] args)
        {
            int target = 7;
            bool found = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        int value = i + j + k;

                        if (value == target)
                        {
                            Console.WriteLine($"Found {target} at i={i}, j={j}, k={k}");
                            found = true;
                            goto Found;
                        }
                    }
                }
            }

        Found:
            if (!found)
            {
                Console.WriteLine("Target not found.");
            }

            Console.WriteLine("Search complete.");
        }
    }
}
