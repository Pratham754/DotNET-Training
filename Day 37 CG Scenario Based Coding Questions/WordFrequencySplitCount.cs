// Q12. Word Frequency - Split + Count
// A text analyzer needs word frequency counts.
// Requirements:
// •	Split the sentence into words
// •	Count each word occurrence
// •	Ignore case differences (treat 'Dot' and 'dot' same)
// Task: Input a sentence and print word frequency output.

namespace WordFrequencySplitCount
{
    public class WordFrequency
    {
        public static void Main()
        {
            Console.Write("Enter String: ");
            string input = Console.ReadLine() ?? "";
            string lowered = input.ToLower();
            string[] parts = lowered.Split(" ");
            Dictionary<string,int> count = [];
            foreach(var part in parts)
            {
                count.TryAdd(part,0);
                count[part]++;
            }

            Console.WriteLine("\nOutput:");
            foreach (var words in count)
            {
                Console.WriteLine($"{words.Key}: {words.Value}");
            }
        }
    }
}
