using Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTests;

[TestClass]
public class BasicAlgorithmTests
{
    // Exercise 1 - Triple Sum for Equal Integers

    [TestMethod]
    public void TripleSumForEqualIntegers_DifferentValues_ReturnsSum()
    {
        // Arrange
        int a = 1;
        int b = 2;
        int expected = 3;

        // Act
        int result = BasicAlgorithm.TripleSumForEqualIntegers(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TripleSumForEqualIntegers_DifferentValues2_ReturnsSum()
    {
        // Arrange
        int a = 3;
        int b = 2;
        int expected = 5;

        // Act
        int result = BasicAlgorithm.TripleSumForEqualIntegers(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TripleSumForEqualIntegers_SameValues_ReturnsTripleSum()
    {
        // Arrange
        int a = 2;
        int b = 2;
        int expected = 12;

        // Act
        int result = BasicAlgorithm.TripleSumForEqualIntegers(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TripleSumForEqualIntegers_NegativeSameValues_ReturnsTripleSum()
    {
        // Arrange
        int a = -5;
        int b = -5;
        int expected = -30;

        // Act
        int result = BasicAlgorithm.TripleSumForEqualIntegers(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TripleSumForEqualIntegers_ZeroValues_ReturnsZero()
    {
        // Arrange
        int a = 0;
        int b = 0;
        int expected = 0;

        // Act
        int result = BasicAlgorithm.TripleSumForEqualIntegers(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TripleSumForEqualIntegers_PositiveAndNegativeSameValues_ReturnsTripleSum()
    {
        // Arrange
        int a = 7;
        int b = 7;
        int expected = 42;

        // Act
        int result = BasicAlgorithm.TripleSumForEqualIntegers(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }

    // Exercise 2 - Absolute Difference with Triple for Greater

    [TestMethod]
    public void TripleSumForEqualIntegers_DifferentValues()
    {
        // Arrange
        int a = 1;
        int b = 2;
        int expected = 3;

        // Act
        int result = BasicAlgorithm.TripleSumForEqualIntegers(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TripleSumForEqualIntegers_SameValues()
    {
        // Arrange
        int a = 2;
        int b = 2;
        int expected = 12;

        // Act
        int result = BasicAlgorithm.TripleSumForEqualIntegers(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void AbsoluteDifferenceWithTriple_GreaterThan51_ReturnsTripleDifference()
    {
        // Arrange
        int n = 53;
        int expected = 6; // 3 * |53 - 51| = 3 * 2 = 6

        // Act
        int result = BasicAlgorithm.AbsoluteDifferenceWithTriple(n);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void AbsoluteDifferenceWithTriple_LessThan51_ReturnsAbsoluteDifference()
    {
        // Arrange
        int n = 30;
        int expected = 21; // |30 - 51| = 21

        // Act
        int result = BasicAlgorithm.AbsoluteDifferenceWithTriple(n);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void AbsoluteDifferenceWithTriple_EqualTo51_ReturnsZero()
    {
        // Arrange
        int n = 51;
        int expected = 0; // |51 - 51| = 0

        // Act
        int result = BasicAlgorithm.AbsoluteDifferenceWithTriple(n);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void AbsoluteDifferenceWithTriple_NegativeValue_ReturnsAbsoluteDifference()
    {
        // Arrange
        int n = -10;
        int expected = 61; // |-10 - 51| = 61

        // Act
        int result = BasicAlgorithm.AbsoluteDifferenceWithTriple(n);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void AbsoluteDifferenceWithTriple_MuchGreaterThan51_ReturnsTripleDifference()
    {
        // Arrange
        int n = 100;
        int expected = 147; // 3 * |100 - 51| = 3 * 49 = 147

        // Act
        int result = BasicAlgorithm.AbsoluteDifferenceWithTriple(n);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void AbsoluteDifferenceWithTriple_ZeroValue_ReturnsAbsoluteDifference()
    {
        // Arrange
        int n = 0;
        int expected = 51; // |0 - 51| = 51

        // Act
        int result = BasicAlgorithm.AbsoluteDifferenceWithTriple(n);

        // Assert
        Assert.AreEqual(expected, result);
    }

    // Exercise 3 - Check 30 or Sum Equals 30

    [TestMethod]
    public void TripleSumForEqualIntegers_DifferentValue()
    {
        // Arrange
        int a = 1;
        int b = 2;
        int expected = 3;

        // Act
        int result = BasicAlgorithm.TripleSumForEqualIntegers(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void AbsoluteDifferenceWithTriple_GreaterThan51_ReturnsTriple()
    {
        // Arrange
        int n = 53;
        int expected = 6;

        // Act
        int result = BasicAlgorithm.AbsoluteDifferenceWithTriple(n);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Check30OrSumEquals30_FirstIs30_ReturnsTrue()
    {
        // Arrange
        int a = 30;
        int b = 0;

        // Act
        bool result = BasicAlgorithm.Check30OrSumEquals30(a, b);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Check30OrSumEquals30_SecondIs30_ReturnsTrue()
    {
        // Arrange
        int a = 20;
        int b = 30;

        // Act
        bool result = BasicAlgorithm.Check30OrSumEquals30(a, b);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Check30OrSumEquals30_SumIs30_ReturnsTrue()
    {
        // Arrange
        int a = 25;
        int b = 5;

        // Act
        bool result = BasicAlgorithm.Check30OrSumEquals30(a, b);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Check30OrSumEquals30_NeitherConditionMet_ReturnsFalse()
    {
        // Arrange
        int a = 20;
        int b = 25;

        // Act
        bool result = BasicAlgorithm.Check30OrSumEquals30(a, b);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Check30OrSumEquals30_BothAre30_ReturnsTrue()
    {
        // Arrange
        int a = 30;
        int b = 30;

        // Act
        bool result = BasicAlgorithm.Check30OrSumEquals30(a, b);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Check30OrSumEquals30_NegativeNumbersSum30_ReturnsTrue()
    {
        // Arrange
        int a = 40;
        int b = -10;

        // Act
        bool result = BasicAlgorithm.Check30OrSumEquals30(a, b);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Check30OrSumEquals30_NegativeNumbersNoCondition_ReturnsFalse()
    {
        // Arrange
        int a = -15;
        int b = -20;

        // Act
        bool result = BasicAlgorithm.Check30OrSumEquals30(a, b);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Check30OrSumEquals30_ZeroAnd30_ReturnsTrue()
    {
        // Arrange
        int a = 0;
        int b = 30;

        // Act
        bool result = BasicAlgorithm.Check30OrSumEquals30(a, b);

        // Assert
        Assert.IsTrue(result);
    }

    // Exercise 4 - Within 10 of 100 or 200

    [TestMethod]
    public void TripleSumForEqualIntegers()
    {
        // Arrange
        int a = 1;
        int b = 2;
        int expected = 3;

        // Act
        int result = BasicAlgorithm.TripleSumForEqualIntegers(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void AbsoluteDifferenceWithTriple_GreaterThan51()
    {
        // Arrange
        int n = 53;
        int expected = 6;

        // Act
        int result = BasicAlgorithm.AbsoluteDifferenceWithTriple(n);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Check30OrSumEquals30_FirstIs30()
    {
        // Arrange
        int a = 30;
        int b = 0;

        // Act
        bool result = BasicAlgorithm.Check30OrSumEquals30(a, b);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Within10Of100Or200_Within10Of100_ReturnsTrue()
    {
        // Arrange
        int n = 103;

        // Act
        bool result = BasicAlgorithm.Within10Of100Or200(n);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Within10Of100Or200_Within10Of100Lower_ReturnsTrue()
    {
        // Arrange
        int n = 90;

        // Act
        bool result = BasicAlgorithm.Within10Of100Or200(n);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Within10Of100Or200_Outside10Of100_ReturnsFalse()
    {
        // Arrange
        int n = 89;

        // Act
        bool result = BasicAlgorithm.Within10Of100Or200(n);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Within10Of100Or200_Within10Of200_ReturnsTrue()
    {
        // Arrange
        int n = 205;

        // Act
        bool result = BasicAlgorithm.Within10Of100Or200(n);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Within10Of100Or200_Within10Of200Lower_ReturnsTrue()
    {
        // Arrange
        int n = 190;

        // Act
        bool result = BasicAlgorithm.Within10Of100Or200(n);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Within10Of100Or200_Exactly100_ReturnsTrue()
    {
        // Arrange
        int n = 100;

        // Act
        bool result = BasicAlgorithm.Within10Of100Or200(n);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Within10Of100Or200_Exactly200_ReturnsTrue()
    {
        // Arrange
        int n = 200;

        // Act
        bool result = BasicAlgorithm.Within10Of100Or200(n);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Within10Of100Or200_Boundary90_ReturnsTrue()
    {
        // Arrange
        int n = 90; // |100 - 90| = 10

        // Act
        bool result = BasicAlgorithm.Within10Of100Or200(n);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Within10Of100Or200_Boundary110_ReturnsTrue()
    {
        // Arrange
        int n = 110; // |100 - 110| = 10

        // Act
        bool result = BasicAlgorithm.Within10Of100Or200(n);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Within10Of100Or200_Boundary89_ReturnsFalse()
    {
        // Arrange
        int n = 89; // |100 - 89| = 11

        // Act
        bool result = BasicAlgorithm.Within10Of100Or200(n);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Within10Of100Or200_Boundary211_ReturnsFalse()
    {
        // Arrange
        int n = 211; // |200 - 211| = 11

        // Act
        bool result = BasicAlgorithm.Within10Of100Or200(n);

        // Assert
        Assert.IsFalse(result);
    }

    // Exercise 5 - Add 'if' to String if Absent

    [TestMethod]
    public void AddIfToString_StartsWithIf_ReturnsUnchanged()
    {
        // Arrange
        string input = "if else";
        string expected = "if else";

        // Act
        string result = BasicAlgorithm.AddIfToString(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void AddIfToString_DoesNotStartWithIf_AddsIfPrefix()
    {
        // Arrange
        string input = "else";
        string expected = "if else";

        // Act
        string result = BasicAlgorithm.AddIfToString(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void AddIfToString_UpperCaseIf_ReturnsUnchanged()
    {
        // Arrange
        string input = "IF statement";
        string expected = "IF statement";

        // Act
        string result = BasicAlgorithm.AddIfToString(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void AddIfToString_EmptyString_ReturnsIf()
    {
        // Arrange
        string input = "";
        string expected = "if";

        // Act
        string result = BasicAlgorithm.AddIfToString(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void AddIfToString_NullString_ReturnsIf()
    {
        // Arrange
        string input = null;
        string expected = "if";

        // Act
        string result = BasicAlgorithm.AddIfToString(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void AddIfToString_WithLeadingSpacesAndIf_ReturnsUnchanged()
    {
        // Arrange
        string input = "   if condition";
        string expected = "   if condition";

        // Act
        string result = BasicAlgorithm.AddIfToString(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void AddIfToString_ContainsIfButNotAtStart_AddsIfPrefix()
    {
        // Arrange
        string input = "this if that";
        string expected = "if this if that";

        // Act
        string result = BasicAlgorithm.AddIfToString(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    // Exercise 6 - Remove Character at Position


    [TestMethod]
    public void RemoveCharacterAtPosition_ValidPosition_RemovesCharacter()
    {
        // Arrange
        string input = "Python";
        int position = 1;
        string expected = "Pthon";

        // Act
        string result = BasicAlgorithm.RemoveCharacterAtPosition(input, position);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void RemoveCharacterAtPosition_PositionZero_RemovesFirstCharacter()
    {
        // Arrange
        string input = "Python";
        int position = 0;
        string expected = "ython";

        // Act
        string result = BasicAlgorithm.RemoveCharacterAtPosition(input, position);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void RemoveCharacterAtPosition_LastPosition_RemovesLastCharacter()
    {
        // Arrange
        string input = "Python";
        int position = 4;
        string expected = "Pythn";

        // Act
        string result = BasicAlgorithm.RemoveCharacterAtPosition(input, position);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void RemoveCharacterAtPosition_PositionOutOfRange_ReturnsOriginal()
    {
        // Arrange
        string input = "Python";
        int position = 10;
        string expected = "Python";

        // Act
        string result = BasicAlgorithm.RemoveCharacterAtPosition(input, position);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void RemoveCharacterAtPosition_NegativePosition_ReturnsOriginal()
    {
        // Arrange
        string input = "Python";
        int position = -1;
        string expected = "Python";

        // Act
        string result = BasicAlgorithm.RemoveCharacterAtPosition(input, position);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void RemoveCharacterAtPosition_EmptyString_ReturnsEmpty()
    {
        // Arrange
        string input = "";
        int position = 0;
        string expected = "";

        // Act
        string result = BasicAlgorithm.RemoveCharacterAtPosition(input, position);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void RemoveCharacterAtPosition_NullString_ReturnsNull()
    {
        // Arrange
        string input = null;
        int position = 0;
        string expected = null;

        // Act
        string result = BasicAlgorithm.RemoveCharacterAtPosition(input, position);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void RemoveCharacterAtPosition_SingleCharacter_ReturnsEmpty()
    {
        // Arrange
        string input = "A";
        int position = 0;
        string expected = "";

        // Act
        string result = BasicAlgorithm.RemoveCharacterAtPosition(input, position);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void RemoveCharacterAtPosition_LastCharacterPosition_RemovesCorrectly()
    {
        // Arrange
        string input = "Python";
        int position = 5;
        string expected = "Pytho";

        // Act
        string result = BasicAlgorithm.RemoveCharacterAtPosition(input, position);

        // Assert
        Assert.AreEqual(expected, result);
    }

    // Exercise 7 - Exchange First and Last Characters

    [TestMethod]
    public void ExchangeFirstLastCharacters_NormalString_ExchangesCharacters()
    {
        // Arrange
        string input = "abcd";
        string expected = "dbca";

        // Act
        string result = BasicAlgorithm.ExchangeFirstLastCharacters(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ExchangeFirstLastCharacters_SingleCharacter_ReturnsSame()
    {
        // Arrange
        string input = "a";
        string expected = "a";

        // Act
        string result = BasicAlgorithm.ExchangeFirstLastCharacters(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ExchangeFirstLastCharacters_TwoCharacters_ExchangesCharacters()
    {
        // Arrange
        string input = "xy";
        string expected = "yx";

        // Act
        string result = BasicAlgorithm.ExchangeFirstLastCharacters(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ExchangeFirstLastCharacters_EmptyString_ReturnsEmpty()
    {
        // Arrange
        string input = "";
        string expected = "";

        // Act
        string result = BasicAlgorithm.ExchangeFirstLastCharacters(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ExchangeFirstLastCharacters_NullString_ReturnsNull()
    {
        // Arrange
        string input = null;
        string expected = null;

        // Act
        string result = BasicAlgorithm.ExchangeFirstLastCharacters(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ExchangeFirstLastCharacters_ThreeCharacters_ExchangesCharacters()
    {
        // Arrange
        string input = "abc";
        string expected = "cba";

        // Act
        string result = BasicAlgorithm.ExchangeFirstLastCharacters(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ExchangeFirstLastCharacters_FourCharacters_ExchangesCharacters()
    {
        // Arrange
        string input = "word";
        string expected = "dorw";

        // Act
        string result = BasicAlgorithm.ExchangeFirstLastCharacters(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ExchangeFirstLastCharacters_WithSpaces_ExchangesCharacters()
    {
        // Arrange
        string input = "hello world";
        string expected = "dello worlh";

        // Act
        string result = BasicAlgorithm.ExchangeFirstLastCharacters(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ExchangeFirstLastCharacters_SpecialCharacters_ExchangesCharacters()
    {
        // Arrange
        string input = "@#$%";
        string expected = "%#$@";

        // Act
        string result = BasicAlgorithm.ExchangeFirstLastCharacters(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    // Exercise 8 - Four Copies of First Two Characters

    [TestMethod]
    public void FourCopiesOfFirstTwoCharacters_NormalString_ReturnsFourCopies()
    {
        // Arrange
        string input = "C Sharp";
        string expected = "C C C C ";

        // Act
        string result = BasicAlgorithm.FourCopiesOfFirstTwoCharacters(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void FourCopiesOfFirstTwoCharacters_TwoCharacters_ReturnsFourCopies()
    {
        // Arrange
        string input = "JS";
        string expected = "JSJSJSJS";

        // Act
        string result = BasicAlgorithm.FourCopiesOfFirstTwoCharacters(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void FourCopiesOfFirstTwoCharacters_SingleCharacter_ReturnsOriginal()
    {
        // Arrange
        string input = "a";
        string expected = "a";

        // Act
        string result = BasicAlgorithm.FourCopiesOfFirstTwoCharacters(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void FourCopiesOfFirstTwoCharacters_EmptyString_ReturnsEmpty()
    {
        // Arrange
        string input = "";
        string expected = "";

        // Act
        string result = BasicAlgorithm.FourCopiesOfFirstTwoCharacters(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void FourCopiesOfFirstTwoCharacters_NullString_ReturnsNull()
    {
        // Arrange
        string input = null;
        string expected = null;

        // Act
        string result = BasicAlgorithm.FourCopiesOfFirstTwoCharacters(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void FourCopiesOfFirstTwoCharacters_ExactlyTwoChars_ReturnsFourCopies()
    {
        // Arrange
        string input = "AB";
        string expected = "ABABABAB";

        // Act
        string result = BasicAlgorithm.FourCopiesOfFirstTwoCharacters(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void FourCopiesOfFirstTwoCharacters_ThreeCharacters_ReturnsFourCopiesOfFirstTwo()
    {
        // Arrange
        string input = "XYZ";
        string expected = "XYXYXYXY";

        // Act
        string result = BasicAlgorithm.FourCopiesOfFirstTwoCharacters(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void FourCopiesOfFirstTwoCharacters_SpecialCharacters_ReturnsFourCopies()
    {
        // Arrange
        string input = "@#$%";
        string expected = "@#@#@#@#";

        // Act
        string result = BasicAlgorithm.FourCopiesOfFirstTwoCharacters(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void FourCopiesOfFirstTwoCharacters_WithSpaces_ReturnsFourCopies()
    {
        // Arrange
        string input = "A B";
        string expected = "A A A A ";

        // Act
        string result = BasicAlgorithm.FourCopiesOfFirstTwoCharacters(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    // Exercise 9 - Last Character at Front and Back

    [TestMethod]
    public void LastCharacterAtFrontAndBack_NormalString_AddsLastCharAtFrontAndBack()
    {
        // Arrange
        string input = "Red";
        string expected = "dRedd";

        // Act
        string result = BasicAlgorithm.LastCharacterAtFrontAndBack(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void LastCharacterAtFrontAndBack_AnotherString_AddsLastCharAtFrontAndBack()
    {
        // Arrange
        string input = "Green";
        string expected = "nGreenn";

        // Act
        string result = BasicAlgorithm.LastCharacterAtFrontAndBack(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void LastCharacterAtFrontAndBack_SingleCharacter_AddsCharacterAtFrontAndBack()
    {
        // Arrange
        string input = "1";
        string expected = "111";

        // Act
        string result = BasicAlgorithm.LastCharacterAtFrontAndBack(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void LastCharacterAtFrontAndBack_EmptyString_ReturnsEmpty()
    {
        // Arrange
        string input = "";
        string expected = "";

        // Act
        string result = BasicAlgorithm.LastCharacterAtFrontAndBack(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void LastCharacterAtFrontAndBack_NullString_ReturnsNull()
    {
        // Arrange
        string input = null;
        string expected = null;

        // Act
        string result = BasicAlgorithm.LastCharacterAtFrontAndBack(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void LastCharacterAtFrontAndBack_TwoCharacters_AddsLastCharAtFrontAndBack()
    {
        // Arrange
        string input = "AB";
        string expected = "BABB";

        // Act
        string result = BasicAlgorithm.LastCharacterAtFrontAndBack(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void LastCharacterAtFrontAndBack_WithSpecialCharacters_AddsLastCharAtFrontAndBack()
    {
        // Arrange
        string input = "Hello!";
        string expected = "!Hello!!";

        // Act
        string result = BasicAlgorithm.LastCharacterAtFrontAndBack(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void LastCharacterAtFrontAndBack_WithSpaces_AddsLastCharAtFrontAndBack()
    {
        // Arrange
        string input = "A B";
        string expected = "BA BB";

        // Act
        string result = BasicAlgorithm.LastCharacterAtFrontAndBack(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void LastCharacterAtFrontAndBack_WithNumbers_AddsLastCharAtFrontAndBack()
    {
        // Arrange
        string input = "123";
        string expected = "31233";

        // Act
        string result = BasicAlgorithm.LastCharacterAtFrontAndBack(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    // Exercise 10 - Multiple of 3 or 7

    [TestMethod]
    public void MultipleOf3Or7_MultipleOf3_ReturnsTrue()
    {
        // Arrange
        int number = 3;

        // Act
        bool result = BasicAlgorithm.MultipleOf3Or7(number);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void MultipleOf3Or7_MultipleOf7_ReturnsTrue()
    {
        // Arrange
        int number = 14;

        // Act
        bool result = BasicAlgorithm.MultipleOf3Or7(number);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void MultipleOf3Or7_MultipleOfBoth_ReturnsTrue()
    {
        // Arrange
        int number = 21;

        // Act
        bool result = BasicAlgorithm.MultipleOf3Or7(number);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void MultipleOf3Or7_MultipleOf3Another_ReturnsTrue()
    {
        // Arrange
        int number = 12;

        // Act
        bool result = BasicAlgorithm.MultipleOf3Or7(number);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void MultipleOf3Or7_NotMultiple_ReturnsFalse()
    {
        // Arrange
        int number = 37;

        // Act
        bool result = BasicAlgorithm.MultipleOf3Or7(number);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void MultipleOf3Or7_Zero_ReturnsFalse()
    {
        // Arrange
        int number = 0;

        // Act
        bool result = BasicAlgorithm.MultipleOf3Or7(number);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void MultipleOf3Or7_NegativeNumber_ReturnsFalse()
    {
        // Arrange
        int number = -9;

        // Act
        bool result = BasicAlgorithm.MultipleOf3Or7(number);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void MultipleOf3Or7_One_ReturnsFalse()
    {
        // Arrange
        int number = 1;

        // Act
        bool result = BasicAlgorithm.MultipleOf3Or7(number);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void MultipleOf3Or7_MultipleOf3LargeNumber_ReturnsTrue()
    {
        // Arrange
        int number = 999;

        // Act
        bool result = BasicAlgorithm.MultipleOf3Or7(number);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void MultipleOf3Or7_MultipleOf7LargeNumber_ReturnsTrue()
    {
        // Arrange
        int number = 98;

        // Act
        bool result = BasicAlgorithm.MultipleOf3Or7(number);

        // Assert
        Assert.IsTrue(result);
    }

    // Exercise 11 - First Three Characters Front and Back

    [TestMethod]
    public void FirstThreeCharsFrontBack_Test()
    {
        // Arrange & Act & Assert
        Assert.AreEqual("PytPythonPyt", BasicAlgorithm.FirstThreeCharsFrontBack("Python"));
        Assert.AreEqual("JSJSJS", BasicAlgorithm.FirstThreeCharsFrontBack("JS"));
        Assert.AreEqual("CodCodeCod", BasicAlgorithm.FirstThreeCharsFrontBack("Code"));
        Assert.AreEqual("aaa", BasicAlgorithm.FirstThreeCharsFrontBack("a"));
        Assert.AreEqual("ABABAB", BasicAlgorithm.FirstThreeCharsFrontBack("AB"));
    }

    // Exercise 12 - Starts with 'C#'

    [TestMethod]
    public void StartsWithCSharp_Test()
    {
        // Arrange & Act & Assert
        Assert.IsTrue(BasicAlgorithm.StartsWithCSharp("C# Sharp"));
        Assert.IsTrue(BasicAlgorithm.StartsWithCSharp("C#"));
        Assert.IsFalse(BasicAlgorithm.StartsWithCSharp("C++"));
        Assert.IsFalse(BasicAlgorithm.StartsWithCSharp("Java"));
        Assert.IsFalse(BasicAlgorithm.StartsWithCSharp(""));
        Assert.IsTrue(BasicAlgorithm.StartsWithCSharp("C# is great"));
    }

    // Exercise 13 - Temperature Comparison

    [TestMethod]
    public void CheckTemperatures_Test()
    {
        // Arrange
        int temp1, temp2;
        bool result;

        // Act & Assert - Test case 1
        temp1 = 120;
        temp2 = -1;
        result = BasicAlgorithm.CheckTemperatures(temp1, temp2);
        Assert.IsTrue(result);

        // Act & Assert - Test case 2
        temp1 = -1;
        temp2 = 120;
        result = BasicAlgorithm.CheckTemperatures(temp1, temp2);
        Assert.IsTrue(result);

        // Act & Assert - Test case 3
        temp1 = 2;
        temp2 = 120;
        result = BasicAlgorithm.CheckTemperatures(temp1, temp2);
        Assert.IsFalse(result);

        // Act & Assert - Additional test cases
        temp1 = -5;
        temp2 = 101;
        result = BasicAlgorithm.CheckTemperatures(temp1, temp2);
        Assert.IsTrue(result);

        temp1 = 0;
        temp2 = 100;
        result = BasicAlgorithm.CheckTemperatures(temp1, temp2);
        Assert.IsFalse(result);

        temp1 = -10;
        temp2 = 50;
        result = BasicAlgorithm.CheckTemperatures(temp1, temp2);
        Assert.IsFalse(result);
    }

    // Exercise 14 - One Integer in Range 100-200

    [TestMethod]
    public void IsOneInRange100To200_Test()
    {
        // Arrange
        int num1, num2;
        bool result;

        // Act & Assert - Test case 1
        num1 = 100;
        num2 = 199;
        result = BasicAlgorithm.IsOneInRange100To200(num1, num2);
        Assert.IsTrue(result);

        // Act & Assert - Test case 2
        num1 = 250;
        num2 = 300;
        result = BasicAlgorithm.IsOneInRange100To200(num1, num2);
        Assert.IsFalse(result);

        // Act & Assert - Test case 3
        num1 = 105;
        num2 = 190;
        result = BasicAlgorithm.IsOneInRange100To200(num1, num2);
        Assert.IsTrue(result);

        // Act & Assert - Additional test cases
        num1 = 200;
        num2 = 50;
        result = BasicAlgorithm.IsOneInRange100To200(num1, num2);
        Assert.IsTrue(result);

        num1 = 99;
        num2 = 201;
        result = BasicAlgorithm.IsOneInRange100To200(num1, num2);
        Assert.IsFalse(result);

        num1 = 150;
        num2 = 250;
        result = BasicAlgorithm.IsOneInRange100To200(num1, num2);
        Assert.IsTrue(result);
    }

    //Exercise 15 - Check Integers in Range 20-50

    [TestMethod]
    public void CheckIntegersInRange20To50_Test()
    {
        // Arrange
        int num1, num2, num3;
        bool result;

        // Act & Assert - Test case 1
        num1 = 11;
        num2 = 20;
        num3 = 12;
        result = BasicAlgorithm.CheckIntegersInRange20To50(num1, num2, num3);
        Assert.IsTrue(result);

        // Act & Assert - Test case 2
        num1 = 30;
        num2 = 30;
        num3 = 17;
        result = BasicAlgorithm.CheckIntegersInRange20To50(num1, num2, num3);
        Assert.IsTrue(result);

        // Act & Assert - Test case 3
        num1 = 25;
        num2 = 35;
        num3 = 50;
        result = BasicAlgorithm.CheckIntegersInRange20To50(num1, num2, num3);
        Assert.IsTrue(result);

        // Act & Assert - Test case 4
        num1 = 15;
        num2 = 12;
        num3 = 8;
        result = BasicAlgorithm.CheckIntegersInRange20To50(num1, num2, num3);
        Assert.IsFalse(result);

        // Act & Assert - Additional test cases
        num1 = 20;
        num2 = 10;
        num3 = 5;
        result = BasicAlgorithm.CheckIntegersInRange20To50(num1, num2, num3);
        Assert.IsTrue(result);

        num1 = 50;
        num2 = 60;
        num3 = 70;
        result = BasicAlgorithm.CheckIntegersInRange20To50(num1, num2, num3);
        Assert.IsTrue(result);

        num1 = 19;
        num2 = 51;
        num3 = 100;
        result = BasicAlgorithm.CheckIntegersInRange20To50(num1, num2, num3);
        Assert.IsFalse(result);
    }

    // Exercise 16 - One of Two Integers in Range 20-50

    [TestMethod]
    public void IsOneOfTwoInRange20To50_Test()
    {
        // Arrange
        int num1, num2;
        bool result;

        // Act & Assert - Test case 1
        num1 = 20;
        num2 = 84;
        result = BasicAlgorithm.IsOneOfTwoInRange20To50(num1, num2);
        Assert.IsTrue(result);

        // Act & Assert - Test case 2
        num1 = 14;
        num2 = 50;
        result = BasicAlgorithm.IsOneOfTwoInRange20To50(num1, num2);
        Assert.IsTrue(result);

        // Act & Assert - Test case 3
        num1 = 11;
        num2 = 55;
        result = BasicAlgorithm.IsOneOfTwoInRange20To50(num1, num2);
        Assert.IsFalse(result);

        // Act & Assert - Test case 4
        num1 = 25;
        num2 = 40;
        result = BasicAlgorithm.IsOneOfTwoInRange20To50(num1, num2);
        Assert.IsTrue(result);

        // Act & Assert - Additional test cases
        num1 = 19;
        num2 = 51;
        result = BasicAlgorithm.IsOneOfTwoInRange20To50(num1, num2);
        Assert.IsFalse(result);

        num1 = 20;
        num2 = 50;
        result = BasicAlgorithm.IsOneOfTwoInRange20To50(num1, num2);
        Assert.IsTrue(result);

        num1 = 30;
        num2 = 10;
        result = BasicAlgorithm.IsOneOfTwoInRange20To50(num1, num2);
        Assert.IsTrue(result);
    }

    // Exercise 17 - Remove 'yt' at Index 1

    [TestMethod]
    public void RemoveYtIfAtPosition1_Test()
    {
        // Arrange
        string input;
        string result;

        // Act & Assert - Test case 1
        input = "Python";
        result = BasicAlgorithm.RemoveYtIfAtPosition1(input);
        Assert.AreEqual("Phon", result);

        // Act & Assert - Test case 2
        input = "ytade";
        result = BasicAlgorithm.RemoveYtIfAtPosition1(input);
        Assert.AreEqual("ytade", result);

        // Act & Assert - Test case 3
        input = "jsues";
        result = BasicAlgorithm.RemoveYtIfAtPosition1(input);
        Assert.AreEqual("jsues", result);

        // Act & Assert - Additional test cases
        input = "xytz";
        result = BasicAlgorithm.RemoveYtIfAtPosition1(input);
        Assert.AreEqual("xz", result);

        input = "aytb";
        result = BasicAlgorithm.RemoveYtIfAtPosition1(input);
        Assert.AreEqual("ab", result);

        input = "yt";
        result = BasicAlgorithm.RemoveYtIfAtPosition1(input);
        Assert.AreEqual("yt", result);

        input = "a";
        result = BasicAlgorithm.RemoveYtIfAtPosition1(input);
        Assert.AreEqual("a", result);

        input = "ab";
        result = BasicAlgorithm.RemoveYtIfAtPosition1(input);
        Assert.AreEqual("ab", result);
    }

    // Exercise 18 - Largest Among Three Integers

    [TestMethod]
    public void LargestAmongThree_Test()
    {
        // Arrange
        int num1, num2, num3;
        int result;

        // Act & Assert - Test case 1
        num1 = 1;
        num2 = 2;
        num3 = 3;
        result = BasicAlgorithm.LargestAmongThree(num1, num2, num3);
        Assert.AreEqual(3, result);

        // Act & Assert - Test case 2
        num1 = 1;
        num2 = 3;
        num3 = 2;
        result = BasicAlgorithm.LargestAmongThree(num1, num2, num3);
        Assert.AreEqual(3, result);

        // Act & Assert - Test case 3
        num1 = 1;
        num2 = 1;
        num3 = 1;
        result = BasicAlgorithm.LargestAmongThree(num1, num2, num3);
        Assert.AreEqual(1, result);

        // Act & Assert - Test case 4
        num1 = 1;
        num2 = 2;
        num3 = 2;
        result = BasicAlgorithm.LargestAmongThree(num1, num2, num3);
        Assert.AreEqual(2, result);

        // Act & Assert - Additional test cases
        num1 = -5;
        num2 = -2;
        num3 = -10;
        result = BasicAlgorithm.LargestAmongThree(num1, num2, num3);
        Assert.AreEqual(-2, result);

        num1 = 100;
        num2 = 50;
        num3 = 75;
        result = BasicAlgorithm.LargestAmongThree(num1, num2, num3);
        Assert.AreEqual(100, result);

        num1 = 0;
        num2 = 0;
        num3 = -1;
        result = BasicAlgorithm.LargestAmongThree(num1, num2, num3);
        Assert.AreEqual(0, result);
    }

    // Exercise 19 - Closest to 100 Between Two

    [TestMethod]
    public void ClosestTo100_Test()
    {
        // Arrange
        int num1, num2;
        int result;

        // Act & Assert - Test case 1
        num1 = 78;
        num2 = 95;
        result = BasicAlgorithm.ClosestTo100(num1, num2);
        Assert.AreEqual(95, result);

        // Act & Assert - Test case 2
        num1 = 95;
        num2 = 95;
        result = BasicAlgorithm.ClosestTo100(num1, num2);
        Assert.AreEqual(0, result);

        // Act & Assert - Test case 3
        num1 = 99;
        num2 = 70;
        result = BasicAlgorithm.ClosestTo100(num1, num2);
        Assert.AreEqual(99, result);

        // Act & Assert - Additional test cases
        num1 = 101;
        num2 = 99;
        result = BasicAlgorithm.ClosestTo100(num1, num2);
        Assert.AreEqual(99, result);

        num1 = 105;
        num2 = 110;
        result = BasicAlgorithm.ClosestTo100(num1, num2);
        Assert.AreEqual(105, result);

        num1 = 50;
        num2 = 150;
        result = BasicAlgorithm.ClosestTo100(num1, num2);
        Assert.AreEqual(50, result);

        num1 = 100;
        num2 = 100;
        result = BasicAlgorithm.ClosestTo100(num1, num2);
        Assert.AreEqual(0, result);

        // Act & Assert - Edge case: numbers equally distant from 100
        num1 = 98;
        num2 = 102;
        result = BasicAlgorithm.ClosestTo100(num1, num2);
        Assert.AreEqual(98, result);
    }

    // Exercise 20 - Both Integers in Ranges 40-50 or 50-60

    [TestMethod]
    public void BothInRanges40To50Or50To60_Test()
    {
        // Arrange
        int num1, num2;
        bool result;

        // Act & Assert - Test case 1
        num1 = 78;
        num2 = 95;
        result = BasicAlgorithm.BothInRanges40To50Or50To60(num1, num2);
        Assert.IsFalse(result);

        // Act & Assert - Test case 2
        num1 = 25;
        num2 = 35;
        result = BasicAlgorithm.BothInRanges40To50Or50To60(num1, num2);
        Assert.IsFalse(result);

        // Act & Assert - Test case 3
        num1 = 40;
        num2 = 50;
        result = BasicAlgorithm.BothInRanges40To50Or50To60(num1, num2);
        Assert.IsTrue(result);

        // Act & Assert - Test case 4
        num1 = 55;
        num2 = 60;
        result = BasicAlgorithm.BothInRanges40To50Or50To60(num1, num2);
        Assert.IsTrue(result);

        // Act & Assert - Additional test cases
        num1 = 45;
        num2 = 48;
        result = BasicAlgorithm.BothInRanges40To50Or50To60(num1, num2);
        Assert.IsTrue(result);

        num1 = 52;
        num2 = 58;
        result = BasicAlgorithm.BothInRanges40To50Or50To60(num1, num2);
        Assert.IsTrue(result);

        num1 = 40;
        num2 = 60;
        result = BasicAlgorithm.BothInRanges40To50Or50To60(num1, num2);
        Assert.IsFalse(result);

        num1 = 50;
        num2 = 50;
        result = BasicAlgorithm.BothInRanges40To50Or50To60(num1, num2);
        Assert.IsTrue(result);

        num1 = 39;
        num2 = 50;
        result = BasicAlgorithm.BothInRanges40To50Or50To60(num1, num2);
        Assert.IsFalse(result);
    }

    // Exercise 21 - Largest in Range 20-30

    [TestMethod]
    public void LargestInRange20To30_Test()
    {
        // Arrange
        int num1, num2;
        int result;

        // Act & Assert - Test case 1
        num1 = 78;
        num2 = 95;
        result = BasicAlgorithm.LargestInRange20To30(num1, num2);
        Assert.AreEqual(0, result);

        // Act & Assert - Test case 2
        num1 = 20;
        num2 = 30;
        result = BasicAlgorithm.LargestInRange20To30(num1, num2);
        Assert.AreEqual(30, result);

        // Act & Assert - Test case 3
        num1 = 21;
        num2 = 25;
        result = BasicAlgorithm.LargestInRange20To30(num1, num2);
        Assert.AreEqual(25, result);

        // Act & Assert - Test case 4
        num1 = 28;
        num2 = 28;
        result = BasicAlgorithm.LargestInRange20To30(num1, num2);
        Assert.AreEqual(28, result);

        // Act & Assert - Additional test cases
        num1 = 15;
        num2 = 25;
        result = BasicAlgorithm.LargestInRange20To30(num1, num2);
        Assert.AreEqual(25, result);

        num1 = 22;
        num2 = 35;
        result = BasicAlgorithm.LargestInRange20To30(num1, num2);
        Assert.AreEqual(22, result);

        num1 = 19;
        num2 = 31;
        result = BasicAlgorithm.LargestInRange20To30(num1, num2);
        Assert.AreEqual(0, result);

        num1 = 20;
        num2 = 20;
        result = BasicAlgorithm.LargestInRange20To30(num1, num2);
        Assert.AreEqual(20, result);

        num1 = 30;
        num2 = 30;
        result = BasicAlgorithm.LargestInRange20To30(num1, num2);
        Assert.AreEqual(30, result);
    }

    // Exercise 22 - Contains 2-4 'z' Characters

    [TestMethod]
    public void ContainsTwoToFourZ_Test()
    {
        // Arrange
        string input;
        bool result;

        // Act & Assert - Test case 1
        input = "frizz";
        result = BasicAlgorithm.ContainsTwoToFourZ(input);
        Assert.IsTrue(result);

        // Act & Assert - Test case 2
        input = "zane";
        result = BasicAlgorithm.ContainsTwoToFourZ(input);
        Assert.IsFalse(result);

        // Act & Assert - Test case 3
        input = "Zazz";
        result = BasicAlgorithm.ContainsTwoToFourZ(input);
        Assert.IsTrue(result);

        // Act & Assert - Test case 4
        input = "false";
        result = BasicAlgorithm.ContainsTwoToFourZ(input);
        Assert.IsFalse(result);

        // Act & Assert - Test case 5
        input = "zzzz";
        result = BasicAlgorithm.ContainsTwoToFourZ(input);
        Assert.IsTrue(result);

        // Act & Assert - Test case 6
        input = "ZZZZ";
        result = BasicAlgorithm.ContainsTwoToFourZ(input);
        Assert.IsFalse(result);

        // Act & Assert - Additional test cases
        input = "z";
        result = BasicAlgorithm.ContainsTwoToFourZ(input);
        Assert.IsFalse(result);

        input = "zz";
        result = BasicAlgorithm.ContainsTwoToFourZ(input);
        Assert.IsTrue(result);

        input = "zzz";
        result = BasicAlgorithm.ContainsTwoToFourZ(input);
        Assert.IsTrue(result);

        input = "zzzzz";
        result = BasicAlgorithm.ContainsTwoToFourZ(input);
        Assert.IsFalse(result);

        input = "pizza";
        result = BasicAlgorithm.ContainsTwoToFourZ(input);
        Assert.IsTrue(result);

        input = "";
        result = BasicAlgorithm.ContainsTwoToFourZ(input);
        Assert.IsFalse(result);
    }

    // Exercise 23 - Same Last Digit for Two Integers

    [TestMethod]
    public void HaveSameLastDigit_Test()
    {
        // Arrange
        int num1, num2;
        bool result;

        // Act & Assert - Test case 1
        num1 = 123;
        num2 = 456;
        result = BasicAlgorithm.HaveSameLastDigit(num1, num2);
        Assert.IsFalse(result);

        // Act & Assert - Test case 2
        num1 = 12;
        num2 = 512;
        result = BasicAlgorithm.HaveSameLastDigit(num1, num2);
        Assert.IsTrue(result);

        // Act & Assert - Test case 3
        num1 = 7;
        num2 = 87;
        result = BasicAlgorithm.HaveSameLastDigit(num1, num2);
        Assert.IsTrue(result);

        // Act & Assert - Test case 4
        num1 = 12;
        num2 = 45;
        result = BasicAlgorithm.HaveSameLastDigit(num1, num2);
        Assert.IsFalse(result);

        // Act & Assert - Additional test cases
        num1 = 0;
        num2 = 10;
        result = BasicAlgorithm.HaveSameLastDigit(num1, num2);
        Assert.IsTrue(result);

        num1 = 100;
        num2 = 200;
        result = BasicAlgorithm.HaveSameLastDigit(num1, num2);
        Assert.IsTrue(result);

        num1 = 123;
        num2 = 789;
        result = BasicAlgorithm.HaveSameLastDigit(num1, num2);
        Assert.IsFalse(result);

        num1 = 5;
        num2 = 15;
        result = BasicAlgorithm.HaveSameLastDigit(num1, num2);
        Assert.IsTrue(result);

        num1 = 99;
        num2 = 19;
        result = BasicAlgorithm.HaveSameLastDigit(num1, num2);
        Assert.IsTrue(result);
    }

    // Exercise 24 - Uppercase Last Three Characters

    [TestMethod]
    public void UppercaseLastThreeChars_Test()
    {
        // Arrange
        string input;
        string result;

        // Act & Assert - Test case 1
        input = "Python";
        result = BasicAlgorithm.UppercaseLastThreeChars(input);
        Assert.AreEqual("PytHON", result);

        // Act & Assert - Test case 2
        input = "Javascript";
        result = BasicAlgorithm.UppercaseLastThreeChars(input);
        Assert.AreEqual("JavascrIPT", result);

        // Act & Assert - Test case 3
        input = "js";
        result = BasicAlgorithm.UppercaseLastThreeChars(input);
        Assert.AreEqual("JS", result);

        // Act & Assert - Test case 4
        input = "PHP";
        result = BasicAlgorithm.UppercaseLastThreeChars(input);
        Assert.AreEqual("PHP", result);

        // Act & Assert - Additional test cases
        input = "a";
        result = BasicAlgorithm.UppercaseLastThreeChars(input);
        Assert.AreEqual("A", result);

        input = "ab";
        result = BasicAlgorithm.UppercaseLastThreeChars(input);
        Assert.AreEqual("AB", result);

        input = "abc";
        result = BasicAlgorithm.UppercaseLastThreeChars(input);
        Assert.AreEqual("ABC", result);

        input = "abcd";
        result = BasicAlgorithm.UppercaseLastThreeChars(input);
        Assert.AreEqual("aBCD", result);

        input = "hello world";
        result = BasicAlgorithm.UppercaseLastThreeChars(input);
        Assert.AreEqual("hello woRLD", result);

        input = "";
        result = BasicAlgorithm.UppercaseLastThreeChars(input);
        Assert.AreEqual("", result);
    }

    // Exercise 25 - n Copies of String

    [TestMethod]
    public void NCopiesOfString_Test()
    {
        // Arrange
        string input;
        int copies;
        string result;

        // Act & Assert - Test case 1
        input = "JS";
        copies = 2;
        result = BasicAlgorithm.NCopiesOfString(input, copies);
        Assert.AreEqual("JSJS", result);

        // Act & Assert - Test case 2
        input = "JS";
        copies = 3;
        result = BasicAlgorithm.NCopiesOfString(input, copies);
        Assert.AreEqual("JSJSJS", result);

        // Act & Assert - Test case 3
        input = "JS";
        copies = 1;
        result = BasicAlgorithm.NCopiesOfString(input, copies);
        Assert.AreEqual("JS", result);

        // Act & Assert - Additional test cases
        input = "Hello";
        copies = 0;
        result = BasicAlgorithm.NCopiesOfString(input, copies);
        Assert.AreEqual("", result);

        input = "A";
        copies = 5;
        result = BasicAlgorithm.NCopiesOfString(input, copies);
        Assert.AreEqual("AAAAA", result);

        input = "";
        copies = 3;
        result = BasicAlgorithm.NCopiesOfString(input, copies);
        Assert.AreEqual("", result);

        input = "Test";
        copies = 4;
        result = BasicAlgorithm.NCopiesOfString(input, copies);
        Assert.AreEqual("TestTestTestTest", result);

        input = "abc";
        copies = -1;
        result = BasicAlgorithm.NCopiesOfString(input, copies);
        Assert.AreEqual("", result);
    }

    // Exercise 26 - n Copies of First Three Characters

    [TestMethod]
    public void NCopiesOfFirstThreeChars_Test()
    {
        // Arrange
        string input;
        int copies;
        string result;

        // Act & Assert - Test case 1
        input = "Python";
        copies = 2;
        result = BasicAlgorithm.NCopiesOfFirstThreeChars(input, copies);
        Assert.AreEqual("PytPyt", result);

        // Act & Assert - Test case 2
        input = "Python";
        copies = 3;
        result = BasicAlgorithm.NCopiesOfFirstThreeChars(input, copies);
        Assert.AreEqual("PytPytPyt", result);

        // Act & Assert - Test case 3
        input = "JS";
        copies = 3;
        result = BasicAlgorithm.NCopiesOfFirstThreeChars(input, copies);
        Assert.AreEqual("JSJSJS", result);

        // Act & Assert - Additional test cases
        input = "A";
        copies = 4;
        result = BasicAlgorithm.NCopiesOfFirstThreeChars(input, copies);
        Assert.AreEqual("AAAA", result);

        input = "Hello";
        copies = 0;
        result = BasicAlgorithm.NCopiesOfFirstThreeChars(input, copies);
        Assert.AreEqual("", result);

        input = "";
        copies = 3;
        result = BasicAlgorithm.NCopiesOfFirstThreeChars(input, copies);
        Assert.AreEqual("", result);

        input = "Programming";
        copies = 2;
        result = BasicAlgorithm.NCopiesOfFirstThreeChars(input, copies);
        Assert.AreEqual("ProPro", result);

        input = "ab";
        copies = 5;
        result = BasicAlgorithm.NCopiesOfFirstThreeChars(input, copies);
        Assert.AreEqual("ababababab", result);

        input = "Test";
        copies = -1;
        result = BasicAlgorithm.NCopiesOfFirstThreeChars(input, copies);
        Assert.AreEqual("", result);
    }

    // Exercise 27 - Count 'aa' in String

    [TestMethod]
    public void CountAaInString_Test()
    {
        // Arrange
        string input;
        int result;

        // Act & Assert - Test case 1
        input = "bbaaccaag";
        result = BasicAlgorithm.CountAaInString(input);
        Assert.AreEqual(2, result);

        // Act & Assert - Test case 2
        input = "jjkiaaasew";
        result = BasicAlgorithm.CountAaInString(input);
        Assert.AreEqual(2, result);

        // Act & Assert - Test case 3
        input = "JSaaakoiaa";
        result = BasicAlgorithm.CountAaInString(input);
        Assert.AreEqual(3, result);

        // Act & Assert - Additional test cases
        input = "aaa";
        result = BasicAlgorithm.CountAaInString(input);
        Assert.AreEqual(2, result);

        input = "aaaa";
        result = BasicAlgorithm.CountAaInString(input);
        Assert.AreEqual(3, result);

        input = "aa";
        result = BasicAlgorithm.CountAaInString(input);
        Assert.AreEqual(1, result);

        input = "a";
        result = BasicAlgorithm.CountAaInString(input);
        Assert.AreEqual(0, result);

        input = "";
        result = BasicAlgorithm.CountAaInString(input);
        Assert.AreEqual(0, result);

        input = "abc";
        result = BasicAlgorithm.CountAaInString(input);
        Assert.AreEqual(0, result);

        input = "baab";
        result = BasicAlgorithm.CountAaInString(input);
        Assert.AreEqual(1, result);

        input = "aaabbaaa";
        result = BasicAlgorithm.CountAaInString(input);
        Assert.AreEqual(4, result);
    }

    // Exercise 28 - First 'a' Followed by Another 'a'

    [TestMethod]
    public void FirstAIsFollowedByAnotherA_Test()
    {
        // Arrange
        string input;
        bool result;

        // Act & Assert - Test case 1
        input = "caabb";
        result = BasicAlgorithm.FirstAIsFollowedByAnotherA(input);
        Assert.IsTrue(result);

        // Act & Assert - Test case 2
        input = "babaaba";
        result = BasicAlgorithm.FirstAIsFollowedByAnotherA(input);
        Assert.IsFalse(result);

        // Act & Assert - Test case 3
        input = "aaaaa";
        result = BasicAlgorithm.FirstAIsFollowedByAnotherA(input);
        Assert.IsTrue(result);

        // Act & Assert - Additional test cases
        input = "abc";
        result = BasicAlgorithm.FirstAIsFollowedByAnotherA(input);
        Assert.IsFalse(result);

        input = "a";
        result = BasicAlgorithm.FirstAIsFollowedByAnotherA(input);
        Assert.IsFalse(result);

        input = "aa";
        result = BasicAlgorithm.FirstAIsFollowedByAnotherA(input);
        Assert.IsTrue(result);

        input = "baa";
        result = BasicAlgorithm.FirstAIsFollowedByAnotherA(input);
        Assert.IsTrue(result);

        input = "xaya";
        result = BasicAlgorithm.FirstAIsFollowedByAnotherA(input);
        Assert.IsFalse(result);

        input = "nolettera";
        result = BasicAlgorithm.FirstAIsFollowedByAnotherA(input);
        Assert.IsFalse(result);

        input = "";
        result = BasicAlgorithm.FirstAIsFollowedByAnotherA(input);
        Assert.IsFalse(result);

        input = "aab";
        result = BasicAlgorithm.FirstAIsFollowedByAnotherA(input);
        Assert.IsTrue(result);
    }

    // Exercise 29 - Every Other Character in String

    [TestMethod]
    public void EveryOtherCharacter_Test()
    {
        // Arrange
        string input;
        string result;

        // Act & Assert - Test case 1
        input = "Python";
        result = BasicAlgorithm.EveryOtherCharacter(input);
        Assert.AreEqual("Pto", result);

        // Act & Assert - Test case 2
        input = "PHP";
        result = BasicAlgorithm.EveryOtherCharacter(input);
        Assert.AreEqual("PP", result);

        // Act & Assert - Test case 3
        input = "JS";
        result = BasicAlgorithm.EveryOtherCharacter(input);
        Assert.AreEqual("J", result);

        // Act & Assert - Additional test cases
        input = "Hello";
        result = BasicAlgorithm.EveryOtherCharacter(input);
        Assert.AreEqual("Hlo", result);

        input = "A";
        result = BasicAlgorithm.EveryOtherCharacter(input);
        Assert.AreEqual("A", result);

        input = "";
        result = BasicAlgorithm.EveryOtherCharacter(input);
        Assert.AreEqual("", result);

        input = "Programming";
        result = BasicAlgorithm.EveryOtherCharacter(input);
        Assert.AreEqual("Pormig", result);

        input = "abcdef";
        result = BasicAlgorithm.EveryOtherCharacter(input);
        Assert.AreEqual("ace", result);

        input = "123456";
        result = BasicAlgorithm.EveryOtherCharacter(input);
        Assert.AreEqual("135", result);

        input = "x";
        result = BasicAlgorithm.EveryOtherCharacter(input);
        Assert.AreEqual("x", result);
    }

    // Exercise 30 - Cumulative Substrings

    [TestMethod]
    public void CumulativeSubstrings_Test()
    {
        // Arrange
        string input;
        string result;

        // Act & Assert - Test case 1
        input = "abcd";
        result = BasicAlgorithm.CumulativeSubstrings(input);
        Assert.AreEqual("aababcabcd", result);

        // Act & Assert - Test case 2
        input = "abc";
        result = BasicAlgorithm.CumulativeSubstrings(input);
        Assert.AreEqual("aababc", result);

        // Act & Assert - Test case 3
        input = "a";
        result = BasicAlgorithm.CumulativeSubstrings(input);
        Assert.AreEqual("a", result);

        // Act & Assert - Additional test cases
        input = "xy";
        result = BasicAlgorithm.CumulativeSubstrings(input);
        Assert.AreEqual("xxy", result);

        input = "123";
        result = BasicAlgorithm.CumulativeSubstrings(input);
        Assert.AreEqual("112123", result);

        input = "";
        result = BasicAlgorithm.CumulativeSubstrings(input);
        Assert.AreEqual("", result);

        input = "ABCD";
        result = BasicAlgorithm.CumulativeSubstrings(input);
        Assert.AreEqual("AABABCABCD", result);

        input = "w";
        result = BasicAlgorithm.CumulativeSubstrings(input);
        Assert.AreEqual("w", result);

        input = "hello";
        result = BasicAlgorithm.CumulativeSubstrings(input);
        Assert.AreEqual("hhehelhellhello", result);
    }

    // Exercise 31 - Count Substring Matching Last Two Characters

    [TestMethod]
    public void CountSubstringMatchingLastTwo_Test()
    {
        // Arrange
        string input;
        int result;

        // Act & Assert - Test case 1
        input = "abcdsab";
        result = BasicAlgorithm.CountSubstringMatchingLastTwo(input);
        Assert.AreEqual(1, result);

        // Act & Assert - Test case 2
        input = "abcdabab";
        result = BasicAlgorithm.CountSubstringMatchingLastTwo(input);
        Assert.AreEqual(2, result);

        // Act & Assert - Test case 3
        input = "abcabdabab";
        result = BasicAlgorithm.CountSubstringMatchingLastTwo(input);
        Assert.AreEqual(3, result);

        // Act & Assert - Test case 4
        input = "abcabd";
        result = BasicAlgorithm.CountSubstringMatchingLastTwo(input);
        Assert.AreEqual(0, result);

        // Act & Assert - Additional test cases
        input = "ab";
        result = BasicAlgorithm.CountSubstringMatchingLastTwo(input);
        Assert.AreEqual(0, result);

        input = "a";
        result = BasicAlgorithm.CountSubstringMatchingLastTwo(input);
        Assert.AreEqual(0, result);

        input = "";
        result = BasicAlgorithm.CountSubstringMatchingLastTwo(input);
        Assert.AreEqual(0, result);

        input = "ababab";
        result = BasicAlgorithm.CountSubstringMatchingLastTwo(input);
        Assert.AreEqual(2, result);

        input = "xxxx";
        result = BasicAlgorithm.CountSubstringMatchingLastTwo(input);
        Assert.AreEqual(2, result);

        input = "hellohello";
        result = BasicAlgorithm.CountSubstringMatchingLastTwo(input);
        Assert.AreEqual(1, result);

        input = "abcabcabc";
        result = BasicAlgorithm.CountSubstringMatchingLastTwo(input);
        Assert.AreEqual(2, result);
    }

    // Exercise 32 - Check if Element Present in Array

    [TestMethod]
    public void IsElementPresent_Test()
    {
        // Arrange
        int[] numbers;
        int target;
        bool result;

        // Act & Assert - Test case 1
        numbers = new int[] { 1, 2, 9, 3 };
        target = 3;
        result = BasicAlgorithm.IsElementPresent(numbers, target);
        Assert.IsTrue(result);

        // Act & Assert - Test case 2
        numbers = new int[] { 1, 2, 2, 3 };
        target = 2;
        result = BasicAlgorithm.IsElementPresent(numbers, target);
        Assert.IsTrue(result);

        // Act & Assert - Test case 3
        numbers = new int[] { 1, 2, 2, 3 };
        target = 9;
        result = BasicAlgorithm.IsElementPresent(numbers, target);
        Assert.IsFalse(result);

        // Act & Assert - Additional test cases
        numbers = new int[] { 5 };
        target = 5;
        result = BasicAlgorithm.IsElementPresent(numbers, target);
        Assert.IsTrue(result);

        numbers = new int[] { 1, 3, 5, 7 };
        target = 4;
        result = BasicAlgorithm.IsElementPresent(numbers, target);
        Assert.IsFalse(result);

        numbers = new int[] { };
        target = 1;
        result = BasicAlgorithm.IsElementPresent(numbers, target);
        Assert.IsFalse(result);

        numbers = new int[] { 0, -1, 2, -3 };
        target = -1;
        result = BasicAlgorithm.IsElementPresent(numbers, target);
        Assert.IsTrue(result);

        numbers = new int[] { 10, 20, 30, 40, 50 };
        target = 30;
        result = BasicAlgorithm.IsElementPresent(numbers, target);
        Assert.IsTrue(result);
    }

    // Exercise 33 - Element in First 4 Positions of Array

    [TestMethod]
    public void IsElementInFirstFour_Test()
    {
        // Arrange
        int[] numbers;
        int target;
        bool result;

        // Act & Assert - Test case 1
        numbers = new int[] { 1, 2, 9, 3 };
        target = 3;
        result = BasicAlgorithm.IsElementInFirstFour(numbers, target);
        Assert.IsTrue(result);

        // Act & Assert - Test case 2
        numbers = new int[] { 1, 2, 3, 4, 5, 6 };
        target = 2;
        result = BasicAlgorithm.IsElementInFirstFour(numbers, target);
        Assert.IsTrue(result);

        // Act & Assert - Test case 3
        numbers = new int[] { 1, 2, 2, 3 };
        target = 9;
        result = BasicAlgorithm.IsElementInFirstFour(numbers, target);
        Assert.IsFalse(result);

        // Act & Assert - Additional test cases
        numbers = new int[] { 5 };
        target = 5;
        result = BasicAlgorithm.IsElementInFirstFour(numbers, target);
        Assert.IsTrue(result);

        numbers = new int[] { 1, 3, 5, 7, 9 };
        target = 9;
        result = BasicAlgorithm.IsElementInFirstFour(numbers, target);
        Assert.IsFalse(result);

        numbers = new int[] { };
        target = 1;
        result = BasicAlgorithm.IsElementInFirstFour(numbers, target);
        Assert.IsFalse(result);

        numbers = new int[] { 10, 20, 30 };
        target = 30;
        result = BasicAlgorithm.IsElementInFirstFour(numbers, target);
        Assert.IsTrue(result);

        numbers = new int[] { 0, -1, 2, -3, 4 };
        target = -3;
        result = BasicAlgorithm.IsElementInFirstFour(numbers, target);
        Assert.IsTrue(result);

        numbers = new int[] { 1, 2 };
        target = 3;
        result = BasicAlgorithm.IsElementInFirstFour(numbers, target);
        Assert.IsFalse(result);
    }

    // Exercise 34 - Check Sequence 1, 2, 3 in Array

    [TestMethod]
    public void ContainsSequence123_Test()
    {
        // Arrange
        int[] numbers;
        bool result;

        // Act & Assert - Test case 1
        numbers = new int[] { 1, 1, 2, 3, 1 };
        result = BasicAlgorithm.ContainsSequence123(numbers);
        Assert.IsTrue(result);

        // Act & Assert - Test case 2
        numbers = new int[] { 1, 1, 2, 4, 1 };
        result = BasicAlgorithm.ContainsSequence123(numbers);
        Assert.IsFalse(result);

        // Act & Assert - Test case 3
        numbers = new int[] { 1, 1, 2, 1, 2, 3 };
        result = BasicAlgorithm.ContainsSequence123(numbers);
        Assert.IsTrue(result);

        // Act & Assert - Additional test cases
        numbers = new int[] { 1, 2, 3 };
        result = BasicAlgorithm.ContainsSequence123(numbers);
        Assert.IsTrue(result);

        numbers = new int[] { 1, 2 };
        result = BasicAlgorithm.ContainsSequence123(numbers);
        Assert.IsFalse(result);

        numbers = new int[] { 1 };
        result = BasicAlgorithm.ContainsSequence123(numbers);
        Assert.IsFalse(result);

        numbers = new int[] { };
        result = BasicAlgorithm.ContainsSequence123(numbers);
        Assert.IsFalse(result);

        numbers = new int[] { 3, 2, 1 };
        result = BasicAlgorithm.ContainsSequence123(numbers);
        Assert.IsFalse(result);

        numbers = new int[] { 1, 3, 2, 1, 2, 3 };
        result = BasicAlgorithm.ContainsSequence123(numbers);
        Assert.IsTrue(result);

        numbers = new int[] { 0, 1, 2, 3, 4 };
        result = BasicAlgorithm.ContainsSequence123(numbers);
        Assert.IsTrue(result);

        numbers = new int[] { 1, 2, 2, 3 };
        result = BasicAlgorithm.ContainsSequence123(numbers);
        Assert.IsFalse(result);
    }

    // Exercise 35 - Count Matching Substrings in Two Strings

    [TestMethod]
    public void CountMatchingSubstrings_Test()
    {
        // Arrange
        string str1, str2;
        int result;

        // Act & Assert - Test case 1
        str1 = "abcdefgh";
        str2 = "abijsklm";
        result = BasicAlgorithm.CountMatchingSubstrings(str1, str2);
        Assert.AreEqual(1, result);

        // Act & Assert - Test case 2
        str1 = "abcde";
        str2 = "osuefrcd";
        result = BasicAlgorithm.CountMatchingSubstrings(str1, str2);
        Assert.AreEqual(1, result);

        // Act & Assert - Test case 3
        str1 = "pqrstuvwx";
        str2 = "pqkdiewx";
        result = BasicAlgorithm.CountMatchingSubstrings(str1, str2);
        Assert.AreEqual(2, result);

        // Act & Assert - Additional test cases
        str1 = "ab";
        str2 = "ab";
        result = BasicAlgorithm.CountMatchingSubstrings(str1, str2);
        Assert.AreEqual(1, result);

        str1 = "a";
        str2 = "b";
        result = BasicAlgorithm.CountMatchingSubstrings(str1, str2);
        Assert.AreEqual(0, result);

        str1 = "";
        str2 = "test";
        result = BasicAlgorithm.CountMatchingSubstrings(str1, str2);
        Assert.AreEqual(0, result);

        str1 = "hello";
        str2 = "hello";
        result = BasicAlgorithm.CountMatchingSubstrings(str1, str2);
        Assert.AreEqual(4, result);

        str1 = "abcd";
        str2 = "axcy";
        result = BasicAlgorithm.CountMatchingSubstrings(str1, str2);
        Assert.AreEqual(0, result);

        str1 = "1234";
        str2 = "1234";
        result = BasicAlgorithm.CountMatchingSubstrings(str1, str2);
        Assert.AreEqual(3, result);
    }

    // Exercise 36 - Remove Character Except First and Last

    [TestMethod]
    public void RemoveCharExceptFirstAndLast_Test()
    {
        // Arrange
        string input;
        char target;
        string result;

        // Act & Assert - Test case 1
        input = "xxHxix";
        target = 'x';
        result = BasicAlgorithm.RemoveCharExceptFirstAndLast(input, target);
        Assert.AreEqual("xHix", result);

        // Act & Assert - Test case 2
        input = "abxdddca";
        target = 'a';
        result = BasicAlgorithm.RemoveCharExceptFirstAndLast(input, target);
        Assert.AreEqual("abxdddca", result);

        // Act & Assert - Test case 3
        input = "xabjbhtrb";
        target = 'b';
        result = BasicAlgorithm.RemoveCharExceptFirstAndLast(input, target);
        Assert.AreEqual("xajhtrb", result);

        // Act & Assert - Additional test cases
        input = "aa";
        target = 'a';
        result = BasicAlgorithm.RemoveCharExceptFirstAndLast(input, target);
        Assert.AreEqual("aa", result);

        input = "a";
        target = 'a';
        result = BasicAlgorithm.RemoveCharExceptFirstAndLast(input, target);
        Assert.AreEqual("a", result);

        input = "";
        target = 'a';
        result = BasicAlgorithm.RemoveCharExceptFirstAndLast(input, target);
        Assert.AreEqual("", result);

        input = "hello";
        target = 'l';
        result = BasicAlgorithm.RemoveCharExceptFirstAndLast(input, target);
        Assert.AreEqual("heo", result);

        input = "banana";
        target = 'a';
        result = BasicAlgorithm.RemoveCharExceptFirstAndLast(input, target);
        Assert.AreEqual("bnna", result);

        input = "test";
        target = 't';
        result = BasicAlgorithm.RemoveCharExceptFirstAndLast(input, target);
        Assert.AreEqual("test", result);

        input = "abcabc";
        target = 'a';
        result = BasicAlgorithm.RemoveCharExceptFirstAndLast(input, target);
        Assert.AreEqual("abcbc", result);
    }

    // Exercise 37 - Characters at Index 0,1,4,5,...

    [TestMethod]
    public void CharactersAtSpecialIndexes_Test()
    {
        // Arrange
        string input;
        string result;

        // Act & Assert - Test case 1
        input = "Python";
        result = BasicAlgorithm.CharactersAtSpecialIndexes(input);
        Assert.AreEqual("Pyon", result);

        // Act & Assert - Test case 2
        input = "JavaScript";
        result = BasicAlgorithm.CharactersAtSpecialIndexes(input);
        Assert.AreEqual("JaScpt", result);

        // Act & Assert - Test case 3
        input = "HTML";
        result = BasicAlgorithm.CharactersAtSpecialIndexes(input);
        Assert.AreEqual("HT", result);

        // Act & Assert - Additional test cases
        input = "A";
        result = BasicAlgorithm.CharactersAtSpecialIndexes(input);
        Assert.AreEqual("A", result);

        input = "AB";
        result = BasicAlgorithm.CharactersAtSpecialIndexes(input);
        Assert.AreEqual("AB", result);

        input = "ABC";
        result = BasicAlgorithm.CharactersAtSpecialIndexes(input);
        Assert.AreEqual("AB", result);

        input = "ABCD";
        result = BasicAlgorithm.CharactersAtSpecialIndexes(input);
        Assert.AreEqual("AB", result);

        input = "ABCDE";
        result = BasicAlgorithm.CharactersAtSpecialIndexes(input);
        Assert.AreEqual("ABE", result);

        input = "ABCDEF";
        result = BasicAlgorithm.CharactersAtSpecialIndexes(input);
        Assert.AreEqual("ABEF", result);

        input = "ABCDEFGH";
        result = BasicAlgorithm.CharactersAtSpecialIndexes(input);
        Assert.AreEqual("ABEF", result);

        input = "";
        result = BasicAlgorithm.CharactersAtSpecialIndexes(input);
        Assert.AreEqual("", result);

        input = "1234567890";
        result = BasicAlgorithm.CharactersAtSpecialIndexes(input);
        Assert.AreEqual("125690", result);
    }

    // Exercise 38 - Count 5's Next to Each Other

    [TestMethod]
    public void CountFivesNextToEachOther_Test()
    {
        // Arrange
        int[] numbers;
        int result;

        // Act & Assert - Test case 1
        numbers = new int[] { 5, 5, 2 };
        result = BasicAlgorithm.CountFivesNextToEachOther(numbers);
        Assert.AreEqual(1, result);

        // Act & Assert - Test case 2
        numbers = new int[] { 5, 5, 2, 5, 5 };
        result = BasicAlgorithm.CountFivesNextToEachOther(numbers);
        Assert.AreEqual(2, result);

        // Act & Assert - Test case 3
        numbers = new int[] { 5, 6, 2, 9 };
        result = BasicAlgorithm.CountFivesNextToEachOther(numbers);
        Assert.AreEqual(1, result);

        // Act & Assert - Additional test cases
        numbers = new int[] { 5, 5, 5, 5 };
        result = BasicAlgorithm.CountFivesNextToEachOther(numbers);
        Assert.AreEqual(3, result);

        numbers = new int[] { 5, 6, 5, 6 };
        result = BasicAlgorithm.CountFivesNextToEachOther(numbers);
        Assert.AreEqual(2, result);

        numbers = new int[] { 1, 2, 3, 4 };
        result = BasicAlgorithm.CountFivesNextToEachOther(numbers);
        Assert.AreEqual(0, result);

        numbers = new int[] { 5 };
        result = BasicAlgorithm.CountFivesNextToEachOther(numbers);
        Assert.AreEqual(0, result);

        numbers = new int[] { };
        result = BasicAlgorithm.CountFivesNextToEachOther(numbers);
        Assert.AreEqual(0, result);

        numbers = new int[] { 5, 5 };
        result = BasicAlgorithm.CountFivesNextToEachOther(numbers);
        Assert.AreEqual(1, result);

        numbers = new int[] { 5, 6 };
        result = BasicAlgorithm.CountFivesNextToEachOther(numbers);
        Assert.AreEqual(1, result);

        numbers = new int[] { 6, 5 };
        result = BasicAlgorithm.CountFivesNextToEachOther(numbers);
        Assert.AreEqual(0, result);
    }

    // Exercise 39 - Check Triple in Array

    [TestMethod]
    public void HasTriple_Test()
    {
        // Arrange
        int[] numbers;
        bool result;

        // Act & Assert - Test case 1
        numbers = new int[] { 1, 1, 2, 2, 1 };
        result = BasicAlgorithm.HasTriple(numbers);
        Assert.IsFalse(result);

        // Act & Assert - Test case 2
        numbers = new int[] { 1, 1, 2, 1, 2, 3 };
        result = BasicAlgorithm.HasTriple(numbers);
        Assert.IsFalse(result);

        // Act & Assert - Test case 3
        numbers = new int[] { 1, 1, 1, 2, 2, 2, 1 };
        result = BasicAlgorithm.HasTriple(numbers);
        Assert.IsTrue(result);

        // Act & Assert - Additional test cases
        numbers = new int[] { 1, 1, 1 };
        result = BasicAlgorithm.HasTriple(numbers);
        Assert.IsTrue(result);

        numbers = new int[] { 1, 2, 3 };
        result = BasicAlgorithm.HasTriple(numbers);
        Assert.IsFalse(result);

        numbers = new int[] { 5, 5, 5, 5 };
        result = BasicAlgorithm.HasTriple(numbers);
        Assert.IsTrue(result);

        numbers = new int[] { 0, 0, 0 };
        result = BasicAlgorithm.HasTriple(numbers);
        Assert.IsTrue(result);

        numbers = new int[] { 1, 1 };
        result = BasicAlgorithm.HasTriple(numbers);
        Assert.IsFalse(result);

        numbers = new int[] { 1 };
        result = BasicAlgorithm.HasTriple(numbers);
        Assert.IsFalse(result);

        numbers = new int[] { };
        result = BasicAlgorithm.HasTriple(numbers);
        Assert.IsFalse(result);

        numbers = new int[] { 2, 2, 2, 1, 1, 1 };
        result = BasicAlgorithm.HasTriple(numbers);
        Assert.IsTrue(result);

        numbers = new int[] { 1, 2, 2, 2, 3 };
        result = BasicAlgorithm.HasTriple(numbers);
        Assert.IsTrue(result);
    }

    // Exercise 40 - Sum in Range 10-20 Returns 30

    [TestMethod]
    public void SumWithSpecialRule_Test()
    {
        // Arrange
        int a, b;
        int result;

        // Act & Assert - Test case 1
        a = 12;
        b = 17;
        result = BasicAlgorithm.SumWithSpecialRule(a, b);
        Assert.AreEqual(29, result);

        // Act & Assert - Test case 2
        a = 2;
        b = 17;
        result = BasicAlgorithm.SumWithSpecialRule(a, b);
        Assert.AreEqual(30, result);

        // Act & Assert - Test case 3
        a = 22;
        b = 17;
        result = BasicAlgorithm.SumWithSpecialRule(a, b);
        Assert.AreEqual(39, result);

        // Act & Assert - Test case 4
        a = 20;
        b = 0;
        result = BasicAlgorithm.SumWithSpecialRule(a, b);
        Assert.AreEqual(30, result);

        // Act & Assert - Additional test cases
        a = 10;
        b = 0;
        result = BasicAlgorithm.SumWithSpecialRule(a, b);
        Assert.AreEqual(30, result);

        a = 9;
        b = 1;
        result = BasicAlgorithm.SumWithSpecialRule(a, b);
        Assert.AreEqual(30, result);

        a = 20;
        b = 1;
        result = BasicAlgorithm.SumWithSpecialRule(a, b);
        Assert.AreEqual(21, result);

        a = 5;
        b = 4;
        result = BasicAlgorithm.SumWithSpecialRule(a, b);
        Assert.AreEqual(9, result);

        a = 15;
        b = 5;
        result = BasicAlgorithm.SumWithSpecialRule(a, b);
        Assert.AreEqual(30, result);

        a = 8;
        b = 12;
        result = BasicAlgorithm.SumWithSpecialRule(a, b);
        Assert.AreEqual(30, result);

        a = 0;
        b = 0;
        result = BasicAlgorithm.SumWithSpecialRule(a, b);
        Assert.AreEqual(0, result);

        a = -5;
        b = 15;
        result = BasicAlgorithm.SumWithSpecialRule(a, b);
        Assert.AreEqual(30, result);

        a = -10;
        b = 5;
        result = BasicAlgorithm.SumWithSpecialRule(a, b);
        Assert.AreEqual(-5, result);
    }

    // Exercise 41 - Check for 5 or Sum/Difference Equals 5

    [TestMethod]
    public void CheckFiveOrSumDiffFive_Test()
    {
        // Arrange
        int a, b;
        bool result;

        // Act & Assert - Test case 1
        a = 5;
        b = 4;
        result = BasicAlgorithm.CheckFiveOrSumDiffFive(a, b);
        Assert.IsTrue(result);

        // Act & Assert - Test case 2
        a = 4;
        b = 3;
        result = BasicAlgorithm.CheckFiveOrSumDiffFive(a, b);
        Assert.IsFalse(result);

        // Act & Assert - Test case 3
        a = 1;
        b = 4;
        result = BasicAlgorithm.CheckFiveOrSumDiffFive(a, b);
        Assert.IsTrue(result);

        // Act & Assert - Additional test cases
        a = 5;
        b = 0;
        result = BasicAlgorithm.CheckFiveOrSumDiffFive(a, b);
        Assert.IsTrue(result);

        a = 10;
        b = 5;
        result = BasicAlgorithm.CheckFiveOrSumDiffFive(a, b);
        Assert.IsTrue(result);

        a = 8;
        b = 3;
        result = BasicAlgorithm.CheckFiveOrSumDiffFive(a, b);
        Assert.IsTrue(result);

        a = 7;
        b = 2;
        result = BasicAlgorithm.CheckFiveOrSumDiffFive(a, b);
        Assert.IsTrue(result);

        a = 6;
        b = 1;
        result = BasicAlgorithm.CheckFiveOrSumDiffFive(a, b);
        Assert.IsTrue(result);

        a = 2;
        b = 2;
        result = BasicAlgorithm.CheckFiveOrSumDiffFive(a, b);
        Assert.IsFalse(result);

        a = 0;
        b = 5;
        result = BasicAlgorithm.CheckFiveOrSumDiffFive(a, b);
        Assert.IsTrue(result);

        a = -3;
        b = 8;
        result = BasicAlgorithm.CheckFiveOrSumDiffFive(a, b);
        Assert.IsTrue(result);

        a = -5;
        b = 0;
        result = BasicAlgorithm.CheckFiveOrSumDiffFive(a, b);
        Assert.IsTrue(result);

        a = 10;
        b = 15;
        result = BasicAlgorithm.CheckFiveOrSumDiffFive(a, b);
        Assert.IsTrue(result);
    }

    // Exercise 42 - Multiple of 13 or 1 More

    [TestMethod]
    public void IsMultipleOf13OrOneMore_Test()
    {
        // Arrange
        int number;
        bool result;

        // Act & Assert - Test case 1
        number = 13;
        result = BasicAlgorithm.IsMultipleOf13OrOneMore(number);
        Assert.IsTrue(result);

        // Act & Assert - Test case 2
        number = 14;
        result = BasicAlgorithm.IsMultipleOf13OrOneMore(number);
        Assert.IsTrue(result);

        // Act & Assert - Test case 3
        number = 27;
        result = BasicAlgorithm.IsMultipleOf13OrOneMore(number);
        Assert.IsTrue(result);

        // Act & Assert - Test case 4
        number = 41;
        result = BasicAlgorithm.IsMultipleOf13OrOneMore(number);
        Assert.IsFalse(result);

        // Act & Assert - Additional test cases
        number = 0;
        result = BasicAlgorithm.IsMultipleOf13OrOneMore(number);
        Assert.IsTrue(result);

        number = 1;
        result = BasicAlgorithm.IsMultipleOf13OrOneMore(number);
        Assert.IsTrue(result);

        number = 12;
        result = BasicAlgorithm.IsMultipleOf13OrOneMore(number);
        Assert.IsFalse(result);

        number = 26;
        result = BasicAlgorithm.IsMultipleOf13OrOneMore(number);
        Assert.IsTrue(result);

        number = 28;
        result = BasicAlgorithm.IsMultipleOf13OrOneMore(number);
        Assert.IsFalse(result);

        number = 39;
        result = BasicAlgorithm.IsMultipleOf13OrOneMore(number);
        Assert.IsTrue(result);

        number = 40;
        result = BasicAlgorithm.IsMultipleOf13OrOneMore(number);
        Assert.IsTrue(result);

        number = 52;
        result = BasicAlgorithm.IsMultipleOf13OrOneMore(number);
        Assert.IsTrue(result);

        number = 53;
        result = BasicAlgorithm.IsMultipleOf13OrOneMore(number);
        Assert.IsTrue(result);

        number = 54;
        result = BasicAlgorithm.IsMultipleOf13OrOneMore(number);
        Assert.IsFalse(result);
    }

    // Exercise 43 - Multiple of 3 or 7 but Not Both

    [TestMethod]
    public void IsMultipleOf3Or7ButNotBoth_Test()
    {
        // Arrange
        int number;
        bool result;

        // Act & Assert - Test case 1
        number = 3;
        result = BasicAlgorithm.IsMultipleOf3Or7ButNotBoth(number);
        Assert.IsTrue(result);

        // Act & Assert - Test case 2
        number = 7;
        result = BasicAlgorithm.IsMultipleOf3Or7ButNotBoth(number);
        Assert.IsTrue(result);

        // Act & Assert - Test case 3
        number = 21;
        result = BasicAlgorithm.IsMultipleOf3Or7ButNotBoth(number);
        Assert.IsFalse(result);

        // Act & Assert - Additional test cases
        number = 6;
        result = BasicAlgorithm.IsMultipleOf3Or7ButNotBoth(number);
        Assert.IsTrue(result);

        number = 14;
        result = BasicAlgorithm.IsMultipleOf3Or7ButNotBoth(number);
        Assert.IsTrue(result);

        number = 42;
        result = BasicAlgorithm.IsMultipleOf3Or7ButNotBoth(number);
        Assert.IsFalse(result);

        number = 0;
        result = BasicAlgorithm.IsMultipleOf3Or7ButNotBoth(number);
        Assert.IsFalse(result);

        number = 1;
        result = BasicAlgorithm.IsMultipleOf3Or7ButNotBoth(number);
        Assert.IsFalse(result);

        number = 9;
        result = BasicAlgorithm.IsMultipleOf3Or7ButNotBoth(number);
        Assert.IsTrue(result);

        number = 28;
        result = BasicAlgorithm.IsMultipleOf3Or7ButNotBoth(number);
        Assert.IsTrue(result);

        number = 63;
        result = BasicAlgorithm.IsMultipleOf3Or7ButNotBoth(number);
        Assert.IsFalse(result);

        number = 10;
        result = BasicAlgorithm.IsMultipleOf3Or7ButNotBoth(number);
        Assert.IsFalse(result);
    }

    // Exercise 44 - Within 2 of Multiple of 10

    [TestMethod]
    public void Within2OfMultipleOf10_Test()
    {
        // Arrange
        int number;
        bool result;

        // Act & Assert - Test case 1
        number = 3;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsFalse(result);

        // Act & Assert - Test case 2
        number = 7;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsFalse(result);

        // Act & Assert - Test case 3
        number = 8;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsTrue(result);

        // Act & Assert - Test case 4
        number = 21;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsTrue(result);

        // Act & Assert - Additional test cases
        number = 0;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsTrue(result);

        number = 1;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsTrue(result);

        number = 2;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsTrue(result);

        number = 3;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsFalse(result);

        number = 8;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsTrue(result);

        number = 9;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsTrue(result);

        number = 10;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsTrue(result);

        number = 11;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsTrue(result);

        number = 12;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsTrue(result);

        number = 13;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsFalse(result);

        number = 18;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsTrue(result);

        number = 19;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsTrue(result);

        number = 20;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsTrue(result);

        number = 27;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsFalse(result);

        number = 28;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsTrue(result);

        number = 29;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsTrue(result);

        number = 30;
        result = BasicAlgorithm.Within2OfMultipleOf10(number);
        Assert.IsTrue(result);
    }

    // Exercise 45 - Sum is 18 if One Value in 10-20 Range

    [TestMethod]
    public void SumWithSpecialRule_Tests()
    {
        // Arrange
        int a, b;
        int result;

        // Act & Assert - Test case 1
        a = 3;
        b = 7;
        result = BasicAlgorithm.SumWithSpecialRules(a, b);
        Assert.AreEqual(10, result);

        // Act & Assert - Test case 2
        a = 10;
        b = 11;
        result = BasicAlgorithm.SumWithSpecialRules(a, b);
        Assert.AreEqual(18, result);

        // Act & Assert - Test case 3
        a = 10;
        b = 20;
        result = BasicAlgorithm.SumWithSpecialRules(a, b);
        Assert.AreEqual(18, result);

        // Act & Assert - Test case 4
        a = 21;
        b = 220;
        result = BasicAlgorithm.SumWithSpecialRules(a, b);
        Assert.AreEqual(241, result);

        // Act & Assert - Additional test cases
        a = 9;
        b = 9;
        result = BasicAlgorithm.SumWithSpecialRules(a, b);
        Assert.AreEqual(18, result);

        a = 10;
        b = 5;
        result = BasicAlgorithm.SumWithSpecialRules(a, b);
        Assert.AreEqual(18, result);

        a = 20;
        b = 1;
        result = BasicAlgorithm.SumWithSpecialRules(a, b);
        Assert.AreEqual(18, result);

        a = 21;
        b = 1;
        result = BasicAlgorithm.SumWithSpecialRules(a, b);
        Assert.AreEqual(22, result);

        a = 0;
        b = 10;
        result = BasicAlgorithm.SumWithSpecialRules(a, b);
        Assert.AreEqual(18, result);

        a = 15;
        b = 15;
        result = BasicAlgorithm.SumWithSpecialRules(a, b);
        Assert.AreEqual(18, result);

        a = 5;
        b = 25;
        result = BasicAlgorithm.SumWithSpecialRules(a, b);
        Assert.AreEqual(30, result);

        a = 8;
        b = 12;
        result = BasicAlgorithm.SumWithSpecialRules(a, b);
        Assert.AreEqual(18, result);

        a = 19;
        b = 21;
        result = BasicAlgorithm.SumWithSpecialRules(a, b);
        Assert.AreEqual(18, result);

        a = 25;
        b = 30;
        result = BasicAlgorithm.SumWithSpecialRules(a, b);
        Assert.AreEqual(55, result);
    }

    // Exercise 46 - Fizz, Buzz, FizzBuzz

    [TestMethod]
    public void FizzBuzzCheck_Test()
    {
        // Arrange
        string input;
        string result;

        // Act & Assert - Test case 1
        input = "FizzBuzz";
        result = BasicAlgorithm.FizzBuzzCheck(input);
        Assert.AreEqual("Fizz", result);

        // Act & Assert - Test case 2
        input = "Fizz";
        result = BasicAlgorithm.FizzBuzzCheck(input);
        Assert.AreEqual("Fizz", result);

        // Act & Assert - Test case 3
        input = "Buzz";
        result = BasicAlgorithm.FizzBuzzCheck(input);
        Assert.AreEqual("Buzz", result);

        // Act & Assert - Test case 4
        input = "Founder";
        result = BasicAlgorithm.FizzBuzzCheck(input);
        Assert.AreEqual("Fizz", result);

        // Act & Assert - Additional test cases
        input = "TestB";
        result = BasicAlgorithm.FizzBuzzCheck(input);
        Assert.AreEqual("Buzz", result);

        input = "FB";
        result = BasicAlgorithm.FizzBuzzCheck(input);
        Assert.AreEqual("FizzBuzz", result);

        input = "Hello";
        result = BasicAlgorithm.FizzBuzzCheck(input);
        Assert.AreEqual("Hello", result);

        input = "F";
        result = BasicAlgorithm.FizzBuzzCheck(input);
        Assert.AreEqual("Fizz", result);

        input = "B";
        result = BasicAlgorithm.FizzBuzzCheck(input);
        Assert.AreEqual("Buzz", result);

        input = "";
        result = BasicAlgorithm.FizzBuzzCheck(input);
        Assert.AreEqual("", result);

        input = "FrontBack";
        result = BasicAlgorithm.FizzBuzzCheck(input);
        Assert.AreEqual("Fizz", result);

        input = "AmazingB";
        result = BasicAlgorithm.FizzBuzzCheck(input);
        Assert.AreEqual("Buzz", result);
    }

    // Exercise 47 - Sum of Two Equals Third

    [TestMethod]
    public void SumOfTwoEqualsThird_Test()
    {
        // Arrange
        int a, b, c;
        bool result;

        // Act & Assert - Test case 1
        a = 1;
        b = 2;
        c = 3;
        result = BasicAlgorithm.SumOfTwoEqualsThird(a, b, c);
        Assert.IsTrue(result);

        // Act & Assert - Test case 2
        a = 4;
        b = 5;
        c = 6;
        result = BasicAlgorithm.SumOfTwoEqualsThird(a, b, c);
        Assert.IsFalse(result);

        // Act & Assert - Test case 3
        a = -1;
        b = 1;
        c = 0;
        result = BasicAlgorithm.SumOfTwoEqualsThird(a, b, c);
        Assert.IsTrue(result);

        // Act & Assert - Additional test cases
        a = 5;
        b = 3;
        c = 2;
        result = BasicAlgorithm.SumOfTwoEqualsThird(a, b, c);
        Assert.IsTrue(result);

        a = 10;
        b = 5;
        c = 5;
        result = BasicAlgorithm.SumOfTwoEqualsThird(a, b, c);
        Assert.IsTrue(result);

        a = 7;
        b = 7;
        c = 14;
        result = BasicAlgorithm.SumOfTwoEqualsThird(a, b, c);
        Assert.IsTrue(result);

        a = 0;
        b = 0;
        c = 0;
        result = BasicAlgorithm.SumOfTwoEqualsThird(a, b, c);
        Assert.IsTrue(result);

        a = 1;
        b = 2;
        c = 4;
        result = BasicAlgorithm.SumOfTwoEqualsThird(a, b, c);
        Assert.IsFalse(result);

        a = -5;
        b = -3;
        c = -8;
        result = BasicAlgorithm.SumOfTwoEqualsThird(a, b, c);
        Assert.IsTrue(result);

        a = 100;
        b = 50;
        c = 50;
        result = BasicAlgorithm.SumOfTwoEqualsThird(a, b, c);
        Assert.IsTrue(result);

        a = 8;
        b = 4;
        c = 3;
        result = BasicAlgorithm.SumOfTwoEqualsThird(a, b, c);
        Assert.IsFalse(result);
    }

    // Exercise 48 - Strict Increasing Order for Three Numbers

    [TestMethod]
    public void IsStrictlyIncreasing_Test()
    {
        // Arrange
        int x, y, z;
        bool result;

        // Act & Assert - Test case 1
        x = 1;
        y = 2;
        z = 3;
        result = BasicAlgorithm.IsStrictlyIncreasing(x, y, z);
        Assert.IsTrue(result);

        // Act & Assert - Test case 2
        x = 4;
        y = 5;
        z = 6;
        result = BasicAlgorithm.IsStrictlyIncreasing(x, y, z);
        Assert.IsTrue(result);

        // Act & Assert - Test case 3
        x = -1;
        y = 1;
        z = 0;
        result = BasicAlgorithm.IsStrictlyIncreasing(x, y, z);
        Assert.IsFalse(result);

        // Act & Assert - Additional test cases
        x = 0;
        y = 1;
        z = 2;
        result = BasicAlgorithm.IsStrictlyIncreasing(x, y, z);
        Assert.IsTrue(result);

        x = 5;
        y = 5;
        z = 6;
        result = BasicAlgorithm.IsStrictlyIncreasing(x, y, z);
        Assert.IsFalse(result);

        x = 10;
        y = 9;
        z = 8;
        result = BasicAlgorithm.IsStrictlyIncreasing(x, y, z);
        Assert.IsFalse(result);

        x = -5;
        y = -3;
        z = -1;
        result = BasicAlgorithm.IsStrictlyIncreasing(x, y, z);
        Assert.IsTrue(result);

        x = 1;
        y = 3;
        z = 2;
        result = BasicAlgorithm.IsStrictlyIncreasing(x, y, z);
        Assert.IsFalse(result);

        x = 100;
        y = 200;
        z = 300;
        result = BasicAlgorithm.IsStrictlyIncreasing(x, y, z);
        Assert.IsTrue(result);

        x = 0;
        y = 0;
        z = 0;
        result = BasicAlgorithm.IsStrictlyIncreasing(x, y, z);
        Assert.IsFalse(result);

        x = -10;
        y = -5;
        z = 0;
        result = BasicAlgorithm.IsStrictlyIncreasing(x, y, z);
        Assert.IsTrue(result);
    }

    // Exercise 49 - Strictly Increasing or Equal if Flag True

    [TestMethod]
    public void CheckIncreasingOrder_Test()
    {
        // Arrange
        int a, b, c;
        bool allowEquality;
        bool result;

        // Act & Assert - Test case 1
        a = 1;
        b = 2;
        c = 3;
        allowEquality = false;
        result = BasicAlgorithm.CheckIncreasingOrder(a, b, c, allowEquality);
        Assert.IsTrue(result);

        // Act & Assert - Test case 2
        a = 1;
        b = 2;
        c = 3;
        allowEquality = true;
        result = BasicAlgorithm.CheckIncreasingOrder(a, b, c, allowEquality);
        Assert.IsTrue(result);

        // Act & Assert - Test case 3
        a = 10;
        b = 2;
        c = 30;
        allowEquality = false;
        result = BasicAlgorithm.CheckIncreasingOrder(a, b, c, allowEquality);
        Assert.IsFalse(result);

        // Act & Assert - Test case 4
        a = 10;
        b = 10;
        c = 30;
        allowEquality = true;
        result = BasicAlgorithm.CheckIncreasingOrder(a, b, c, allowEquality);
        Assert.IsTrue(result);

        // Act & Assert - Additional test cases
        a = 5;
        b = 5;
        c = 5;
        allowEquality = true;
        result = BasicAlgorithm.CheckIncreasingOrder(a, b, c, allowEquality);
        Assert.IsTrue(result);

        a = 5;
        b = 5;
        c = 5;
        allowEquality = false;
        result = BasicAlgorithm.CheckIncreasingOrder(a, b, c, allowEquality);
        Assert.IsFalse(result);

        a = 6;
        b = 6;
        c = 8;
        allowEquality = true;
        result = BasicAlgorithm.CheckIncreasingOrder(a, b, c, allowEquality);
        Assert.IsTrue(result);

        a = 6;
        b = 6;
        c = 8;
        allowEquality = false;
        result = BasicAlgorithm.CheckIncreasingOrder(a, b, c, allowEquality);
        Assert.IsFalse(result);

        a = 7;
        b = 8;
        c = 9;
        allowEquality = false;
        result = BasicAlgorithm.CheckIncreasingOrder(a, b, c, allowEquality);
        Assert.IsTrue(result);

        a = 7;
        b = 8;
        c = 9;
        allowEquality = true;
        result = BasicAlgorithm.CheckIncreasingOrder(a, b, c, allowEquality);
        Assert.IsTrue(result);

        a = 10;
        b = 15;
        c = 10;
        allowEquality = true;
        result = BasicAlgorithm.CheckIncreasingOrder(a, b, c, allowEquality);
        Assert.IsFalse(result);

        a = 10;
        b = 15;
        c = 10;
        allowEquality = false;
        result = BasicAlgorithm.CheckIncreasingOrder(a, b, c, allowEquality);
        Assert.IsFalse(result);

        a = -5;
        b = 0;
        c = 5;
        allowEquality = false;
        result = BasicAlgorithm.CheckIncreasingOrder(a, b, c, allowEquality);
        Assert.IsTrue(result);
    }

    // Exercise 50 - Same Rightmost Digit in Two or More Integers

    [TestMethod]
    public void SameRightmostDigit_Test()
    {
        // Arrange
        int[] numbers;
        bool result;

        // Act & Assert - Test case 1
        numbers = new int[] { 11, 21, 31 };
        result = BasicAlgorithm.SameRightmostDigit(numbers);
        Assert.IsTrue(result);

        // Act & Assert - Test case 2
        numbers = new int[] { 11, 22, 31 };
        result = BasicAlgorithm.SameRightmostDigit(numbers);
        Assert.IsTrue(result);

        // Act & Assert - Test case 3
        numbers = new int[] { 11, 22, 33 };
        result = BasicAlgorithm.SameRightmostDigit(numbers);
        Assert.IsFalse(result);

        // Act & Assert - Additional test cases
        numbers = new int[] { 5, 15, 25 };
        result = BasicAlgorithm.SameRightmostDigit(numbers);
        Assert.IsTrue(result);

        numbers = new int[] { 1, 2, 3 };
        result = BasicAlgorithm.SameRightmostDigit(numbers);
        Assert.IsFalse(result);

        numbers = new int[] { 10, 20, 30 };
        result = BasicAlgorithm.SameRightmostDigit(numbers);
        Assert.IsTrue(result);

        numbers = new int[] { 123, 456, 789 };
        result = BasicAlgorithm.SameRightmostDigit(numbers);
        Assert.IsFalse(result);

        numbers = new int[] { 17, 27, 37, 47 };
        result = BasicAlgorithm.SameRightmostDigit(numbers);
        Assert.IsTrue(result);

        numbers = new int[] { 14, 24, 34, 45 };
        result = BasicAlgorithm.SameRightmostDigit(numbers);
        Assert.IsTrue(result);

        numbers = new int[] { 0, 10, 20 };
        result = BasicAlgorithm.SameRightmostDigit(numbers);
        Assert.IsTrue(result);

        numbers = new int[] { 99, 199, 299 };
        result = BasicAlgorithm.SameRightmostDigit(numbers);
        Assert.IsTrue(result);

        numbers = new int[] { 100, 201, 302 };
        result = BasicAlgorithm.SameRightmostDigit(numbers);
        Assert.IsFalse(result);

        numbers = new int[] { 7 };
        result = BasicAlgorithm.SameRightmostDigit(numbers);
        Assert.IsFalse(result);

        numbers = new int[] { };
        result = BasicAlgorithm.SameRightmostDigit(numbers);
        Assert.IsFalse(result);
    }
}
