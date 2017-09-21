using System;

public class Program
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int subtractedNumbers = 0;
        int productOfMixedNumbers = 0;
        int lastNumber = 0;
        int firstNumber = 0;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            lastNumber = numbers[i] % 10;
            firstNumber = numbers[i + 1] / 10;
            productOfMixedNumbers = lastNumber * firstNumber;
            Console.Write(productOfMixedNumbers + " ");
        }

        Console.WriteLine();
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            subtractedNumbers = numbers[i] - numbers[i + 1];
            Console.Write(Math.Abs(subtractedNumbers) + " ");
        }
    }
}