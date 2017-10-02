using System;
using System.Collections.Generic;
using System.Text;

class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        SubsequenceValidator(arr, startIndex, count);
        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        ExtractEndingValidator(str, count);

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    public static void CheckPrime(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentException("number must be greater than zero!");
        }

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                Console.WriteLine("The number is not prime number!");
            }
        }
    }

    public static void SubsequenceValidator<T>(T[] arr, int startIndex, int count)
    {
        if (arr.Length == 0)
        {
            throw new ArgumentException("Array is empty!");
        }

        if (startIndex > arr.Length || startIndex < 0)
        {
            throw new IndexOutOfRangeException("startIndex is out of array range!");
        }

        if ((startIndex + count) > arr.Length)
        {
            throw new IndexOutOfRangeException("count is too big and get out of array indexes range");
        }

        if (count <= 0)
        {
            throw new ArgumentException("count must be greater than zero!");
        }
    }

    public static void ExtractEndingValidator(string str, int count)
    {
        if (string.IsNullOrEmpty(str))
        {
            throw new ArgumentException("str must not be null or empty!");
        }

        if (count <= 0)
        {
            throw new ArgumentException("count must be greater than zero!");
        }

        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException("count must not be greater than str length!");
        }
    }

    static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        Console.WriteLine(ExtractEnding("Hi", 100));

        CheckPrime(23);
        CheckPrime(33);

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}