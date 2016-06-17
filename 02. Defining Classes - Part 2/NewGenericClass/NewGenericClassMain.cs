namespace NewGenericClass
{
    using System;

    class NewGenericClassMain
    {
        static void Main()
        {
            GenericList<int> testArray = new GenericList<int>(4);
           
            testArray.AddElelment(653);
            testArray.AddElelment(6543);
            testArray.AddElelment(6563);
            testArray.AddElelment(65333);
            testArray.AddAtIndex(0, 890);
            testArray.AddAtIndex(0, 890);
            testArray.AddAtIndex(0, 890);
            testArray.AddAtIndex(0, 890);
            testArray.AddAtIndex(0, 100);
            testArray.AddAtIndex(0, 1000000);
            testArray.AddAtIndex(0, -200);
            
                    

            Console.WriteLine(testArray.Capacity);
            Console.WriteLine(testArray.Count);
            Console.WriteLine(testArray.MinElement());
            Console.WriteLine(testArray.MaxElement());

            testArray[10] = -123;
            Console.WriteLine(testArray);
        }
    }
}
