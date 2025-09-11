namespace Exercises
{
    public static class ArrayExercises
    {
        // Exercise 1 - Write a C# Sharp program that stores elements in an array and prints them.
        public static string StoreAndPrintElements(int[] elements)
        {
            return $"Elements in array are: {string.Join(" ", elements)}";
        }

        // Exercise 2 - Write a C# Sharp program to read n values in an array and display them in reverse order.
        public static string DisplayInReverseOrder(int[] elements)
        {
            var normalOrder = $"The values stored into the array are:\n{string.Join(" ", elements)}";
            var reverseOrder = $"The values stored into the array in reverse are:\n{string.Join(" ", elements.Reverse())}";
            return $"{normalOrder}\n{reverseOrder}";
        }

        // Exercise 3 - Write a program in C# Sharp to find the sum of all array elements.
        public static int SumOfArrayElements(int[] elements)
        {
            return elements.Sum();
        }

        // Exercise 4 - Write a C# Sharp program to copy the elements of one array into another array.
        public static string CopyArray(int[] elements)
        {
            var copiedArray = new int[elements.Length];
            elements.CopyTo(copiedArray, 0);

            var original = $"The elements stored in the first array are:\n{string.Join(" ", elements)}";
            var copied = $"The elements copied into the second array are:\n{string.Join(" ", copiedArray)}";

            return $"{original}\n{copied}";
        }

        // Exercise 5 - Write a C# Sharp program in to count duplicate elements in an array.
        public static int CountDuplicateElements(int[] elements)
        {
            return elements.GroupBy(x => x)
                          .Where(g => g.Count() > 1)
                          .Sum(g => g.Count() - 1);
        }

        // Exercise 6 - Write a program in C# Sharp to print all unique elements in an array.
        public static int[] FindUniqueElements(int[] elements)
        {
            return elements.GroupBy(x => x)
                          .Where(g => g.Count() == 1)
                          .Select(g => g.Key)
                          .ToArray();
        }

        // Exercise 7 - Write a C# Sharp program to merge two arrays of the same size sorted in ascending order.
        public static int[] MergeAndSortArrays(int[] arr1, int[] arr2)
        {
            return arr1.Concat(arr2).OrderBy(x => x).ToArray();
        }

        // Exercise 8 - Write a C# Sharp program to count the frequency of each element in an array.
        public static string CountElementFrequency(int[] elements)
        {
            var frequency = elements.GroupBy(x => x)
                                  .Select(g => $"{g.Key} occurs {g.Count()} times");

            return $"The frequency of all elements of the array:\n{string.Join("\n", frequency)}";
        }

        // Exercise 9 - Write a C# Sharp program to find the maximum and minimum elements in an array.
        public static string FindMaxAndMin(int[] elements)
        {
            var max = elements.Max();
            var min = elements.Min();
            return $"Maximum element is : {max}\nMinimum element is : {min}";
        }

        // Exercise 10 - Write a program in C# Sharp to separate odd and even integers into separate arrays.
        public static (int[] even, int[] odd) SeparateOddEven(int[] elements)
        {
            var even = elements.Where(x => x % 2 == 0).ToArray();
            var odd = elements.Where(x => x % 2 != 0).ToArray();
            return (even, odd);
        }

        // Exercise 11 - Write a C# Sharp program to sort elements of an array in ascending order.
        public static int[] SortAscending(int[] elements)
        {
            return elements.OrderBy(x => x).ToArray();
        }

        // Exercise 12 - Write a C# Sharp program to sort array elements in descending order.
        public static int[] SortDescending(int[] elements)
        {
            return elements.OrderByDescending(x => x).ToArray();
        }

        // Exercise 13 - Write a C# Sharp program to insert an additional value into an array (sorted list).
        public static int[] InsertIntoSortedArray(int[] sortedArray, int value)
        {
            var list = sortedArray.ToList();
            var index = list.BinarySearch(value);
            if (index < 0) index = ~index;
            list.Insert(index, value);
            return list.ToArray();
        }

        // Exercise 14 - Write a C# Sharp program to insert another value in the array (unsorted list).
        public static int[] InsertIntoArray(int[] array, int value, int position)
        {
            var list = array.ToList();
            list.Insert(position - 1, value);
            return list.ToArray();
        }

        // Exercise 15 -  Write a C# Sharp program to delete an element at the desired position from an array.
        public static int[] DeleteElementAtPosition(int[] array, int position)
        {
            var list = array.ToList();
            list.RemoveAt(position - 1);
            return list.ToArray();
        }

        // Exercise 16 - Write a C# Sharp program to find the second largest element in an array.
        public static int FindSecondLargest(int[] elements)
        {
            var distinctSorted = elements.Distinct().OrderByDescending(x => x).ToArray();
            return distinctSorted.Length > 1 ? distinctSorted[1] : distinctSorted[0];
        }

        // Exercise 17 - Write a C# Sharp program to find the second smallest element in an array.
        public static int FindSecondSmallest(int[] elements)
        {
            var distinctSorted = elements.Distinct().OrderBy(x => x).ToArray();
            return distinctSorted.Length > 1 ? distinctSorted[1] : distinctSorted[0];
        }

        // Exercise 18 - Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix.
        public static string PrintMatrix(int[,] matrix)
        {
            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);
            var lines = new string[rows];

            for (var i = 0; i < rows; i++)
            {
                var line = new int[cols];
                for (var j = 0; j < cols; j++)
                {
                    line[j] = matrix[i, j];
                }
                lines[i] = string.Join(" ", line);
            }

            return string.Join(Environment.NewLine, lines);
        }

        // Exercise 19 - Write a C# Sharp program for adding two matrices of the same size.
        public static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            var rows = matrix1.GetLength(0);
            var cols = matrix1.GetLength(1);
            var result = new int[rows, cols];

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        // Exercise 20 - Write a C# Sharp program for the subtraction of two matrixes.
        public static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
        {
            var rows = matrix1.GetLength(0);
            var cols = matrix1.GetLength(1);
            var result = new int[rows, cols];

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }

        // Exercise 21 - Write a C# Sharp program for multiplication of two square matrices.
        public static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            var rows1 = matrix1.GetLength(0);
            var cols1 = matrix1.GetLength(1);
            var rows2 = matrix2.GetLength(0);
            var cols2 = matrix2.GetLength(1);

            if (cols1 != rows2)
                throw new ArgumentException("Number of columns in first matrix must equal number of rows in second matrix");

            var result = new int[rows1, cols2];

            for (var i = 0; i < rows1; i++)
            {
                for (var j = 0; j < cols2; j++)
                {
                    var sum = 0;
                    for (var k = 0; k < cols1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }

        // Exercise 22 - Write a C# Sharp program to find the transpose of a given matrix.
        public static int[,] TransposeMatrix(int[,] matrix)
        {
            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);
            var result = new int[cols, rows];

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }

            return result;
        }

        // Exercise 23 - Write a C# Sharp program to find the sum of the right diagonals of a matrix.
        public static int SumRightDiagonal(int[,] matrix)
        {
            var size = matrix.GetLength(0);
            var sum = 0;

            for (var i = 0; i < size; i++)
            {
                sum += matrix[i, i];
            }

            return sum;
        }

        // Exercise 24 - Write a C# Sharp program to find the sum of the left diagonals of a matrix.
        public static int SumLeftDiagonal(int[,] matrix)
        {
            var size = matrix.GetLength(0);
            var sum = 0;

            for (var i = 0; i < size; i++)
            {
                sum += matrix[i, i]; // Diagonal principal (i = j)
            }

            return sum;
        }

        // Exercise 25 - Write a C# Sharp program to find the sum of rows and columns in a matrix.
        public static (int[] rowSums, int[] columnSums) CalculateRowAndColumnSums(int[,] matrix)
        {
            var size = matrix.GetLength(0);
            var rowSums = new int[size];
            var columnSums = new int[size];

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    rowSums[i] += matrix[i, j];
                    columnSums[j] += matrix[i, j];
                }
            }

            return (rowSums, columnSums);
        }

        // Exercise 26 - Write a program in C# Sharp to print or display the lower triangular of a given matrix.
        public static int[,] GetLowerTriangularMatrix(int[,] matrix)
        {
            var size = matrix.GetLength(0);
            var result = new int[size, size];

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    result[i, j] = i <= j ? matrix[i, j] : 0;
                }
            }

            return result;
        }

        // Exercise 27 - Write a C# Sharp program to print or display an upper triangular matrix.
        public static int[,] GetUpperTriangularMatrix(int[,] matrix)
        {
            var size = matrix.GetLength(0);
            var result = new int[size, size];

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    result[i, j] = i >= j ? matrix[i, j] : 0;
                }
            }

            return result;
        }

        // Exercise 28 - Write a C# Sharp program to calculate the determinant of a 3 x 3 matrix.
        public static int CalculateDeterminant3x3(int[,] matrix)
        {
            var det = 0;

            for (var i = 0; i < 3; i++)
            {
                det += matrix[0, i] *
                      (matrix[1, (i + 1) % 3] * matrix[2, (i + 2) % 3] -
                       matrix[1, (i + 2) % 3] * matrix[2, (i + 1) % 3]);
            }

            return det;
        }

        // Exercise 29 - Write a C# Sharp program to accept a matrix and determine whether it is a sparse matrix.
        public static (bool isSparse, int zeroCount) CheckSparseMatrix(int[,] matrix)
        {
            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);
            var zeroCount = 0;
            var totalElements = rows * cols;

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        zeroCount++;
                    }
                }
            }

            var isSparse = zeroCount > totalElements / 2;
            return (isSparse, zeroCount);
        }

        // Exercise 30 -  Write a C# Sharp program to accept two matrices and check equality.
        public static bool AreMatricesEqual(int[,] matrix1, int[,] matrix2)
        {
            var rows1 = matrix1.GetLength(0);
            var cols1 = matrix1.GetLength(1);
            var rows2 = matrix2.GetLength(0);
            var cols2 = matrix2.GetLength(1);

            if (rows1 != rows2 || cols1 != cols2)
                return false;

            for (var i = 0; i < rows1; i++)
            {
                for (var j = 0; j < cols1; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                        return false;
                }
            }

            return true;
        }

        // Exercise 31 - Write a C# Sharp program to Check whether a Given Matrix is an Identity Matrix.
        public static bool IsIdentityMatrix(int[,] matrix)
        {
            var size = matrix.GetLength(0);

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    if ((i == j && matrix[i, j] != 1) || (i != j && matrix[i, j] != 0))
                        return false;
                }
            }

            return true;
        }

        // Exercise 32 - Write a C# Sharp program to get only odd values from a given integer array.
        public static int[] GetOddValues(int[] array)
        {
            return array.Where(n => n % 2 != 0).ToArray();
        }

        // Exercise 33 - Write a C# Sharp program that removes all duplicate elements from a given array and returns an updated array.
        public static object[] RemoveDuplicates(object[] array)
        {
            return array.Distinct().ToArray();
        }

        // Exercise 34 - Write a C# Sharp program to find the missing number in a given array of numbers between 10 and 20.
        public static int FindMissingNumber10To20(int[] numbers)
        {
            const int expectedSum = 165;
            return expectedSum - numbers.Sum();
        }

        // Exercise 35 - Write a C# Sharp program to calculate the sum of the two lowest negative numbers in a given array of integers.
        public static int SumTwoLowestNegativeNumbers(int[] numbers)
        {
            return numbers.Where(x => x < 0)
                         .OrderBy(x => x)
                         .Take(2)
                         .Sum();
        }

        // Exercise 36 - Write a C# Sharp program to re-arrange the elements in a given array of numbers and check whether the numbers are consecutive or not.
        public static bool AreNumbersConsecutive(int[] numbers)
        {
            if (numbers.Length == 0)
                return false;

            var sorted = numbers.OrderBy(x => x).ToArray();

            for (var i = 1; i < sorted.Length; i++)
            {
                if (sorted[i] - sorted[i - 1] != 1)
                    return false;
            }

            return true;
        }

        // Exercise 37 - Write a C# Sharp program that calculates the smallest gap between numbers in an array of integers.
        public static int FindSmallestGap(int[] numbers)
        {
            if (numbers.Length < 2)
                return 0;

            var sorted = numbers.OrderBy(x => x).ToArray();
            return sorted.Skip(1)
                        .Select((num, index) => num - sorted[index])
                        .Min();
        }

        // Exercise 38 - Write a C# Sharp program that takes an array of numbers and a digit. Check whether the digit is present in this array of numbers.
        public static string CheckDigitPresence(int[] numbers, string digit)
        {
            return numbers.Any(num => num.ToString().Contains(digit))
                ? "Present"
                : "Not present..!";
        }

        // Exercise 39 - Write a C# Sharp program that calculates the sum of all prime numbers in an array of numbers.
        public static int SumOfPrimes(int[] numbers)
        {
            return numbers.Where(IsPrime).Sum();
        }

        private static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (var i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        // Exercise 40 - Write a C# Sharp program that takes an array of integers and finds the smallest positive integer that is not present in that array.
        public static int FindSmallestMissingPositive(int[] numbers)
        {
            var positiveNumbers = numbers.Where(x => x > 0).ToArray();
            var max = positiveNumbers.DefaultIfEmpty(0).Max();

            for (var i = 1; i <= max + 1; i++)
            {
                if (!positiveNumbers.Contains(i))
                    return i;
            }

            return 1;
        }

        // Exercise 41 - Write a C# Sharp program to find two numbers in an array of integers whose product is equal to a given number.
        public static int[] FindProductPair(int[] numbers, int target)
        {
            for (var i = 0; i < numbers.Length; i++)
            {
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] * numbers[j] == target)
                    {
                        return new[] { numbers[i], numbers[j] };
                    }
                }
            }

            return new int[0];
        }
    }
}
