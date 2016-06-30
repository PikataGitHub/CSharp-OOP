namespace Problem05._64BitArray
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            BitArray64 testArray = new BitArray64(ulong.MaxValue);
            //Test ToString
            Console.WriteLine(testArray);

            //Test Indexes
            Console.WriteLine(testArray[60]);

            BitArray64 anotherTestArray = new BitArray64(4294967295);

            //Print Second BitArray 
            Console.WriteLine(anotherTestArray);

            //Test GetHashCode
            Console.WriteLine(testArray.GetHashCode());
            Console.WriteLine(anotherTestArray.GetHashCode());

            //Test Equals
            Console.WriteLine(testArray.Equals(anotherTestArray));

            var thirdTestArray = new BitArray64(4294967295);
            Console.WriteLine(thirdTestArray == anotherTestArray);
        }
    }
}
