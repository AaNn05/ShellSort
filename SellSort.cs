namespace Sort
{
    public static class SortingAlgorithm
    {
        public static int ShellSort(int[] arr)
        {
            int n = arr.Length;

            for (int g = n / 2; g > 0; g /= 2)
            {
                for (int i = g; i < n; i += 1)
                {
                    int temp = arr[i];

                    int j;
                    for (j = i; j >= g && arr[j - g] > temp; j -= g)
                        arr[j] = arr[j - g];

                    arr[j] = temp;
                }
            }
            return 0;
        }

        public static int PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            return 0;
        }
    }
}
