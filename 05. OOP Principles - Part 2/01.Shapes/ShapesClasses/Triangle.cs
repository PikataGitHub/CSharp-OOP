namespace _01.Shapes
{
    public class Triangle : Shape
    {
        //Constructors
        public Triangle(double width, double height) : base(width, height) { }

        //Methods
        public override double CalculateSurface()
        {
            return width * height / 2;
        }
    }
}
