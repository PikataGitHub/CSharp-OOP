namespace _01.Shapes
{
    public abstract class Shape
    {
        //Fields 
        internal double width;
        internal double height;

        //Constructors
        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        //Methods
        public abstract double CalculateSurface();
    }
}
