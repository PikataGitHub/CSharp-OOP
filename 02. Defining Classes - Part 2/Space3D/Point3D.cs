namespace Space3D
{
    public struct Point3D
    {
        private static readonly Point3D pointO = new Point3D(0,0,0);

        public Point3D(double coodinateX, double coordinateY, double coordinateZ)
        {
            this.X = coodinateX;
            this.Y = coordinateY;
            this.Z = coordinateZ;
        }

        public static Point3D PointO
        {
            get
            {
                return pointO;
            }
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }
                
        public override string ToString()
        {
            return string.Format("{0},{1},{2}", this.X, this.Y, this.Z);
        }
    }
}
