using System;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            zip();
        }

        static void filteringData_Keywords()
        {
            string[] words = ["the", "quick", "brown", "fox", "jumps"];

            IEnumerable<string> query = from word in words
                                        where word.Length == 3
                                        select word;

            foreach (string str in query)
            {
                Console.WriteLine(str);
            }
        }

        static void filteringData_Methods()
        {
            string[] words = ["the", "quick", "brown", "fox", "jumps"];

            IEnumerable<string> query =
                words.Where(word => word.Length == 3);

            foreach (string str in query)
            {
                Console.WriteLine(str);
            }
        }

        static void select_Keywords()
        {
            List<string> words = ["an", "apple", "a", "day"];

            var query = from word in words
                        select word.Substring(0, 1);

            foreach (string s in query)
            {
                Console.WriteLine(s);
            }
        }  

        static void select_Methods()
        {
            List<string> words = ["an", "apple", "a", "day"];

            var query = words.Select(word => word.Substring(0, 1));

            foreach (string s in query)
            {
                Console.WriteLine(s);
            }
        }

        static void selectMany_Keywords()
        {
            List<string> phrases = ["an apple a day", "the quick brown fox"];

            var query = from phrase in phrases
                        from word in phrase.Split(' ')
                        select word;

            foreach (string s in query)
            {
                Console.WriteLine(s);
            }
        }

        static void selectMany_Methods()
        {
            List<string> phrases = ["an apple a day", "the quick brown fox"];

            var query = phrases.SelectMany(phrase => phrase.Split(' '));

            foreach (string s in query)
            {
                Console.WriteLine(s);
            }
        }

        static void zip()
        {
            IEnumerable<int> numbers = [1, 2, 3, 4, 5, 6, 7];
            IEnumerable<char> letters = ['A', 'B', 'C', 'D', 'E', 'F'];

            foreach ((int number, char letter) in numbers.Zip(letters))
            {
                Console.WriteLine($"Number: {number} zipped with letter: '{letter}'");
            }

            IEnumerable<string> emoji = ["🤓", "🔥", "🎉", "👀", "⭐", "💜", "✔", "💯"];

            foreach ((int number, char letter, string em) in numbers.Zip(letters, emoji))
            {
                Console.WriteLine(
                    $"Number: {number} is zipped with letter: '{letter}' and emoji: {em}");
            }

            foreach (string result in numbers.Zip(letters, (number, letter) => $"{number} = {letter} ({(int)letter})"))
            {
                Console.WriteLine(result);
            }
        }
    }
}

