namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;

    public class ShapesMain
    {
        public static void Main()
        {
            var differentShapes = new List<Shape>
            { new   Triangle(10, 10),
              new   Rectangle(5, 8),
              new   Square(10) };

            foreach (var shape in differentShapes)
            {
                Console.WriteLine(String.Format("I am a {0}, my dimentions are width: {1} and height: {2}, and my Area is: {3}\n", shape.GetType(), shape.width, shape.height, shape.CalculateSurface()));
            }
        }
    }
}
