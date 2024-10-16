using System;

class Sorter
{
    public static void SelectionSort<T>(T[] array) where T : IComparable<T>
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int index = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j].CompareTo(array[index]) < 0)
                {
                    index = j;
                }
            }
            T temp = array[index];
            array[index] = array[i];
            array[i] = temp;
        }
    }
}

class Program
{
    static void Main()
    {
        int[] a = { 2, 5, 6, 1, 3, 4 };
        Sorter.SelectionSort(a);
        Console.WriteLine(string.Join(", ", a));
    }
}
