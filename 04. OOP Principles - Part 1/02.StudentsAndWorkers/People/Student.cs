namespace _02.StudentsAndWorkers
{
    public class Student : Human
    {
        //Fields
        private int grade;

        //Constructors
        public Student(string inputFirstName, string inputLastName, int studentGrade) : base(inputFirstName, inputLastName)
        {
            this.Grade = studentGrade;
        }

        //Properties
        public int Grade
        {
            get { return this.grade; }
            private set { this.grade = value; }
        }

        //Methods
        public override string ToString()
        {
            return base.ToString() + " - Grade: " + Grade;
        }
    }
}
