namespace Problem1.StudentClass
{
    using Enumerations;
    using System;

    public class StartUp
    {
        static void Main()
        {
            //Test Problem 1. Student class: 
            var peshoStudent = new Student("Pesho", "Dimitrov", "Peshev", 9012036553, "Address in Sofia", "0899633253", "pesho@abv.bg", "SChaprCourse", Speciality.Georgapry, University.Sofia_University, Faculty.Faculty_Of_Economics);

            var joroStudent = new Student("Joro", "Georgiev", "Ivanov", 8910234421, "Address in Plovdiv", "0899635423", "joro@abv.bg", "JavaScriptCourse", Speciality.Mathematics, University.Technical_University, Faculty.Faculty_Of_Physics);

            //Test Equal method
            Console.WriteLine("Test Problem 1. Student class:");
            Console.WriteLine("Test Equal Method:");
            Console.WriteLine(peshoStudent.Equals(joroStudent));

            //Test ToString method
            Console.WriteLine("\nTest ToString() method:\n");
            Console.WriteLine(peshoStudent.ToString());

            //Test GetHashCode
            Console.WriteLine("\nTest GethashCode(): ");
            Console.WriteLine("HashCode for {0} is: {1}", peshoStudent.FirstName, peshoStudent.GetHashCode());
            Console.WriteLine("HashCode for {0} is: {1}", joroStudent.FirstName, joroStudent.GetHashCode());

            //Test == and != opperators
            Console.WriteLine("\nTest == and != opperators: ");
            Console.WriteLine("Is? ==  - " + (peshoStudent == joroStudent).ToString());
            Console.WriteLine("Is? !=  - " + (peshoStudent != joroStudent).ToString());
            Console.WriteLine();

            //Test Problem 2. ICloneable:
            Console.WriteLine("Test Problem 2. ICloneable:");
            var peshoClone = peshoStudent.Clone() as Student;

            peshoClone.Course = "Workshop Course";
            peshoClone.Speciality = Speciality.Iconomics;

            Console.WriteLine("\nCloned Studend with changed properties (deep copy) \"Course\" and \"Speciality\":\n");
            Console.WriteLine(peshoClone);

            //Test Problem 3. IComparable:
            Console.WriteLine("Test Problem 3. IComparable:");
            Console.WriteLine(joroStudent.CompareTo(peshoStudent));
            Console.WriteLine(peshoStudent.CompareTo(peshoClone));
        }
    }
}
