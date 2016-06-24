namespace _01.SchoolClasses
{
    public class Student : Human, IComment
    {
        //Fields
        private int classNumber;

        //Constructors
        public Student(string name, int uniqueClassNumber) : base(name)
        {
            this.classNumber = uniqueClassNumber;
        }

        //Properties
        public int ClassNumber
        {
            get { return this.classNumber; }
        }
    }
}
