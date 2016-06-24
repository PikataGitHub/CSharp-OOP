namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentsAndWorkersMain
    {
        static void Main()
        {
            //Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
            var tenStudents = new List<Student>
            { new Student("Petar", "Petrov", 12),
              new Student("Stiliqn", "Vladimirov", 10),
              new Student("Teodora", "Yanev", 10),
              new Student("Ivan", "Ivanov", 9),
              new Student("Nikolina", "Georgieva", 12),
              new Student("Dimitrina", "Stoyanova", 11),
              new Student("Viktoria", "Dimitrova", 11),
              new Student("Desislav", "Dermendjiev", 10),
              new Student("Kristian", "Detelinov", 9),
              new Student("Ivajlo", "Kenov", 12) };

            var orderedTenStudents = tenStudents
                .OrderBy(st => st.Grade)
                .ToList();

            Console.WriteLine("Ordered Students By Grade: \n");
            for (int i = 0; i < orderedTenStudents.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + orderedTenStudents[i]);
            }

            //Initialize a list of 10 workers and sort them by money per hour in descending order.
            var tenWorkers = new List<Worker>
            { new Worker("Dobrin", "Dobrinov", 460.50, 8),
              new Worker("Petko", "Petkov", 512.00, 9),
              new Worker("Elena", "Peltekova",628.00, 8),
              new Worker("Ivan", "Vakareev", 326.50, 8),
              new Worker("Bojan", "Georgiev", 450.00, 10),
              new Worker("Asen", "Nikolov",255.50, 8),
              new Worker("Atanas", "Dobromirov", 333.00, 8),
              new Worker("Aleksandar", "Yakovliev",421.00, 10),
              new Worker("Georgi", "Peshev", 490.50, 8),
              new Worker("Simeon", "Simeonov", 1000.00, 10) };

            var orderedTenWorkers = tenWorkers
                .OrderByDescending(worker => worker.MoneyPerHour())
                .ToList();

            Console.WriteLine("\n\nOrdered Workers By MoneyPerHour - Descending: \n");
            for (int i = 0; i < orderedTenWorkers.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + orderedTenWorkers[i] +
                    " - CalculatedPerHour: " + "{0:F2}", orderedTenWorkers[i].MoneyPerHour());
            }

            //Merge the lists and sort them by first name and last name.

            var mergedList = new List<Human>();
            mergedList.AddRange(tenStudents);
            mergedList.AddRange(tenWorkers);

            var orderedMergedList = mergedList
                .OrderBy(item => item.FirstName)
                .ThenBy(item => item.LastName)
                .ToList();

            Console.WriteLine("\n\nOrdered By Names And merged Human List: \n");
            for (int i = 0; i < orderedMergedList.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + orderedMergedList[i]);
            }
            Console.WriteLine();
        }
    }
}
