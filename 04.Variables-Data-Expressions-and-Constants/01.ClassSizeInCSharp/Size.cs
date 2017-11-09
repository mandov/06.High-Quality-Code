namespace VariablesDataExpressionsAndConstantsHomeworkTaskOne
{
    using System;

    public class Size
    {
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; private set; }

        public double Height { get; private set; }

        public static Size GetRotatedSize(Size objectToRotate, double rotationAngle)
        {
            double rotationAngleCos = Math.Cos(rotationAngle);
            double rotationAngleSin = Math.Sin(rotationAngle);
            double rotationCosAbs = Math.Abs(rotationAngleCos);
            double rotationSinAbs = Math.Abs(rotationAngleSin);

            double width = (rotationCosAbs * objectToRotate.Width) + (rotationSinAbs * objectToRotate.Height);
            double height = (rotationSinAbs * objectToRotate.Width) + (rotationCosAbs * objectToRotate.Height);

            return new Size(width, height);
        }
    }
}
