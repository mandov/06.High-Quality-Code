namespace QualityMethods
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Triangle area:{0}", Calculations.CalcTriangleArea(3, 4, 5));

            Console.WriteLine("Digit to string:{0}", FormatNumbers.DigitToDigitWord(5));

            Console.WriteLine("Max value from senquence:{0}", Calculations.FindMax(5, -1, 3, 2, 14, 2, 3));

            FormatNumbers.PrintNumberWithFloatPointTwoDigitsPrecision(1.3);
            FormatNumbers.PrintNumberLikePercentage(0.75);
            FormatNumbers.PrintNumberWithEightSpacesRighAlign(2.30);

            Console.WriteLine("Distance between points:{0}", Calculations.CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + Calculations.IsHorizontalLinear(3, 3));
            Console.WriteLine("Vertical? " + Calculations.IsVerticalLinear(-1, 2.5));

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov", City = "Sofia", BornDate = "01.02.2002" };
            Student stella = new Student() { FirstName = "Stella", LastName = "Markova", City = "Plovdiv", BornDate = "15.02.2002" };

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella.BornDate));
        }
    }
}