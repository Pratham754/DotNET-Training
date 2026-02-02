using System;

#region FlipKey
/// <summary>
/// Provides string transformation functionality.
/// </summary>
public class FlipKey
{
    #region CleanseAndInvert
    /// <summary>
    /// Cleans and transforms the input string based on given rules.
    /// </summary>
    public static string CleanseAndInvert(string input)
    {
        // this will validate input: null, length, and allowed characters
        if (string.IsNullOrEmpty(input) || input.Length < 6) return string.Empty;

        foreach (char ch in input)
        {
            if (!char.IsLetter(ch)) return string.Empty;
        }

        // converts to lowercase
        input = input.ToLower();

        // removes characters with even ASCII values
        string filtered = "";
        foreach (char ch in input)
        {
            if ((int)ch % 2 != 0)
                filtered += ch;
        }

        // Reverse filtered string
        char[] reversed = filtered.ToCharArray();
        Array.Reverse(reversed);

        // this will uppercase characters at even positions
        for (int i = 0; i < reversed.Length; i++)
        {
            if (i % 2 == 0)
                reversed[i] = char.ToUpper(reversed[i]);
        }

        return new string(reversed);
    }
    #endregion

    #region Main
    /// <summary>
    /// Program entry point.
    /// </summary>
    public static void Main()
    {
        Console.WriteLine("Enter the word");
        string input = Console.ReadLine();

        string result = CleanseAndInvert(input);

        string.IsNullOrEmpty(result) ? Console.WriteLine("Invalid Input") : Console.WriteLine("The generated key is - " + result);
    }
    #endregion
}
#endregion