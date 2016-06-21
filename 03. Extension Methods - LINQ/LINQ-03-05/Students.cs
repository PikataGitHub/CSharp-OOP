namespace LINQ_03_05
{
    public class Student
    {
        //Constructor
        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        //Properties
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }        
    }
}
