using System;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            exampleFour();
        }

        static void exampleOne()
        {
            int[] scores = [97, 92, 81, 60];

            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            foreach (var i in scoreQuery)
            {
                Console.WriteLine(i + " ");
            }
        }

        static void exampleTwo()
        {
            // The Three Parts of a LINQ Query
            // 1. Data source.
            int[] numbers = [0, 1, 2, 3, 4, 5, 6];

            // 2. Query creation
            // numQuery is an IEnumerable<int>
            var numQuery = from num in numbers
                           where (num % 2) == 0
                           select num;

            // 3. Query execution
            foreach (int num in numQuery)
            {
                Console.WriteLine("{0,1} ", num);
            }
        }

        static void exampleThree()
        {
            int[] numbers = [0, 1, 2, 3, 4, 5, 6];
            var evenNumQuery = from num in numbers
                               where (num % 2) == 0
                               select num;

            int evenNumCount = evenNumQuery.Count();

            Console.WriteLine(evenNumCount);
        }

        static void exampleFour()
        {
            int[] numbers = [0, 1, 2, 3, 4, 5, 6];

            List<int> numQuery2 = (from num in numbers
                                   where (num % 2) == 0
                                   select num).ToList();

            var numQuery3 = (from num in numbers
                             where (num % 2) == 0
                             select num).ToArray();
        }
    }
}

