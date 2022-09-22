using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace sampleDotNet
{
    class StringRelated
    {
        // How do you print the first non-repeated character from a string?
        public static Char FirstNonRepeatChar(string inputString)
        {
            Char firstDistinctChar = ' ';
            firstDistinctChar = inputString
              .AsEnumerable()
              .GroupBy(c => c).Where(c => c.Count() == 1)
              .Select(c => c.Key)
              .First();

            return firstDistinctChar;
        }

        // How do you count the occurrence of a given character in a string?
        public static Dictionary<Char, int> CountAllOccurrenceChar(string inputString)
        {
          return inputString
            .GroupBy(c => c)
            .Select(c => new KeyValuePair<Char, int>(c.Key, c.Count()))
            .ToDictionary(o => o.Key, o => o.Value);
        }

        // How do you check if a given string is a palindrome?
        // This techique uses a general iterative FOR counter
        public static bool PalindromeIterative(string testWord)
        {
          string reverseWord = string.Empty;
          
          for (int i = testWord.Length - 1; i >= 0; i--)
          {
            reverseWord += testWord[i];
          }
          
          if (testWord.Equals(reverseWord, StringComparison.OrdinalIgnoreCase))
          {
            return true;
          }
          else
          {
            return false;
          }
        }

        // How do you check if a given string is a palindrome?
        // This techique uses the Array.Reverse
        public static bool PalindromeStringArray(string testWord)
        {
          char[] wordArray = testWord.ToCharArray();
          Array.Reverse(wordArray);
          string reverseWord = new string(wordArray);

          if (testWord.Equals(reverseWord, StringComparison.OrdinalIgnoreCase))
          {
            return true;
          }
          else
          {
            return false;
          }
        }

        public static string DoubleLetter()
        {
          var doubleLetters = Enumerable.Range((char)65, 26)
            .SelectMany(x => Enumerable.Range((char)65, 26).Select(y => (char)x + "" + (char)y));

          foreach (var doubleLetter in doubleLetters)
          {
            Console.Write(doubleLetter + " "); // AA AB AC ... AZ BA BB ... ZX ZY ZZ
          }
        }
    }
}
