using Exercises;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTests;

[TestClass]
public class SearchingAndSortingTests
{
    // Exercise 1 - Write a C# Sharp program to sort a list of elements using Shell sort.
    [TestMethod]
    [DataRow(new int[] { 5, -4, 11, 0, 18, 22, 67, 51, 6 }, new int[] { -4, 0, 5, 6, 11, 18, 22, 51, 67 })]
    [DataRow(new int[] { 1 }, new int[] { 1 })]
    [DataRow(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
    [DataRow(new int[] { -3, -1, -2 }, new int[] { -3, -2, -1 })]
    [DataRow(new int[] { 5, 5, 3, 3, 1 }, new int[] { 1, 3, 3, 5, 5 })]
    public void ShellSort_ShouldSortArrayCorrectly(int[] input, int[] expected)
    {
        SearchingAndSorting.ShellSort(input);
        input.Should().Equal(expected);
    }

    // Exercise 2 - Write a C# Sharp program to sort a list of elements using Bogosort sort.
    [TestMethod]
    [DataRow(new int[] { 0, 1, 2, 3 }, 0)]
    [DataRow(new int[] { -4, -3, -2, -1 }, 0)]
    [DataRow(new int[] { 1 }, 0)]
    public void BogoSort_ShouldReturnZeroIterations_WhenArrayIsAlreadySorted(int[] input, int expectedIterations)
    {
        var result = SearchingAndSorting.BogoSort(input);
        result.Should().Be(expectedIterations);
        input.Should().BeInAscendingOrder();
    }

    [TestMethod]
    public void BogoSort_ShouldSortArray_AndReturnPositiveIterations()
    {
        var input = new int[] { 2, 1, 3, 0 };
        var result = SearchingAndSorting.BogoSort(input);

        result.Should().BeGreaterThanOrEqualTo(0);
        input.Should().Equal(new int[] { 0, 1, 2, 3 });
    }

    // Exercise 3 - Write a C# Sharp program to sort a list of elements using Bubble sort.
    [TestMethod]
    [DataRow(new int[] { 3, 0, 2, 5, -1, 4, 1 }, new int[] { -1, 0, 1, 2, 3, 4, 5 })]
    [DataRow(new int[] { 1 }, new int[] { 1 })]
    [DataRow(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
    [DataRow(new int[] { -3, -1, -2 }, new int[] { -3, -2, -1 })]
    [DataRow(new int[] { 2, 2, 1, 1 }, new int[] { 1, 1, 2, 2 })]
    public void BubbleSort_ShouldSortArrayCorrectly(int[] input, int[] expected)
    {
        SearchingAndSorting.BubbleSort(input);
        input.Should().Equal(expected);
    }

    // Exercise 4 - Write a C# Sharp program to sort a list of elements using Counting sort.
    [TestMethod]
    [DataRow(new int[] { 2, 5, -4, 11, 0, 8, 22, 67, 51, 6 }, new int[] { -4, 0, 2, 5, 6, 8, 11, 22, 51, 67 })]
    [DataRow(new int[] { 1 }, new int[] { 1 })]
    [DataRow(new int[] { 3, 3, 2, 2, 1, 1 }, new int[] { 1, 1, 2, 2, 3, 3 })]
    [DataRow(new int[] { -3, -1, -2 }, new int[] { -3, -2, -1 })]
    [DataRow(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
    public void CountingSort_ShouldSortArrayCorrectly(int[] input, int[] expected)
    {
        SearchingAndSorting.CountingSort(input);
        input.Should().Equal(expected);
    }

    // Exercise 5 - Write a C# Sharp program to sort a list of elements using Heap sort.
    [TestMethod]
    [DataRow(new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 }, new int[] { -4, 0, 2, 5, 6, 11, 18, 22, 51, 67 })]
    [DataRow(new int[] { 1 }, new int[] { 1 })]
    [DataRow(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
    [DataRow(new int[] { -3, -1, -2 }, new int[] { -3, -2, -1 })]
    [DataRow(new int[] { 3, 3, 2, 2, 1, 1 }, new int[] { 1, 1, 2, 2, 3, 3 })]
    public void HeapSort_ShouldSortArrayCorrectly(int[] input, int[] expected)
    {
        SearchingAndSorting.HeapSort(input);
        input.Should().Equal(expected);
    }

    // Exercise 6 - Write a C# Sharp program to sort a list of elements using Insertion sort.
    [TestMethod]
    [DataRow(new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 }, new int[] { -4, 0, 2, 5, 6, 11, 18, 22, 51, 67 })]
    [DataRow(new int[] { 1 }, new int[] { 1 })]
    [DataRow(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
    [DataRow(new int[] { -3, -1, -2 }, new int[] { -3, -2, -1 })]
    [DataRow(new int[] { 3, 3, 2, 2, 1, 1 }, new int[] { 1, 1, 2, 2, 3, 3 })]
    public void InsertionSort_ShouldSortArrayCorrectly(int[] input, int[] expected)
    {
        SearchingAndSorting.InsertionSort(input);
        input.Should().Equal(expected);
    }

    // Exercise 7 - Write a C# Sharp program to sort a list of elements using Merge sort.
    [TestMethod]
    [DataRow(new int[] { 79, 69, 9, 95, 65, 49, 65, 40, 27, 95 }, new int[] { 9, 27, 40, 49, 65, 65, 69, 79, 95, 95 })]
    [DataRow(new int[] { 1 }, new int[] { 1 })]
    [DataRow(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
    [DataRow(new int[] { -3, -1, -2 }, new int[] { -3, -2, -1 })]
    [DataRow(new int[] { 3, 3, 2, 2, 1, 1 }, new int[] { 1, 1, 2, 2, 3, 3 })]
    public void MergeSort_ShouldSortArrayCorrectly(int[] input, int[] expected)
    {
        SearchingAndSorting.MergeSort(input);
        input.Should().Equal(expected);
    }

    // Exercise 8 - Write a C# Sharp program to sort a list of elements using Permutation sort.
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, 0)]
    [DataRow(new int[] { -3, -2, -1 }, 0)]
    [DataRow(new int[] { 1 }, 0)]
    public void PermutationSort_ShouldReturnZeroIterations_WhenArrayIsAlreadySorted(int[] input, int expectedIterations)
    {
        var result = SearchingAndSorting.PermutationSort(input);
        result.Should().Be(expectedIterations);
        input.Should().BeInAscendingOrder();
    }

    [TestMethod]
    public void PermutationSort_ShouldSortArray_AndReturnPositiveIterations()
    {
        var input = new int[] { 3, 1, 2 };
        var result = SearchingAndSorting.PermutationSort(input);

        result.Should().BeGreaterThanOrEqualTo(0);
        input.Should().Equal(new int[] { 1, 2, 3 });
    }

    // Exercise 9 - Write a C# Sharp program to sort a list of elements using Quick sort.
    [TestMethod]
    [DataRow(new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 }, new int[] { -4, 0, 2, 5, 6, 11, 18, 22, 51, 67 })]
    [DataRow(new int[] { 1 }, new int[] { 1 })]
    [DataRow(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
    [DataRow(new int[] { -3, -1, -2 }, new int[] { -3, -2, -1 })]
    [DataRow(new int[] { 3, 3, 2, 2, 1, 1 }, new int[] { 1, 1, 2, 2, 3, 3 })]
    public void QuickSort_ShouldSortArrayCorrectly(int[] input, int[] expected)
    {
        SearchingAndSorting.QuickSort(input);
        input.Should().Equal(expected);
    }

    // Exercise 10 - Write a C# Sharp program to sort a list of elements using the Radix sort algorithm.
    [TestMethod]
    [DataRow(new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 }, new int[] { -4, 0, 2, 5, 6, 11, 18, 22, 51, 67 })]
    [DataRow(new int[] { 1 }, new int[] { 1 })]
    [DataRow(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
    [DataRow(new int[] { -3, -1, -2 }, new int[] { -3, -2, -1 })]
    [DataRow(new int[] { 3, 3, 2, 2, 1, 1 }, new int[] { 1, 1, 2, 2, 3, 3 })]
    public void RadixSort_ShouldSortArrayCorrectly(int[] input, int[] expected)
    {
        SearchingAndSorting.RadixSort(input);
        input.Should().Equal(expected);
    }

    // Exercise 11 - Write a C# Sharp program to sort a list of elements using the Selection sort algorithm.
    [TestMethod]
    [DataRow(new int[] { 50, 70, 50, 80, 89, 25, 78, 58, 83, 73 }, new int[] { 25, 50, 50, 58, 70, 73, 78, 80, 83, 89 })]
    [DataRow(new int[] { 1 }, new int[] { 1 })]
    [DataRow(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
    [DataRow(new int[] { -3, -1, -2 }, new int[] { -3, -2, -1 })]
    [DataRow(new int[] { 3, 3, 2, 2, 1, 1 }, new int[] { 1, 1, 2, 2, 3, 3 })]
    public void SelectionSort_ShouldSortArrayCorrectly(int[] input, int[] expected)
    {
        SearchingAndSorting.SelectionSort(input);
        input.Should().Equal(expected);
    }
}
