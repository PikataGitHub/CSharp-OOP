namespace LINQ_03_05
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Solve_03_05
    {
        static void Main()
        {            
            var studentGroup = new Student[]
            {
                new  Student("Ivan", "Ivanov", 25),
                new  Student("Petar", "Ivanov", 20),
                new  Student("Stoyan", "Mihajlov", 18),
                new  Student("Georgi", "Stoev", 30),
                new  Student("Dimitar", "Aleksandrov", 26),
                new  Student("Hristina", "Petkova", 24),
                new  Student("Desislav", "Hristov", 26)
            };

            //03. Method that from a given array of students finds all students whose first name is before its last name alphabetically.
            var studentsWithFirstBeforeLastName = StudentsWithFirstBeforeLastName(studentGroup);

            Console.WriteLine("03. First name is before last name");
            foreach (var student in studentsWithFirstBeforeLastName)
            {
                Console.WriteLine(student.FullName);
            }

            //04. LINQ query(method) that finds the first name and last name of all students with age between 18 and 24.
            var ageBetween18And24 = GetAgeBetween18And24(studentGroup);

            Console.WriteLine("\n04. Students in range 18 - 24 years of age");
            foreach (var student in ageBetween18And24)
            {
                Console.WriteLine(student.FullName + " - " + student.Age + " years");
            }

            //Problem 5. Order students.
            //Variant 1 - using LINQ - see method below

            var descendingOrder = GetDescendingOrder(studentGroup);

            Console.WriteLine("\n05.Sorted decending with LINQ");
            foreach (var student in descendingOrder)
            {
                Console.WriteLine(student.FullName + " - " + student.Age + " years");
            }

            //Variant 2 - using OrderBy() and ThenBy()

            var descendingOrderLambda = studentGroup
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName)
                .ToArray();

            Console.WriteLine("\n05.Sorted decending with Lambda");
            foreach (var student in descendingOrderLambda)
            {
                Console.WriteLine(student.FullName + " - " + student.Age + " years");
            }
        }

        //Methods using LINQ queries
        private static IEnumerable<Student> StudentsWithFirstBeforeLastName(Student[] studentGroup)
        {
            var studentsWithFirstBeforeLastName =
                from student in studentGroup
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            return studentsWithFirstBeforeLastName;
        }

        private static IEnumerable<Student> GetAgeBetween18And24(Student[] studentGroup)
        {
            var ageBetween18And24 =
                from student in studentGroup
                where student.Age >= 18 && student.Age <= 24
                select student;

            return ageBetween18And24;
        }

        private static IEnumerable<Student> GetDescendingOrder(Student[] studentGroup)
        {
            var descendingOrder =
                from student in studentGroup
                orderby student.FullName descending
                select student;

            return descendingOrder;
        }
    }
}
