namespace Problem1.StudentClass
{
    using Problem1.StudentClass.Enumerations;
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        //Fields
        private const int hashConstant = 11;

        //Constructors
        public Student(string firstName, string middleName, string lastName, long socialSecNum, string permanentAddress, string mobilePhone, string email, string course, Speciality speciality, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = socialSecNum;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Speciality = speciality;
            this.University = university;
            this.Faculty = faculty;
        }

        //Properties
        public string FirstName { get; private set; }

        public string MiddleName { get; private set; }

        public string LastName { get; private set; }

        public long SSN { get; private set; }

        public string PermanentAddress { get; private set; }

        public string MobilePhone { get; private set; }

        public string Email { get; private set; }

        public string Course { get; set; }

        public Speciality Speciality { get; set; }

        public University University { get; private set; }

        public Faculty Faculty { get; private set; }

        //Methods
        public override bool Equals(object anotherStudent)
        {
            var equalStudent = anotherStudent as Student;

            if (equalStudent == null) { return false; }
            if (this.FirstName != equalStudent.FirstName) { return false; }
            if (this.MiddleName != equalStudent.MiddleName) { return false; }
            if (this.LastName != equalStudent.LastName) { return false; }
            if (this.SSN != equalStudent.SSN) { return false; }
            if (this.PermanentAddress != equalStudent.PermanentAddress) { return false; }
            if (this.MobilePhone != equalStudent.MobilePhone) { return false; }
            if (this.Email != equalStudent.Email) { return false; }
            if (this.Course != equalStudent.Course) { return false; }
            if (this.Speciality != equalStudent.Speciality) { return false; }
            if (this.University != equalStudent.University) { return false; }
            if (this.Faculty != equalStudent.Faculty) { return false; }

            return true;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(String.Format("Full name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            builder.AppendLine("SSN: " + this.SSN);
            builder.AppendLine("Address: " + this.PermanentAddress);
            builder.AppendLine("Mobile Phone: " + this.MobilePhone);
            builder.AppendLine("Email: " + this.Email);
            builder.AppendLine("Course: " + this.Course);
            builder.AppendLine("Speciality: " + this.Speciality);
            builder.AppendLine("University: " + this.University);
            builder.AppendLine("Faculty: " + this.Faculty);

            return builder.ToString();
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() * hashConstant + this.SSN.GetHashCode();
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !Student.Equals(firstStudent, secondStudent);
        }

        //Solve Problem 2. ICloneable
        public object Clone()
        {
            var firstNameCloning = this.FirstName.Clone() as string;
            var middleNameCloning = this.MiddleName.Clone() as string;
            var lastNameCloning = this.LastName.Clone() as string;
            var permanentAddressCloning = this.PermanentAddress.Clone() as string;
            var emailCloning = this.Email.Clone() as string;
            var courseCloning = this.Course.Clone() as string;

            var cloningStudent = new Student(firstNameCloning, middleNameCloning, lastNameCloning, this.SSN, permanentAddressCloning, this.MobilePhone, emailCloning, courseCloning, this.Speciality, this.University, this.Faculty);

            return cloningStudent;
        }

        //Solve Problem 3. IComparable
        public int CompareTo(Student otherStudent)
        {
            var firstStudentFullName = this.FirstName + this.MiddleName + this.LastName;
            var secondStudentFullName = otherStudent.FirstName + otherStudent.MiddleName + otherStudent.LastName;

            if (firstStudentFullName.CompareTo(secondStudentFullName) < 0) { return -1; }
            if (firstStudentFullName.CompareTo(secondStudentFullName) > 0) { return 1; }
            if (firstStudentFullName.CompareTo(secondStudentFullName) == 0)
            {
                if (this.SSN.CompareTo(otherStudent.SSN) < 0) { return -1; }
                if (this.SSN.CompareTo(otherStudent.SSN) > 0) { return 1; }
            }
            return 0;
        }
    }
}
