using System;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            select_Methods();
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


    }
}

