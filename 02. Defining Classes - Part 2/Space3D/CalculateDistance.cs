namespace Space3D
{
    public static class CalculateDistance
    {
        public static double GetDistanceBetween(Point3D pointA, Point3D pointB)
        {
            double distance = 
                System.Math.Sqrt((pointA.X - pointB.X) * (pointA.X - pointB.X) +
                                (pointA.Y - pointB.Y) * (pointA.Y - pointB.Y) + 
                                (pointA.Z - pointB.Z) * (pointA.Z - pointB.Z));
            return distance;
        }
    }
}
