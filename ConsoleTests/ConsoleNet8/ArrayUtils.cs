namespace ConsoleNet8;

internal static class ArrayUtils
{
    public static int FindIndexOfMin(int[] array) =>
        FindIndexOfMin(array, 0, array.Length - 1);

    public static int FindIndexOfMin(int[] array, int from, int to)
    {
        int indexOfMin = from;

        for (int i = from + 1; i <= to; i++)
        {
            if (array[i] < array[indexOfMin])
            {
                indexOfMin = i;
            }
        }
        return indexOfMin;
    }

    public static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int indexOfMin = FindIndexOfMin(array, i, array.Length - 1);
            Swap(array, i, indexOfMin);
        }
    }

    public static int FindFirstIndexOfElement(int[] array, int element)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == element)
                return i;
        }
        return -1;
    }

    public static void PrintArray(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine($"a[{i}] = {a[i]}");
        }
    }

    public static int[] ReverseArray(int[] source)
    {
        int n = source.Length;
        int[] dest = new int[n];

        for (int i = 0; i < n; i++)
        {
            dest[i] = source[n - i - 1];
        }
        return dest;
    }


    //public static int Max(int i, int j) =>
    //    (i > j) ? i : j;

    //public static int GetValueAtOrDefault(int[] array, int i) =>
    //    i < array.Length ? array[i] : 0;

    /// <summary>
    /// Sums two arrays, possibly with different lengths.
    /// </summary>
    /// <param name="a1">The first array</param>
    /// <param name="a2">The second array</param>
    /// <returns>An array with length equals to the max of the two lenghts.</returns>
    public static int[] AddTwoArrays(int[] a1, int[] a2)
    {
        int[] result = new int[Math.Max(a1.Length, a2.Length)];

        for (int i = 0; result.Length > i; i++)
            result[i] = a1.ElementAtOrDefault(i) + a2.ElementAtOrDefault(i);
        
        return result;
    }


    /// <summary>
    /// Merges two sorted arrays into a new sorted array
    /// Example:
    ///    a1 = [1, 3, 8, 9];
    ///    a2 = [1, 2, 4, 8, 10];
    //     result = [1, 1, 2, 3, 4, 8, 8, 9, 10]
    /// </summary>
    /// <param name="a1">The first sorted array</param>
    /// <param name="a2">The second sorted array</param>
    /// <returns>The moerged sorted array</returns>
    public static int[] MergeSortedArrays(int[] a1, int[] a2)
    {
        throw new NotImplementedException();
        
    }


    /*
     *   n! = n * (n - 1) * (n - 2) * ... * 3 * 2 * 1
     *   
     *   0! = 1
     *   n! = n * (n - 1)!  n > 0
     * 
     *  5! = 5 * 4!
     *     = 5 * 4 * 3!
     *     = 5 * 4 * 3 * 2!
     *     = 5 * 4 * 3 * 2 * 1!
     *     = 5 * 4 * 3 * 2 * 1
     */


    public static int Factorial(int n) =>
        n == 0 ? 1 : n * Factorial(n - 1);

    public static int FactorialIterative(int n)
    {
        int fact = 1;
        for (int i = 2; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }


    // Fib(0) = 1
    // Fib(1) = 1
    // Fib(n) = Fib(n - 1) + Fib(n - 2)

    // 0 1 1 2 3 5 8 13 21 34 

}
