namespace Space3D
{
    using System;
    using System.Text;    

    public struct Point3D
    {
        //Fields
        private static readonly Point3D pointO = new Point3D(0,0,0);

        //Constructors
        public Point3D(double coodinateX, double coordinateY, double coordinateZ)
        {
            this.X = coodinateX;
            this.Y = coordinateY;
            this.Z = coordinateZ;
        }

        //Property for zero point
        public static Point3D PointO
        {
            get
            {
                return pointO;
            }
        }
                
        //Properties
        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        //Methods
        internal static Point3D Parse(string line) //Method for parsing points from file
        {
            StringBuilder numberAsCoordinate = new StringBuilder();
            double[] coordinates3D = new double[3];
            int coordinatesIndex = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (Char.IsDigit(line[i]) || line[i] == '-')
                {

                    while (i < line.Length && (Char.IsDigit(line[i]) || line[i] == '-' || line[i] == '.'))
                    {
                        numberAsCoordinate.Append(line[i]);
                        i++;
                    }
                }

                if (coordinates3D.Length > 0)
                {
                    coordinates3D[coordinatesIndex] = double.Parse(numberAsCoordinate.ToString());
                    coordinatesIndex++;
                    numberAsCoordinate.Clear();
                }
            }

            return new Point3D(coordinates3D[0], coordinates3D[1], coordinates3D[2]); ;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}", this.X, this.Y, this.Z);
        }
    }
}
