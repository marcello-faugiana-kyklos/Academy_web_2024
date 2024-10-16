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

}
