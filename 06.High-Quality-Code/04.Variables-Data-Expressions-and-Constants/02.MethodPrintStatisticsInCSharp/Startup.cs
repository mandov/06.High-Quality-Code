using System;
using MethodPrintStatisticsInCSharp;

public class Program
{
    public static void Main()
    {
        double[] numbers = new double[] { 554, 2, 3, 454 };
        CalculateStatistics statistics = new CalculateStatistics(numbers);
        statistics.PrintStatistics();
    }
}