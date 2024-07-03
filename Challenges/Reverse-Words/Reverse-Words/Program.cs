using System;

namespace Reverse_Words
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = "csharp is programming language";
            Console.WriteLine($"Input : {str}");
            Console.WriteLine($"Output : {ReverseWords(str)}");
        }

        public static string ReverseWords(string input)
        {
            if (input == null)
            {
                return input;
            }

            string[] words = input.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}