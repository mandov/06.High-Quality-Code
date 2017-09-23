using System;
using System.Linq;
using System.Numerics;

class Startup
{
    static void Main()
    {
        long[] numbers = Console.ReadLine().Split(' ').Select(a => long.Parse(a)).ToArray();
        BigInteger sum = 0;
        BigInteger difference = 0;
        int index = 1;

        while (index < numbers.Length)
        {
            difference = Math.Abs(numbers[index - 1] + numbers[index]);
            if (difference % 2 == 0)
            {
                sum += difference;
                index += 2;
            }
            else
            {
                index += 1;
            }
        }

        Console.WriteLine(sum);
    }
}