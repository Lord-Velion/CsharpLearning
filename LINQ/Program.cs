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

        static void exampleFive()
        {
            List<int> numbers = [1, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20];

            IEnumerable<int> queryFactorsOfFour = from num in numbers
                                                  where num % 4 == 0
                                                  select num;

            // Store the results in a new variable
            // without executing a foreach loop.
            var factorsofFourList = queryFactorsOfFour.ToList();

            // Read and write from the newly created list to demonstrate that it holds data.
            Console.WriteLine(factorsofFourList[2]);
            factorsofFourList[2] = 0;
            Console.WriteLine(factorsofFourList[2]);
        }

        static void exampleSix()
        {
            // Data source.
            int[] scores = [90, 71, 82, 93, 75, 82];

            // Query Expression.
            IEnumerable<int> scoreQuery = //query variable
                from score in scores //required
                where score > 80 // optional
                orderby score descending // optional
                select score; //must end with select or group

            // Execute the query to produce the results
            foreach (var testScore in scoreQuery)
            {
                Console.WriteLine(testScore);
            }

            // Output: 93 90 82 82
        }

        static void exampleSeven()
        {
            int[] numbers = [5, 10, 8, 3, 6, 12];

            //Query syntax:
            IEnumerable<int> numQuery1 =
                from num in numbers
                where num % 2 == 0
                orderby num
                select num;

            //Method syntax:
            IEnumerable<int> numQuery2 = numbers
                .Where(num => num % 2 == 0)
                .OrderBy(n => n);

            foreach (int i in numQuery1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(System.Environment.NewLine);
            foreach (int i in numQuery2)
            {
                Console.Write(i + " ");
            }
        }
    }
}

