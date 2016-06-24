namespace _03.AnimalHierarchy
{
    public class Cat : Animal, ISound
    {
        //Constructors
        public Cat(string name, int age, Sex sex) : base(name, age, sex)
        {
        }

        //Methods
        public string ProduceSound()
        {
            return "Miaaauuuuu-miauuuu";
        }
    }
}
