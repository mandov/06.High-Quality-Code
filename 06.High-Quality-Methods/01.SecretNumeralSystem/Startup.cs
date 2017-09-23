using System;
using System.Numerics;

class Startup
{
    static void Main()
    {
        var input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        var product = new BigInteger(1);

        foreach (var item in input)
        {
            var octaNum = item
                             .Replace("hristofor", "3")
                             .Replace("haralampi", "5")
                             .Replace("hristo", "0")
                             .Replace("pesho", "2")
                             .Replace("tosho", "1")
                             .Replace("vladimir", "7")
                             .Replace("vlad", "4")
                             .Replace("zoro", "6");

            product *= new BigInteger(Convert.ToInt64(octaNum, 8));
        }

        Console.WriteLine(product);
    }
}