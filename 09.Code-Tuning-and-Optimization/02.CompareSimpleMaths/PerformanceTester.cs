namespace CompareSimpleMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    public static class PerformanceTester<T>
    {
        private static List<T> list = new List<T>();

        private static void Add(T value)
        {
            for (int i = 0; i < 100; i++)
            {
                list.Add(value);
            }

            list.Clear();
        }

        private static void Subtract(T value)
        {
            T result = (dynamic)0;
            for (int i = 0; i < 100; i++)
            {
                result = (dynamic)i - value;
            }
        }

        private static void Increment(T value)
        {
            T result = (dynamic)0;
            for (int i = 0; i < 100; i++)
            {
                result = (dynamic)i + value;
            }
        }

        private static void Multiply(T value)
        {
            T result = (dynamic)0;
            for (int i = 0; i < 100; i++)
            {
                result = (dynamic)i * value;
            }
        }

        private static void Divide(T value)
        {
            T result = (dynamic)0;
            for (int i = 1; i < 100; i++)
            {
                result = (dynamic)i / value;
            }
        }

        public static void Performance(T value, string operationType)
        {
            Action<T> action = new Action<T>(Add);
            switch (operationType)
            {
                case "Increment":
                    action = new Action<T>(Increment); break;
                case "Multiply":
                    action = new Action<T>(Multiply); break;
                case "Divide":
                    action = new Action<T>(Divide); break;
                case "Subtract":
                    action = new Action<T>(Subtract); break;
                default:
                    break;                
            }

            Console.WriteLine("{0}:", value.GetType().Name);
            var stopWatch = Stopwatch.StartNew();
            for (int j = 0; j < 10000; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    action(value);
                }
            }

            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
        }
    }
}
