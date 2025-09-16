
namespace Exercises
{
    public class SearchingAndSorting
    {
        // Exercise 1 - Write a C# Sharp program to sort a list of elements using Shell sort.
        public static void ShellSort(int[] arr)
        {
            var n = arr.Length;

            for (var gap = n / 2; gap > 0; gap /= 2)
            {
                for (var i = gap; i < n; i++)
                {
                    var temp = arr[i];
                    var j = i;

                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }

                    arr[j] = temp;
                }
            }
        }

        // Exercise 2 - Write a C# Sharp program to sort a list of elements using Bogosort sort.
        private static Random random = new Random();

        public static int BogoSort(int[] arr)
        {
            var iterations = 0;

            while (!IsSorted(arr))
            {
                Shuffle(arr);
                iterations++;
            }

            return iterations;
        }

        private static bool IsSorted(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                    return false;
            }
            return true;
        }

        private static void Shuffle(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                var randomIndex = random.Next(arr.Length);
                (arr[i], arr[randomIndex]) = (arr[randomIndex], arr[i]);
            }
        }

        // Exercise 3 - Write a C# Sharp program to sort a list of elements using Bubble sort.
        public static void BubbleSort(int[] arr)
        {
            var n = arr.Length;

            for (var i = 0; i < n - 1; i++)
            {
                for (var j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }
        }

        // Exercise 4 - Write a C# Sharp program to sort a list of elements using Counting sort.
        public static void CountingSort(int[] arr)
        {
            if (arr.Length == 0) return;

            var min = arr[0];
            var max = arr[0];

            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }

            var range = max - min + 1;
            var count = new int[range];
            var output = new int[arr.Length];

            for (var i = 0; i < arr.Length; i++)
            {
                count[arr[i] - min]++;
            }

            for (var i = 1; i < range; i++)
            {
                count[i] += count[i - 1];
            }

            for (var i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i] - min] - 1] = arr[i];
                count[arr[i] - min]--;
            }

            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = output[i];
            }
        }

        // Exercise 5 - Write a C# Sharp program to sort a list of elements using Heap sort.
        public static void HeapSort(int[] arr)
        {
            var n = arr.Length;

            for (var i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            for (var i = n - 1; i > 0; i--)
            {
                (arr[0], arr[i]) = (arr[i], arr[0]);
                Heapify(arr, i, 0);
            }
        }

        private static void Heapify(int[] arr, int n, int i)
        {
            var largest = i;
            var left = 2 * i + 1;
            var right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                (arr[i], arr[largest]) = (arr[largest], arr[i]);
                Heapify(arr, n, largest);
            }
        }

        // Exercise 6 - Write a C# Sharp program to sort a list of elements using Insertion sort.
        public static void InsertionSort(int[] arr)
        {
            for (var i = 1; i < arr.Length; i++)
            {
                var key = arr[i];
                var j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
        }

        // Exercise 7 - Write a C# Sharp program to sort a list of elements using Merge sort.
        public static void MergeSort(int[] arr)
        {
            if (arr.Length <= 1) return;

            var mid = arr.Length / 2;
            var left = new int[mid];
            var right = new int[arr.Length - mid];

            for (var i = 0; i < mid; i++)
                left[i] = arr[i];

            for (var i = mid; i < arr.Length; i++)
                right[i - mid] = arr[i];

            MergeSort(left);
            MergeSort(right);
            Merge(arr, left, right);
        }

        private static void Merge(int[] arr, int[] left, int[] right)
        {
            var i = 0;
            var j = 0;
            var k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    arr[k++] = left[i++];
                else
                    arr[k++] = right[j++];
            }

            while (i < left.Length)
                arr[k++] = left[i++];

            while (j < right.Length)
                arr[k++] = right[j++];
        }

        // Exercise 8 - Write a C# Sharp program to sort a list of elements using Permutation sort.
        public static int PermutationSort(int[] arr)
        {
            var iterations = 0;
            var sorted = arr.OrderBy(x => x).ToArray();

            while (!arr.SequenceEqual(sorted))
            {
                RandomizeArray(arr);
                iterations++;
            }

            return iterations;
        }

        private static void RandomizeArray(int[] arr)
        {
            var random = new Random();
            for (var i = 0; i < arr.Length; i++)
            {
                var randomIndex = random.Next(arr.Length);
                (arr[i], arr[randomIndex]) = (arr[randomIndex], arr[i]);
            }
        }

        // Exercise 9 - Write a C# Sharp program to sort a list of elements using Quick sort.
        public static void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        private static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                var pivotIndex = Partition(arr, left, right);
                QuickSort(arr, left, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            var pivot = arr[right];
            var i = left - 1;

            for (var j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }

            (arr[i + 1], arr[right]) = (arr[right], arr[i + 1]);
            return i + 1;
        }

        // Exercise 10 - Write a C# Sharp program to sort a list of elements using the Radix sort algorithm.
        public static void RadixSort(int[] arr)
        {
            if (arr.Length == 0) return;

            var max = Math.Abs(arr[0]);
            for (var i = 1; i < arr.Length; i++)
            {
                var absValue = Math.Abs(arr[i]);
                if (absValue > max) max = absValue;
            }

            for (var exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSortByDigit(arr, exp);
            }
        }

        private static void CountingSortByDigit(int[] arr, int exp)
        {
            var output = new int[arr.Length];
            var count = new int[19];

            for (var i = 0; i < arr.Length; i++)
            {
                var digit = (arr[i] / exp) % 10 + 9;
                count[digit]++;
            }

            for (var i = 1; i < 19; i++)
            {
                count[i] += count[i - 1];
            }

            for (var i = arr.Length - 1; i >= 0; i--)
            {
                var digit = (arr[i] / exp) % 10 + 9;
                output[count[digit] - 1] = arr[i];
                count[digit]--;
            }

            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = output[i];
            }
        }

        // Exercise 11 - Write a C# Sharp program to sort a list of elements using the Selection sort algorithm.
        public static void SelectionSort(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                var minIndex = i;

                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            }
        }
    }
}
