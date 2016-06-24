namespace _03.AnimalHierarchy
{
    public class Frog : Animal, ISound
    {
        //Constructors
        public Frog(string name, int age, Sex sex) : base(name, age, sex)
        {
        }

        //Methods
        public string ProduceSound()
        {
            return "Qwakkk-Quakkk";
        }
    }
}
