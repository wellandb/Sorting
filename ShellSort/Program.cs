namespace ShellSort
{
    internal class Program
    {
        //O(n(logn)^2)
        static void ShellSort(int[] arr)
        {
            int i, j, pos, temp;
            pos = 3;
            while (pos > 0)
            {
                for (i = 0; i < arr.Length; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= pos) && (arr[j - pos] > temp))
                    {
                        arr[j] = arr[j - pos];
                        j = j - pos;
                    }
                    arr[j] = temp;
                }
                if (pos / 2 != 0)
                    pos = pos / 2;
                else if (pos == 1)
                    pos = 0;
                else
                    pos = 1;
            }
        }
        static void Main(string[] args)
        {
                int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
                ShellSort(array);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
                Console.ReadLine();
        }
    }
}
