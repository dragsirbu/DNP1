using System;

namespace TestConsoleApp1
{
    class Program
    {
        static int[] IncreasingInsertionSort(int[] array)
        {
            int j;
            int key;
            for (int i = 1; i < array.Length - 1; i++)
            {
                key = array[i];
                j = i;
                while (j > 0 && array[j - 1] > key)
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = key;
            }
            return array;
        }
        
        static string PrintArray(int[] array)
        {
            string ToPrint = "";
            foreach (var element in array)
            {
                ToPrint += element + " ";
            }

            return ToPrint;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] {3, 6, 4, 1, 2, 5};
            Console.WriteLine($"Array after increasing sort: {PrintArray(IncreasingInsertionSort(array))}");
        }
    }
}