namespace StudentGroups_09_19
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TestLINQandExtension
    {
        public static void Main()
        {
            var graduateStudents = new List<Student>
            { new Student("Dimitar", "Dimitrov", 122102, "+359883665456", "dimitar.dimitrov@abv.bg", new List<int> { 2, 5, 6, 4, 6 }, 1),
            new Student("Petar", "Petrov", 324206, "+359884222456", "petar.petrov@yahoo.com", new List<int> { 3, 4, 5, 5, 3}, 2),
            new Student("Ivan", "Ivanov", 632506, "+35923111111", "ivan.ivanov@yahoo.com", new List<int> { 3, 5, 2, 3, 4, 2 }, 3),
            new Student("Pavlina", "Pavlova", 216503, "+359883666555", "pavlina.pavlova@gmail.com", new List<int> { 2, 2, 5, 5, 6}, 1),
            new Student("Teodora", "Todorova", 210607, "+359883442442", "Teodora.Todorova@abv.bg", new List<int> { 2, 2, 2, 4, 5 }, 2),
            new Student("Petko", "Petkov", 219605, "+3592999333", "petko.petkov@gmail.com", new List<int> { 5, 5, 6, 6, 6}, 3)
            };
            Console.SetBufferSize(125, 150);
            Console.SetWindowSize(100, 40);

            //Problem 9. Student groups - Select only the students that are from group number 2.
            var studentsFromGroup2 = graduateStudents
                .Where(st => st.GroupNumber == 2)
                .ToArray();

            Console.WriteLine("Problem 9. Select only the students that are from group number 2:\n");
            PrintCollection(studentsFromGroup2);

            //Problem 9. Student groups - Use LINQ query. Order the students by FirstName.
            var orderedStudentsByFirstName =
                from student in graduateStudents
                orderby student.FirstName ascending
                select student;

            Console.WriteLine("\n\nProblem 9. Order the students by FirstName with LINQ:\n");
            PrintCollection(orderedStudentsByFirstName);

            //Problem 10. Student groups extensions - the previous one more time - Order the students by FirstName.
            var orderedStudentsByFirstNameExtension = graduateStudents
                .OrderBy(st => st.FirstName)
                .ToArray();

            Console.WriteLine("\n\nProblem 10. Order the students by FirstName with Extensions:\n");
            PrintCollection(orderedStudentsByFirstNameExtension);

            //Problem 11. Extract students by email.
            var extractedByEmail =
                from student in graduateStudents
                where student.Email.Substring((student.Email.IndexOf('@') + 1), 6) == "abv.bg"
                select student;

            Console.WriteLine("\n\nProblem 11. Extract students by email (abv.bg) with LINQ:\n");
            PrintCollection(extractedByEmail);

            //Problem 12. Extract students by phone - Sofia numbers start with '+3592'
            var extractedByPhone =
                from student in graduateStudents
                where student.Tel.Substring(0, 5) == "+3592"
                select student;

            Console.WriteLine("\n\nProblem 12. Extract students by phone\n");
            PrintCollection(extractedByPhone);

            //Problem 13. Extract students by marks - Creates NEW Anonymous Class Type {String FullName, List Marks} !!! JUST Terrible :D, but it's working! 
            var quieryToTest =
                from student in graduateStudents
                where student.Marks.Contains(6)
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    Marks = student.Marks
                };

            Console.WriteLine("\n\nProblem 13. Extract students by marks - Creates NEW Anonymous Class Type\n"); //Because it's anonymous class - I have to do majic just to print it! Pfff...
            foreach (var student in quieryToTest)
            {
                Console.Write(student.FullName + ", Marks:(");
                for (int i = 0; i < student.Marks.Count - 1; i++)
                {
                    Console.Write(student.Marks[i] + ", ");
                }
                Console.Write(student.Marks[student.Marks.Count - 1] + ")\n");
            }

            //Problem 14. Extract students with two marks
            var extractByTwoMarks = graduateStudents
                .Where(st => st.Marks.Contains(2))
                .ToArray();

            Console.WriteLine("\n\nProblem 14. Extract students with two \"2\" marks:\n");
            foreach (var student in extractByTwoMarks)
            {
                int counterOfMark2 = 0;
                for (int i = 0; i < student.Marks.Count; i++)
                {
                    if (student.Marks[i] == 2)
                    {
                        counterOfMark2++;
                    }
                }
                if (counterOfMark2 == 2)
                {
                    Console.WriteLine(student.ToString());
                }
            }

            //Problem 15. Extract marks of the students that enrolled in 2006. 
            var extractMarks = graduateStudents
                .Where(st => st.FN.ToString().Substring(4, 2) == "06")
                .Select(st => st.Marks)
                .ToArray();

            Console.WriteLine("\n\nProblem 15. Extract marks of the students that enrolled in 2006\n");
            foreach (var mark in extractMarks)
            {
                for (int i = 0; i < mark.Count; i++)
                {
                    Console.Write(mark[i] + " ");
                }
            }

            //Problem 16. Problem 16.* Groups.
            var groups = new List<Group>()
            {
                new Group(1, "Informatics"),
                new Group(2, "Mathematics"),
                new Group(3, "Literature")
            };

            var extractedByDepartment =
                from student in graduateStudents
                join gr in groups
                on student.GroupNumber equals gr.GroupNumber
                where student.GroupNumber == 2
                select student;

            Console.WriteLine("\n\nProblem 16. Problem 16.* Groups - extract by Mathematics department = Group 2:\n");
            PrintCollection(extractedByDepartment);

            //Problem 18. Grouped by GroupNumber - Use LINQ:
            var groupedByGroupNumber =
                from student in graduateStudents
                group student by student.GroupNumber
                into student                
                select student;

            Console.WriteLine("\n\nProblem 18. Grouped by GroupNumber - Use LINQ:\n");
            foreach (var groupColection in groupedByGroupNumber)
            {
                Console.WriteLine("Group Number :" + groupColection.Key);
                PrintCollection(groupColection);
            }

            //Problem 19. Grouped by GroupName extensions:
            var groupedByGroupNumberExtensions = graduateStudents
                .GroupBy(st => st.GroupNumber)
                .ToArray();
            
            Console.WriteLine("\n\nProblem 19. Grouped by GroupName Extensions:\n");
            foreach (var groupColection in groupedByGroupNumberExtensions)
            {
                Console.WriteLine("Group Number :" + groupColection.Key);
                PrintCollection(groupColection);
            }
        }

        //Method for printing collection
        private static void PrintCollection(IEnumerable<Student> collection)
        {
            int count = 1;
            foreach (var student in collection)
            {
                Console.WriteLine(count + ". " + student.ToString());
                count++;
            };
        }
    }
}
