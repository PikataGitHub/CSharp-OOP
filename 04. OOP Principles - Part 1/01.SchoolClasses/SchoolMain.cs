namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    class SchoolMain
    {
        static void Main()
        {
            var teacherOOP = new Teacher("Ivanov");
            teacherOOP.Disciplines.Add(new Discipline("CSharp OOP", 7, 100));

            var teacherCSS = new Teacher("Petrov", new List<Discipline>{new Discipline("CSS", 6, 35), new Discipline("JS Fundamentals", 10, 222) });

            Console.WriteLine(teacherCSS.Disciplines[1].DisciplineName);
            teacherOOP.AddComment("Tests will start today");
            Console.WriteLine(teacherOOP.OptionalComment);

            var CSharpAdvanced = new Discipline("C# Advanced", 8, 144);
            Console.WriteLine(CSharpAdvanced.OptionalComment);
            CSharpAdvanced.AddComment("TEST TODAY");
            Console.WriteLine(CSharpAdvanced.OptionalComment);

            var firstGradeStudent = new Student("Dimitrov", 023563);
            firstGradeStudent.OptionalComment = "I am the BEST Student in this Class";            
            Console.WriteLine("Optional comment:" + firstGradeStudent.OptionalComment);
            Console.WriteLine();

            //Anyone can test any feature here below ... I guess ot will work! ;)


        }
    }
}
