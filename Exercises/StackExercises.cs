
namespace Exercises
{
    public class StackExercises
    {
        /* Exercise 1 - Write a C# program to implement a stack with push and pop operations. 
        Find the top element of the stack and check if the stack is empty or not.*/
        public class StackExercises1
        {
            private int[] stackElements;
            private int topPosition;

            public StackExercises1(int capacity)
            {
                stackElements = new int[capacity];
                topPosition = -1;
            }

            public bool IsStackEmpty()
            {
                return topPosition == -1;
            }

            public void PushElement(int value)
            {
                stackElements[++topPosition] = value;
            }

            public int PopElement()
            {
                return stackElements[topPosition--];
            }

            public int PeekTopElement()
            {
                return stackElements[topPosition];
            }
        }

        // Exercise 2 - Write a C# program to sort the elements of a given stack in descending order.
        public class StackExercises2
        {
            private int[] stackItems;
            private int topPointer;

            public StackExercises2(int capacity)
            {
                stackItems = new int[capacity];
                topPointer = -1;
            }

            public bool CheckEmptyStack()
            {
                return topPointer == -1;
            }

            public void InsertItem(int value)
            {
                stackItems[++topPointer] = value;
            }

            public int RemoveItem()
            {
                return stackItems[topPointer--];
            }

            public int ViewTopItem()
            {
                return stackItems[topPointer];
            }

            public static void ArrangeDescending(StackExercises2 stack)
            {
                var temporaryStack = new StackExercises2(stack.stackItems.Length);

                while (!stack.CheckEmptyStack())
                {
                    var currentElement = stack.RemoveItem();

                    while (!temporaryStack.CheckEmptyStack() && temporaryStack.ViewTopItem() < currentElement)
                    {
                        stack.InsertItem(temporaryStack.RemoveItem());
                    }

                    temporaryStack.InsertItem(currentElement);
                }

                while (!temporaryStack.CheckEmptyStack())
                {
                    stack.InsertItem(temporaryStack.RemoveItem());
                }
            }
        }

        // Exercise 3 - Write a C# program to sort the elements of a given stack in ascending order.
        public class StackExercises3
        {
            private int[] stackCollection;
            private int currentTop;

            public StackExercises3(int capacity)
            {
                stackCollection = new int[capacity];
                currentTop = -1;
            }

            public bool VerifyEmpty()
            {
                return currentTop == -1;
            }

            public void AddToStack(int value)
            {
                stackCollection[++currentTop] = value;
            }

            public int TakeFromStack()
            {
                return stackCollection[currentTop--];
            }

            public int InspectTop()
            {
                return stackCollection[currentTop];
            }

            public static void OrderAscending(StackExercises3 stack)
            {
                var auxiliaryStack = new StackExercises3(stack.stackCollection.Length);

                while (!stack.VerifyEmpty())
                {
                    var currentValue = stack.TakeFromStack();

                    while (!auxiliaryStack.VerifyEmpty() && auxiliaryStack.InspectTop() > currentValue)
                    {
                        stack.AddToStack(auxiliaryStack.TakeFromStack());
                    }

                    auxiliaryStack.AddToStack(currentValue);
                }

                while (!auxiliaryStack.VerifyEmpty())
                {
                    stack.AddToStack(auxiliaryStack.TakeFromStack());
                }
            }
        }

        // Exercise 4 - Write a C# program to reverse the elements of a given stack.
        public class StackExercises4
        {
            private int[] stackData;
            private int topIndex;

            public StackExercises4(int capacity)
            {
                stackData = new int[capacity];
                topIndex = -1;
            }

            public bool CheckIfEmpty()
            {
                return topIndex == -1;
            }

            public void PushValue(int value)
            {
                stackData[++topIndex] = value;
            }

            public int PopValue()
            {
                return stackData[topIndex--];
            }

            public int PeekValue()
            {
                return stackData[topIndex];
            }

            public static StackExercises4 ReverseStack(StackExercises4 originalStack)
            {
                var tempStack = new StackExercises4(originalStack.stackData.Length);
                var reversedStack = new StackExercises4(originalStack.stackData.Length);

                // Primeiro, copiamos os elementos para uma stack temporária
                while (!originalStack.CheckIfEmpty())
                {
                    tempStack.PushValue(originalStack.PopValue());
                }

                // Depois, copiamos de volta para a stack original e para a reversed
                while (!tempStack.CheckIfEmpty())
                {
                    var value = tempStack.PopValue();
                    originalStack.PushValue(value);
                    reversedStack.PushValue(value);
                }

                return reversedStack;
            }
        }


        // Exercise 5 - Write a C# program to find the maximum element in a stack.
        public class StackExercises5
        {
            private int[] stackElements;
            private int topPosition;

            public StackExercises5(int capacity)
            {
                stackElements = new int[capacity];
                topPosition = -1;
            }

            public bool IsStackEmpty()
            {
                return topPosition == -1;
            }

            public void PushElement(int value)
            {
                stackElements[++topPosition] = value;
            }

            public int PopElement()
            {
                return stackElements[topPosition--];
            }

            public int PeekTopElement()
            {
                return stackElements[topPosition];
            }

            public int FindMaximumValue()
            {
                if (IsStackEmpty())
                {
                    return -1;
                }

                int maxValue = stackElements[0];

                for (int i = 1; i <= topPosition; i++)
                {
                    if (stackElements[i] > maxValue)
                    {
                        maxValue = stackElements[i];
                    }
                }

                return maxValue;
            }
        }

        // Exercise 6 - Write a C# program to find the minimum element in a stack.
        public class StackExercises6
        {
            private int[] stackItems;
            private int topPointer;

            public StackExercises6(int capacity)
            {
                stackItems = new int[capacity];
                topPointer = -1;
            }

            public bool CheckEmpty()
            {
                return topPointer == -1;
            }

            public void PushItem(int value)
            {
                stackItems[++topPointer] = value;
            }

            public int PopItem()
            {
                return stackItems[topPointer--];
            }

            public int PeekItem()
            {
                return stackItems[topPointer];
            }

            public int FindMinimumValue()
            {
                if (CheckEmpty())
                {
                    return -1;
                }

                int minValue = stackItems[0];

                for (int i = 1; i <= topPointer; i++)
                {
                    if (stackItems[i] < minValue)
                    {
                        minValue = stackItems[i];
                    }
                }

                return minValue;
            }
        }

        // Exercise 7 - Write a C# program to remove all the elements from a given stack.
        public class StackExercises7
        {
            private int[] stackData;
            private int topIndex;

            public StackExercises7(int capacity)
            {
                stackData = new int[capacity];
                topIndex = -1;
            }

            public bool IsEmpty()
            {
                return topIndex == -1;
            }

            public void PushElement(int value)
            {
                stackData[++topIndex] = value;
            }

            public int PopElement()
            {
                return stackData[topIndex--];
            }

            public int PeekElement()
            {
                return stackData[topIndex];
            }

            public void ClearAllElements()
            {
                topIndex = -1;
            }
        }

        // Exercise 8 - Write a C# program to remove specified element from a given stack.
        public class StackExercises8
        {
            private int[] stackArray;
            private int topMarker;

            public StackExercises8(int capacity)
            {
                stackArray = new int[capacity];
                topMarker = -1;
            }

            public bool CheckIfEmpty()
            {
                return topMarker == -1;
            }

            public void AddElement(int value)
            {
                stackArray[++topMarker] = value;
            }

            public int RemoveElement()
            {
                return stackArray[topMarker--];
            }

            public int ViewTopElement()
            {
                return stackArray[topMarker];
            }

            public static void RemoveSpecificElement(StackExercises8 stack, int targetValue)
            {
                var tempStack = new StackExercises8(stack.stackArray.Length);

                while (!stack.CheckIfEmpty())
                {
                    var currentElement = stack.RemoveElement();
                    if (currentElement != targetValue)
                    {
                        tempStack.AddElement(currentElement);
                    }
                }

                while (!tempStack.CheckIfEmpty())
                {
                    stack.AddElement(tempStack.RemoveElement());
                }
            }
        }

        // Exercise 9 - Write a C# program to count all the elements in a given stack.
        public class StackExercises9
        {
            private int[] stackItems;
            private int topPosition;

            public StackExercises9(int capacity)
            {
                stackItems = new int[capacity];
                topPosition = -1;
            }

            public bool IsStackEmpty()
            {
                return topPosition == -1;
            }

            public void PushItem(int value)
            {
                stackItems[++topPosition] = value;
            }

            public int PopItem()
            {
                return stackItems[topPosition--];
            }

            public int PeekItem()
            {
                return stackItems[topPosition];
            }

            public int GetElementCount()
            {
                return topPosition + 1;
            }
        }

        // Exercise 10 - Write a C# program to count specified element in a given stack.
        public class StackExercises10
        {
            private int[] stackElements;
            private int topIndex;

            public StackExercises10(int capacity)
            {
                stackElements = new int[capacity];
                topIndex = -1;
            }

            public bool CheckEmpty()
            {
                return topIndex == -1;
            }

            public void PushValue(int value)
            {
                stackElements[++topIndex] = value;
            }

            public int PopValue()
            {
                return stackElements[topIndex--];
            }

            public int PeekValue()
            {
                return stackElements[topIndex];
            }

            public int CountOccurrences(int targetValue)
            {
                int count = 0;
                var tempStack = new StackExercises10(stackElements.Length);

                while (!CheckEmpty())
                {
                    var current = PopValue();
                    if (current == targetValue)
                    {
                        count++;
                    }
                    tempStack.PushValue(current);
                }

                while (!tempStack.CheckEmpty())
                {
                    PushValue(tempStack.PopValue());
                }

                return count;
            }
        }

        // Exercise 11 - Write a C# program to implement a stack that checks if a given element is present or not in the stack.
        public class StackExercises11
        {
            private int[] stackData;
            private int topPointer;

            public StackExercises11(int capacity)
            {
                stackData = new int[capacity];
                topPointer = -1;
            }

            public bool IsEmptyStack()
            {
                return topPointer == -1;
            }

            public void PushElement(int value)
            {
                stackData[++topPointer] = value;
            }

            public int PopElement()
            {
                return stackData[topPointer--];
            }

            public int PeekElement()
            {
                return stackData[topPointer];
            }

            public bool ContainsValue(int targetValue)
            {
                var tempStack = new StackExercises11(stackData.Length);
                bool found = false;

                while (!IsEmptyStack())
                {
                    var current = PopElement();
                    if (current == targetValue)
                    {
                        found = true;
                    }
                    tempStack.PushElement(current);
                }

                while (!tempStack.IsEmptyStack())
                {
                    PushElement(tempStack.PopElement());
                }

                return found;
            }
        }

        // Exercise 12 - Write a C# program to remove duplicates from a given stack.
        public class StackExercises12
        {
            private int[] stackArray;
            private int topMarker;

            public StackExercises12(int capacity)
            {
                stackArray = new int[capacity];
                topMarker = -1;
            }

            public bool IsEmpty()
            {
                return topMarker == -1;
            }

            public void PushElement(int value)
            {
                stackArray[++topMarker] = value;
            }

            public int PopElement()
            {
                return stackArray[topMarker--];
            }

            public int PeekElement()
            {
                return stackArray[topMarker];
            }

            public static void RemoveDuplicates(StackExercises12 stack)
            {
                var uniqueSet = new HashSet<int>();
                var tempStack = new StackExercises12(stack.stackArray.Length);

                while (!stack.IsEmpty())
                {
                    var current = stack.PopElement();
                    if (uniqueSet.Add(current))
                    {
                        tempStack.PushElement(current);
                    }
                }

                while (!tempStack.IsEmpty())
                {
                    stack.PushElement(tempStack.PopElement());
                }
            }
        }

        // Exercise 13 - Write a C# program to find the top and bottom elements of a given stack.
        public class StackExercises13
        {
            private int[] stackItems;
            private int topPosition;

            public StackExercises13(int capacity)
            {
                stackItems = new int[capacity];
                topPosition = -1;
            }

            public bool IsEmpty()
            {
                return topPosition == -1;
            }

            public void PushValue(int value)
            {
                stackItems[++topPosition] = value;
            }

            public int PopValue()
            {
                return stackItems[topPosition--];
            }

            public int PeekTop()
            {
                return stackItems[topPosition];
            }

            public int GetTopElement()
            {
                return IsEmpty() ? -1 : PeekTop();
            }

            public int GetBottomElement()
            {
                if (IsEmpty())
                {
                    return -1;
                }

                var tempStack = new StackExercises13(stackItems.Length);
                int bottomElement = -1;

                while (!IsEmpty())
                {
                    var current = PopValue();
                    tempStack.PushValue(current);
                    bottomElement = current;
                }

                while (!tempStack.IsEmpty())
                {
                    PushValue(tempStack.PopValue());
                }

                return bottomElement;
            }
        }

        // Exercise 14 - Write a C# program to rotate the stack elements to the left direction.
        public class StackExercises14
        {
            private int[] stackElements;
            private int topIndex;

            public StackExercises14(int capacity)
            {
                stackElements = new int[capacity];
                topIndex = -1;
            }

            public bool IsEmpty()
            {
                return topIndex == -1;
            }

            public void PushValue(int value)
            {
                stackElements[++topIndex] = value;
            }

            public int PopValue()
            {
                return stackElements[topIndex--];
            }

            public int PeekValue()
            {
                return stackElements[topIndex];
            }

            public int GetElementCount()
            {
                return topIndex + 1;
            }

            public static void RotateLeft(StackExercises14 stack, int rotations)
            {
                int count = stack.GetElementCount();
                if (count == 0) return;

                rotations %= count;
                if (rotations == 0) return;

                var tempArray = new int[count];

                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = stack.PopValue();
                }

                for (int i = count - 1; i >= 0; i--)
                {
                    int newIndex = (i + rotations) % count;
                    stack.PushValue(tempArray[newIndex]);
                }
            }
        }

        // Exercise 15 - Write a C# program to swap the top two elements of a given stack.
        public class StackExercises15
        {
            private int[] stackData;
            private int topPointer;

            public StackExercises15(int capacity)
            {
                stackData = new int[capacity];
                topPointer = -1;
            }

            public bool IsEmpty()
            {
                return topPointer == -1;
            }

            public void PushValue(int value)
            {
                stackData[++topPointer] = value;
            }

            public int PopValue()
            {
                return stackData[topPointer--];
            }

            public int PeekValue()
            {
                return stackData[topPointer];
            }

            public int GetCount()
            {
                return topPointer + 1;
            }

            public static void SwapTopTwo(StackExercises15 stack)
            {
                if (stack.GetCount() < 2) return;

                var top = stack.PopValue();
                var second = stack.PopValue();

                stack.PushValue(top);
                stack.PushValue(second);
            }
        }

        // Exercise 16 - Write a C# program to get the nth element from the top of the stack.
        public class StackExercises16
        {
            private int[] stackArray;
            private int topIndex;

            public StackExercises16(int capacity)
            {
                stackArray = new int[capacity];
                topIndex = -1;
            }

            public bool IsEmpty()
            {
                return topIndex == -1;
            }

            public void PushValue(int value)
            {
                stackArray[++topIndex] = value;
            }

            public int PopValue()
            {
                return stackArray[topIndex--];
            }

            public int PeekValue()
            {
                return stackArray[topIndex];
            }

            public int GetCount()
            {
                return topIndex + 1;
            }

            public int GetNthFromTop(int n)
            {
                if (n < 1 || n > GetCount())
                {
                    return -1;
                }

                var tempStack = new StackExercises16(stackArray.Length);
                int result = -1;

                for (int i = 0; i < n; i++)
                {
                    var current = PopValue();
                    tempStack.PushValue(current);
                    if (i == n - 1)
                    {
                        result = current;
                    }
                }

                while (!tempStack.IsEmpty())
                {
                    PushValue(tempStack.PopValue());
                }

                return result;
            }
        }

        // Exercise 17 - Write a C# program to merge two stacks into one.
        public class StackExercises17
        {
            private int[] stackElements;
            private int topIndex;

            public StackExercises17(int capacity)
            {
                stackElements = new int[capacity];
                topIndex = -1;
            }

            public bool IsEmpty()
            {
                return topIndex == -1;
            }

            public void PushValue(int value)
            {
                stackElements[++topIndex] = value;
            }

            public int PopValue()
            {
                return stackElements[topIndex--];
            }

            public int PeekValue()
            {
                return stackElements[topIndex];
            }

            public int GetCount()
            {
                return topIndex + 1;
            }

            public static StackExercises17 MergeStacks(StackExercises17 stack1, StackExercises17 stack2)
            {
                var resultStack = new StackExercises17(stack1.GetCount() + stack2.GetCount());

                // Primeiro transfere stack2 para resultStack (preservando ordem original)
                var tempStack2 = new StackExercises17(stack2.GetCount());
                while (!stack2.IsEmpty())
                {
                    tempStack2.PushValue(stack2.PopValue());
                }
                while (!tempStack2.IsEmpty())
                {
                    resultStack.PushValue(tempStack2.PopValue());
                }

                // Depois transfere stack1 para resultStack (preservando ordem original)
                var tempStack1 = new StackExercises17(stack1.GetCount());
                while (!stack1.IsEmpty())
                {
                    tempStack1.PushValue(stack1.PopValue());
                }
                while (!tempStack1.IsEmpty())
                {
                    resultStack.PushValue(tempStack1.PopValue());
                }

                return resultStack;
            }
        }

        // Exercise 18 - Write a C# program that implements a stack and checks if a stack is a subset of another stack.
        public class StackExercises18
        {
            private int[] stackElements;
            private int topIndex;

            public StackExercises18(int capacity)
            {
                stackElements = new int[capacity];
                topIndex = -1;
            }

            public bool IsEmpty()
            {
                return topIndex == -1;
            }

            public void PushValue(int value)
            {
                stackElements[++topIndex] = value;
            }

            public int PopValue()
            {
                return stackElements[topIndex--];
            }

            public int PeekValue()
            {
                return stackElements[topIndex];
            }

            public int GetCount()
            {
                return topIndex + 1;
            }

            public bool ContainsValue(int targetValue)
            {
                var tempStack = new StackExercises18(stackElements.Length);
                bool found = false;

                while (!IsEmpty())
                {
                    var current = PopValue();
                    if (current == targetValue)
                    {
                        found = true;
                    }
                    tempStack.PushValue(current);
                }

                while (!tempStack.IsEmpty())
                {
                    PushValue(tempStack.PopValue());
                }

                return found;
            }

            public static bool IsSubset(StackExercises18 subsetStack, StackExercises18 mainStack)
            {
                if (subsetStack.IsEmpty()) return true;
                if (mainStack.IsEmpty()) return false;

                var tempStack = new StackExercises18(subsetStack.GetCount());
                bool isSubset = true;

                while (!subsetStack.IsEmpty())
                {
                    var current = subsetStack.PopValue();
                    tempStack.PushValue(current);

                    if (!mainStack.ContainsValue(current))
                    {
                        isSubset = false;
                        break;
                    }
                }

                while (!tempStack.IsEmpty())
                {
                    subsetStack.PushValue(tempStack.PopValue());
                }

                return isSubset;
            }
        }

        // Exercise 19 - Write a C# program that implements a stack and checks if two stacks are equal.
        public class StackExercises19
        {
            private int[] stackElements;
            private int topIndex;

            public StackExercises19(int capacity)
            {
                stackElements = new int[capacity];
                topIndex = -1;
            }

            public bool IsEmpty()
            {
                return topIndex == -1;
            }

            public void PushValue(int value)
            {
                stackElements[++topIndex] = value;
            }

            public int PopValue()
            {
                return stackElements[topIndex--];
            }

            public int PeekValue()
            {
                return stackElements[topIndex];
            }

            public int GetCount()
            {
                return topIndex + 1;
            }

            public static bool AreStacksEqual(StackExercises19 stack1, StackExercises19 stack2)
            {
                if (stack1.GetCount() != stack2.GetCount())
                {
                    return false;
                }

                var tempStack1 = new StackExercises19(stack1.GetCount());
                var tempStack2 = new StackExercises19(stack2.GetCount());
                bool areEqual = true;

                while (!stack1.IsEmpty())
                {
                    var value1 = stack1.PopValue();
                    var value2 = stack2.PopValue();

                    tempStack1.PushValue(value1);
                    tempStack2.PushValue(value2);

                    if (value1 != value2)
                    {
                        areEqual = false;
                        break;
                    }
                }

                while (!tempStack1.IsEmpty())
                {
                    stack1.PushValue(tempStack1.PopValue());
                }

                while (!tempStack2.IsEmpty())
                {
                    stack2.PushValue(tempStack2.PopValue());
                }

                return areEqual;
            }
        }

        // Exercise 20 - Write a C# program that implements a stack and finds common elements between two stacks.
        public class StackExercises20
        {
            private int[] stackElements;
            private int topIndex;

            public StackExercises20(int capacity)
            {
                stackElements = new int[capacity];
                topIndex = -1;
            }

            public bool IsEmpty()
            {
                return topIndex == -1;
            }

            public void PushValue(int value)
            {
                stackElements[++topIndex] = value;
            }

            public int PopValue()
            {
                return stackElements[topIndex--];
            }

            public int PeekValue()
            {
                return stackElements[topIndex];
            }

            public int GetCount()
            {
                return topIndex + 1;
            }

            public bool ContainsValue(int targetValue)
            {
                for (int i = 0; i <= topIndex; i++)
                {
                    if (stackElements[i] == targetValue)
                    {
                        return true;
                    }
                }
                return false;
            }

            public static StackExercises20 FindCommonElements(StackExercises20 stack1, StackExercises20 stack2)
            {
                var commonElements = new StackExercises20(stack1.GetCount());
                var seenValues = new HashSet<int>();

                for (int i = 0; i <= stack1.topIndex; i++)
                {
                    var currentValue = stack1.stackElements[i];

                    if (stack2.ContainsValue(currentValue) && !seenValues.Contains(currentValue))
                    {
                        commonElements.PushValue(currentValue);
                        seenValues.Add(currentValue);
                    }
                }

                return commonElements;
            }
        }

        // Exercise 21 - Write a C# program that implements a stack and find elements that are in the first stack but not in the second stack.
        public class StackExercises21
        {
            private int[] stackElements;
            private int topIndex;

            public StackExercises21(int capacity)
            {
                stackElements = new int[capacity];
                topIndex = -1;
            }

            public bool IsEmpty()
            {
                return topIndex == -1;
            }

            public void PushValue(int value)
            {
                stackElements[++topIndex] = value;
            }

            public int PopValue()
            {
                return stackElements[topIndex--];
            }

            public int PeekValue()
            {
                return stackElements[topIndex];
            }

            public int GetCount()
            {
                return topIndex + 1;
            }

            public bool ContainsValue(int targetValue)
            {
                for (int i = 0; i <= topIndex; i++)
                {
                    if (stackElements[i] == targetValue)
                    {
                        return true;
                    }
                }
                return false;
            }

            public static StackExercises21 ElementsInFirstButNotInSecond(StackExercises21 stack1, StackExercises21 stack2)
            {
                var resultStack = new StackExercises21(stack1.GetCount());
                var seenValues = new HashSet<int>();

                for (int i = 0; i <= stack1.topIndex; i++)
                {
                    var currentValue = stack1.stackElements[i];

                    if (!stack2.ContainsValue(currentValue) && !seenValues.Contains(currentValue))
                    {
                        resultStack.PushValue(currentValue);
                        seenValues.Add(currentValue);
                    }
                }

                return resultStack;
            }
        }

        // Exercise 22 - Write a C# program that implements a stack and creates a new stack that contains all elements from both stacks without duplicates.
        public class StackExercises22
        {
            private int[] stackElements;
            private int topIndex;

            public StackExercises22(int capacity)
            {
                stackElements = new int[capacity];
                topIndex = -1;
            }

            public bool IsEmpty()
            {
                return topIndex == -1;
            }

            public void PushValue(int value)
            {
                stackElements[++topIndex] = value;
            }

            public int PopValue()
            {
                return stackElements[topIndex--];
            }

            public int PeekValue()
            {
                return stackElements[topIndex];
            }

            public int GetCount()
            {
                return topIndex + 1;
            }

            public bool ContainsValue(int targetValue)
            {
                for (int i = 0; i <= topIndex; i++)
                {
                    if (stackElements[i] == targetValue)
                    {
                        return true;
                    }
                }
                return false;
            }

            public static StackExercises22 MergeStacksWithoutDuplicates(StackExercises22 stack1, StackExercises22 stack2)
            {
                var resultStack = new StackExercises22(stack1.GetCount() + stack2.GetCount());
                var seenValues = new HashSet<int>();

                // Add elements from stack1
                for (int i = 0; i <= stack1.topIndex; i++)
                {
                    var currentValue = stack1.stackElements[i];
                    if (seenValues.Add(currentValue))
                    {
                        resultStack.PushValue(currentValue);
                    }
                }

                // Add elements from stack2
                for (int i = 0; i <= stack2.topIndex; i++)
                {
                    var currentValue = stack2.stackElements[i];
                    if (seenValues.Add(currentValue))
                    {
                        resultStack.PushValue(currentValue);
                    }
                }

                return resultStack;
            }
        }

        /* Exercise 23 - Write a C# program that implements a stack and creates a new stack that contains only
        elements that are in either the first or the second stack, but not in both.*/
        public class StackExercises23
        {
            private int[] stackElements;
            private int topIndex;

            public StackExercises23(int capacity)
            {
                stackElements = new int[capacity];
                topIndex = -1;
            }

            public bool IsEmpty()
            {
                return topIndex == -1;
            }

            public void PushValue(int value)
            {
                stackElements[++topIndex] = value;
            }

            public int PopValue()
            {
                return stackElements[topIndex--];
            }

            public int PeekValue()
            {
                return stackElements[topIndex];
            }

            public int GetCount()
            {
                return topIndex + 1;
            }

            public bool ContainsValue(int targetValue)
            {
                for (int i = 0; i <= topIndex; i++)
                {
                    if (stackElements[i] == targetValue)
                    {
                        return true;
                    }
                }
                return false;
            }

            public static StackExercises23 GetSymmetricDifference(StackExercises23 stack1, StackExercises23 stack2)
            {
                var resultStack = new StackExercises23(stack1.GetCount() + stack2.GetCount());
                var seenValues = new HashSet<int>();

                // Elements in stack1 but not in stack2
                for (int i = 0; i <= stack1.topIndex; i++)
                {
                    var currentValue = stack1.stackElements[i];
                    if (!stack2.ContainsValue(currentValue) && seenValues.Add(currentValue))
                    {
                        resultStack.PushValue(currentValue);
                    }
                }

                // Elements in stack2 but not in stack1
                for (int i = 0; i <= stack2.topIndex; i++)
                {
                    var currentValue = stack2.stackElements[i];
                    if (!stack1.ContainsValue(currentValue) && seenValues.Add(currentValue))
                    {
                        resultStack.PushValue(currentValue);
                    }
                }

                return resultStack;
            }
        }

        // Exercise 24 - Write a C# program that implements a stack and creates a new stack from a portion of the original stack.
        public class StackExercises24
        {
            private int[] stackElements;
            private int topIndex;

            public StackExercises24(int capacity)
            {
                stackElements = new int[capacity];
                topIndex = -1;
            }

            public bool IsEmpty()
            {
                return topIndex == -1;
            }

            public void PushValue(int value)
            {
                stackElements[++topIndex] = value;
            }

            public int PopValue()
            {
                return stackElements[topIndex--];
            }

            public int PeekValue()
            {
                return stackElements[topIndex];
            }

            public int GetCount()
            {
                return topIndex + 1;
            }

            public static StackExercises24 CreateSubstack(StackExercises24 original, int startIndex, int endIndex)
            {
                if (startIndex < 0 || endIndex >= original.GetCount() || startIndex > endIndex)
                {
                    return new StackExercises24(0);
                }

                int substackSize = endIndex - startIndex + 1;
                var substack = new StackExercises24(substackSize);
                var tempStack = new StackExercises24(original.GetCount());

                // Primeiro, transferir todos os elementos para a tempStack
                while (!original.IsEmpty())
                {
                    tempStack.PushValue(original.PopValue());
                }

                // Agora reconstruir a original e criar a substack
                int currentIndex = 0;
                while (!tempStack.IsEmpty())
                {
                    var currentValue = tempStack.PopValue();
                    original.PushValue(currentValue);

                    if (currentIndex >= startIndex && currentIndex <= endIndex)
                    {
                        substack.PushValue(currentValue);
                    }
                    currentIndex++;
                }

                return substack;
            }
        }

        // Exercise 25 - Write a C# program that implements a stack and checks if all elements of the stack satisfy a condition.
        public class StackExercises25
        {
            private int[] stackElements;
            private int topIndex;

            public StackExercises25(int capacity)
            {
                stackElements = new int[capacity];
                topIndex = -1;
            }

            public bool IsEmpty()
            {
                return topIndex == -1;
            }

            public void PushValue(int value)
            {
                stackElements[++topIndex] = value;
            }

            public int PopValue()
            {
                return stackElements[topIndex--];
            }

            public int PeekValue()
            {
                return stackElements[topIndex];
            }

            public int GetCount()
            {
                return topIndex + 1;
            }

            public bool AllElementsSatisfy(Func<int, bool> condition)
            {
                var tempStack = new StackExercises25(stackElements.Length);
                bool allSatisfy = true;

                while (!IsEmpty())
                {
                    var current = PopValue();
                    tempStack.PushValue(current);

                    if (!condition(current))
                    {
                        allSatisfy = false;
                    }
                }

                while (!tempStack.IsEmpty())
                {
                    PushValue(tempStack.PopValue());
                }

                return allSatisfy;
            }
        }

        // Exercise 26 - Write a C# program that implements a stack and checks if at least one element of the stack satisfies a condition.
        public class StackExercises26
        {
            private int[] stackElements;
            private int topIndex;

            public StackExercises26(int capacity)
            {
                stackElements = new int[capacity];
                topIndex = -1;
            }

            public bool IsEmpty()
            {
                return topIndex == -1;
            }

            public void PushValue(int value)
            {
                stackElements[++topIndex] = value;
            }

            public int PopValue()
            {
                return stackElements[topIndex--];
            }

            public int PeekValue()
            {
                return stackElements[topIndex];
            }

            public int GetCount()
            {
                return topIndex + 1;
            }

            public bool AnyElementSatisfies(Func<int, bool> condition)
            {
                var tempStack = new StackExercises26(stackElements.Length);
                bool result = false;

                while (!IsEmpty())
                {
                    var current = PopValue();
                    tempStack.PushValue(current);

                    if (condition(current))
                    {
                        result = true;
                    }
                }

                while (!tempStack.IsEmpty())
                {
                    PushValue(tempStack.PopValue());
                }

                return result;
            }
        }

        // Exercise 27 - Write a C# program that implements a stack and create a new stack by removing elements that do not satisfy a condition.
        public class StackExercises27
        {
            private int[] stackElements;
            private int topIndex;

            public StackExercises27(int capacity)
            {
                stackElements = new int[capacity];
                topIndex = -1;
            }

            public bool IsEmpty()
            {
                return topIndex == -1;
            }

            public void PushValue(int value)
            {
                stackElements[++topIndex] = value;
            }

            public int PopValue()
            {
                return stackElements[topIndex--];
            }

            public int PeekValue()
            {
                return stackElements[topIndex];
            }

            public int GetCount()
            {
                return topIndex + 1;
            }

            public static StackExercises27 FilterStack(StackExercises27 original, Func<int, bool> condition)
            {
                var tempStack = new StackExercises27(original.GetCount());
                var filteredStack = new StackExercises27(original.GetCount());

                // First, transfer all elements to tempStack (reversing order)
                while (!original.IsEmpty())
                {
                    tempStack.PushValue(original.PopValue());
                }

                // Now process elements in original order
                while (!tempStack.IsEmpty())
                {
                    var current = tempStack.PopValue();
                    original.PushValue(current);

                    if (condition(current))
                    {
                        filteredStack.PushValue(current);
                    }
                }

                return filteredStack;
            }
        }
    }
}