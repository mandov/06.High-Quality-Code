namespace VariablesDataExpressionsAndConstantsHomeworkTaskTwo
{
    using System;

    public class Statistics
    {
        public double[] ProcessStatistics(double[] collection)
        {
            if (collection.Length == 0)
            {
                throw new ArgumentException("Cannot process statistics without any input data!");
            }

            double minValue = collection[0];
            double maxValue = collection[0];
            double collectionSum = 0;

            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] < minValue)
                {
                    minValue = collection[i];
                }

                if (collection[i] > maxValue)
                {
                    maxValue = collection[i];
                }

                collectionSum += collection[i];
            }

            double average = collectionSum / collection.Length;

            return new double[] { minValue, maxValue, average };
        }

        public void PrintStatistics(double[] processedStatistics)
        {
            if (processedStatistics.Length != 3)
            {
                throw new ArgumentException("The processed statistics has 3 elements - min, max and average");
            }

            double minValue = processedStatistics[0];
            double maxValue = processedStatistics[1];
            double average = processedStatistics[2];

            this.Printer(minValue);
            this.Printer(maxValue);
            this.Printer(average);
        }

        private void Printer(double number)
        {
            Console.WriteLine(number);
        }
    }
}
