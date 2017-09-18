namespace MethodPrintStatisticsInCSharp
{
    using System;
    using MethodPrintStatisticsInCSharp.Contracts;

   public class Printer : IPrintable
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}