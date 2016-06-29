namespace _01.Shapes
{
    class Rectangle : Shape
    {
        //Constructors
        public Rectangle(double width, double height) : base(width, height) { }

        //Methods
        public override double CalculateSurface()
        {
            return width * height;
        }
    }
}
