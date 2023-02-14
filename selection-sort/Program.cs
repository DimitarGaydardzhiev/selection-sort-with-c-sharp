namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = CreateIntArrayDescending(10);
            Console.WriteLine("Unsorted array:");
            PrintArray(numbers);

            PerformIntArraySelectionSort(numbers);

            Console.WriteLine("Sorted array:");
            PrintArray(numbers);
        }

        static int[] CreateIntArrayDescending(int size)
        {
            var currentNumber = size;
            var numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = currentNumber;
                currentNumber--;
            }

            return numbers;
        }

        static void SwapMembers(int[] array, int firstIndex, int secondIndex)
        {
            var temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }

        static void PerformIntArraySelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                var smallest = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < smallest)
                    {
                        smallest = numbers[j];
                        SwapMembers(numbers, i, j);
                    }
                }
            }
        }
    }
}