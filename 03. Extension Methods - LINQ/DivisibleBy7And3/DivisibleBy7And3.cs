namespace DivisibleBy7And3
{
    using System;
    using System.Linq;

    class DivisibleBy7And3
    {
        static void Main()
        {
            var arrayOfIntegers = new[] { 25, 20, 1, 23, 21, 87, -65, -45, -56, 49, 27, 18, 35, 0, -1, 42 };

            //Using lambda extensions
            var arrayWithLambda = arrayOfIntegers
                .Where(num => num % 3 == 0 && num % 7 == 0)
                .ToArray();

            Console.WriteLine("Using lambda extensions:");
            foreach (var number in arrayWithLambda)
            {
                Console.Write(number + " ");
            }

            //Using LINQ query

            var arrayWithLINQ =
                from number in arrayOfIntegers
                where number % 21 == 0
                select number;

            Console.WriteLine("\n\nUsing LINQ query:");
            foreach (var number in arrayWithLINQ)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
