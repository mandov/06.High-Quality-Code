namespace QualityMethods
{
    using System;

    public class Calculations
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides must be greater than 0!");
            }

            if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new ArgumentOutOfRangeException("These sides cannot form a triangle!");
            }

            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

            return area;
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Elements should not be empty!");
            }

            int max = int.MinValue;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            return distance;
        }

        public static bool IsHorizontalLinear(double x1, double x2)
        {
            return x1 == x2;
        }

        public static bool IsVerticalLinear(double y1, double y2)
        {
            return y1 == y2;
        }
    }
}
