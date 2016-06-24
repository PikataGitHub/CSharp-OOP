namespace _02.StudentsAndWorkers
{
    public abstract class Human
    {
        //Fields
        private string firstName;
        private string lastName;

        //Constructors
        public Human(string inputFirstName, string inputLastName)
        {
            this.FirstName = inputFirstName;
            this.LastName = inputLastName;
        }

        //Properties
        public string FirstName
        {
            get { return this.firstName; }
            private set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set { this.lastName = value; }
        }

        //Methods
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
