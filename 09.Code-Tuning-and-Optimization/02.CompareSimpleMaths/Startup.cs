namespace CompareSimpleMaths
{
    using System;

    class Startup
    {
        static void Main()
        {
            long numberLikeLong = 1;
            int numberLikeInteger = 1;
            double numberLikeDouble = 1;
            decimal numberLikeDecimal = 1;
            float numberLikeFloat = 1;

            Console.WriteLine("Add");
            PerformanceTester<decimal>.Performance(numberLikeDecimal, "Add");
            PerformanceTester<long>.Performance(numberLikeLong, "Add");
            PerformanceTester<int>.Performance(numberLikeInteger, "Add");
            PerformanceTester<double>.Performance(numberLikeDouble, "Add");
            PerformanceTester<float>.Performance(numberLikeFloat, "Add");

            Console.WriteLine("\nSubtract");
            PerformanceTester<decimal>.Performance(numberLikeDecimal, "Subtract");
            PerformanceTester<long>.Performance(numberLikeLong, "Subtract");
            PerformanceTester<int>.Performance(numberLikeInteger, "Subtract");
            PerformanceTester<double>.Performance(numberLikeDouble, "Subtract");
            PerformanceTester<float>.Performance(numberLikeFloat, "Subtract");

            Console.WriteLine("\nIncerement");
            PerformanceTester<decimal>.Performance(numberLikeDecimal, "Increment");
            PerformanceTester<long>.Performance(numberLikeLong, "Increment");
            PerformanceTester<int>.Performance(numberLikeInteger, "Increment");
            PerformanceTester<double>.Performance(numberLikeDouble, "Increment");
            PerformanceTester<float>.Performance(numberLikeFloat, "Increment");

            Console.WriteLine("\nMultiply");
            PerformanceTester<decimal>.Performance(numberLikeDecimal, "Multiply");
            PerformanceTester<long>.Performance(numberLikeLong, "Multiply");
            PerformanceTester<int>.Performance(numberLikeInteger, "Multiply");
            PerformanceTester<double>.Performance(numberLikeDouble, "Multiply");
            PerformanceTester<float>.Performance(numberLikeFloat, "Multiply");

            Console.WriteLine("\nDivide");
            PerformanceTester<decimal>.Performance(numberLikeDecimal, "Divide");
            PerformanceTester<long>.Performance(numberLikeLong, "Divide");
            PerformanceTester<int>.Performance(numberLikeInteger, "Divide");
            PerformanceTester<double>.Performance(numberLikeDouble, "Divide");
            PerformanceTester<float>.Performance(numberLikeFloat, "Divide");                        
        }
    }
}