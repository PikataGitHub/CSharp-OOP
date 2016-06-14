namespace Space3D
{
    using System;

    public class Space3DMain
    {
        public static void Main()
        {
            var point = new Point3D();
            point.X = 1;
            point.Y = 1;
            point.Z = 1;

            Console.WriteLine(point.ToString());
            var zeroPoint = Point3D.PointO;
            Console.WriteLine(zeroPoint.ToString());

            Console.WriteLine(CalculateDistance.GetDistanceBetween(point, zeroPoint));
        }
    }
}
