using System;
using System.Collections;
using System.Linq;

namespace sampleDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World!";
            Console.WriteLine(message);

            // String Related problems
            var nonRepeatChar = StringRelated.FirstNonRepeatChar(message);
            Console.WriteLine("First non-repeat char is..." + nonRepeatChar.ToString());

            var occurrenceCountDictionary = StringRelated.CountAllOccurrenceChar(message);
            foreach (var charCount in occurrenceCountDictionary)
            {
                Console.WriteLine("Char {0} has {1} occurrence.", charCount.Key, charCount.Value);
            }

            string palindromeString = "level";
            string nonPalindromeString = "base";

            Console.WriteLine("Are these palindrome strings:");
            Console.WriteLine("{0} = {1}", palindromeString, StringRelated.PalindromeIterative(palindromeString));
            Console.WriteLine("{0} = {1}", nonPalindromeString, StringRelated.PalindromeIterative(nonPalindromeString));

            Console.WriteLine("Are these palindrome strings:");
            Console.WriteLine("{0} = {1}", palindromeString, StringRelated.PalindromeStringArray(palindromeString));
            Console.WriteLine("{0} = {1}", nonPalindromeString, StringRelated.PalindromeStringArray(nonPalindromeString));


            // Math Related problems
            // Fibonacci numbers
            int numberOfSeq = 30;
            var thirtiethFib = MathRelated.Fibonacci().Skip(numberOfSeq - 1).Take(1).First();
            Console.WriteLine("Fibonacci number for seq({0}) is...{1}", numberOfSeq, thirtiethFib);

            Console.WriteLine("Fibonacci number recursive:");
            MathRelated.FibonacciSeries(0, 1, 1, numberOfSeq);
            Console.WriteLine();

            Console.WriteLine("Fibonacci number iterative:");
            MathRelated.FibonacciIterate(0, 1, numberOfSeq);
            Console.WriteLine();

        }
    }
}
