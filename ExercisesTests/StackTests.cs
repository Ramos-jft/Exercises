using Exercises;
using FluentAssertions;
using static Exercises.StackExercises;

namespace ExercisesTests;

[TestClass]
public class StackTests
{
    /* Exercise 1 - Write a C# program to implement a stack with push and pop operations. 
    Find the top element of the stack and check if the stack is empty or not.*/
    [TestMethod]
    [DataRow(5, 10, 20, 30, 40, 50)]
    public void StackOperations_CompleteFlow_ValidBehavior(int capacity, int first, int second, int third, int fourth, int fifth)
    {
        var stack = new StackExercises1(capacity);

        stack.IsStackEmpty().Should().BeTrue();

        stack.PushElement(first);
        stack.PushElement(second);
        stack.PushElement(third);

        stack.IsStackEmpty().Should().BeFalse();
        stack.PeekTopElement().Should().Be(third);

        stack.PopElement().Should().Be(third);
        stack.PeekTopElement().Should().Be(second);

        stack.PushElement(fourth);
        stack.PushElement(fifth);

        stack.PeekTopElement().Should().Be(fifth);
        stack.PopElement().Should().Be(fifth);
        stack.PopElement().Should().Be(fourth);
        stack.PeekTopElement().Should().Be(second);
    }

    [TestMethod]
    [DataRow(3, 100, 200, 300)]
    public void StackOperations_FullCapacity_ValidBehavior(int capacity, int first, int second, int third)
    {
        var stack = new StackExercises1(capacity);

        stack.PushElement(first);
        stack.PushElement(second);
        stack.PushElement(third);

        stack.PeekTopElement().Should().Be(third);
        stack.PopElement().Should().Be(third);
        stack.PopElement().Should().Be(second);
        stack.PopElement().Should().Be(first);

        stack.IsStackEmpty().Should().BeTrue();
    }

    // Exercise 2 - Write a C# program to sort the elements of a given stack in descending order.
    [TestMethod]
    [DataRow(new int[] { 1, 3, 5, 2, 4 }, new int[] { 5, 4, 3, 2, 1 })]
    [DataRow(new int[] { 10, 5, 8, 1, 7 }, new int[] { 10, 8, 7, 5, 1 })]
    [DataRow(new int[] { 9, 2, 6, 4, 8 }, new int[] { 9, 8, 6, 4, 2 })]
    public void ArrangeDescending_UnsortedStack_ReturnsDescendingOrder(int[] input, int[] expected)
    {
        var stack = new StackExercises2(input.Length);
        foreach (var item in input)
        {
            stack.InsertItem(item);
        }

        StackExercises2.ArrangeDescending(stack);

        foreach (var expectedItem in expected)
        {
            stack.RemoveItem().Should().Be(expectedItem);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 2, 1 }, new int[] { 2, 1 })]
    [DataRow(new int[] { 5 }, new int[] { 5 })]
    [DataRow(new int[] { 7, 7, 3 }, new int[] { 7, 7, 3 })]
    public void ArrangeDescending_SpecialCases_CorrectOrder(int[] input, int[] expected)
    {
        var stack = new StackExercises2(input.Length);
        foreach (var item in input)
        {
            stack.InsertItem(item);
        }

        StackExercises2.ArrangeDescending(stack);

        foreach (var expectedItem in expected)
        {
            stack.RemoveItem().Should().Be(expectedItem);
        }
    }

    // Exercise 3 - Write a C# program to sort the elements of a given stack in ascending order.
    [TestMethod]
    [DataRow(new int[] { 5, 9, 3, 3, 1 }, new int[] { 1, 3, 3, 5, 9 })]
    [DataRow(new int[] { 10, 0, 1, 3, 3, 5, 9 }, new int[] { 0, 1, 3, 3, 5, 9, 10 })]
    [DataRow(new int[] { 8, 2, 6, 4, 7 }, new int[] { 2, 4, 6, 7, 8 })]
    public void OrderAscending_UnsortedStack_ReturnsAscendingOrder(int[] input, int[] expected)
    {
        var stack = new StackExercises3(input.Length);
        foreach (var item in input)
        {
            stack.AddToStack(item);
        }

        StackExercises3.OrderAscending(stack);

        foreach (var expectedItem in expected)
        {
            stack.TakeFromStack().Should().Be(expectedItem);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 2, 1 }, new int[] { 1, 2 })]
    [DataRow(new int[] { 5 }, new int[] { 5 })]
    [DataRow(new int[] { 3, 3, 1 }, new int[] { 1, 3, 3 })]
    public void OrderAscending_SpecialCases_CorrectAscendingOrder(int[] input, int[] expected)
    {
        var stack = new StackExercises3(input.Length);
        foreach (var item in input)
        {
            stack.AddToStack(item);
        }

        StackExercises3.OrderAscending(stack);

        foreach (var expectedItem in expected)
        {
            stack.TakeFromStack().Should().Be(expectedItem);
        }
    }

    // Exercise 4 - Write a C# program to reverse the elements of a given stack.
    [TestMethod]
    [DataRow(new int[] { 5, 9, 3, 3, 1 }, new int[] { 1, 3, 3, 9, 5 })]
    [DataRow(new int[] { 10, 20, 30, 40 }, new int[] { 40, 30, 20, 10 })]
    [DataRow(new int[] { 7, 2, 9, 4 }, new int[] { 4, 9, 2, 7 })]
    public void ReverseStack_GivenStack_ReturnsReversedOrder(int[] input, int[] expected)
    {
        var originalStack = new StackExercises4(input.Length);
        foreach (var item in input)
        {
            originalStack.PushValue(item);
        }

        var reversedStack = StackExercises4.ReverseStack(originalStack);

        foreach (var expectedItem in expected)
        {
            reversedStack.PopValue().Should().Be(expectedItem);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2 }, new int[] { 2, 1 })]
    [DataRow(new int[] { 5 }, new int[] { 5 })]
    [DataRow(new int[] { 8, 5, 3 }, new int[] { 3, 5, 8 })]
    public void ReverseStack_VariousCases_CorrectReversal(int[] input, int[] expected)
    {
        var originalStack = new StackExercises4(input.Length);
        foreach (var item in input)
        {
            originalStack.PushValue(item);
        }

        var reversedStack = StackExercises4.ReverseStack(originalStack);

        foreach (var expectedItem in expected)
        {
            reversedStack.PopValue().Should().Be(expectedItem);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 10, 20, 30 })]
    public void ReverseStack_OriginalStackRemainsUnchanged(int[] input)
    {
        var originalStack = new StackExercises4(input.Length);
        foreach (var item in input)
        {
            originalStack.PushValue(item);
        }

        var reversedStack = StackExercises4.ReverseStack(originalStack);

        originalStack.PopValue().Should().Be(30);
        originalStack.PopValue().Should().Be(20);
        originalStack.PopValue().Should().Be(10);
    }

    // Exercise 5 - Write a C# program to find the maximum element in a stack.
    [TestMethod]
    [DataRow(new int[] { 1, 3, 4, 9, 5, 6 }, 9)]
    [DataRow(new int[] { 10, 5, 8, 15, 3 }, 15)]
    [DataRow(new int[] { 7, 2, 9, 4 }, 9)]
    public void FindMaximumValue_StackWithElements_ReturnsMaximum(int[] elements, int expectedMax)
    {
        var stack = new StackExercises5(elements.Length);
        foreach (var element in elements)
        {
            stack.PushElement(element);
        }

        stack.FindMaximumValue().Should().Be(expectedMax);
    }

    [TestMethod]
    [DataRow(new int[] { 5 }, 5)]
    [DataRow(new int[] { 2, 2, 2 }, 2)]
    [DataRow(new int[] { -1, -5, -3 }, -1)]
    public void FindMaximumValue_SpecialCases_ReturnsCorrectMaximum(int[] elements, int expectedMax)
    {
        var stack = new StackExercises5(elements.Length);
        foreach (var element in elements)
        {
            stack.PushElement(element);
        }

        stack.FindMaximumValue().Should().Be(expectedMax);
    }

    [TestMethod]
    public void FindMaximumValue_EmptyStack_ReturnsMinusOne()
    {
        var stack = new StackExercises5(5);
        stack.FindMaximumValue().Should().Be(-1);
    }

    [TestMethod]
    [DataRow(new int[] { 10, 20, 30 })]
    public void FindMaximumValue_StackOperationsPreserveElements(int[] elements)
    {
        var stack = new StackExercises5(elements.Length);
        foreach (var element in elements)
        {
            stack.PushElement(element);
        }

        stack.FindMaximumValue().Should().Be(30);

        stack.PopElement().Should().Be(30);
        stack.PopElement().Should().Be(20);
        stack.PopElement().Should().Be(10);
    }

    // Exercise 6 - Write a C# program to find the minimum element in a stack.
    [TestMethod]
    [DataRow(new int[] { 6, 5, 9, 4, 3, 1 }, 1)]
    [DataRow(new int[] { 10, 5, 8, 15, 3 }, 3)]
    [DataRow(new int[] { 7, 2, 9, 4 }, 2)]
    public void FindMinimumValue_StackWithElements_ReturnsMinimum(int[] elements, int expectedMin)
    {
        var stack = new StackExercises6(elements.Length);
        foreach (var element in elements)
        {
            stack.PushItem(element);
        }

        stack.FindMinimumValue().Should().Be(expectedMin);
    }

    [TestMethod]
    [DataRow(new int[] { 5 }, 5)]
    [DataRow(new int[] { 2, 2, 2 }, 2)]
    [DataRow(new int[] { -1, -5, -3 }, -5)]
    public void FindMinimumValue_SpecialCases_ReturnsCorrectMinimum(int[] elements, int expectedMin)
    {
        var stack = new StackExercises6(elements.Length);
        foreach (var element in elements)
        {
            stack.PushItem(element);
        }

        stack.FindMinimumValue().Should().Be(expectedMin);
    }

    [TestMethod]
    public void FindMinimumValue_EmptyStack_ReturnsMinusOne()
    {
        var stack = new StackExercises6(5);
        stack.FindMinimumValue().Should().Be(-1);
    }

    [TestMethod]
    [DataRow(new int[] { 10, 20, 30 })]
    public void FindMinimumValue_StackOperationsPreserveElements(int[] elements)
    {
        var stack = new StackExercises6(elements.Length);
        foreach (var element in elements)
        {
            stack.PushItem(element);
        }

        stack.FindMinimumValue().Should().Be(10);

        stack.PopItem().Should().Be(30);
        stack.PopItem().Should().Be(20);
        stack.PopItem().Should().Be(10);
    }

    // Exercise 7 - Write a C# program to remove all the elements from a given stack.
    [TestMethod]
    [DataRow(new int[] { 10, 20, 30, 40, 50 })]
    [DataRow(new int[] { 1, 2, 3 })]
    [DataRow(new int[] { 7 })]
    public void ClearAllElements_StackWithElements_BecomesEmpty(int[] elements)
    {
        var stack = new StackExercises7(elements.Length);
        foreach (var element in elements)
        {
            stack.PushElement(element);
        }

        stack.ClearAllElements();
        stack.IsEmpty().Should().BeTrue();
    }

    [TestMethod]
    public void ClearAllElements_EmptyStack_RemainsEmpty()
    {
        var stack = new StackExercises7(5);

        stack.ClearAllElements();
        stack.IsEmpty().Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 10, 20, 30 })]
    public void ClearAllElements_AfterClear_CanPushNewElements(int[] elements)
    {
        var stack = new StackExercises7(elements.Length + 2);
        foreach (var element in elements)
        {
            stack.PushElement(element);
        }

        stack.ClearAllElements();
        stack.IsEmpty().Should().BeTrue();

        stack.PushElement(100);
        stack.PushElement(200);

        stack.IsEmpty().Should().BeFalse();
        stack.PeekElement().Should().Be(200);
        stack.PopElement().Should().Be(200);
        stack.PopElement().Should().Be(100);
    }

    [TestMethod]
    [DataRow(new int[] { 5, 10, 15 })]
    public void ClearAllElements_StackStateResetCorrectly(int[] elements)
    {
        var stack = new StackExercises7(elements.Length);
        foreach (var element in elements)
        {
            stack.PushElement(element);
        }

        stack.ClearAllElements();
        stack.IsEmpty().Should().BeTrue();

        // Verify that pushing after clear works correctly
        stack.PushElement(99);
        stack.PeekElement().Should().Be(99);
        stack.PopElement().Should().Be(99);
        stack.IsEmpty().Should().BeTrue();
    }

    // Exercise 8 - Write a C# program to remove specified element from a given stack.
    [TestMethod]
    [DataRow(new int[] { 10, 20, 30, 40, 50 }, 30, new int[] { 50, 40, 20, 10 })]
    [DataRow(new int[] { 10, 20, 30, 40, 50 }, 50, new int[] { 40, 30, 20, 10 })]
    [DataRow(new int[] { 5, 10, 15, 20 }, 10, new int[] { 20, 15, 5 })]
    public void RemoveSpecificElement_ElementExists_RemovesElement(int[] elements, int target, int[] expected)
    {
        var stack = new StackExercises8(elements.Length);
        foreach (var element in elements)
        {
            stack.AddElement(element);
        }

        StackExercises8.RemoveSpecificElement(stack, target);

        foreach (var expectedElement in expected)
        {
            stack.RemoveElement().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 10, 20, 30 }, 99, new int[] { 30, 20, 10 })]
    [DataRow(new int[] { 5, 10, 15 }, 25, new int[] { 15, 10, 5 })]
    public void RemoveSpecificElement_ElementNotExists_StackUnchanged(int[] elements, int target, int[] expected)
    {
        var stack = new StackExercises8(elements.Length);
        foreach (var element in elements)
        {
            stack.AddElement(element);
        }

        StackExercises8.RemoveSpecificElement(stack, target);

        foreach (var expectedElement in expected)
        {
            stack.RemoveElement().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 5, 5, 5 }, 5, new int[] { })]
    [DataRow(new int[] { 1, 2, 1, 3, 1 }, 1, new int[] { 3, 2 })]
    public void RemoveSpecificElement_MultipleOccurrences_RemovesAll(int[] elements, int target, int[] expected)
    {
        var stack = new StackExercises8(elements.Length);
        foreach (var element in elements)
        {
            stack.AddElement(element);
        }

        StackExercises8.RemoveSpecificElement(stack, target);

        foreach (var expectedElement in expected)
        {
            stack.RemoveElement().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    public void RemoveSpecificElement_EmptyStack_NoChange()
    {
        var stack = new StackExercises8(5);

        StackExercises8.RemoveSpecificElement(stack, 10);

        stack.CheckIfEmpty().Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 7 }, 7, new int[] { })]
    [DataRow(new int[] { 7 }, 8, new int[] { 7 })]
    public void RemoveSpecificElement_SingleElementStack_ProperBehavior(int[] elements, int target, int[] expected)
    {
        var stack = new StackExercises8(elements.Length);
        foreach (var element in elements)
        {
            stack.AddElement(element);
        }

        StackExercises8.RemoveSpecificElement(stack, target);

        foreach (var expectedElement in expected)
        {
            stack.RemoveElement().Should().Be(expectedElement);
        }
    }

    // Exercise 9 - Write a C# program to count all the elements in a given stack.
    [TestMethod]
    [DataRow(new int[] { 10, 20, 30, 40, 50 }, 5)]
    [DataRow(new int[] { 5, 10, 15 }, 3)]
    [DataRow(new int[] { 7 }, 1)]
    public void GetElementCount_StackWithElements_ReturnsCorrectCount(int[] elements, int expectedCount)
    {
        var stack = new StackExercises9(elements.Length);
        foreach (var element in elements)
        {
            stack.PushItem(element);
        }

        stack.GetElementCount().Should().Be(expectedCount);
    }

    [TestMethod]
    public void GetElementCount_EmptyStack_ReturnsZero()
    {
        var stack = new StackExercises9(5);
        stack.GetElementCount().Should().Be(0);
    }

    [TestMethod]
    [DataRow(new int[] { 10, 20, 30 }, 2)]
    public void GetElementCount_AfterPopOperations_ReturnsUpdatedCount(int[] elements, int pops)
    {
        var stack = new StackExercises9(elements.Length);
        foreach (var element in elements)
        {
            stack.PushItem(element);
        }

        for (int i = 0; i < pops; i++)
        {
            stack.PopItem();
        }

        stack.GetElementCount().Should().Be(elements.Length - pops);
    }

    [TestMethod]
    [DataRow(new int[] { 10, 20 }, 1)]
    public void GetElementCount_AfterPushOperations_ReturnsUpdatedCount(int[] initialElements, int additionalPushes)
    {
        var stack = new StackExercises9(initialElements.Length + additionalPushes);
        foreach (var element in initialElements)
        {
            stack.PushItem(element);
        }

        for (int i = 0; i < additionalPushes; i++)
        {
            stack.PushItem(99);
        }

        stack.GetElementCount().Should().Be(initialElements.Length + additionalPushes);
    }

    [TestMethod]
    [DataRow(new int[] { 5, 10, 15, 20 })]
    public void GetElementCount_StackStatePreserved_CountAccurate(int[] elements)
    {
        var stack = new StackExercises9(elements.Length);
        foreach (var element in elements)
        {
            stack.PushItem(element);
        }

        var count = stack.GetElementCount();
        count.Should().Be(elements.Length);

        // Verify stack state is preserved
        stack.PopItem().Should().Be(20);
        stack.PopItem().Should().Be(15);
        stack.PopItem().Should().Be(10);
        stack.PopItem().Should().Be(5);
    }

    // Exercise 10 - Write a C# program to count specified element in a given stack.
    [TestMethod]
    [DataRow(new int[] { 10, 50, 30, 40, 50, 50 }, 50, 3)]
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, 3, 1)]
    [DataRow(new int[] { 7, 7, 7, 7 }, 7, 4)]
    public void CountOccurrences_ValueExists_ReturnsCorrectCount(int[] elements, int target, int expectedCount)
    {
        var stack = new StackExercises10(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.CountOccurrences(target).Should().Be(expectedCount);
    }

    [TestMethod]
    [DataRow(new int[] { 10, 20, 30 }, 99, 0)]
    [DataRow(new int[] { 5, 10, 15 }, 25, 0)]
    public void CountOccurrences_ValueNotExists_ReturnsZero(int[] elements, int target, int expectedCount)
    {
        var stack = new StackExercises10(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.CountOccurrences(target).Should().Be(expectedCount);
    }

    [TestMethod]
    public void CountOccurrences_EmptyStack_ReturnsZero()
    {
        var stack = new StackExercises10(5);
        stack.CountOccurrences(10).Should().Be(0);
    }

    [TestMethod]
    [DataRow(new int[] { 10, 50, 30, 40, 50, 50 })]
    public void CountOccurrences_StackStatePreserved_AfterCounting(int[] elements)
    {
        var stack = new StackExercises10(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.CountOccurrences(50);

        // Verify stack state is preserved
        stack.PopValue().Should().Be(50);
        stack.PopValue().Should().Be(50);
        stack.PopValue().Should().Be(40);
        stack.PopValue().Should().Be(30);
        stack.PopValue().Should().Be(50);
        stack.PopValue().Should().Be(10);
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 1, 3, 1 }, 1, 3)]
    [DataRow(new int[] { 5, 5, 5 }, 5, 3)]
    public void CountOccurrences_MultipleValues_ReturnsCorrectCount(int[] elements, int target, int expectedCount)
    {
        var stack = new StackExercises10(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.CountOccurrences(target).Should().Be(expectedCount);
    }

    // Exercise 11 - Write a C# program to implement a stack that checks if a given element is present or not in the stack.
    [TestMethod]
    [DataRow(new int[] { 10, 50, 30, 40, 50, 50 }, 50, true)]
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, 3, true)]
    [DataRow(new int[] { 7, 8, 9 }, 10, false)]
    public void ContainsValue_ValueExists_ReturnsTrue(int[] elements, int target, bool expected)
    {
        var stack = new StackExercises11(elements.Length);
        foreach (var element in elements)
        {
            stack.PushElement(element);
        }

        stack.ContainsValue(target).Should().Be(expected);
    }

    [TestMethod]
    [DataRow(new int[] { 10, 20, 30 }, 99, false)]
    [DataRow(new int[] { 5, 10, 15 }, 25, false)]
    public void ContainsValue_ValueNotExists_ReturnsFalse(int[] elements, int target, bool expected)
    {
        var stack = new StackExercises11(elements.Length);
        foreach (var element in elements)
        {
            stack.PushElement(element);
        }

        stack.ContainsValue(target).Should().Be(expected);
    }

    [TestMethod]
    public void ContainsValue_EmptyStack_ReturnsFalse()
    {
        var stack = new StackExercises11(5);
        stack.ContainsValue(10).Should().BeFalse();
    }

    [TestMethod]
    [DataRow(new int[] { 10, 50, 30, 40, 50, 50 })]
    public void ContainsValue_StackStatePreserved_AfterCheck(int[] elements)
    {
        var stack = new StackExercises11(elements.Length);
        foreach (var element in elements)
        {
            stack.PushElement(element);
        }

        stack.ContainsValue(50);

        // Verify stack state is preserved
        stack.PopElement().Should().Be(50);
        stack.PopElement().Should().Be(50);
        stack.PopElement().Should().Be(40);
        stack.PopElement().Should().Be(30);
        stack.PopElement().Should().Be(50);
        stack.PopElement().Should().Be(10);
    }

    [TestMethod]
    [DataRow(new int[] { 1 }, 1, true)]
    [DataRow(new int[] { 1 }, 2, false)]
    public void ContainsValue_SingleElementStack_CorrectResult(int[] elements, int target, bool expected)
    {
        var stack = new StackExercises11(elements.Length);
        foreach (var element in elements)
        {
            stack.PushElement(element);
        }

        stack.ContainsValue(target).Should().Be(expected);
    }

    [TestMethod]
    [DataRow(new int[] { 5, 5, 5 }, 5, true)]
    [DataRow(new int[] { 1, 2, 1, 3, 1 }, 2, true)]
    public void ContainsValue_MultipleOccurrences_ReturnsTrue(int[] elements, int target, bool expected)
    {
        var stack = new StackExercises11(elements.Length);
        foreach (var element in elements)
        {
            stack.PushElement(element);
        }

        stack.ContainsValue(target).Should().Be(expected);
    }

    // Exercise 12 - Write a C# program to remove duplicates from a given stack.
    [TestMethod]
    [DataRow(new int[] { 10, 50, 30, 40, 50, 50, 10 }, new int[] { 10, 50, 40, 30 })]
    [DataRow(new int[] { 1, 2, 3, 2, 1 }, new int[] { 1, 2, 3 })]
    [DataRow(new int[] { 7, 7, 7 }, new int[] { 7 })]
    public void RemoveDuplicates_StackWithDuplicates_RemovesDuplicates(int[] elements, int[] expected)
    {
        var stack = new StackExercises12(elements.Length);
        foreach (var element in elements)
        {
            stack.PushElement(element);
        }

        StackExercises12.RemoveDuplicates(stack);

        foreach (var expectedElement in expected)
        {
            stack.PopElement().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
    [DataRow(new int[] { 10 }, new int[] { 10 })]
    public void RemoveDuplicates_StackWithoutDuplicates_RemainsSame(int[] elements, int[] expected)
    {
        var stack = new StackExercises12(elements.Length);
        foreach (var element in elements)
        {
            stack.PushElement(element);
        }

        StackExercises12.RemoveDuplicates(stack);

        foreach (var expectedElement in expected)
        {
            stack.PopElement().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    public void RemoveDuplicates_EmptyStack_NoChange()
    {
        var stack = new StackExercises12(5);

        StackExercises12.RemoveDuplicates(stack);

        stack.IsEmpty().Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 5, 5, 5, 5 })]
    public void RemoveDuplicates_AllSameElements_KeepsOne(int[] elements)
    {
        var stack = new StackExercises12(elements.Length);
        foreach (var element in elements)
        {
            stack.PushElement(element);
        }

        StackExercises12.RemoveDuplicates(stack);

        stack.PopElement().Should().Be(5);
        stack.IsEmpty().Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5, 4, 3, 2, 1 })]
    public void RemoveDuplicates_PreservesOrder_RemovesDuplicates(int[] elements)
    {
        var stack = new StackExercises12(elements.Length);
        foreach (var element in elements)
        {
            stack.PushElement(element);
        }

        StackExercises12.RemoveDuplicates(stack);

        // Should maintain relative order of first occurrences
        stack.PopElement().Should().Be(1);
        stack.PopElement().Should().Be(2);
        stack.PopElement().Should().Be(3);
        stack.PopElement().Should().Be(4);
        stack.PopElement().Should().Be(5);
        stack.IsEmpty().Should().BeTrue();
    }

    // Exercise 13 - Write a C# program to find the top and bottom elements of a given stack.
    [TestMethod]
    [DataRow(new int[] { 10, 50, 30, 40, 50, 50 }, 50, 10)]
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, 5, 1)]
    [DataRow(new int[] { 7, 8, 9 }, 9, 7)]
    public void GetTopAndBottomElements_StackWithElements_ReturnsCorrectValues(int[] elements, int expectedTop, int expectedBottom)
    {
        var stack = new StackExercises13(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.GetTopElement().Should().Be(expectedTop);
        stack.GetBottomElement().Should().Be(expectedBottom);
    }

    [TestMethod]
    public void GetTopAndBottomElements_EmptyStack_ReturnsMinusOne()
    {
        var stack = new StackExercises13(5);

        stack.GetTopElement().Should().Be(-1);
        stack.GetBottomElement().Should().Be(-1);
    }

    [TestMethod]
    [DataRow(new int[] { 5 }, 5, 5)]
    public void GetTopAndBottomElements_SingleElement_ReturnsSameValue(int[] elements, int expectedTop, int expectedBottom)
    {
        var stack = new StackExercises13(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.GetTopElement().Should().Be(expectedTop);
        stack.GetBottomElement().Should().Be(expectedBottom);
    }

    [TestMethod]
    [DataRow(new int[] { 10, 20, 30 })]
    public void GetTopAndBottomElements_StackStatePreserved_AfterGettingElements(int[] elements)
    {
        var stack = new StackExercises13(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        var top = stack.GetTopElement();
        var bottom = stack.GetBottomElement();

        // Verify stack state is preserved
        stack.PopValue().Should().Be(30);
        stack.PopValue().Should().Be(20);
        stack.PopValue().Should().Be(10);
    }

    [TestMethod]
    [DataRow(new int[] { 2, 4, 6, 8 })]
    public void GetTopAndBottomElements_MultipleCalls_ReturnsConsistentValues(int[] elements)
    {
        var stack = new StackExercises13(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        var firstTop = stack.GetTopElement();
        var firstBottom = stack.GetBottomElement();
        var secondTop = stack.GetTopElement();
        var secondBottom = stack.GetBottomElement();

        firstTop.Should().Be(secondTop);
        firstBottom.Should().Be(secondBottom);
        firstTop.Should().Be(8);
        firstBottom.Should().Be(2);
    }

    // Exercise 14 - Write a C# program to rotate the stack elements to the left direction.
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 1, new int[] { 5, 4, 3, 2, 1, 6 })]
    [DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 2, new int[] { 4, 3, 2, 1, 6, 5 })]
    [DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 3, new int[] { 3, 2, 1, 6, 5, 4 })]
    public void RotateLeft_WithRotations_RotatesCorrectly(int[] elements, int rotations, int[] expected)
    {
        var stack = new StackExercises14(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        StackExercises14.RotateLeft(stack, rotations);

        foreach (var expectedElement in expected)
        {
            stack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, 0, new int[] { 3, 2, 1 })]
    [DataRow(new int[] { 1, 2, 3 }, 3, new int[] { 3, 2, 1 })]
    [DataRow(new int[] { 1, 2, 3 }, 6, new int[] { 3, 2, 1 })]
    public void RotateLeft_ZeroOrMultipleOfCount_NoChange(int[] elements, int rotations, int[] expected)
    {
        var stack = new StackExercises14(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        StackExercises14.RotateLeft(stack, rotations);

        foreach (var expectedElement in expected)
        {
            stack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    public void RotateLeft_EmptyStack_NoChange()
    {
        var stack = new StackExercises14(5);

        StackExercises14.RotateLeft(stack, 2);

        stack.IsEmpty().Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 5 }, 1, new int[] { 5 })]
    [DataRow(new int[] { 5 }, 2, new int[] { 5 })]
    public void RotateLeft_SingleElement_NoChange(int[] elements, int rotations, int[] expected)
    {
        var stack = new StackExercises14(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        StackExercises14.RotateLeft(stack, rotations);

        foreach (var expectedElement in expected)
        {
            stack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4 })]
    public void RotateLeft_StackStatePreserved_AfterRotation(int[] elements)
    {
        var stack = new StackExercises14(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        StackExercises14.RotateLeft(stack, 1);

        stack.GetElementCount().Should().Be(elements.Length);
    }

    // Exercise 15 - Write a C# program to swap the top two elements of a given stack.
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 5, 6, 4, 3, 2, 1 })]
    [DataRow(new int[] { 10, 20, 30 }, new int[] { 20, 30, 10 })]
    [DataRow(new int[] { 7, 8 }, new int[] { 7, 8 })] // Corrigido: após swap, a ordem fica 7, 8
    public void SwapTopTwo_StackWithElements_SwapsTopTwo(int[] elements, int[] expected)
    {
        var stack = new StackExercises15(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        StackExercises15.SwapTopTwo(stack);

        foreach (var expectedElement in expected)
        {
            stack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 5 })]
    public void SwapTopTwo_SingleElement_NoChange(int[] elements)
    {
        var stack = new StackExercises15(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        StackExercises15.SwapTopTwo(stack);
        stack.PopValue().Should().Be(5);
    }

    [TestMethod]
    public void SwapTopTwo_EmptyStack_NoChange()
    {
        var stack = new StackExercises15(5);

        StackExercises15.SwapTopTwo(stack);
        stack.IsEmpty().Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 })]
    public void SwapTopTwo_StackStatePreserved_AfterSwap(int[] elements)
    {
        var stack = new StackExercises15(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        StackExercises15.SwapTopTwo(stack);

        stack.GetCount().Should().Be(elements.Length);
        stack.PopValue().Should().Be(2); // Após swap: top=2, second=3
        stack.PopValue().Should().Be(3);
        stack.PopValue().Should().Be(1);
    }

    [TestMethod]
    [DataRow(new int[] { 4, 5 })]
    public void SwapTopTwo_TwoElements_SwapsCorrectly(int[] elements)
    {
        var stack = new StackExercises15(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        StackExercises15.SwapTopTwo(stack);

        stack.PopValue().Should().Be(4); // Após swap: top=4, second=5
        stack.PopValue().Should().Be(5);
    }

    // Exercise 16 - Write a C# program to get the nth element from the top of the stack.
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 2, 5)]
    [DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 3, 4)]
    [DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 4, 3)]
    [DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 6, 1)]
    public void GetNthFromTop_ValidPosition_ReturnsCorrectElement(int[] elements, int n, int expected)
    {
        var stack = new StackExercises16(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.GetNthFromTop(n).Should().Be(expected);
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, 4, -1)]
    [DataRow(new int[] { 1, 2, 3 }, 0, -1)]
    [DataRow(new int[] { 1, 2, 3 }, -1, -1)]
    public void GetNthFromTop_InvalidPosition_ReturnsMinusOne(int[] elements, int n, int expected)
    {
        var stack = new StackExercises16(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.GetNthFromTop(n).Should().Be(expected);
    }

    [TestMethod]
    public void GetNthFromTop_EmptyStack_ReturnsMinusOne()
    {
        var stack = new StackExercises16(5);
        stack.GetNthFromTop(1).Should().Be(-1);
    }

    [TestMethod]
    [DataRow(new int[] { 10, 20, 30 })]
    public void GetNthFromTop_StackStatePreserved_AfterGet(int[] elements)
    {
        var stack = new StackExercises16(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.GetNthFromTop(2);

        stack.PopValue().Should().Be(30);
        stack.PopValue().Should().Be(20);
        stack.PopValue().Should().Be(10);
    }

    [TestMethod]
    [DataRow(new int[] { 7 }, 1, 7)]
    public void GetNthFromTop_SingleElement_ReturnsElement(int[] elements, int n, int expected)
    {
        var stack = new StackExercises16(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.GetNthFromTop(n).Should().Be(expected);
    }

    // Exercise 17 - Write a C# program to merge two stacks into one.
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 3, 2, 1, 6, 5, 4 })]
    [DataRow(new int[] { 10, 20 }, new int[] { 30, 40 }, new int[] { 20, 10, 40, 30 })]
    [DataRow(new int[] { 7 }, new int[] { 8 }, new int[] { 7, 8 })]
    public void MergeStacks_TwoStacks_ReturnsMergedStack(int[] stack1Elements, int[] stack2Elements, int[] expected)
    {
        var stack1 = new StackExercises17(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises17(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var mergedStack = StackExercises17.MergeStacks(stack1, stack2);

        foreach (var expectedElement in expected)
        {
            mergedStack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { }, new int[] { 3, 2, 1 })]
    [DataRow(new int[] { }, new int[] { 4, 5, 6 }, new int[] { 6, 5, 4 })]
    public void MergeStacks_OneEmptyStack_ReturnsNonEmptyStack(int[] stack1Elements, int[] stack2Elements, int[] expected)
    {
        var stack1 = new StackExercises17(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises17(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var mergedStack = StackExercises17.MergeStacks(stack1, stack2);

        foreach (var expectedElement in expected)
        {
            mergedStack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    public void MergeStacks_BothEmptyStacks_ReturnsEmptyStack()
    {
        var stack1 = new StackExercises17(5);
        var stack2 = new StackExercises17(5);

        var mergedStack = StackExercises17.MergeStacks(stack1, stack2);

        mergedStack.IsEmpty().Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2 }, new int[] { 3, 4 })]
    public void MergeStacks_OriginalStacksBecomeEmpty(int[] stack1Elements, int[] stack2Elements)
    {
        var stack1 = new StackExercises17(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises17(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var mergedStack = StackExercises17.MergeStacks(stack1, stack2);

        stack1.IsEmpty().Should().BeTrue();
        stack2.IsEmpty().Should().BeTrue();
        mergedStack.GetCount().Should().Be(stack1Elements.Length + stack2Elements.Length);
    }

    // Exercise 18 - Write a C# program that implements a stack and checks if a stack is a subset of another stack.
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4, 5, 6 }, true)]
    [DataRow(new int[] { 3, 2, 1 }, new int[] { 6, 5, 4, 3, 2, 1 }, true)]
    [DataRow(new int[] { 7, 8, 9 }, new int[] { 1, 2, 3, 4, 5, 6 }, false)]
    public void IsSubset_ValidStacks_ReturnsCorrectResult(int[] subsetElements, int[] mainElements, bool expected)
    {
        var subsetStack = new StackExercises18(subsetElements.Length);
        foreach (var element in subsetElements)
        {
            subsetStack.PushValue(element);
        }

        var mainStack = new StackExercises18(mainElements.Length);
        foreach (var element in mainElements)
        {
            mainStack.PushValue(element);
        }

        StackExercises18.IsSubset(subsetStack, mainStack).Should().Be(expected);
    }

    [TestMethod]
    [DataRow(new int[] { }, new int[] { 1, 2, 3 }, true)]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { }, false)]
    public void IsSubset_EmptyStacks_ReturnsCorrectResult(int[] subsetElements, int[] mainElements, bool expected)
    {
        var subsetStack = new StackExercises18(subsetElements.Length);
        foreach (var element in subsetElements)
        {
            subsetStack.PushValue(element);
        }

        var mainStack = new StackExercises18(mainElements.Length);
        foreach (var element in mainElements)
        {
            mainStack.PushValue(element);
        }

        StackExercises18.IsSubset(subsetStack, mainStack).Should().Be(expected);
    }

    [TestMethod]
    [DataRow(new int[] { 1 }, new int[] { 1 }, true)]
    [DataRow(new int[] { 2 }, new int[] { 1 }, false)]
    public void IsSubset_SingleElementStacks_ReturnsCorrectResult(int[] subsetElements, int[] mainElements, bool expected)
    {
        var subsetStack = new StackExercises18(subsetElements.Length);
        foreach (var element in subsetElements)
        {
            subsetStack.PushValue(element);
        }

        var mainStack = new StackExercises18(mainElements.Length);
        foreach (var element in mainElements)
        {
            mainStack.PushValue(element);
        }

        StackExercises18.IsSubset(subsetStack, mainStack).Should().Be(expected);
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 })]
    public void IsSubset_StackStatePreserved_AfterCheck(int[] subsetElements)
    {
        var subsetStack = new StackExercises18(subsetElements.Length);
        foreach (var element in subsetElements)
        {
            subsetStack.PushValue(element);
        }

        var mainStack = new StackExercises18(6);
        mainStack.PushValue(1);
        mainStack.PushValue(2);
        mainStack.PushValue(3);
        mainStack.PushValue(4);
        mainStack.PushValue(5);
        mainStack.PushValue(6);

        StackExercises18.IsSubset(subsetStack, mainStack);

        // Verify subset stack state is preserved
        subsetStack.PopValue().Should().Be(3);
        subsetStack.PopValue().Should().Be(2);
        subsetStack.PopValue().Should().Be(1);
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 2 }, new int[] { 1, 2, 3, 4 }, true)]
    [DataRow(new int[] { 1, 2, 2 }, new int[] { 1, 3, 4 }, false)]
    public void IsSubset_DuplicateElements_ReturnsCorrectResult(int[] subsetElements, int[] mainElements, bool expected)
    {
        var subsetStack = new StackExercises18(subsetElements.Length);
        foreach (var element in subsetElements)
        {
            subsetStack.PushValue(element);
        }

        var mainStack = new StackExercises18(mainElements.Length);
        foreach (var element in mainElements)
        {
            mainStack.PushValue(element);
        }

        StackExercises18.IsSubset(subsetStack, mainStack).Should().Be(expected);
    }

    // Exercise 19 - Write a C# program that implements a stack and checks if two stacks are equal.
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, true)]
    [DataRow(new int[] { 4, 5, 6 }, new int[] { 4, 5, 6 }, true)]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 }, false)]
    [DataRow(new int[] { 7, 8 }, new int[] { 7, 8, 9 }, false)]
    public void AreStacksEqual_CompareStacks_ReturnsCorrectResult(int[] stack1Elements, int[] stack2Elements, bool expected)
    {
        var stack1 = new StackExercises19(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises19(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        StackExercises19.AreStacksEqual(stack1, stack2).Should().Be(expected);
    }

    [TestMethod]
    public void AreStacksEqual_BothEmptyStacks_ReturnsTrue()
    {
        var stack1 = new StackExercises19(5);
        var stack2 = new StackExercises19(5);

        StackExercises19.AreStacksEqual(stack1, stack2).Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 1 }, new int[] { 1 }, true)]
    [DataRow(new int[] { 1 }, new int[] { 2 }, false)]
    public void AreStacksEqual_SingleElementStacks_ReturnsCorrectResult(int[] stack1Elements, int[] stack2Elements, bool expected)
    {
        var stack1 = new StackExercises19(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises19(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        StackExercises19.AreStacksEqual(stack1, stack2).Should().Be(expected);
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 })]
    public void AreStacksEqual_StackStatePreserved_AfterCheck(int[] elements)
    {
        var stack1 = new StackExercises19(elements.Length);
        foreach (var element in elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises19(elements.Length);
        foreach (var element in elements)
        {
            stack2.PushValue(element);
        }

        StackExercises19.AreStacksEqual(stack1, stack2);

        // Verify both stacks state is preserved
        stack1.PopValue().Should().Be(3);
        stack1.PopValue().Should().Be(2);
        stack1.PopValue().Should().Be(1);

        stack2.PopValue().Should().Be(3);
        stack2.PopValue().Should().Be(2);
        stack2.PopValue().Should().Be(1);
    }

    [TestMethod]
    [DataRow(new int[] { 5, 5, 5 }, new int[] { 5, 5, 5 }, true)]
    [DataRow(new int[] { 1, 2, 1 }, new int[] { 1, 2, 2 }, false)]
    public void AreStacksEqual_DuplicateElements_ReturnsCorrectResult(int[] stack1Elements, int[] stack2Elements, bool expected)
    {
        var stack1 = new StackExercises19(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises19(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        StackExercises19.AreStacksEqual(stack1, stack2).Should().Be(expected);
    }

    // Exercise 20 - Write a C# program that implements a stack and finds common elements between two stacks.
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { 2, 3, 4, 5 }, new int[] { 3, 2 })]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { 3, 4, 5 }, new int[] { 3 })]
    [DataRow(new int[] { 2, 3, 4 }, new int[] { 3, 4, 5 }, new int[] { 4, 3 })]
    public void FindCommonElements_TwoStacks_ReturnsCommonElements(int[] stack1Elements, int[] stack2Elements, int[] expected)
    {
        var stack1 = new StackExercises20(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises20(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var commonStack = StackExercises20.FindCommonElements(stack1, stack2);

        foreach (var expectedElement in expected)
        {
            commonStack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { })]
    [DataRow(new int[] { 7, 8, 9 }, new int[] { 1, 2, 3 }, new int[] { })]
    public void FindCommonElements_NoCommonElements_ReturnsEmptyStack(int[] stack1Elements, int[] stack2Elements, int[] expected)
    {
        var stack1 = new StackExercises20(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises20(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var commonStack = StackExercises20.FindCommonElements(stack1, stack2);

        commonStack.IsEmpty().Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { }, new int[] { 1, 2, 3 }, new int[] { })]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { }, new int[] { })]
    public void FindCommonElements_EmptyStack_ReturnsEmptyStack(int[] stack1Elements, int[] stack2Elements, int[] expected)
    {
        var stack1 = new StackExercises20(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises20(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var commonStack = StackExercises20.FindCommonElements(stack1, stack2);

        commonStack.IsEmpty().Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 2, 3 }, new int[] { 2, 3, 3, 4 }, new int[] { 3, 2 })]
    [DataRow(new int[] { 5, 5, 5 }, new int[] { 5, 6, 7 }, new int[] { 5 })]
    public void FindCommonElements_DuplicateElements_ReturnsUniqueCommonElements(int[] stack1Elements, int[] stack2Elements, int[] expected)
    {
        var stack1 = new StackExercises20(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises20(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var commonStack = StackExercises20.FindCommonElements(stack1, stack2);

        foreach (var expectedElement in expected)
        {
            commonStack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 })]
    public void FindCommonElements_OriginalStacksPreserved(int[] elements)
    {
        var stack1 = new StackExercises20(elements.Length);
        foreach (var element in elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises20(elements.Length);
        foreach (var element in elements)
        {
            stack2.PushValue(element);
        }

        var commonStack = StackExercises20.FindCommonElements(stack1, stack2);

        // Verify original stacks are preserved
        stack1.PopValue().Should().Be(3);
        stack1.PopValue().Should().Be(2);
        stack1.PopValue().Should().Be(1);

        stack2.PopValue().Should().Be(3);
        stack2.PopValue().Should().Be(2);
        stack2.PopValue().Should().Be(1);
    }

    // Exercise 21 - Write a C# program that implements a stack and find elements that are in the first stack but not in the second stack.
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { 2, 3, 4, 5 }, new int[] { 1 })]
    [DataRow(new int[] { 2, 3, 4 }, new int[] { 3, 4, 5 }, new int[] { 2 })]
    [DataRow(new int[] { 3, 4, 5 }, new int[] { 1, 2, 3 }, new int[] { 5, 4 })]
    public void ElementsInFirstButNotInSecond_TwoStacks_ReturnsDifference(int[] stack1Elements, int[] stack2Elements, int[] expected)
    {
        var stack1 = new StackExercises21(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises21(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var resultStack = StackExercises21.ElementsInFirstButNotInSecond(stack1, stack2);

        foreach (var expectedElement in expected)
        {
            resultStack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, new int[] { })]
    [DataRow(new int[] { 4, 5, 6 }, new int[] { 4, 5, 6 }, new int[] { })]
    public void ElementsInFirstButNotInSecond_IdenticalStacks_ReturnsEmpty(int[] stack1Elements, int[] stack2Elements, int[] expected)
    {
        var stack1 = new StackExercises21(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises21(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var resultStack = StackExercises21.ElementsInFirstButNotInSecond(stack1, stack2);

        resultStack.IsEmpty().Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { }, new int[] { 3, 2, 1 })]
    [DataRow(new int[] { }, new int[] { 1, 2, 3 }, new int[] { })]
    public void ElementsInFirstButNotInSecond_EmptyStack_ReturnsCorrectResult(int[] stack1Elements, int[] stack2Elements, int[] expected)
    {
        var stack1 = new StackExercises21(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises21(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var resultStack = StackExercises21.ElementsInFirstButNotInSecond(stack1, stack2);

        foreach (var expectedElement in expected)
        {
            resultStack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 2, 3 }, new int[] { 2, 4, 5 }, new int[] { 3, 1 })]
    [DataRow(new int[] { 5, 5, 6 }, new int[] { 5, 7, 8 }, new int[] { 6 })]
    public void ElementsInFirstButNotInSecond_DuplicateElements_ReturnsUniqueDifference(int[] stack1Elements, int[] stack2Elements, int[] expected)
    {
        var stack1 = new StackExercises21(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises21(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var resultStack = StackExercises21.ElementsInFirstButNotInSecond(stack1, stack2);

        foreach (var expectedElement in expected)
        {
            resultStack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 })]
    public void ElementsInFirstButNotInSecond_OriginalStacksPreserved(int[] elements)
    {
        var stack1 = new StackExercises21(elements.Length);
        foreach (var element in elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises21(elements.Length);
        foreach (var element in elements)
        {
            stack2.PushValue(element);
        }

        var resultStack = StackExercises21.ElementsInFirstButNotInSecond(stack1, stack2);

        // Verify original stacks are preserved
        stack1.PopValue().Should().Be(3);
        stack1.PopValue().Should().Be(2);
        stack1.PopValue().Should().Be(1);

        stack2.PopValue().Should().Be(3);
        stack2.PopValue().Should().Be(2);
        stack2.PopValue().Should().Be(1);
    }

    // Exercise 22 - Write a C# program that implements a stack and creates a new stack that contains all elements from both stacks without duplicates.
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
    [DataRow(new int[] { 2, 3, 4 }, new int[] { 3, 4, 5 }, new int[] { 5, 4, 3, 2 })]
    [DataRow(new int[] { 3, 4, 5 }, new int[] { 1, 2, 3 }, new int[] { 2, 1, 5, 4, 3 })]
    public void MergeStacksWithoutDuplicates_TwoStacks_ReturnsMergedWithoutDuplicates(int[] stack1Elements, int[] stack2Elements, int[] expected)
    {
        var stack1 = new StackExercises22(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises22(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var resultStack = StackExercises22.MergeStacksWithoutDuplicates(stack1, stack2);

        foreach (var expectedElement in expected)
        {
            resultStack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
    [DataRow(new int[] { 4, 5, 6 }, new int[] { 4, 5, 6 }, new int[] { 6, 5, 4 })]
    public void MergeStacksWithoutDuplicates_IdenticalStacks_ReturnsUniqueElements(int[] stack1Elements, int[] stack2Elements, int[] expected)
    {
        var stack1 = new StackExercises22(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises22(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var resultStack = StackExercises22.MergeStacksWithoutDuplicates(stack1, stack2);

        foreach (var expectedElement in expected)
        {
            resultStack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { }, new int[] { 3, 2, 1 })]
    [DataRow(new int[] { }, new int[] { 4, 5, 6 }, new int[] { 6, 5, 4 })]
    public void MergeStacksWithoutDuplicates_EmptyStack_ReturnsNonEmptyStack(int[] stack1Elements, int[] stack2Elements, int[] expected)
    {
        var stack1 = new StackExercises22(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises22(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var resultStack = StackExercises22.MergeStacksWithoutDuplicates(stack1, stack2);

        foreach (var expectedElement in expected)
        {
            resultStack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    public void MergeStacksWithoutDuplicates_BothEmptyStacks_ReturnsEmptyStack()
    {
        var stack1 = new StackExercises22(5);
        var stack2 = new StackExercises22(5);

        var resultStack = StackExercises22.MergeStacksWithoutDuplicates(stack1, stack2);

        resultStack.IsEmpty().Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 2, 3 }, new int[] { 2, 3, 3, 4 }, new int[] { 4, 3, 2, 1 })]
    [DataRow(new int[] { 5, 5, 6 }, new int[] { 5, 6, 7 }, new int[] { 7, 6, 5 })]
    public void MergeStacksWithoutDuplicates_DuplicateElements_ReturnsUniqueElements(int[] stack1Elements, int[] stack2Elements, int[] expected)
    {
        var stack1 = new StackExercises22(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises22(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var resultStack = StackExercises22.MergeStacksWithoutDuplicates(stack1, stack2);

        foreach (var expectedElement in expected)
        {
            resultStack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 })]
    public void MergeStacksWithoutDuplicates_OriginalStacksPreserved(int[] elements)
    {
        var stack1 = new StackExercises22(elements.Length);
        foreach (var element in elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises22(elements.Length);
        foreach (var element in elements)
        {
            stack2.PushValue(element);
        }

        var resultStack = StackExercises22.MergeStacksWithoutDuplicates(stack1, stack2);

        // Verify original stacks are preserved
        stack1.PopValue().Should().Be(3);
        stack1.PopValue().Should().Be(2);
        stack1.PopValue().Should().Be(1);

        stack2.PopValue().Should().Be(3);
        stack2.PopValue().Should().Be(2);
        stack2.PopValue().Should().Be(1);
    }

    /* Exercise 23 - Write a C# program that implements a stack and creates a new stack that contains only
    elements that are in either the first or the second stack, but not in both.*/
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { 2, 3, 4, 5 }, new int[] { 5, 4, 1 })]
    [DataRow(new int[] { 2, 3, 4 }, new int[] { 3, 4, 5 }, new int[] { 5, 2 })]
    [DataRow(new int[] { 3, 4, 5 }, new int[] { 1, 2, 3 }, new int[] { 2, 1, 5, 4 })]
    public void GetSymmetricDifference_TwoStacks_ReturnsSymmetricDifference(int[] stack1Elements, int[] stack2Elements, int[] expected)
    {
        var stack1 = new StackExercises23(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises23(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var resultStack = StackExercises23.GetSymmetricDifference(stack1, stack2);

        foreach (var expectedElement in expected)
        {
            resultStack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, new int[] { })]
    [DataRow(new int[] { 4, 5, 6 }, new int[] { 4, 5, 6 }, new int[] { })]
    public void GetSymmetricDifference_IdenticalStacks_ReturnsEmpty(int[] stack1Elements, int[] stack2Elements, int[] expected)
    {
        var stack1 = new StackExercises23(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises23(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var resultStack = StackExercises23.GetSymmetricDifference(stack1, stack2);

        resultStack.IsEmpty().Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { }, new int[] { 3, 2, 1 })]
    [DataRow(new int[] { }, new int[] { 4, 5, 6 }, new int[] { 6, 5, 4 })]
    public void GetSymmetricDifference_EmptyStack_ReturnsNonEmptyStack(int[] stack1Elements, int[] stack2Elements, int[] expected)
    {
        var stack1 = new StackExercises23(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises23(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var resultStack = StackExercises23.GetSymmetricDifference(stack1, stack2);

        foreach (var expectedElement in expected)
        {
            resultStack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    public void GetSymmetricDifference_BothEmptyStacks_ReturnsEmptyStack()
    {
        var stack1 = new StackExercises23(5);
        var stack2 = new StackExercises23(5);

        var resultStack = StackExercises23.GetSymmetricDifference(stack1, stack2);

        resultStack.IsEmpty().Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 2, 3 }, new int[] { 2, 3, 3, 4 }, new int[] { 4, 1 })]
    [DataRow(new int[] { 5, 5, 6 }, new int[] { 5, 6, 7 }, new int[] { 7 })]
    public void GetSymmetricDifference_DuplicateElements_ReturnsUniqueDifference(int[] stack1Elements, int[] stack2Elements, int[] expected)
    {
        var stack1 = new StackExercises23(stack1Elements.Length);
        foreach (var element in stack1Elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises23(stack2Elements.Length);
        foreach (var element in stack2Elements)
        {
            stack2.PushValue(element);
        }

        var resultStack = StackExercises23.GetSymmetricDifference(stack1, stack2);

        foreach (var expectedElement in expected)
        {
            resultStack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 })]
    public void GetSymmetricDifference_OriginalStacksPreserved(int[] elements)
    {
        var stack1 = new StackExercises23(elements.Length);
        foreach (var element in elements)
        {
            stack1.PushValue(element);
        }

        var stack2 = new StackExercises23(elements.Length);
        foreach (var element in elements)
        {
            stack2.PushValue(element);
        }

        var resultStack = StackExercises23.GetSymmetricDifference(stack1, stack2);

        // Verify original stacks are preserved
        stack1.PopValue().Should().Be(3);
        stack1.PopValue().Should().Be(2);
        stack1.PopValue().Should().Be(1);

        stack2.PopValue().Should().Be(3);
        stack2.PopValue().Should().Be(2);
        stack2.PopValue().Should().Be(1);
    }

    // Exercise 24 - Write a C# program that implements a stack and creates a new stack from a portion of the original stack.
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 0, 4, new int[] { 5, 4, 3, 2, 1 })]
    [DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 2, 4, new int[] { 5, 4, 3 })]
    [DataRow(new int[] { 10, 20, 30, 40 }, 1, 2, new int[] { 30, 20 })]
    public void CreateSubstack_ValidRange_ReturnsSubstack(int[] elements, int start, int end, int[] expected)
    {
        var originalStack = new StackExercises24(elements.Length);
        foreach (var element in elements)
        {
            originalStack.PushValue(element);
        }

        var substack = StackExercises24.CreateSubstack(originalStack, start, end);

        foreach (var expectedElement in expected)
        {
            substack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, 0, 0, new int[] { 1 })]
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, 4, 4, new int[] { 5 })]
    public void CreateSubstack_SingleElementRange_ReturnsSingleElement(int[] elements, int start, int end, int[] expected)
    {
        var originalStack = new StackExercises24(elements.Length);
        foreach (var element in elements)
        {
            originalStack.PushValue(element);
        }

        var substack = StackExercises24.CreateSubstack(originalStack, start, end);

        foreach (var expectedElement in expected)
        {
            substack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, -1, 2)]
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, 2, 5)]
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, 3, 2)]
    public void CreateSubstack_InvalidRange_ReturnsEmptyStack(int[] elements, int start, int end)
    {
        var originalStack = new StackExercises24(elements.Length);
        foreach (var element in elements)
        {
            originalStack.PushValue(element);
        }

        var substack = StackExercises24.CreateSubstack(originalStack, start, end);

        substack.IsEmpty().Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5 })]
    public void CreateSubstack_OriginalStackPreserved(int[] elements)
    {
        var originalStack = new StackExercises24(elements.Length);
        foreach (var element in elements)
        {
            originalStack.PushValue(element);
        }

        var substack = StackExercises24.CreateSubstack(originalStack, 1, 3);

        // Verify original stack is preserved
        originalStack.PopValue().Should().Be(5);
        originalStack.PopValue().Should().Be(4);
        originalStack.PopValue().Should().Be(3);
        originalStack.PopValue().Should().Be(2);
        originalStack.PopValue().Should().Be(1);
    }

    [TestMethod]
    public void CreateSubstack_EmptyStack_ReturnsEmptyStack()
    {
        var originalStack = new StackExercises24(5);

        var substack = StackExercises24.CreateSubstack(originalStack, 0, 2);

        substack.IsEmpty().Should().BeTrue();
    }

    // Exercise 25 - Write a C# program that implements a stack and checks if all elements of the stack satisfy a condition.
    [TestMethod]
    [DataRow(new int[] { 4, 4, 6 }, true)]
    [DataRow(new int[] { 1, 2, 3 }, false)]
    [DataRow(new int[] { 2, 4, 6 }, true)]
    public void AllElementsSatisfy_EvenNumbers_ReturnsCorrectResult(int[] elements, bool expected)
    {
        var stack = new StackExercises25(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.AllElementsSatisfy(x => x % 2 == 0).Should().Be(expected);
    }

    [TestMethod]
    [DataRow(new int[] { 1, 3, 5 }, true)]
    [DataRow(new int[] { 1, 2, 3 }, false)]
    [DataRow(new int[] { 7, 9, 11 }, true)]
    public void AllElementsSatisfy_OddNumbers_ReturnsCorrectResult(int[] elements, bool expected)
    {
        var stack = new StackExercises25(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.AllElementsSatisfy(x => x % 2 != 0).Should().Be(expected);
    }

    [TestMethod]
    [DataRow(new int[] { 10, 20, 30 }, true)]
    [DataRow(new int[] { 10, 3, 30 }, false)] // Corrigido: 3 não é maior que 5
    public void AllElementsSatisfy_GreaterThanFive_ReturnsCorrectResult(int[] elements, bool expected)
    {
        var stack = new StackExercises25(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.AllElementsSatisfy(x => x > 5).Should().Be(expected);
    }

    [TestMethod]
    public void AllElementsSatisfy_EmptyStack_ReturnsTrue()
    {
        var stack = new StackExercises25(5);

        stack.AllElementsSatisfy(x => x % 2 == 0).Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 2 }, true)]
    [DataRow(new int[] { 1 }, false)]
    public void AllElementsSatisfy_SingleElement_ReturnsCorrectResult(int[] elements, bool expected)
    {
        var stack = new StackExercises25(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.AllElementsSatisfy(x => x % 2 == 0).Should().Be(expected);
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5 })]
    public void AllElementsSatisfy_StackStatePreserved(int[] elements)
    {
        var stack = new StackExercises25(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.AllElementsSatisfy(x => x > 0);

        // Verify stack state is preserved
        stack.PopValue().Should().Be(5);
        stack.PopValue().Should().Be(4);
        stack.PopValue().Should().Be(3);
        stack.PopValue().Should().Be(2);
        stack.PopValue().Should().Be(1);
    }

    [TestMethod]
    [DataRow(new int[] { -1, -2, -3 }, true)]
    [DataRow(new int[] { -1, 2, -3 }, false)]
    public void AllElementsSatisfy_NegativeNumbers_ReturnsCorrectResult(int[] elements, bool expected)
    {
        var stack = new StackExercises25(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.AllElementsSatisfy(x => x < 0).Should().Be(expected);
    }

    [TestMethod]
    [DataRow(new int[] { 0, 0, 0 }, true)]
    [DataRow(new int[] { 0, 1, 0 }, false)]
    public void AllElementsSatisfy_ZeroValues_ReturnsCorrectResult(int[] elements, bool expected)
    {
        var stack = new StackExercises25(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.AllElementsSatisfy(x => x == 0).Should().Be(expected);
    }

    // Exercise 26 - Write a C# program that implements a stack and checks if at least one element of the stack satisfies a condition.
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, true)]
    [DataRow(new int[] { 1, 3, 5, 7 }, false)]
    [DataRow(new int[] { 2, 4, 6 }, true)]
    public void AnyElementSatisfies_EvenNumbers_ReturnsCorrectResult(int[] elements, bool expected)
    {
        var stack = new StackExercises26(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.AnyElementSatisfies(x => x % 2 == 0).Should().Be(expected);
    }

    [TestMethod]
    [DataRow(new int[] { 1, 3, 5 }, true)]
    [DataRow(new int[] { 2, 4, 6 }, false)]
    [DataRow(new int[] { 2, 3, 4 }, true)]
    public void AnyElementSatisfies_OddNumbers_ReturnsCorrectResult(int[] elements, bool expected)
    {
        var stack = new StackExercises26(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.AnyElementSatisfies(x => x % 2 != 0).Should().Be(expected);
    }

    [TestMethod]
    [DataRow(new int[] { 10, 20, 30 }, true)]
    [DataRow(new int[] { 1, 2, 3 }, false)]
    [DataRow(new int[] { 5, 10, 15 }, true)]
    public void AnyElementSatisfies_GreaterThanFive_ReturnsCorrectResult(int[] elements, bool expected)
    {
        var stack = new StackExercises26(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.AnyElementSatisfies(x => x > 5).Should().Be(expected);
    }

    [TestMethod]
    public void AnyElementSatisfies_EmptyStack_ReturnsFalse()
    {
        var stack = new StackExercises26(5);

        stack.AnyElementSatisfies(x => x % 2 == 0).Should().BeFalse();
    }

    [TestMethod]
    [DataRow(new int[] { 2 }, true)]
    [DataRow(new int[] { 1 }, false)]
    public void AnyElementSatisfies_SingleElement_ReturnsCorrectResult(int[] elements, bool expected)
    {
        var stack = new StackExercises26(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.AnyElementSatisfies(x => x % 2 == 0).Should().Be(expected);
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5 })]
    public void AnyElementSatisfies_StackStatePreserved(int[] elements)
    {
        var stack = new StackExercises26(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.AnyElementSatisfies(x => x > 3);

        // Verify stack state is preserved
        stack.PopValue().Should().Be(5);
        stack.PopValue().Should().Be(4);
        stack.PopValue().Should().Be(3);
        stack.PopValue().Should().Be(2);
        stack.PopValue().Should().Be(1);
    }

    [TestMethod]
    [DataRow(new int[] { -1, -2, -3 }, true)]
    [DataRow(new int[] { 1, 2, 3 }, false)]
    public void AnyElementSatisfies_NegativeNumbers_ReturnsCorrectResult(int[] elements, bool expected)
    {
        var stack = new StackExercises26(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.AnyElementSatisfies(x => x < 0).Should().Be(expected);
    }

    [TestMethod]
    [DataRow(new int[] { 0, 1, 2 }, true)]
    [DataRow(new int[] { 1, 2, 3 }, false)]
    public void AnyElementSatisfies_ZeroValues_ReturnsCorrectResult(int[] elements, bool expected)
    {
        var stack = new StackExercises26(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        stack.AnyElementSatisfies(x => x == 0).Should().Be(expected);
    }

    // Exercise 27 - Write a C# program that implements a stack and create a new stack by removing elements that do not satisfy a condition.
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { 2 })]
    [DataRow(new int[] { 2, 3, 4, 5 }, new int[] { 4, 2 })]
    [DataRow(new int[] { 3, 4, 5 }, new int[] { 4 })]
    public void FilterStack_EvenNumbers_ReturnsFilteredStack(int[] elements, int[] expected)
    {
        var stack = new StackExercises27(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        var filteredStack = StackExercises27.FilterStack(stack, x => x % 2 == 0);

        foreach (var expectedElement in expected)
        {
            filteredStack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { 3, 1 })]
    [DataRow(new int[] { 2, 3, 4, 5 }, new int[] { 5, 3 })]
    [DataRow(new int[] { 2, 4, 6 }, new int[] { })]
    public void FilterStack_OddNumbers_ReturnsFilteredStack(int[] elements, int[] expected)
    {
        var stack = new StackExercises27(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        var filteredStack = StackExercises27.FilterStack(stack, x => x % 2 != 0);

        foreach (var expectedElement in expected)
        {
            filteredStack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3 })]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { 3 })]
    [DataRow(new int[] { 1, 2 }, new int[] { })]
    public void FilterStack_GreaterThanTwo_ReturnsFilteredStack(int[] elements, int[] expected)
    {
        var stack = new StackExercises27(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        var filteredStack = StackExercises27.FilterStack(stack, x => x > 2);

        foreach (var expectedElement in expected)
        {
            filteredStack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    public void FilterStack_EmptyStack_ReturnsEmptyStack()
    {
        var stack = new StackExercises27(5);

        var filteredStack = StackExercises27.FilterStack(stack, x => x % 2 == 0);

        filteredStack.IsEmpty().Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 2 }, new int[] { 2 })]
    [DataRow(new int[] { 1 }, new int[] { })]
    public void FilterStack_SingleElement_ReturnsFilteredStack(int[] elements, int[] expected)
    {
        var stack = new StackExercises27(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        var filteredStack = StackExercises27.FilterStack(stack, x => x % 2 == 0);

        foreach (var expectedElement in expected)
        {
            filteredStack.PopValue().Should().Be(expectedElement);
        }
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5 })]
    public void FilterStack_OriginalStackPreserved(int[] elements)
    {
        var stack = new StackExercises27(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        var filteredStack = StackExercises27.FilterStack(stack, x => x % 2 == 0);

        // Verify original stack is preserved
        stack.PopValue().Should().Be(5);
        stack.PopValue().Should().Be(4);
        stack.PopValue().Should().Be(3);
        stack.PopValue().Should().Be(2);
        stack.PopValue().Should().Be(1);
    }

    [TestMethod]
    [DataRow(new int[] { -1, -2, 0, 1, 2 }, new int[] { 2, 0, -2 })]
    [DataRow(new int[] { -3, -1, 1, 3 }, new int[] { })]
    public void FilterStack_EvenNumbersWithNegatives_ReturnsFilteredStack(int[] elements, int[] expected)
    {
        var stack = new StackExercises27(elements.Length);
        foreach (var element in elements)
        {
            stack.PushValue(element);
        }

        var filteredStack = StackExercises27.FilterStack(stack, x => x % 2 == 0);

        foreach (var expectedElement in expected)
        {
            filteredStack.PopValue().Should().Be(expectedElement);
        }
    }
}
