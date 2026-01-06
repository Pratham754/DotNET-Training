using System;

namespace MyConsoleApp
{
    public static class Palindrome
    {
        public static bool IsPalindrome(this String str)
        {
            int l=0;
            int r=str.Length-1;
            while (l < r)
            {
                if (str[l] != str[r])
                {
                    return false;
                }
                l++;
                r--;
            }
            return true;
        }

        public static void Main()
        {
            System.Console.Write("Enter a string: ");
            string? input = Console.ReadLine() ?? "";

            if (input.IsPalindrome())
            {
                System.Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                System.Console.WriteLine("The string is not a palindrome.");
            }
        }
    }
}