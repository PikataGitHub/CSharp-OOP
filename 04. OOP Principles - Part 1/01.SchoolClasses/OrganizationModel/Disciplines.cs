namespace _01.SchoolClasses
{    
    public class Discipline: IComment
    {
        //Fields
        private const string initialComent = null;
        private string optionalComment;
        
        //Constructors
        public Discipline(string disciplineName, int numberOfLectures, int numberOfExcercises)
        {
            this.DisciplineName = disciplineName;
            this.NumberOfLectures = numberOfLectures;
            this.NumberofExercises = numberOfExcercises;
            this.OptionalComment = initialComent;
        }

        //Properties
        public string DisciplineName { get; private set; }

        public int NumberOfLectures { get; private set; }

        public int NumberofExercises { get; private set; }

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
