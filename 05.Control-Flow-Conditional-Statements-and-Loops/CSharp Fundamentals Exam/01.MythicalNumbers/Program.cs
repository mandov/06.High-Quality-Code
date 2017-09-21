using System;
using MythicalNumbers;

public class Startup
{
    static void Main(string[] args)
    {
        double input = double.Parse(Console.ReadLine());
        ThirdDigitCalculation calc = new ThirdDigitCalculation(input);
        Console.WriteLine("Result:{0:F2}", calc.Result);
    }
}
