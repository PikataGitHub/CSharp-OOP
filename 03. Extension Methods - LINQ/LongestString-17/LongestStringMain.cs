namespace LongestString_17
{
    using System;
    using System.Linq;

    class LongestStringMain
    {
        static void Main()
        {
            //Problem 17. Longest string
            var arrOfStrings = new string[9]
            {
                "With LINQ to SQL, for instance, it",
                "is possible to write",
                "a LINQ query which not only involves data from the server and",
                "functions on",
                "the",
                "server but also functions that can only be executed on the client and to mix them in together.",
                "The LINQ to SQL provider will then do its best",
                "to untangle things and execute the parts that it can on the server",
                "and other parts on the client."
            };

            var longestString = arrOfStrings
                .OrderByDescending(s => s.Length)
                .First();

            Console.WriteLine("String with maximum length from Array: \n\n\"" + longestString + "\"");
            Console.WriteLine();
        }
    }
}
