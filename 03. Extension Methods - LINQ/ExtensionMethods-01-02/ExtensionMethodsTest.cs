namespace ExtensionMethods_01_02
{
    using Extensions;
    using System;
    using System.Collections.Generic;
    using System.Text;

    class ExtensionMethodsTest
    {
        static void Main()
        {
            //Test Stringbuilder Extension
            StringBuilder testBuilder = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                testBuilder.Append(i);
            }

            Console.WriteLine("Test Stringbuilder: " + testBuilder.ToString());

            var testSubBuilder = testBuilder.Substring(3, 3);

            Console.WriteLine("Substring.Stringbuilder: " + testSubBuilder.ToString());


            //Test IEnumerable Extension
            Console.WriteLine("\nTest IEnumerable Extension Test number 1:");
            var testList = new List<int>() { 10, 5, -20, 200 };

            Console.WriteLine($"Sum: {testList.Sum()}");
            Console.WriteLine($"Product: {testList.Product()}");
            Console.WriteLine($"Min element: {testList.MinValue()}");
            Console.WriteLine($"Max element: {testList.MaxValue()}");
            Console.WriteLine($"Average: {testList.Average()}");

            Console.WriteLine("\nTest number 2:");
            var someArray = new double[] { 11.16, -6.66, 19.78, 118.2, 4.9 };

            Console.WriteLine($"Sum: {someArray.Sum()}");
            Console.WriteLine($"Product: {someArray.Product()}");
            Console.WriteLine($"Min element: {someArray.MinValue()}");
            Console.WriteLine($"Max element: {someArray.MaxValue()}");
            Console.WriteLine($"Average: {someArray.Average()}");


        }
    }
}
