namespace _03.AnimalHierarchy
{
    using System;

    class AnimalHierarchyMain
    {
        static void Main()
        {
            Animal[] animals = new Animal[]
            {   new Frog("Jaba-Jaburana", 2, Sex.Male),
                new Kitten("Kitka", 6),
                new Frog("Jabcho", 1, Sex.Female),
                new Dog("Sarra", 11, Sex.Female),
                new Tomcat("Tomcho", 8),
                new Cat("Pisana", 1, Sex.Female),
                new Dog("Mecho", 12, Sex.Male) };

            Console.WriteLine("The avarage age of all Animals is: {0:0.00} years old", Animal.AvarageAge(animals));
            Console.WriteLine();

            foreach (ISound animial in animals)
            {
                Console.WriteLine("{0}. And I say to you \"{1}\"!", animial, animial.ProduceSound());
            }
            Console.WriteLine();
        }
    }
}
