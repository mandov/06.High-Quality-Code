namespace ClassSizeInCSharp
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

        public static Size GetRotatedSize(Size size, double angleOfTheFigureThatWillBeRotaed)
        {
            double cosineOfAngle = Math.Cos(angleOfTheFigureThatWillBeRotaed);
            double sineOfAngle = Math.Sin(angleOfTheFigureThatWillBeRotaed);
            double absoluteValueOfCosine = Math.Abs(cosineOfAngle);
            double absoluteValueOfSine = Math.Abs(sineOfAngle);
            double newHeight = (absoluteValueOfCosine * size.Width) + (absoluteValueOfSine * size.Height);
            double newWidth = (absoluteValueOfCosine * size.Width) + (absoluteValueOfSine * size.Height);

            return new Size(newWidth, newHeight);
        }
    }
}