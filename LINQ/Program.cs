using System;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            filteringData_1();
        }

        static void filteringData_1()
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

        static void filteringData_2()
        {
            string[] words = ["the", "quick", "brown", "fox", "jumps"];

            IEnumerable<string> query =
                words.Where(word => word.Length == 3);

            foreach (string str in query)
            {
                Console.WriteLine(str);
            }
        }

              
    }
}

