// using System;

// /// <summary>
// /// This program validates a sentence and performs word manipulation.
// /// If the number of words is even, it reverses the word order.
// /// If the number of words is odd, it reverses the letters in each word.
// /// </summary>
// #region Word Processing

// class WordWandProcessor
// {
//     #region Validation

//     // Ensures the sentence contains only letters and spaces
//     static bool ValidateSentence(string input)
//     {
//         foreach (char ch in input)
//         {
//             if (!char.IsLetter(ch) && ch != ' ')
//                 return false;
//         }
//         return true;
//     }

//     #endregion

//     #region Transformation Logic

//     // Reverses characters in each word
//     static string ReverseEachWord(string[] wordList)
//     {
//         string output = "";

//         foreach (string word in wordList)
//         {
//             char[] letters = word.ToCharArray();
//             Array.Reverse(letters);
//             output += new string(letters) + " ";
//         }

//         return output.Trim();
//     }

//     // Reverses the order of words in the sentence
//     static string ReverseWordOrder(string[] wordList)
//     {
//         Array.Reverse(wordList);
//         return string.Join(" ", wordList);
//     }

//     #endregion

//     #region Main Method

//     public static void Main()
//     {
//         Console.WriteLine("Enter the sentence");
//         string sentence = Console.ReadLine();

//         // Validate input
//         if (!ValidateSentence(sentence))
//         {
//             Console.WriteLine("Invalid Sentence");
//             return;
//         }

//         // Split sentence into words
//         string[] words = sentence.Split(' ');

//         int count = words.Length;
//         Console.WriteLine("Word Count: " + count);

//         string result;

//         // Apply rules based on word count
//         if (count % 2 == 0)
//         {
//             result = ReverseWordOrder(words);
//         }
//         else
//         {
//             result = ReverseEachWord(words);
//         }

//         Console.WriteLine(result);
//     }

//     #endregion
// }

// #endregion