using System;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            exampleOne();
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
    }
}

