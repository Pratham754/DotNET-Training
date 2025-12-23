using System;

namespace Github
{
    class VowelConsonant
    {
        public static void Main()
        {
            Console.Write("Enter a character: ");
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input.");
                return;
            }
            char ch = input[0];
            switch (char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("The character is a vowel.");
                    break;
                default:
                    Console.WriteLine("The character is a consonant.");
                    break;
            }
        }
    }
}