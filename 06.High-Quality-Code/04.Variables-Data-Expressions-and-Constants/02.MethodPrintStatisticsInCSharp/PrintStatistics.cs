namespace MethodPrintStatisticsInCSharp
{
    using System;
    using System.Linq;

    public class CalculateStatistics 
    {
        private double[] numbers;
        private double maxNumber;
        private double minNumber;
        private double averageNumber;

        public CalculateStatistics(double[] numbers)
        {
            this.numbers = numbers;
        }

        public void PrintStatistics()
        {
            Array.Sort(this.numbers);
            this.maxNumber = this.numbers[this.numbers.Length - 1];
            this.minNumber = this.numbers[0];
            this.averageNumber = this.numbers.Sum() / this.numbers.Length;

            Printer printer = new Printer();
            printer.Print("Max number in sequence:" + this.maxNumber.ToString());
            printer.Print("Min number in sequence:" + this.minNumber.ToString());
            printer.Print("Average number in sequence:" + this.averageNumber.ToString());
        }
    }
}