namespace Space3D
{
    using System.Collections.Generic;

    public class Path
    {
        //Constructors

        public Path()
        {
            this.ListOfPoints = new List<Point3D>();
        }

        //Properties

        public List<Point3D> ListOfPoints { get; set; }

        //Methods

        public void AddPoint(Point3D inputPoint)
        {
            this.ListOfPoints.Add(inputPoint);
        }
    }
}
