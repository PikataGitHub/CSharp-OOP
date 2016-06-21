namespace StudentGroups_09_19
{
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        //Constructor
        public Student(string firstName, string lastName, int facultyNumber, string phoneNumber, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = facultyNumber;
            this.Tel = phoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        //Properties
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int FN { get; private set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        //Methods
        private string PrintMarks(List<int> inputMarks)
        {
            StringBuilder buildList = new StringBuilder();
            for (int i = 0; i < inputMarks.Count-1; i++)
            {
                buildList.AppendFormat("{0},", inputMarks[i]);
            }
            buildList.Append(inputMarks[inputMarks.Count-1]);

            return buildList.ToString();
        }

        //Override ToString()
        public override string ToString()
        {
            StringBuilder buildToString = new StringBuilder();
            buildToString.AppendFormat("{0} {1}, FN:{2}, {3}, {4}, Marks:({5}), Group:{6}", FirstName, LastName, FN, Tel, Email, PrintMarks(Marks), GroupNumber);

            return buildToString.ToString();
        }

    }
}
