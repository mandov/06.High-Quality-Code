namespace QualityMethods
{
    using System;

    public class FormatNumbers
    {
       public static string DigitToDigitWord(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Number must be in range 0 - 9!");
            }
        }

        public static void PrintNumberLikePercentage(double number)
        {
            Console.WriteLine("Number with Percentage fix:{0:P0}", number);
        }

        public static void PrintNumberWithFloatPointTwoDigitsPrecision(double number)
        {
            Console.WriteLine("Number with float point fix:{0:F2}", number);
        }

        public static void PrintNumberWithEightSpacesRighAlign(double number)
        {
            Console.WriteLine("Number with right align:{0,8}", number);
        }
    }
}
