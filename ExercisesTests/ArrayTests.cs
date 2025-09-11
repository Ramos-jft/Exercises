using Exercises;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTests;

[TestClass]
public class ArrayTests
{
    // Exercise 1 - Write a C# Sharp program that stores elements in an array and prints them.
    [TestMethod]
    [DataRow(new[] { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, "Elements in array are: 1 1 2 3 4 5 6 7 8 9")]
    [DataRow(new[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 }, "Elements in array are: 2 4 6 8 10 12 14 16 18 20")]
    public void StoreAndPrintElements_GivenArray_ReturnsFormattedString(int[] input, string expected)
    {
        var result = ArrayExercises.StoreAndPrintElements(input);
        result.Should().Be(expected);
    }

    // Exercise 2 - Write a C# Sharp program to read n values in an array and display them in reverse order.
    [TestMethod]
    [DataRow(new[] { 2, 5, 7 }, "The values stored into the array are:\n2 5 7\nThe values stored into the array in reverse are:\n7 5 2")]
    [DataRow(new[] { 1, 2, 3 }, "The values stored into the array are:\n1 2 3\nThe values stored into the array in reverse are:\n3 2 1")]
    public void DisplayInReverseOrder_GivenArray_ReturnsNormalAndReverseOrder(int[] input, string expected)
    {
        var result = ArrayExercises.DisplayInReverseOrder(input);
        result.Should().Be(expected);
    }

    // Exercise 3 - Write a program in C# Sharp to find the sum of all array elements.
    [TestMethod]
    [DataRow(new[] { 2, 5, 8 }, 15)]
    [DataRow(new[] { 2, 4, 6, 4 }, 16)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 15)]
    [DataRow(new[] { 10 }, 10)]
    public void SumOfArrayElements_GivenArray_ReturnsSum(int[] input, int expected)
    {
        var result = ArrayExercises.SumOfArrayElements(input);
        result.Should().Be(expected);
    }

    // Exercise 4 - Write a C# Sharp program to copy the elements of one array into another array.
    [TestMethod]
    [DataRow(new[] { 15, 10, 12 }, "The elements stored in the first array are:\n15 10 12\nThe elements copied into the second array are:\n15 10 12")]
    [DataRow(new[] { 2, 4 }, "The elements stored in the first array are:\n2 4\nThe elements copied into the second array are:\n2 4")]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, "The elements stored in the first array are:\n1 2 3 4 5\nThe elements copied into the second array are:\n1 2 3 4 5")]
    public void CopyArray_GivenArray_ReturnsOriginalAndCopiedArrays(int[] input, string expected)
    {
        var result = ArrayExercises.CopyArray(input);
        result.Should().Be(expected);
    }

    // Exercise 5 - Write a C# Sharp program in to count duplicate elements in an array.
    [TestMethod]
    [DataRow(new[] { 5, 1, 1 }, 1)]
    [DataRow(new[] { 2, 2, 4 }, 1)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 0)]
    [DataRow(new[] { 1, 1, 1, 2, 2 }, 3)]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3 }, 3)]
    public void CountDuplicateElements_GivenArray_ReturnsDuplicateCount(int[] input, int expected)
    {
        var result = ArrayExercises.CountDuplicateElements(input);
        result.Should().Be(expected);
    }

    // Exercise 6 - Write a program in C# Sharp to print all unique elements in an array.
    [TestMethod]
    [DataRow(new[] { 1, 5, 1 }, new[] { 5 })]
    [DataRow(new[] { 2, 4 }, new[] { 2, 4 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 1, 1, 1, 2, 3 }, new[] { 2, 3 })]
    [DataRow(new[] { 1, 2, 2, 3, 3, 4 }, new[] { 1, 4 })]
    public void FindUniqueElements_GivenArray_ReturnsUniqueElements(int[] input, int[] expected)
    {
        var result = ArrayExercises.FindUniqueElements(input);
        result.Should().Equal(expected);
    }

    // Exercise 7 - Write a C# Sharp program to merge two arrays of the same size sorted in ascending order.
    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, new[] { 1, 1, 2, 2, 3, 3 })]
    [DataRow(new[] { 1, 2 }, new[] { 3, 4 }, new[] { 1, 2, 3, 4 })]
    [DataRow(new[] { 5, 8 }, new[] { 1, 3 }, new[] { 1, 3, 5, 8 })]
    [DataRow(new[] { 1 }, new[] { 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 4, 4, 4 }, new[] { 1, 2, 3 }, new[] { 1, 2, 3, 4, 4, 4 })]
    public void MergeAndSortArrays_GivenTwoArrays_ReturnsMergedSortedArray(int[] arr1, int[] arr2, int[] expected)
    {
        var result = ArrayExercises.MergeAndSortArrays(arr1, arr2);
        result.Should().Equal(expected);
    }

    // Exercise 8 - Write a C# Sharp program to count the frequency of each element in an array.
    [TestMethod]
    [DataRow(new[] { 25, 12, 43 }, "The frequency of all elements of the array:\n25 occurs 1 times\n12 occurs 1 times\n43 occurs 1 times")]
    [DataRow(new[] { 10, 15, 10 }, "The frequency of all elements of the array:\n10 occurs 2 times\n15 occurs 1 times")]
    [DataRow(new[] { 1, 1, 1, 2, 2, 3 }, "The frequency of all elements of the array:\n1 occurs 3 times\n2 occurs 2 times\n3 occurs 1 times")]
    [DataRow(new[] { 5 }, "The frequency of all elements of the array:\n5 occurs 1 times")]
    public void CountElementFrequency_GivenArray_ReturnsFrequencyString(int[] input, string expected)
    {
        var result = ArrayExercises.CountElementFrequency(input);
        result.Should().Be(expected);
    }

    // Exercise 9 - Write a C# Sharp program to find the maximum and minimum elements in an array.
    [TestMethod]
    [DataRow(new[] { 45, 25, 21 }, "Maximum element is : 45\nMinimum element is : 21")]
    [DataRow(new[] { 20, 25 }, "Maximum element is : 25\nMinimum element is : 20")]
    [DataRow(new[] { 10, 10, 10 }, "Maximum element is : 10\nMinimum element is : 10")]
    [DataRow(new[] { -5, 0, 5 }, "Maximum element is : 5\nMinimum element is : -5")]
    [DataRow(new[] { 100 }, "Maximum element is : 100\nMinimum element is : 100")]
    public void FindMaxAndMin_GivenArray_ReturnsMaxAndMinString(int[] input, string expected)
    {
        var result = ArrayExercises.FindMaxAndMin(input);
        result.Should().Be(expected);
    }

    // Exercise 10 - Write a program in C# Sharp to separate odd and even integers into separate arrays.
    [TestMethod]
    [DataRow(new[] { 25, 47, 42, 56, 32 }, new[] { 42, 56, 32 }, new[] { 25, 47 })]
    [DataRow(new[] { 3, 6 }, new[] { 6 }, new[] { 3 })]
    [DataRow(new[] { 2, 4, 6 }, new[] { 2, 4, 6 }, new int[0])]
    [DataRow(new[] { 1, 3, 5 }, new int[0], new[] { 1, 3, 5 })]
    [DataRow(new[] { 10 }, new[] { 10 }, new int[0])]
    public void SeparateOddEven_GivenArray_ReturnsSeparatedArrays(int[] input, int[] expectedEven, int[] expectedOdd)
    {
        var result = ArrayExercises.SeparateOddEven(input);
        result.even.Should().Equal(expectedEven);
        result.odd.Should().Equal(expectedOdd);
    }

    // Exercise 11 - Write a C# Sharp program to sort elements of an array in ascending order.
    [TestMethod]
    [DataRow(new[] { 2, 7, 4, 5, 9 }, new[] { 2, 4, 5, 7, 9 })]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4 })]
    [DataRow(new[] { 5, 3, 8, 1, 2 }, new[] { 1, 2, 3, 5, 8 })]
    [DataRow(new[] { 10, 5, 15, 0 }, new[] { 0, 5, 10, 15 })]
    [DataRow(new[] { 1 }, new[] { 1 })]
    public void SortAscending_GivenArray_ReturnsSortedArray(int[] input, int[] expected)
    {
        var result = ArrayExercises.SortAscending(input);
        result.Should().Equal(expected);
    }

    // Exercise 12 - Write a C# Sharp program to sort array elements in descending order.
    [TestMethod]
    [DataRow(new[] { 5, 9, 1 }, new[] { 9, 5, 1 })]
    [DataRow(new[] { 2, 5, 0 }, new[] { 5, 2, 0 })]
    [DataRow(new[] { 10, 3, 8, 1, 6 }, new[] { 10, 8, 6, 3, 1 })]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 4, 3, 2, 1 })]
    [DataRow(new[] { 7 }, new[] { 7 })]
    public void SortDescending_GivenArray_ReturnsSortedArray(int[] input, int[] expected)
    {
        var result = ArrayExercises.SortDescending(input);
        result.Should().Equal(expected);
    }

    // Exercise 13 - Write a C# Sharp program to insert an additional value into an array (sorted list).
    [TestMethod]
    [DataRow(new[] { 5, 7, 9 }, 8, new[] { 5, 7, 8, 9 })]
    [DataRow(new[] { 2, 4 }, 3, new[] { 2, 3, 4 })]
    [DataRow(new[] { 1, 3, 5 }, 0, new[] { 0, 1, 3, 5 })]
    [DataRow(new[] { 1, 3, 5 }, 6, new[] { 1, 3, 5, 6 })]
    [DataRow(new[] { 2 }, 1, new[] { 1, 2 })]
    public void InsertIntoSortedArray_GivenValue_ReturnsArrayWithInsertedValue(int[] sortedArray, int value, int[] expected)
    {
        var result = ArrayExercises.InsertIntoSortedArray(sortedArray, value);
        result.Should().Equal(expected);
    }

    // Exercise 14 - Write a C# Sharp program to insert another value in the array (unsorted list).
    [TestMethod]
    [DataRow(new[] { 1, 8, 7, 10 }, 5, 2, new[] { 1, 5, 8, 7, 10 })]
    [DataRow(new[] { 5, 15 }, 10, 2, new[] { 5, 10, 15 })]
    [DataRow(new[] { 2, 4, 6 }, 1, 1, new[] { 1, 2, 4, 6 })]
    [DataRow(new[] { 2, 4, 6 }, 8, 4, new[] { 2, 4, 6, 8 })]
    [DataRow(new[] { 3 }, 1, 1, new[] { 1, 3 })]
    public void InsertIntoArray_GivenValueAndPosition_ReturnsArrayWithInsertedValue(int[] array, int value, int position, int[] expected)
    {
        var result = ArrayExercises.InsertIntoArray(array, value, position);
        result.Should().Equal(expected);
    }

    // Exercise 15 -  Write a C# Sharp program to delete an element at the desired position from an array.
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 3, new[] { 1, 2, 4, 5 })]
    [DataRow(new[] { 2, 4, 6 }, 2, new[] { 2, 6 })]
    [DataRow(new[] { 1, 3, 5 }, 1, new[] { 3, 5 })]
    [DataRow(new[] { 1, 3, 5 }, 3, new[] { 1, 3 })]
    [DataRow(new[] { 10 }, 1, new int[0])]
    public void DeleteElementAtPosition_GivenPosition_ReturnsArrayWithoutElement(int[] array, int position, int[] expected)
    {
        var result = ArrayExercises.DeleteElementAtPosition(array, position);
        result.Should().Equal(expected);
    }

    // Exercise 16 - Write a C# Sharp program to find the second largest element in an array.
    [TestMethod]
    [DataRow(new[] { 2, 9, 1, 4, 6 }, 6)]
    [DataRow(new[] { 2, 4, 6, 8, 10 }, 8)]
    [DataRow(new[] { 5, 5, 5, 5 }, 5)]
    [DataRow(new[] { 10, 20, 30 }, 20)]
    [DataRow(new[] { 1, 2 }, 1)]
    [DataRow(new[] { 7 }, 7)]
    [DataRow(new[] { 3, 3 }, 3)]
    public void FindSecondLargest_GivenArray_ReturnsSecondLargestElement(int[] input, int expected)
    {
        var result = ArrayExercises.FindSecondLargest(input);
        result.Should().Be(expected);
    }

    // Exercise 17 - Write a C# Sharp program to find the second smallest element in an array.
    [TestMethod]
    [DataRow(new[] { 0, 9, 4, 6, 5 }, 4)]
    [DataRow(new[] { 2, 4, 6, 8, 10 }, 4)]
    [DataRow(new[] { 5, 5, 5, 5 }, 5)]
    [DataRow(new[] { 10, 20, 30 }, 20)]
    [DataRow(new[] { 1, 2 }, 2)]
    [DataRow(new[] { 7 }, 7)]
    [DataRow(new[] { 3, 3 }, 3)]
    public void FindSecondSmallest_GivenArray_ReturnsSecondSmallestElement(int[] input, int expected)
    {
        var result = ArrayExercises.FindSecondSmallest(input);
        result.Should().Be(expected);
    }

    // Exercise 18 - Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix.
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, "1 2 3\n4 5 6\n7 8 9")]
    [DataRow(new[] { 1, 0, 0, 0, 1, 0, 0, 0, 1 }, "1 0 0\n0 1 0\n0 0 1")]
    [DataRow(new[] { 2, 4, 6, 8, 10, 12, 14, 16, 18 }, "2 4 6\n8 10 12\n14 16 18")]
    public void PrintMatrix_Given3x3Matrix_ReturnsFormattedString(int[] flatArray, string expected)
    {
        var matrix = new int[3, 3];
        var index = 0;
        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                matrix[i, j] = flatArray[index++];
            }
        }

        var result = ArrayExercises.PrintMatrix(matrix);
        var normalizedExpected = expected.Replace("\n", Environment.NewLine);
        result.Should().Be(normalizedExpected);
    }

    // Exercise 19 - Write a C# Sharp program for adding two matrices of the same size.
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 6, 8, 10, 12 })]
    [DataRow(new[] { 2, 4, 6, 8 }, new[] { 1, 3, 5, 7 }, new[] { 3, 7, 11, 15 })]
    [DataRow(new[] { 0, 0, 0, 0 }, new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 })]
    [DataRow(new[] { -1, -2, -3, -4 }, new[] { 1, 2, 3, 4 }, new[] { 0, 0, 0, 0 })]
    public void AddMatrices_GivenTwo2x2Matrices_ReturnsSumMatrix(int[] flatMatrix1, int[] flatMatrix2, int[] flatExpected)
    {
        var matrix1 = Create2x2Matrix(flatMatrix1);
        var matrix2 = Create2x2Matrix(flatMatrix2);
        var expected = Create2x2Matrix(flatExpected);

        var result = ArrayExercises.AddMatrices(matrix1, matrix2);

        result.Should().BeEquivalentTo(expected);
    }

    private int[,] Create2x2Matrix(int[] flatArray)
    {
        var matrix = new int[2, 2];
        matrix[0, 0] = flatArray[0];
        matrix[0, 1] = flatArray[1];
        matrix[1, 0] = flatArray[2];
        matrix[1, 1] = flatArray[3];
        return matrix;
    }

    // Exercise 20 - Write a C# Sharp program for the subtraction of two matrixes.
    [TestMethod]
    [DataRow(new[] { 5, 6, 7, 8 }, new[] { 1, 2, 3, 4 }, new[] { 4, 4, 4, 4 })]
    [DataRow(new[] { 2, 4, 6, 8 }, new[] { 1, 3, 5, 7 }, new[] { 1, 1, 1, 1 })]
    [DataRow(new[] { 10, 10, 10, 10 }, new[] { 5, 5, 5, 5 }, new[] { 5, 5, 5, 5 })]
    [DataRow(new[] { 0, 0, 0, 0 }, new[] { 1, 1, 1, 1 }, new[] { -1, -1, -1, -1 })]
    public void SubtractMatrices_GivenTwo2x2Matrices_ReturnsDifferenceMatrix(int[] flatMatrix1, int[] flatMatrix2, int[] flatExpected)
    {
        var matrix1 = Create2x2Matrix1(flatMatrix1);
        var matrix2 = Create2x2Matrix1(flatMatrix2);
        var expected = Create2x2Matrix1(flatExpected);

        var result = ArrayExercises.SubtractMatrices(matrix1, matrix2);

        result.Should().BeEquivalentTo(expected);
    }

    private int[,] Create2x2Matrix1(int[] flatArray)
    {
        var matrix = new int[2, 2];
        matrix[0, 0] = flatArray[0];
        matrix[0, 1] = flatArray[1];
        matrix[1, 0] = flatArray[2];
        matrix[1, 1] = flatArray[3];
        return matrix;
    }

    // Exercise 21 - Write a C# Sharp program for multiplication of two square matrices.
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 19, 22, 43, 50 })]
    [DataRow(new[] { 2, 4, 6, 8 }, new[] { 1, 3, 5, 7 }, new[] { 2 * 1 + 4 * 5, 2 * 3 + 4 * 7, 6 * 1 + 8 * 5, 6 * 3 + 8 * 7 })] // 2+20=22, 6+28=34, 6+40=46, 18+56=74
    [DataRow(new[] { 1, 0, 0, 1 }, new[] { 1, 0, 0, 1 }, new[] { 1, 0, 0, 1 })]
    [DataRow(new[] { 2, 0, 0, 2 }, new[] { 3, 0, 0, 3 }, new[] { 6, 0, 0, 6 })]
    public void MultiplyMatrices_GivenTwo2x2Matrices_ReturnsProductMatrix(int[] flatMatrix1, int[] flatMatrix2, int[] flatExpected)
    {
        var matrix1 = Create2x2Matrix2(flatMatrix1);
        var matrix2 = Create2x2Matrix2(flatMatrix2);
        var expected = Create2x2Matrix2(flatExpected);

        var result = ArrayExercises.MultiplyMatrices(matrix1, matrix2);

        result.Should().BeEquivalentTo(expected);
    }

    [TestMethod]
    public void MultiplyMatrices_IncompatibleDimensions_ThrowsArgumentException()
    {
        var matrix1 = new int[2, 3];
        var matrix2 = new int[4, 2];

        Action act = () => ArrayExercises.MultiplyMatrices(matrix1, matrix2);

        act.Should().Throw<ArgumentException>()
           .WithMessage("Number of columns in first matrix must equal number of rows in second matrix");
    }

    private int[,] Create2x2Matrix2(int[] flatArray)
    {
        var matrix = new int[2, 2];
        matrix[0, 0] = flatArray[0];
        matrix[0, 1] = flatArray[1];
        matrix[1, 0] = flatArray[2];
        matrix[1, 1] = flatArray[3];
        return matrix;
    }

    // Exercise 22 - Write a C# Sharp program to find the transpose of a given matrix.
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, 2, 2, new[] { 1, 3, 2, 4 })]
    [DataRow(new[] { 5, 6, 7, 8 }, 2, 2, new[] { 5, 7, 6, 8 })]
    [DataRow(new[] { 1, 0, 0, 1 }, 2, 2, new[] { 1, 0, 0, 1 })]
    [DataRow(new[] { 2, 4, 6, 8, 10, 12 }, 2, 3, new[] { 2, 8, 4, 10, 6, 12 })]
    public void TransposeMatrix_GivenMatrix_ReturnsTransposedMatrix(int[] flatMatrix, int rows, int cols, int[] flatExpected)
    {
        var matrix = CreateMatrix(flatMatrix, rows, cols);
        var expected = CreateMatrix(flatExpected, cols, rows);

        var result = ArrayExercises.TransposeMatrix(matrix);

        result.Should().BeEquivalentTo(expected);
    }

    private int[,] CreateMatrix(int[] flatArray, int rows, int cols)
    {
        var matrix = new int[rows, cols];
        var index = 0;
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                matrix[i, j] = flatArray[index++];
            }
        }
        return matrix;
    }

    // Exercise 23 - Write a C# Sharp program to find the sum of the right diagonals of a matrix.
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, 5)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 15)]
    [DataRow(new[] { 2, 4, 6, 8 }, 10)]
    [DataRow(new[] { 5, 0, 0, 5 }, 10)]
    [DataRow(new[] { 10 }, 10)]
    public void SumRightDiagonal_GivenSquareMatrix_ReturnsDiagonalSum(int[] flatMatrix, int expected)
    {
        var size = flatMatrix.Length == 1 ? 1 : flatMatrix.Length == 4 ? 2 : 3;
        var matrix = CreateSquareMatrix(flatMatrix, size);

        var result = ArrayExercises.SumRightDiagonal(matrix);

        result.Should().Be(expected);
    }

    private int[,] CreateSquareMatrix(int[] flatArray, int size)
    {
        var matrix = new int[size, size];
        var index = 0;
        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                matrix[i, j] = flatArray[index++];
            }
        }
        return matrix;
    }

    // Exercise 24 - Write a C# Sharp program to find the sum of the left diagonals of a matrix.
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, 5)]
    [DataRow(new[] { 2, 4, 5, 6 }, 8)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 15)]
    [DataRow(new[] { 2, 4, 6, 8 }, 10)]
    [DataRow(new[] { 5, 0, 0, 5 }, 10)]
    [DataRow(new[] { 10 }, 10)]
    public void SumLeftDiagonal_GivenSquareMatrix_ReturnsDiagonalSum(int[] flatMatrix, int expected)
    {
        var size = flatMatrix.Length == 1 ? 1 : flatMatrix.Length == 4 ? 2 : 3;
        var matrix = CreateSquareMatrixForDiagonal(flatMatrix, size);

        var result = ArrayExercises.SumLeftDiagonal(matrix);

        result.Should().Be(expected);
    }

    private int[,] CreateSquareMatrixForDiagonal(int[] flatArray, int size)
    {
        var matrix = new int[size, size];
        var index = 0;
        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                matrix[i, j] = flatArray[index++];
            }
        }
        return matrix;
    }

    // Exercise 25 - Write a C# Sharp program to find the sum of rows and columns in a matrix.
    [TestMethod]
    [DataRow(new[] { 5, 6, 7, 8 }, new[] { 11, 15 }, new[] { 12, 14 })]
    [DataRow(new[] { 2, 4, 6, 8 }, new[] { 6, 14 }, new[] { 8, 12 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] { 6, 15, 24 }, new[] { 12, 15, 18 })]
    public void CalculateRowAndColumnSums_GivenSquareMatrix_ReturnsSums(int[] flatMatrix, int[] expectedRowSums, int[] expectedColumnSums)
    {
        var size = flatMatrix.Length == 4 ? 2 : 3;
        var matrix = CreateSquareMatrixForSums(flatMatrix, size);

        var (rowSums, columnSums) = ArrayExercises.CalculateRowAndColumnSums(matrix);

        rowSums.Should().Equal(expectedRowSums);
        columnSums.Should().Equal(expectedColumnSums);
    }

    private int[,] CreateSquareMatrixForSums(int[] flatArray, int size)
    {
        var matrix = new int[size, size];
        var index = 0;
        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                matrix[i, j] = flatArray[index++];
            }
        }
        return matrix;
    }

    // Exercise 26 - Write a program in C# Sharp to print or display the lower triangular of a given matrix.
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] { 1, 2, 3, 0, 5, 6, 0, 0, 9 })]
    [DataRow(new[] { 2, 4, 6, 8 }, new[] { 2, 4, 0, 8 })]
    [DataRow(new[] { 1, 0, 0, 1 }, new[] { 1, 0, 0, 1 })]
    [DataRow(new[] { 5, 5, 5, 5, 5, 5, 5, 5, 5 }, new[] { 5, 5, 5, 0, 5, 5, 0, 0, 5 })]
    public void GetLowerTriangularMatrix_GivenSquareMatrix_ReturnsLowerTriangular(int[] flatMatrix, int[] flatExpected)
    {
        var size = flatMatrix.Length == 4 ? 2 : 3;
        var matrix = CreateSquareMatrixForTriangular(flatMatrix, size);
        var expected = CreateSquareMatrixForTriangular(flatExpected, size);

        var result = ArrayExercises.GetLowerTriangularMatrix(matrix);

        result.Should().BeEquivalentTo(expected);
    }

    private int[,] CreateSquareMatrixForTriangular(int[] flatArray, int size)
    {
        var matrix = new int[size, size];
        var index = 0;
        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                matrix[i, j] = flatArray[index++];
            }
        }
        return matrix;
    }

    // Exercise 27 - Write a C# Sharp program to print or display an upper triangular matrix.
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] { 1, 0, 0, 4, 5, 0, 7, 8, 9 })]
    [DataRow(new[] { 2, 4, 6, 8 }, new[] { 2, 0, 6, 8 })]
    [DataRow(new[] { 1, 0, 0, 1 }, new[] { 1, 0, 0, 1 })]
    [DataRow(new[] { 5, 5, 5, 5, 5, 5, 5, 5, 5 }, new[] { 5, 0, 0, 5, 5, 0, 5, 5, 5 })]
    public void GetUpperTriangularMatrix_GivenSquareMatrix_ReturnsUpperTriangular(int[] flatMatrix, int[] flatExpected)
    {
        var size = flatMatrix.Length == 4 ? 2 : 3;
        var matrix = CreateSquareMatrixForUpperTriangular(flatMatrix, size);
        var expected = CreateSquareMatrixForUpperTriangular(flatExpected, size);

        var result = ArrayExercises.GetUpperTriangularMatrix(matrix);

        result.Should().BeEquivalentTo(expected);
    }

    private int[,] CreateSquareMatrixForUpperTriangular(int[] flatArray, int size)
    {
        var matrix = new int[size, size];
        var index = 0;
        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                matrix[i, j] = flatArray[index++];
            }
        }
        return matrix;
    }

    // Exercise 28 - Write a C# Sharp program to calculate the determinant of a 3 x 3 matrix.
    [TestMethod]
    [DataRow(new[] { 1, 0, -1, 0, 0, 1, -1, -1, 0 }, 1)]
    [DataRow(new[] { 2, 6, 8, 10, 12, 14, 16, 18, 20 }, 24)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0)]
    [DataRow(new[] { 2, 0, 0, 0, 2, 0, 0, 0, 2 }, 8)]
    [DataRow(new[] { 3, 1, 4, 1, 5, 9, 2, 6, 5 }, -90)] // Corrigido de -10 para -90
    public void CalculateDeterminant3x3_Given3x3Matrix_ReturnsDeterminant(int[] flatMatrix, int expected)
    {
        var matrix = Create3x3Matrix(flatMatrix);

        var result = ArrayExercises.CalculateDeterminant3x3(matrix);

        result.Should().Be(expected);
    }

    private int[,] Create3x3Matrix(int[] flatArray)
    {
        var matrix = new int[3, 3];
        var index = 0;
        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                matrix[i, j] = flatArray[index++];
            }
        }
        return matrix;
    }

    // Exercise 29 - Write a C# Sharp program to accept a matrix and determine whether it is a sparse matrix.
    [TestMethod]
    [DataRow(new[] { 0, 0, 1, 0 }, 2, 2, true, 3)]
    [DataRow(new[] { 0, 1, 0, 0 }, 2, 2, true, 3)]
    [DataRow(new[] { 1, 2, 3, 4 }, 2, 2, false, 0)]
    [DataRow(new[] { 0, 0, 0, 0, 0, 0 }, 2, 3, true, 6)]
    [DataRow(new[] { 1, 0, 0, 0, 1, 0 }, 2, 3, true, 4)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 2, 3, false, 0)]
    public void CheckSparseMatrix_GivenMatrix_ReturnsSparseStatusAndZeroCount(
        int[] flatMatrix, int rows, int cols, bool expectedIsSparse, int expectedZeroCount)
    {
        var matrix = CreateMatrixForSparseCheck(flatMatrix, rows, cols);

        var (isSparse, zeroCount) = ArrayExercises.CheckSparseMatrix(matrix);

        isSparse.Should().Be(expectedIsSparse);
        zeroCount.Should().Be(expectedZeroCount);
    }

    private int[,] CreateMatrixForSparseCheck(int[] flatArray, int rows, int cols)
    {
        var matrix = new int[rows, cols];
        var index = 0;
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                matrix[i, j] = flatArray[index++];
            }
        }
        return matrix;
    }

    // Exercise 30 -  Write a C# Sharp program to accept two matrices and check equality.
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4 }, 2, 2, 2, 2, true)]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, 2, 2, 2, 2, false)]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4, 5, 6 }, 2, 2, 2, 3, false)]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4 }, 2, 2, 2, 2, true)]
    [DataRow(new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, 2, 2, 2, 2, true)]
    [DataRow(new[] { 1, 0, 0, 1 }, new[] { 1, 0, 0, 1 }, 2, 2, 2, 2, true)]
    public void AreMatricesEqual_GivenTwoMatrices_ReturnsEqualityResult(
        int[] flatMatrix1, int[] flatMatrix2, int rows1, int cols1, int rows2, int cols2, bool expected)
    {
        var matrix1 = CreateMatrixForEqualityCheck(flatMatrix1, rows1, cols1);
        var matrix2 = CreateMatrixForEqualityCheck(flatMatrix2, rows2, cols2);

        var result = ArrayExercises.AreMatricesEqual(matrix1, matrix2);

        result.Should().Be(expected);
    }

    private int[,] CreateMatrixForEqualityCheck(int[] flatArray, int rows, int cols)
    {
        var matrix = new int[rows, cols];
        var index = 0;
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                matrix[i, j] = flatArray[index++];
            }
        }
        return matrix;
    }

    // Exercise 31 - Write a C# Sharp program to Check whether a Given Matrix is an Identity Matrix.
    [TestMethod]
    [DataRow(new[] { 1, 0, 0, 1 }, true)]
    [DataRow(new[] { 1, 0, 0, 0, 1, 0, 0, 0, 1 }, true)]
    [DataRow(new[] { 1, 2, 0, 1 }, false)]
    [DataRow(new[] { 1, 0, 1, 0 }, false)]
    [DataRow(new[] { 2, 0, 0, 2 }, false)]
    [DataRow(new[] { 1, 0, 0, 0, 1, 0, 0, 0, 0 }, false)]
    public void IsIdentityMatrix_GivenSquareMatrix_ReturnsIdentityStatus(int[] flatMatrix, bool expected)
    {
        var size = flatMatrix.Length == 4 ? 2 : 3;
        var matrix = CreateSquareMatrixForIdentityCheck(flatMatrix, size);

        var result = ArrayExercises.IsIdentityMatrix(matrix);

        result.Should().Be(expected);
    }

    private int[,] CreateSquareMatrixForIdentityCheck(int[] flatArray, int size)
    {
        var matrix = new int[size, size];
        var index = 0;
        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                matrix[i, j] = flatArray[index++];
            }
        }
        return matrix;
    }

    // Exercise 32 - Write a C# Sharp program to get only odd values from a given integer array.
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 5, 4, 2, 3, 4 }, new[] { 1, 3, 5, 3 })]
    [DataRow(new[] { 2, 4, 2, 6, 4, 8 }, new int[0])]
    [DataRow(new[] { 1, 3, 5, 7 }, new[] { 1, 3, 5, 7 })]
    [DataRow(new[] { 2, 4, 6, 8 }, new int[0])]
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 0 }, new int[0])]
    public void GetOddValues_GivenIntegerArray_ReturnsOddValues(int[] input, int[] expected)
    {
        var result = ArrayExercises.GetOddValues(input);

        result.Should().Equal(expected);
    }

    // Exercise 33 - Write a C# Sharp program that removes all duplicate elements from a given array and returns an updated array.
    [TestMethod]
    public void RemoveDuplicates_GivenMixedArray_ReturnsUniqueElements()
    {
        var mixedArray = new object[]
        {
            25,
            "Anna",
            false,
            25,
            "4/15/2021 12:10:51 PM",
            112.22,
            "Anna",
            false
        };

        var expected = new object[]
        {
            25,
            "Anna",
            false,
            "4/15/2021 12:10:51 PM",
            112.22
        };

        var result = ArrayExercises.RemoveDuplicates(mixedArray);

        result.Should().Equal(expected);
    }

    [TestMethod]
    public void RemoveDuplicates_GivenIntegerArray_ReturnsUniqueElements()
    {
        var input = new object[] { 1, 2, 2, 3, 4, 4, 5 };
        var expected = new object[] { 1, 2, 3, 4, 5 };

        var result = ArrayExercises.RemoveDuplicates(input);

        result.Should().Equal(expected);
    }

    [TestMethod]
    public void RemoveDuplicates_GivenStringArray_ReturnsUniqueElements()
    {
        var input = new object[] { "a", "b", "a", "c", "b" };
        var expected = new object[] { "a", "b", "c" };

        var result = ArrayExercises.RemoveDuplicates(input);

        result.Should().Equal(expected);
    }

    // Exercise 34 - Write a C# Sharp program to find the missing number in a given array of numbers between 10 and 20.
    [TestMethod]
    [DataRow(new[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, 0)]
    [DataRow(new[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, 10)]
    [DataRow(new[] { 10, 11, 12, 13, 14, 16, 17, 18, 19, 20 }, 15)]
    [DataRow(new[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 20)]
    [DataRow(new[] { 10, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, 11)]
    public void FindMissingNumber10To20_GivenArray_ReturnsMissingNumber(int[] input, int expected)
    {
        var result = ArrayExercises.FindMissingNumber10To20(input);

        result.Should().Be(expected);
    }

    // Exercise 35 - Write a C# Sharp program to calculate the sum of the two lowest negative numbers in a given array of integers.
    [TestMethod]
    [DataRow(new[] { -10, -11, -12, -13, -14, 15, 16, 17, 18, 19, 20 }, -27)]
    [DataRow(new[] { -1, -2, -4, 0, 3, 4, 5, 9 }, -6)]
    [DataRow(new[] { -5, -3, -1 }, -8)]
    [DataRow(new[] { -100, -50, -25 }, -150)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 0)] // No negative numbers
    [DataRow(new[] { -1 }, -1)] // Only one negative number
    public void SumTwoLowestNegativeNumbers_GivenArray_ReturnsSum(int[] input, int expected)
    {
        var result = ArrayExercises.SumTwoLowestNegativeNumbers(input);

        result.Should().Be(expected);
    }

    // Exercise 36 - Write a C# Sharp program to re-arrange the elements in a given array of numbers and check whether the numbers are consecutive or not.
    [TestMethod]
    [DataRow(new[] { -10, -11, -12, -13, -14, 15, 16, 17, 18, 19, 20 }, false)]
    [DataRow(new[] { -1, -2, -3, 0, 1, 4, 3, 2 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, true)]
    [DataRow(new[] { -3, -2, -1, 0, 1, 2, 3, 4 }, true)]
    [DataRow(new[] { 6, 7, 8, 9, 10, 11, 12, 13 }, true)]
    [DataRow(new[] { 1, 3, 5, 7 }, false)]
    [DataRow(new[] { 2, 4, 6, 8 }, false)]
    [DataRow(new[] { 1 }, true)] // Single element
    [DataRow(new int[0], false)] // Empty array
    public void AreNumbersConsecutive_GivenArray_ReturnsConsecutiveStatus(int[] input, bool expected)
    {
        var result = ArrayExercises.AreNumbersConsecutive(input);

        result.Should().Be(expected);
    }

    // Exercise 37 - Write a C# Sharp program that calculates the smallest gap between numbers in an array of integers.
    [TestMethod]
    [DataRow(new[] { 7, 5, 8, 9, 11, 23, 18 }, 1)]
    [DataRow(new[] { 200, 300, 250, 151, 162 }, 11)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1)]
    [DataRow(new[] { 10, 20, 30, 40 }, 10)]
    [DataRow(new[] { 5, 10, 15, 20 }, 5)]
    [DataRow(new[] { 1, 100 }, 99)]
    [DataRow(new[] { 5 }, 0)] // Single element
    [DataRow(new int[0], 0)] // Empty array
    public void FindSmallestGap_GivenArray_ReturnsSmallestGap(int[] input, int expected)
    {
        var result = ArrayExercises.FindSmallestGap(input);

        result.Should().Be(expected);
    }

    // Exercise 38 - Write a C# Sharp program that takes an array of numbers and a digit. Check whether the digit is present in this array of numbers.
    [TestMethod]
    [DataRow(new[] { 7, 5, 85, 9, 11, 23, 18 }, "1", "Present")]
    [DataRow(new[] { 7, 5, 85, 9, 11, 23, 18 }, "9", "Present")]
    [DataRow(new[] { 7, 5, 85, 9, 11, 23, 18 }, "4", "Not present..!")]
    [DataRow(new[] { 123, 456, 789 }, "1", "Present")]
    [DataRow(new[] { 123, 456, 789 }, "0", "Not present..!")]
    [DataRow(new[] { 100, 200, 300 }, "0", "Present")]
    [DataRow(new[] { 1, 2, 3 }, "5", "Not present..!")]
    [DataRow(new int[0], "1", "Not present..!")] // Empty array
    public void CheckDigitPresence_GivenArrayAndDigit_ReturnsPresenceStatus(int[] numbers, string digit, string expected)
    {
        var result = ArrayExercises.CheckDigitPresence(numbers, digit);

        result.Should().Be(expected);
    }

    // Exercise 39 - Write a C# Sharp program that calculates the sum of all prime numbers in an array of numbers.
    [TestMethod]
    [DataRow(new[] { 7, 5, 85, 9, 11, 23, 18 }, 46)]
    [DataRow(new[] { 200, 300, 250, 151, 162 }, 151)]
    [DataRow(new[] { 2, 3, 5, 7, 11 }, 28)]
    [DataRow(new[] { 4, 6, 8, 9, 10 }, 0)]
    [DataRow(new[] { 1 }, 0)]
    [DataRow(new[] { 0 }, 0)]
    [DataRow(new int[0], 0)]
    public void SumOfPrimes_GivenArray_ReturnsSumOfPrimeNumbers(int[] input, int expected)
    {
        var result = ArrayExercises.SumOfPrimes(input);

        result.Should().Be(expected);
    }

    // Exercise 40 - Write a C# Sharp program that takes an array of integers and finds the smallest positive integer that is not present in that array.
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 5, 6, 7 }, 4)]
    [DataRow(new[] { -1, -2, 0, 1, 3, 4, 5, 6 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 6)]
    [DataRow(new[] { 2, 3, 4, 5 }, 1)]
    [DataRow(new[] { -1, -2, -3 }, 1)]
    [DataRow(new[] { 0 }, 1)]
    [DataRow(new int[0], 1)]
    public void FindSmallestMissingPositive_GivenArray_ReturnsSmallestMissingPositive(int[] input, int expected)
    {
        var result = ArrayExercises.FindSmallestMissingPositive(input);

        result.Should().Be(expected);
    }

    // Exercise 41 - Write a C# Sharp program to find two numbers in an array of integers whose product is equal to a given number.
    [TestMethod]
    [DataRow(new[] { 10, 18, 39, 75, 100 }, 180, new[] { 10, 18 })]
    [DataRow(new[] { 10, 18, 39, 75, 100 }, 200, new int[0])]
    [DataRow(new[] { 10, 18, 39, 75, 100 }, 702, new[] { 18, 39 })]
    [DataRow(new[] { 2, 3, 4, 5, 6 }, 12, new[] { 2, 6 })]
    [DataRow(new[] { 1, 2, 3, 4 }, 8, new[] { 2, 4 })]
    [DataRow(new[] { 1, 2, 3 }, 6, new[] { 2, 3 })]
    [DataRow(new[] { 1 }, 1, new int[0])]
    public void FindProductPair_GivenArrayAndTarget_ReturnsProductPair(int[] numbers, int target, int[] expected)
    {
        var result = ArrayExercises.FindProductPair(numbers, target);

        result.Should().BeEquivalentTo(expected);
    }
}
