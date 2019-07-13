using System;
using System.Text.RegularExpressions;

namespace Palindrome
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string wordToVerify;
            string wordReverted;

            Console.WriteLine("Please provide a word that you would like to verify as a palindrome:");
            wordToVerify = Console.ReadLine();

            wordToVerify = wordToVerify.ToLower();
            wordToVerify = RemoveSpecialCharacters(wordToVerify);
            wordReverted = Reverse(wordToVerify);

            if (wordToVerify == wordReverted)
            {
                Console.WriteLine("It's a palindrome!");
            }
            else
            {
                Console.WriteLine("It's not a palindrome!");
            }
            Console.ReadKey();
        }

        // Method which removes special characters with regex.
        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-z]+", "", RegexOptions.Compiled);
        }

        // Method which reverses a string.
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

