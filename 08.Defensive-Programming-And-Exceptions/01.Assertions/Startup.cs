using System;
using System.Linq;
using System.Diagnostics;

class Startup
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        bool isValid = ArrayIsValid(arr);
        Debug.Assert(isValid, "Array is empty or dont have enough elements!");
        Debug.Assert(arr != null, "Array must not be null!");

        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr != null && arr.Length > 0, "Array must not be null or empty!");
        bool correctIndexes = IsInArrayRange(arr, startIndex, endIndex);
        Debug.Assert(correctIndexes, "Index is out of range!");

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        Debug.Assert(x != null && y != null, "x and y must not be null!");

        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(value != null, "Value must not be null!");

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        bool correctIndexes = IsInArrayRange(arr, startIndex, endIndex);
        bool isValid = ArrayIsValid(arr);
        Debug.Assert(isValid, "Array is empty or with not enough elements");
        Debug.Assert(correctIndexes, "Index is out of range!");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    public static bool ArrayIsValid<T>(T[] arr)
    {
        bool result = arr.Length > 0 && arr.Length > 1;

        return result;
    }

    public static bool IsInArrayRange<T>(T[] arr, int startIndex, int endIndex)
    {
        bool startIndexInArray = startIndex >= 0 && startIndex < arr.Length;
        bool endIndexInArray = endIndex < arr.Length && endIndex > startIndex;
        bool isSubstringCorrect = startIndexInArray && endIndexInArray;

        return isSubstringCorrect;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}