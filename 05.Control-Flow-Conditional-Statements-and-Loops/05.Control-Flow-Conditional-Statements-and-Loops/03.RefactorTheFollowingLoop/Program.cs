using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[] { 515, 51, 2, 3654, 23, 45, 65, 89, 15, 32, 49, 56, 324, 42, 64, 8, 24, 6, 44, 2 };
        int expectedValue = 65;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == expectedValue)
            {
                Console.WriteLine("Value found at {0} index!", i);
                break;
            }
            else
            {
                Console.WriteLine(numbers[i]);            
            }

            if (i == numbers.Length - 1)
            {
                Console.WriteLine("Value not found!");
            }  
        }      
    }
}