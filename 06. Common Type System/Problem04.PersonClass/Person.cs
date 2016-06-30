namespace Problem04.PersonClass
{
    using System;

    public class Person
    {
        //Fields
        private string name;
        private int? age;

        //Constructors
        public Person(string inputName, int? inputAge)
        {
            this.Name = inputName;
            this.Age = inputAge;
        }

        //Properties
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Person Name must be at least 3 letters");
                }
                this.name = value;
            }
        }

        public int? Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0 || value > 130)
                {
                    throw new ArgumentException("Age must be between [0; 130]");
                }
                this.age = value;
            }
        }

        //Methods
        public override string ToString()
        {
            if (this.Age == null)
            {
                return string.Format("Person Name: {0}, Age: \"not specified\"", this.Name);
            }

            return string.Format("Person Name: {0}, Age: {1}", this.Name, this.Age);
        }
    }
}
