namespace Problem04.PersonClass
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            //Test functionality
            var personList = new List<Person>();

            personList.Add(new Person("Ivan", 30));
            personList.Add(new Person("Dimitar", 24));
            personList.Add(new Person("Pesho", null));
            personList.Add(new Person("George", 18));

            foreach (var person in personList)
            {
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine();
        }
    }
}
