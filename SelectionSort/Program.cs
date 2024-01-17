using System.Collections.Generic;

namespace SelectionSort
{
    internal class Program
    {
        //O(n^2)
        public static void SelectionSort(int[] data)
        {
            int smallest;
            for (int i = 0; i < data.Length - 1; i++)
            {
                smallest = i;

                for (int index = i + 1; index < data.Length; index++)
                {
                    if (data[index] < data[smallest])
                    {
                        smallest = index;
                    }
                }
                int temporary = data[i];
                data[i] = data[smallest];
                data[smallest] = temporary;
            }
        }
        static void Main(string[] args)
        {
                int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
                SelectionSort(array);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
                Console.ReadLine();
            }
    }
}
