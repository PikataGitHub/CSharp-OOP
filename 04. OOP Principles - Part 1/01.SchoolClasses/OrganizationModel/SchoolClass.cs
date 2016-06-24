namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class SchoolClass : IComment
    {
        //Fields
        private const string initialComent = null;
        private string optionalComment;
        private string uniqueClassIdentifier;

        //Constructors
        public SchoolClass(string classiIdentifier, List<Student> studentsInThisClass, List<Teacher> setOfTeachers)
        {
            this.UniqueClassIdentifier = classiIdentifier;
            this.StudentsInClass = new List<Student>();
            this.teachersForThisClass = new List<Teacher>();
            this.OptionalComment = initialComent;
        }

        //Properties
        public string UniqueClassIdentifier
        {
            get { return this.uniqueClassIdentifier; }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Invalid input for class Identifier!");
                }
                this.uniqueClassIdentifier = value;
            }
        }        

        public List<Student> StudentsInClass { get; set; }

        public List<Teacher> teachersForThisClass { get; set; }

        public string OptionalComment
        {
            get { return this.optionalComment; }
            set { this.optionalComment = value; }
        }

        //Methods
        public string AddComment(string comment)
        {
            OptionalComment = comment;
            return OptionalComment;
        }
    }
}
