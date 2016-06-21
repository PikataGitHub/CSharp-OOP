namespace ExtensionMethods_01_02.Extensions
{
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> numbers) where T : struct
        {
            T sumOfNumbers = (dynamic)0;

            foreach (var number in numbers)
            {
                sumOfNumbers += (dynamic)number;
            }
            return sumOfNumbers;
        }

        public static T Product<T>(this IEnumerable<T> numbers) where T : struct
        {
            T productOfNumbers = (dynamic)1;

            foreach (var number in numbers)
            {
                productOfNumbers *= (dynamic)number;
            }
            return productOfNumbers;
        }

        public static dynamic Average<T>(this IEnumerable<T> numbers) where T : struct
        {             
            T sum = (dynamic)0;
            dynamic count = 0;

            foreach (var number in numbers)
            {
                sum += (dynamic)number;
                count++;
            }

            dynamic averageOfCollection = (dynamic)sum / count;

            return averageOfCollection;
        }

        public static T MinValue<T>(this IEnumerable<T> numbers) where T : struct
        {
            T minValue = numbers.FirstOrDefault();
            foreach (var number in numbers)
            {
                if (minValue > (dynamic)number)
                {
                    minValue = number;
                }
            }
            return minValue;
        }

        public static T MaxValue<T>(this IEnumerable<T> numbers) where T : struct
        {
            T maxValue = numbers.FirstOrDefault();
            
            foreach (var number in numbers)
            {
                if (maxValue < (dynamic)number)
                {
                    maxValue = number;
                }
            }
            return maxValue;            
        }
    }
}
