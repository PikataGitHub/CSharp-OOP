namespace _01.SchoolClasses
{
    public abstract class Human : IComment
    {
        //Fields
        private const string initialComment = null;
        private string optionalComment;

        //Constructors
        public Human(string name)
        {
            this.Name = name;
            this.OptionalComment = initialComment;
        }

        //Properties
        public string Name { get; private set; }

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
