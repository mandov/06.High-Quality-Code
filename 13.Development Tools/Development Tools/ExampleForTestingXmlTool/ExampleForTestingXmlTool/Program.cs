using System;
/// <summary>
/// Example
/// </summary>
namespace ExampleForTestingXmlTool
{
    public class Calculations
    {
        static void Main()
        {
        }
        /// <summary>
        /// Sum a parameter with b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Sum(double a, double b)
        {
            double result = a + b;
            return result;
        }

        /// <summary>
        /// Subtract a parametar with b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Subtract(double a, double b)
        {
            double result = a - b;
            return result;
        }
    }
}