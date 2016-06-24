namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal 
    {
        //Fields
        private string name;
        private Sex sex;
        private int age;

        //Constructors
        protected Animal(string initialName, int intialAge, Sex initialSex)
        {
            this.Name = initialName;
            this.Age = intialAge;
            this.sex = initialSex;
        }

        //Properties
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be null or empty!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age must be at least 1 !");
                }
                this.age = value;
            }
        }

        public Sex Sex
        {
            get { return sex; }
            protected set { sex = value; }
        }

        //Methods
        public override string ToString()
        {
            return string.Format("My name is {0}, I'm a {1}. I'm {2} and am {3} years old", this.Name,
                this.GetType().Name, this.Sex, this.Age);
        }

        public static double AvarageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(x => x.Age);
        }
    }
}
