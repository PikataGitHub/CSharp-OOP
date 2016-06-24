namespace _01.SchoolClasses
{  
    using System.Collections.Generic;

    public class Teacher : Human, IComment
    {
        //Constructors
        public Teacher(string name) : base(name)
        {
            this.Disciplines = new List<Discipline>();     
        }

        public Teacher(string name, List<Discipline> disciplines) : this(name)
        {
            this.Disciplines = disciplines;
        }

        //Properties
        public List<Discipline> Disciplines { get; set; }        
    }
}
