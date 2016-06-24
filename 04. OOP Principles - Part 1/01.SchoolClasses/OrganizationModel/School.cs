namespace _01.SchoolClasses
{
    using System.Collections.Generic;

    public class School
    {
        //Fields
        private string nameOfSchool;

        //Constructors
        public School(string nameOfTheSchool, List<SchoolClass> classesInThisSchool)
        {
            this.nameOfSchool = nameOfTheSchool;
            this.ClassesSet = classesInThisSchool;
        }

        //Properties
        public List<SchoolClass> ClassesSet { get; private set; }

        public string NameOfSchool
        {
            get { return this.nameOfSchool; }
        }
    }
}
