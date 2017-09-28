namespace CohesionAndCoupling
{
    using System;

    public class Demo
    {
        public static void Main()
        {
            FileExtensionExamples();

            FigureCalculation2DExamples();

            FigureCalculations3DExamples();
        }

        private static void FileExtensionExamples()
        {
            Console.WriteLine(File.GetFileExtension("example"));
            Console.WriteLine(File.GetFileExtension("example.pdf"));
            Console.WriteLine(File.GetFileExtension("example.new.pdf"));

            Console.WriteLine(File.GetFileNameWithoutExtension("example"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example.new.pdf"));
        }

        private static void FigureCalculation2DExamples()
        {
            var distance = DistanceCalculator.CalcDistance2D(1, -2, 3, 4);
            Console.WriteLine("Distance in the 2D space = {0:f2}", distance);

            var figureWidth = 20.3;
            var figureHeight = 10.2;
            var diagonal = DistanceCalculator.CalcDistance2D(0, 0, figureWidth, figureHeight);

            Console.WriteLine("Diagonal XY = {0:f2}", diagonal);
        }

        private static void FigureCalculations3DExamples()
        {
            var distance = DistanceCalculator.CalcDistance3D(5, 2, -1, 3, -6, 4);
            Console.WriteLine("Distance in the 3D space = {0:f2}", distance);

            Utils.Width = 20.3;
            Utils.Height = 10.2;
            Utils.Depth = 5.6;

            var volume = Utils.CalcVolume();
            var diagonal = Utils.CalcDiagonalXYZ();

            Console.WriteLine("Volume = {0:f2}", volume);
            Console.WriteLine("Diagonal XYZ = {0:f2}", diagonal);
        }
    }
}