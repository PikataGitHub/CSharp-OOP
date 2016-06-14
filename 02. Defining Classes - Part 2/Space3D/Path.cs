namespace Space3D
{
    using System.Collections.Generic;
    
    public class Path
    {
        public Path()
        {
            this.SequenceOfPoints = new List<Point3D>();
        }

        public List<Point3D> SequenceOfPoints { get; set; }
    }
}
