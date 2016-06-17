namespace Space3D
{
    using System.IO;

    public class PathStorage
    {
        internal static Path ReadFromFile(string inputfilePath)
        {
            Path inputData = new Path();
            StreamReader reader = new StreamReader(inputfilePath);

            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    Point3D pointFromFile = Point3D.Parse(line);
                    inputData.AddPoint(pointFromFile);
                    line = reader.ReadLine();
                }
            }
            return inputData;
        }

        internal static void WriteToFile(Path outputData, string outputFilePath)
        {
            StreamWriter writer = new StreamWriter(outputFilePath, true);
            
            using (writer)
            {
                for (int i = 0; i < outputData.ListOfPoints.Count; i++)
                {
                    writer.WriteLine(outputData.ListOfPoints[i]);
                }
            }
        }
    }
}