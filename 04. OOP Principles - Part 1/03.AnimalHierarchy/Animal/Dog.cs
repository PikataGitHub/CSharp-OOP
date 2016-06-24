namespace _03.AnimalHierarchy
{
    public class Dog : Animal, ISound
    {
        //Constructors
        public Dog(string name, int age, Sex sex) : base(name, age, sex)
        {
        }

        //Methods
        public string ProduceSound()
        {
            return "Bau-BAu-Bau";
        }
    }
}
