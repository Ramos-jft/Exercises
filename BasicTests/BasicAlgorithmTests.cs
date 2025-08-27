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

    // Exercise 51 - Check if One Integer 20 Less Than Another

    [TestMethod]
    public void CheckInteger20Less_11_21_31_ReturnsTrue()
    {
        // Arrange
        int a = 11, b = 21, c = 31;

        // Act
        bool result = BasicAlgorithm.CheckInteger20Less(a, b, c);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CheckInteger20Less_11_22_31_ReturnsTrue()
    {
        // Arrange
        int a = 11, b = 22, c = 31;

        // Act
        bool result = BasicAlgorithm.CheckInteger20Less(a, b, c);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CheckInteger20Less_10_20_15_ReturnsFalse()
    {
        // Arrange
        int a = 10, b = 20, c = 15;

        // Act
        bool result = BasicAlgorithm.CheckInteger20Less(a, b, c);

        // Assert
        Assert.IsFalse(result);
    }

    // Exercise 52 - Largest of Two Integers or Smallest if Same Remainder by 7

    [TestMethod]
    public void LargestOrSmallestBy7_11_21_Returns21()
    {
        // Arrange
        int a = 11, b = 21;

        // Act
        int result = BasicAlgorithm.LargestOrSmallestBy7(a, b);

        // Assert
        Assert.AreEqual(21, result);
    }

    [TestMethod]
    public void LargestOrSmallestBy7_11_20_Returns20()
    {
        // Arrange
        int a = 11, b = 20;

        // Act
        int result = BasicAlgorithm.LargestOrSmallestBy7(a, b);

        // Assert
        Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void LargestOrSmallestBy7_10_10_Returns0()
    {
        // Arrange
        int a = 10, b = 10;

        // Act
        int result = BasicAlgorithm.LargestOrSmallestBy7(a, b);

        // Assert
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void LargestOrSmallestBy7_14_28_Returns14()
    {
        // Arrange
        int a = 14, b = 28;

        // Act
        int result = BasicAlgorithm.LargestOrSmallestBy7(a, b);

        // Assert
        Assert.AreEqual(14, result);
    }

    // Exercise 53 - Digit Appears in Both Integers

    [TestMethod]
    public void DigitAppearsInBoth_11_21_ReturnsTrue()
    {
        // Arrange
        int a = 11, b = 21;

        // Act
        bool result = BasicAlgorithm.DigitAppearsInBoth(a, b);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void DigitAppearsInBoth_11_20_ReturnsFalse()
    {
        // Arrange
        int a = 11, b = 20;

        // Act
        bool result = BasicAlgorithm.DigitAppearsInBoth(a, b);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void DigitAppearsInBoth_10_10_ReturnsTrue()
    {
        // Arrange
        int a = 10, b = 10;

        // Act
        bool result = BasicAlgorithm.DigitAppearsInBoth(a, b);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void DigitAppearsInBoth_13_33_ReturnsTrue()
    {
        // Arrange
        int a = 13, b = 33;

        // Act
        bool result = BasicAlgorithm.DigitAppearsInBoth(a, b);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void DigitAppearsInBoth_12_34_ReturnsFalse()
    {
        // Arrange
        int a = 12, b = 34;

        // Act
        bool result = BasicAlgorithm.DigitAppearsInBoth(a, b);

        // Assert
        Assert.IsFalse(result);
    }

    // Exercise 54 - Sum of Integers with Same Digit Count

    [TestMethod]
    public void SumIfSameDigitCount_TestCases()
    {
        // Arrange
        int x1 = 4, y1 = 5;
        int x2 = 7, y2 = 4;
        int x3 = 10, y3 = 10;

        // Act
        int result1 = BasicAlgorithm.SumIfSameDigitCount(x1, y1);
        int result2 = BasicAlgorithm.SumIfSameDigitCount(x2, y2);
        int result3 = BasicAlgorithm.SumIfSameDigitCount(x3, y3);

        // Assert
        Assert.AreEqual(9, result1);
        Assert.AreEqual(7, result2);
        Assert.AreEqual(20, result3);
    }

    [TestMethod]
    public void SumIfSameDigitCount_EdgeCases()
    {
        // Arrange
        int x1 = 0, y1 = 5;
        int x2 = 99, y2 = 1;
        int x3 = 100, y3 = 900;

        // Act
        int result1 = BasicAlgorithm.SumIfSameDigitCount(x1, y1);
        int result2 = BasicAlgorithm.SumIfSameDigitCount(x2, y2);
        int result3 = BasicAlgorithm.SumIfSameDigitCount(x3, y3);

        // Assert
        Assert.AreEqual(5, result1);
        Assert.AreEqual(99, result2);
        Assert.AreEqual(100, result3);
    }

    // Exercise 55 - Sum of Three Integers or Return Third if Two Match

    [TestMethod]
    public void SumOrThirdIfTwoMatch_TestCases()
    {
        // Arrange
        int a1 = 4, b1 = 5, c1 = 7;
        int a2 = 7, b2 = 4, c2 = 12;
        int a3 = 10, b3 = 10, c3 = 12;
        int a4 = 12, b4 = 12, c4 = 18;

        // Act
        int result1 = BasicAlgorithm.SumOrThirdIfTwoMatch(a1, b1, c1);
        int result2 = BasicAlgorithm.SumOrThirdIfTwoMatch(a2, b2, c2);
        int result3 = BasicAlgorithm.SumOrThirdIfTwoMatch(a3, b3, c3);
        int result4 = BasicAlgorithm.SumOrThirdIfTwoMatch(a4, b4, c4);

        // Assert
        Assert.AreEqual(16, result1);
        Assert.AreEqual(23, result2);
        Assert.AreEqual(12, result3);
        Assert.AreEqual(18, result4);
    }

    [TestMethod]
    public void SumOrThirdIfTwoMatch_EdgeCases()
    {
        // Arrange
        int a1 = 0, b1 = 0, c1 = 5;
        int a2 = 5, b2 = 5, c2 = 5;
        int a3 = -3, b3 = -3, c3 = 10;
        int a4 = 1, b4 = 2, c4 = 3;

        // Act
        int result1 = BasicAlgorithm.SumOrThirdIfTwoMatch(a1, b1, c1);
        int result2 = BasicAlgorithm.SumOrThirdIfTwoMatch(a2, b2, c2);
        int result3 = BasicAlgorithm.SumOrThirdIfTwoMatch(a3, b3, c3);
        int result4 = BasicAlgorithm.SumOrThirdIfTwoMatch(a4, b4, c4);

        // Assert
        Assert.AreEqual(5, result1);
        Assert.AreEqual(5, result2);
        Assert.AreEqual(10, result3);
        Assert.AreEqual(6, result4);
    }

    // Exercise 56 - Sum of Three Integers Ignoring 13 and Right

    [TestMethod]
    public void SumIgnoring13AndRight_TestCases()
    {
        // Arrange
        int a1 = 4, b1 = 5, c1 = 7;
        int a2 = 7, b2 = 4, c2 = 12;
        int a3 = 10, b3 = 13, c3 = 12;
        int a4 = 13, b4 = 12, c4 = 18;

        // Act
        int result1 = BasicAlgorithm.SumIgnoring13AndRight(a1, b1, c1);
        int result2 = BasicAlgorithm.SumIgnoring13AndRight(a2, b2, c2);
        int result3 = BasicAlgorithm.SumIgnoring13AndRight(a3, b3, c3);
        int result4 = BasicAlgorithm.SumIgnoring13AndRight(a4, b4, c4);

        // Assert
        Assert.AreEqual(16, result1);
        Assert.AreEqual(23, result2);
        Assert.AreEqual(10, result3);
        Assert.AreEqual(0, result4);
    }

    [TestMethod]
    public void SumIgnoring13AndRight_EdgeCases()
    {
        // Arrange
        int a1 = 13, b1 = 13, c1 = 13;
        int a2 = 1, b2 = 13, c2 = 13;
        int a3 = 5, b3 = 6, c3 = 13;
        int a4 = 2, b4 = 3, c4 = 4;
        int a5 = 0, b5 = 13, c5 = 5;

        // Act
        int result1 = BasicAlgorithm.SumIgnoring13AndRight(a1, b1, c1);
        int result2 = BasicAlgorithm.SumIgnoring13AndRight(a2, b2, c2);
        int result3 = BasicAlgorithm.SumIgnoring13AndRight(a3, b3, c3);
        int result4 = BasicAlgorithm.SumIgnoring13AndRight(a4, b4, c4);
        int result5 = BasicAlgorithm.SumIgnoring13AndRight(a5, b5, c5);

        // Assert
        Assert.AreEqual(0, result1);
        Assert.AreEqual(1, result2);
        Assert.AreEqual(11, result3);
        Assert.AreEqual(9, result4);
        Assert.AreEqual(0, result5);
    }

    // Exercise 57 - Sum Ignoring 10-20 Except 13, 17

    [TestMethod]
    public void SumIgnoring10To20Except13And17_TestCases()
    {
        // Arrange
        int a1 = 4, b1 = 5, c1 = 7;
        int a2 = 7, b2 = 4, c2 = 12;
        int a3 = 10, b3 = 13, c3 = 12;
        int a4 = 14, b4 = 15, c4 = 16;

        // Act
        int result1 = BasicAlgorithm.SumIgnoring10To20Except13And17(a1, b1, c1);
        int result2 = BasicAlgorithm.SumIgnoring10To20Except13And17(a2, b2, c2);
        int result3 = BasicAlgorithm.SumIgnoring10To20Except13And17(a3, b3, c3);
        int result4 = BasicAlgorithm.SumIgnoring10To20Except13And17(a4, b4, c4);

        // Assert
        Assert.AreEqual(16, result1);
        Assert.AreEqual(11, result2);
        Assert.AreEqual(13, result3);
        Assert.AreEqual(0, result4);
    }

    [TestMethod]
    public void SumIgnoring10To20Except13And17_EdgeCases()
    {
        // Arrange
        int a1 = 13, b1 = 17, c1 = 19;
        int a2 = 9, b2 = 10, c2 = 20;
        int a3 = 8, b3 = 13, c3 = 21;
        int a4 = 17, b4 = 18, c4 = 19;
        int a5 = 1, b5 = 2, c5 = 3;

        // Act
        int result1 = BasicAlgorithm.SumIgnoring10To20Except13And17(a1, b1, c1);
        int result2 = BasicAlgorithm.SumIgnoring10To20Except13And17(a2, b2, c2);
        int result3 = BasicAlgorithm.SumIgnoring10To20Except13And17(a3, b3, c3);
        int result4 = BasicAlgorithm.SumIgnoring10To20Except13And17(a4, b4, c4);
        int result5 = BasicAlgorithm.SumIgnoring10To20Except13And17(a5, b5, c5);

        // Assert
        Assert.AreEqual(30, result1);
        Assert.AreEqual(9, result2);
        Assert.AreEqual(42, result3);
        Assert.AreEqual(17, result4);
        Assert.AreEqual(6, result5);
    }

    // Exercise 58 - Nearest to 13 Without Crossing

    [TestMethod]
    public void NearestTo13WithoutCrossing_TestCases()
    {
        // Arrange
        int a1 = 4, b1 = 5;
        int a2 = 7, b2 = 12;
        int a3 = 10, b3 = 13;
        int a4 = 17, b4 = 33;

        // Act
        int result1 = BasicAlgorithm.NearestTo13WithoutCrossing(a1, b1);
        int result2 = BasicAlgorithm.NearestTo13WithoutCrossing(a2, b2);
        int result3 = BasicAlgorithm.NearestTo13WithoutCrossing(a3, b3);
        int result4 = BasicAlgorithm.NearestTo13WithoutCrossing(a4, b4);

        // Assert
        Assert.AreEqual(5, result1);
        Assert.AreEqual(12, result2);
        Assert.AreEqual(13, result3);
        Assert.AreEqual(0, result4);
    }

    [TestMethod]
    public void NearestTo13WithoutCrossing_EdgeCases()
    {
        // Arrange
        int a1 = 13, b1 = 13;
        int a2 = 12, b2 = 14;
        int a3 = 11, b3 = 15;
        int a4 = 0, b4 = 13;
        int a5 = 14, b5 = 15;
        int a6 = 10, b6 = 10;

        // Act
        int result1 = BasicAlgorithm.NearestTo13WithoutCrossing(a1, b1);
        int result2 = BasicAlgorithm.NearestTo13WithoutCrossing(a2, b2);
        int result3 = BasicAlgorithm.NearestTo13WithoutCrossing(a3, b3);
        int result4 = BasicAlgorithm.NearestTo13WithoutCrossing(a4, b4);
        int result5 = BasicAlgorithm.NearestTo13WithoutCrossing(a5, b5);
        int result6 = BasicAlgorithm.NearestTo13WithoutCrossing(a6, b6);

        // Assert
        Assert.AreEqual(13, result1);
        Assert.AreEqual(12, result2);
        Assert.AreEqual(11, result3);
        Assert.AreEqual(13, result4);
        Assert.AreEqual(0, result5);
        Assert.AreEqual(10, result6);
    }

    // Exercise 59 - Check Equal Differences in Three Integers

    [TestMethod]
    public void CheckEqualDifferences_TestCases()
    {
        // Arrange
        int a1 = 4, b1 = 5, c1 = 6;
        int a2 = 7, b2 = 12, c2 = 13;
        int a3 = -1, b3 = 0, c3 = 1;

        // Act
        bool result1 = BasicAlgorithm.CheckEqualDifferences(a1, b1, c1);
        bool result2 = BasicAlgorithm.CheckEqualDifferences(a2, b2, c2);
        bool result3 = BasicAlgorithm.CheckEqualDifferences(a3, b3, c3);

        // Assert
        Assert.IsTrue(result1);
        Assert.IsFalse(result2);
        Assert.IsTrue(result3);
    }

    [TestMethod]
    public void CheckEqualDifferences_EdgeCases()
    {
        // Arrange
        int a1 = 1, b1 = 1, c1 = 1;
        int a2 = 2, b2 = 4, c2 = 6;
        int a3 = 10, b3 = 5, c3 = 0;
        int a4 = 3, b4 = 1, c4 = 5;
        int a5 = -5, b5 = 0, c5 = 5;

        // Act
        bool result1 = BasicAlgorithm.CheckEqualDifferences(a1, b1, c1);
        bool result2 = BasicAlgorithm.CheckEqualDifferences(a2, b2, c2);
        bool result3 = BasicAlgorithm.CheckEqualDifferences(a3, b3, c3);
        bool result4 = BasicAlgorithm.CheckEqualDifferences(a4, b4, c4);
        bool result5 = BasicAlgorithm.CheckEqualDifferences(a5, b5, c5);

        // Assert
        Assert.IsTrue(result1);
        Assert.IsTrue(result2);
        Assert.IsTrue(result3);
        Assert.IsTrue(result4);
        Assert.IsTrue(result5);
    }

    [TestMethod]
    public void CheckEqualDifferences_WithUnsortedNumbers()
    {
        // Arrange
        int a1 = 6, b1 = 4, c1 = 5;
        int a2 = 12, b2 = 7, c2 = 13;
        int a3 = 0, b3 = -1, c3 = 1;

        // Act
        bool result1 = BasicAlgorithm.CheckEqualDifferences(a1, b1, c1);
        bool result2 = BasicAlgorithm.CheckEqualDifferences(a2, b2, c2);
        bool result3 = BasicAlgorithm.CheckEqualDifferences(a3, b3, c3);

        // Assert 
        Assert.IsTrue(result1);
        Assert.IsFalse(result2);
        Assert.IsTrue(result3);
    }

    // Exercise 60 - String Format s1s2s2s1

    [TestMethod]
    public void CreateS1S2S2S1String_TestCases()
    {
        // Arrange
        string s1_1 = "Hi", s2_1 = "Hello";
        string s1_2 = "whats", s2_2 = "app";

        // Act
        string result1 = BasicAlgorithm.CreateS1S2S2S1String(s1_1, s2_1);
        string result2 = BasicAlgorithm.CreateS1S2S2S1String(s1_2, s2_2);

        // Assert
        Assert.AreEqual("HiHelloHelloHi", result1);
        Assert.AreEqual("whatsappappwhats", result2);
    }

    [TestMethod]
    public void CreateS1S2S2S1String_EdgeCases()
    {
        // Arrange
        string s1_1 = "", s2_1 = "";
        string s1_2 = "a", s2_2 = "b";
        string s1_3 = "123", s2_3 = "456";
        string s1_4 = " ", s2_4 = " ";
        string s1_5 = "ABC", s2_5 = "";

        // Act
        string result1 = BasicAlgorithm.CreateS1S2S2S1String(s1_1, s2_1);
        string result2 = BasicAlgorithm.CreateS1S2S2S1String(s1_2, s2_2);
        string result3 = BasicAlgorithm.CreateS1S2S2S1String(s1_3, s2_3);
        string result4 = BasicAlgorithm.CreateS1S2S2S1String(s1_4, s2_4);
        string result5 = BasicAlgorithm.CreateS1S2S2S1String(s1_5, s2_5);

        // Assert
        Assert.AreEqual("", result1);
        Assert.AreEqual("abba", result2);
        Assert.AreEqual("123456456123", result3);
        Assert.AreEqual("    ", result4);
        Assert.AreEqual("ABCABC", result5);
    }

    // Exercise 61 - Insert String into Middle of Another

    [TestMethod]
    public void InsertIntoMiddle_TestCases()
    {
        // Arrange
        string outer1 = "[[]]", inner1 = "Hello";
        string outer2 = "(())", inner2 = "Hi";

        // Act
        string result1 = BasicAlgorithm.InsertIntoMiddle(outer1, inner1);
        string result2 = BasicAlgorithm.InsertIntoMiddle(outer2, inner2);

        // Assert
        Assert.AreEqual("[[Hello]]", result1);
        Assert.AreEqual("((Hi))", result2);
    }

    [TestMethod]
    public void InsertIntoMiddle_EdgeCases()
    {
        // Arrange
        string outer1 = "abcd", inner1 = "XYZ";
        string outer2 = "1234", inner2 = "";
        string outer3 = "****", inner3 = "test";
        string outer4 = "    ", inner4 = "mid";
        string outer5 = "ABCD", inner5 = "123";

        // Act
        string result1 = BasicAlgorithm.InsertIntoMiddle(outer1, inner1);
        string result2 = BasicAlgorithm.InsertIntoMiddle(outer2, inner2);
        string result3 = BasicAlgorithm.InsertIntoMiddle(outer3, inner3);
        string result4 = BasicAlgorithm.InsertIntoMiddle(outer4, inner4);
        string result5 = BasicAlgorithm.InsertIntoMiddle(outer5, inner5);

        // Assert
        Assert.AreEqual("abXYZcd", result1);
        Assert.AreEqual("1234", result2);
        Assert.AreEqual("**test**", result3);
        Assert.AreEqual("  mid  ", result4);
        Assert.AreEqual("AB123CD", result5);
    }

    [TestMethod]
    public void InsertIntoMiddle_WithNon4Length()
    {
        // Arrange
        string outer1 = "abc", inner1 = "test";
        string outer2 = "abcde", inner2 = "test";

        // Act
        string result1 = BasicAlgorithm.InsertIntoMiddle(outer1, inner1);
        string result2 = BasicAlgorithm.InsertIntoMiddle(outer2, inner2);

        // Assert
        Assert.AreEqual("abc", result1);
        Assert.AreEqual("abcde", result2);
    }

    // Exercise 62 - Three Copies of Last Two Characters

    [TestMethod]
    public void ThreeCopiesOfLastTwoChars_TestCases()
    {
        // Arrange
        string input1 = "Hello";
        string input2 = "Hi";

        // Act
        string result1 = BasicAlgorithm.ThreeCopiesOfLastTwoChars(input1);
        string result2 = BasicAlgorithm.ThreeCopiesOfLastTwoChars(input2);

        // Assert
        Assert.AreEqual("lololo", result1);
        Assert.AreEqual("HiHiHi", result2);
    }

    [TestMethod]
    public void ThreeCopiesOfLastTwoChars_EdgeCases()
    {
        // Arrange
        string input1 = "ab";
        string input2 = "123";
        string input3 = "A";
        string input4 = "";
        string input5 = "test";
        string input6 = "xyz";

        // Act
        string result1 = BasicAlgorithm.ThreeCopiesOfLastTwoChars(input1);
        string result2 = BasicAlgorithm.ThreeCopiesOfLastTwoChars(input2);
        string result3 = BasicAlgorithm.ThreeCopiesOfLastTwoChars(input3);
        string result4 = BasicAlgorithm.ThreeCopiesOfLastTwoChars(input4);
        string result5 = BasicAlgorithm.ThreeCopiesOfLastTwoChars(input5);
        string result6 = BasicAlgorithm.ThreeCopiesOfLastTwoChars(input6);

        // Assert
        Assert.AreEqual("ababab", result1);
        Assert.AreEqual("232323", result2);
        Assert.AreEqual("A", result3);
        Assert.AreEqual("", result4);
        Assert.AreEqual("ststst", result5);
        Assert.AreEqual("yzyzyz", result6);
    }

    [TestMethod]
    public void ThreeCopiesOfLastTwoChars_LongerStrings()
    {
        // Arrange
        string input1 = "programming";
        string input2 = "abcdefgh";
        string input3 = "Hello World";

        // Act
        string result1 = BasicAlgorithm.ThreeCopiesOfLastTwoChars(input1);
        string result2 = BasicAlgorithm.ThreeCopiesOfLastTwoChars(input2);
        string result3 = BasicAlgorithm.ThreeCopiesOfLastTwoChars(input3);

        // Assert
        Assert.AreEqual("ngngng", result1);
        Assert.AreEqual("ghghgh", result2);
        Assert.AreEqual("ldldld", result3);
    }

    // Exercise 63 - First Two Characters or Original String

    [TestMethod]
    public void FirstTwoCharsOrOriginal_TestCases()
    {
        // Arrange
        string input1 = "Hello";
        string input2 = "Hi";
        string input3 = "H";
        string input4 = " ";

        // Act
        string result1 = BasicAlgorithm.FirstTwoCharsOrOriginal(input1);
        string result2 = BasicAlgorithm.FirstTwoCharsOrOriginal(input2);
        string result3 = BasicAlgorithm.FirstTwoCharsOrOriginal(input3);
        string result4 = BasicAlgorithm.FirstTwoCharsOrOriginal(input4);

        // Assert
        Assert.AreEqual("He", result1);
        Assert.AreEqual("Hi", result2);
        Assert.AreEqual("H", result3);
        Assert.AreEqual(" ", result4);
    }

    [TestMethod]
    public void FirstTwoCharsOrOriginal_EdgeCases()
    {
        // Arrange
        string input1 = "";
        string input2 = "ab";
        string input3 = "123";
        string input4 = "A";
        string input5 = "  ";
        string input6 = "test";

        // Act
        string result1 = BasicAlgorithm.FirstTwoCharsOrOriginal(input1);
        string result2 = BasicAlgorithm.FirstTwoCharsOrOriginal(input2);
        string result3 = BasicAlgorithm.FirstTwoCharsOrOriginal(input3);
        string result4 = BasicAlgorithm.FirstTwoCharsOrOriginal(input4);
        string result5 = BasicAlgorithm.FirstTwoCharsOrOriginal(input5);
        string result6 = BasicAlgorithm.FirstTwoCharsOrOriginal(input6);

        // Assert
        Assert.AreEqual("", result1);
        Assert.AreEqual("ab", result2);
        Assert.AreEqual("12", result3);
        Assert.AreEqual("A", result4);
        Assert.AreEqual("  ", result5);
        Assert.AreEqual("te", result6);
    }

    [TestMethod]
    public void FirstTwoCharsOrOriginal_LongerStrings()
    {
        // Arrange
        string input1 = "programming";
        string input2 = "abcdefgh";
        string input3 = "Hello World";

        // Act
        string result1 = BasicAlgorithm.FirstTwoCharsOrOriginal(input1);
        string result2 = BasicAlgorithm.FirstTwoCharsOrOriginal(input2);
        string result3 = BasicAlgorithm.FirstTwoCharsOrOriginal(input3);

        // Assert
        Assert.AreEqual("pr", result1);
        Assert.AreEqual("ab", result2);
        Assert.AreEqual("He", result3);
    }

    // Exercise 64 - First Half of Even-Length String

    [TestMethod]
    public void FirstHalfOfEvenString_TestCases()
    {
        // Arrange
        string input1 = "Hello";
        string input2 = "Hi";

        // Act
        string result1 = BasicAlgorithm.FirstHalfOfEvenString(input1);
        string result2 = BasicAlgorithm.FirstHalfOfEvenString(input2);

        // Assert
        Assert.AreEqual("Hello", result1);
        Assert.AreEqual("H", result2);
    }

    [TestMethod]
    public void FirstHalfOfEvenString_EvenLengthStrings()
    {
        // Arrange
        string input1 = "abcd";
        string input2 = "test";
        string input3 = "123456";
        string input4 = "    ";
        string input5 = "AB";

        // Act
        string result1 = BasicAlgorithm.FirstHalfOfEvenString(input1);
        string result2 = BasicAlgorithm.FirstHalfOfEvenString(input2);
        string result3 = BasicAlgorithm.FirstHalfOfEvenString(input3);
        string result4 = BasicAlgorithm.FirstHalfOfEvenString(input4);
        string result5 = BasicAlgorithm.FirstHalfOfEvenString(input5);

        // Assert
        Assert.AreEqual("ab", result1);
        Assert.AreEqual("te", result2);
        Assert.AreEqual("123", result3);
        Assert.AreEqual("  ", result4);
        Assert.AreEqual("A", result5);
    }

    [TestMethod]
    public void FirstHalfOfEvenString_OddLengthStrings()
    {
        // Arrange
        string input1 = "abc";
        string input2 = "hello";
        string input3 = "1";
        string input4 = "A";
        string input5 = "12345";

        // Act
        string result1 = BasicAlgorithm.FirstHalfOfEvenString(input1);
        string result2 = BasicAlgorithm.FirstHalfOfEvenString(input2);
        string result3 = BasicAlgorithm.FirstHalfOfEvenString(input3);
        string result4 = BasicAlgorithm.FirstHalfOfEvenString(input4);
        string result5 = BasicAlgorithm.FirstHalfOfEvenString(input5);

        // Assert
        Assert.AreEqual("abc", result1);
        Assert.AreEqual("hello", result2);
        Assert.AreEqual("1", result3);
        Assert.AreEqual("A", result4);
        Assert.AreEqual("12345", result5);
    }

    [TestMethod]
    public void FirstHalfOfEvenString_EdgeCases()
    {
        // Arrange
        string input1 = "";
        string input2 = "  ";
        string input3 = "programming";

        // Act
        string result1 = BasicAlgorithm.FirstHalfOfEvenString(input1);
        string result2 = BasicAlgorithm.FirstHalfOfEvenString(input2);
        string result3 = BasicAlgorithm.FirstHalfOfEvenString(input3);

        // Assert
        Assert.AreEqual("", result1);
        Assert.AreEqual(" ", result2);
        Assert.AreEqual("programming", result3);
    }

    // Exercise 65 - Remove First and Last Character

    [TestMethod]
    public void RemoveFirstAndLastChar_TestCases()
    {
        // Arrange
        string input1 = "Hello";
        string input2 = "Hi";
        string input3 = "Python";

        // Act
        string result1 = BasicAlgorithm.RemoveFirstAndLastChar(input1);
        string result2 = BasicAlgorithm.RemoveFirstAndLastChar(input2);
        string result3 = BasicAlgorithm.RemoveFirstAndLastChar(input3);

        // Assert
        Assert.AreEqual("ell", result1);
        Assert.AreEqual("", result2);
        Assert.AreEqual("ytho", result3);
    }

    [TestMethod]
    public void RemoveFirstAndLastChar_EdgeCases()
    {
        // Arrange
        string input1 = "ab";
        string input2 = "a";
        string input3 = "";
        string input4 = "12345";
        string input5 = " test ";

        // Act
        string result1 = BasicAlgorithm.RemoveFirstAndLastChar(input1);
        string result2 = BasicAlgorithm.RemoveFirstAndLastChar(input2);
        string result3 = BasicAlgorithm.RemoveFirstAndLastChar(input3);
        string result4 = BasicAlgorithm.RemoveFirstAndLastChar(input4);
        string result5 = BasicAlgorithm.RemoveFirstAndLastChar(input5);

        // Assert
        Assert.AreEqual("", result1);
        Assert.AreEqual("a", result2);
        Assert.AreEqual("", result3);
        Assert.AreEqual("234", result4);
        Assert.AreEqual("test", result5);
    }

    // Exercise 66 - Format Long+Short+Long Strings

    [TestMethod]
    public void FormatLongShortLong_TestCases()
    {
        // Arrange
        string a1 = "Hello", b1 = "Hi";
        string a2 = "JS", b2 = "Python";

        // Act
        string result1 = BasicAlgorithm.FormatLongShortLong(a1, b1);
        string result2 = BasicAlgorithm.FormatLongShortLong(a2, b2);

        // Assert
        Assert.AreEqual("HelloHiHello", result1);
        Assert.AreEqual("PythonJSPython", result2);
    }

    [TestMethod]
    public void FormatLongShortLong_EdgeCases()
    {
        // Arrange
        string a1 = "a", b1 = "bb";
        string a2 = "same", b2 = "same";
        string a3 = "", b3 = "non-empty";
        string a4 = "123", b4 = "45";
        string a5 = "longer", b5 = "short";

        // Act
        string result1 = BasicAlgorithm.FormatLongShortLong(a1, b1);
        string result2 = BasicAlgorithm.FormatLongShortLong(a2, b2);
        string result3 = BasicAlgorithm.FormatLongShortLong(a3, b3);
        string result4 = BasicAlgorithm.FormatLongShortLong(a4, b4);
        string result5 = BasicAlgorithm.FormatLongShortLong(a5, b5);

        // Assert
        Assert.AreEqual("bbabb", result1);
        Assert.AreEqual("samesamesame", result2);
        Assert.AreEqual("non-emptynon-empty", result3);
        Assert.AreEqual("12345123", result4);
        Assert.AreEqual("longershortlonger", result5);
    }

    [TestMethod]
    public void FormatLongShortLong_EqualLength()
    {
        // Arrange
        string a1 = "ab", b1 = "cd";
        string a2 = "12", b2 = "34";

        // Act
        string result1 = BasicAlgorithm.FormatLongShortLong(a1, b1);
        string result2 = BasicAlgorithm.FormatLongShortLong(a2, b2);

        // Assert
        Assert.AreEqual("abcdab", result1);
        Assert.AreEqual("123412", result2);
    }

    // Exercise 67 - Combine Strings After Removing First Char

    [TestMethod]
    public void CombineAfterRemovingFirstChar_TestCases()
    {
        // Arrange
        string a1 = "Hello", b1 = "Hi";
        string a2 = "JS", b2 = "Python";

        // Act
        string result1 = BasicAlgorithm.CombineAfterRemovingFirstChar(a1, b1);
        string result2 = BasicAlgorithm.CombineAfterRemovingFirstChar(a2, b2);

        // Assert
        Assert.AreEqual("elloi", result1);
        Assert.AreEqual("Sython", result2);
    }

    [TestMethod]
    public void CombineAfterRemovingFirstChar_EdgeCases()
    {
        // Arrange
        string a1 = "a", b1 = "b";
        string a2 = "1", b2 = "23";
        string a3 = "", b3 = "test";
        string a4 = "hello", b4 = "";
        string a5 = "x", b5 = "y";

        // Act
        string result1 = BasicAlgorithm.CombineAfterRemovingFirstChar(a1, b1);
        string result2 = BasicAlgorithm.CombineAfterRemovingFirstChar(a2, b2);
        string result3 = BasicAlgorithm.CombineAfterRemovingFirstChar(a3, b3);
        string result4 = BasicAlgorithm.CombineAfterRemovingFirstChar(a4, b4);
        string result5 = BasicAlgorithm.CombineAfterRemovingFirstChar(a5, b5);

        // Assert
        Assert.AreEqual("", result1); // "a".Substring(1) = "", "b".Substring(1) = ""
        Assert.AreEqual("3", result2); // "1".Substring(1) = "", "23".Substring(1) = "3"
        Assert.AreEqual("test", result3); // "".Substring(1) = "", "test".Substring(1) = "test"
        Assert.AreEqual("hello", result4); // "hello".Substring(1) = "hello", "".Substring(1) = ""
        Assert.AreEqual("", result5); // "x".Substring(1) = "", "y".Substring(1) = ""
    }

    [TestMethod]
    public void CombineAfterRemovingFirstChar_SingleCharStrings()
    {
        // Arrange
        string a1 = "X", b1 = "Y";
        string a2 = "1", b2 = "2";

        // Act
        string result1 = BasicAlgorithm.CombineAfterRemovingFirstChar(a1, b1);
        string result2 = BasicAlgorithm.CombineAfterRemovingFirstChar(a2, b2);

        // Assert
        Assert.AreEqual("", result1);
        Assert.AreEqual("", result2);
    }

    // Exercise 68 - Move First Two Characters to End

    [TestMethod]
    public void MoveFirstTwoToEnd_TestCases()
    {
        // Arrange
        string input1 = "Hello";
        string input2 = "JS";

        // Act
        string result1 = BasicAlgorithm.MoveFirstTwoToEnd(input1);
        string result2 = BasicAlgorithm.MoveFirstTwoToEnd(input2);

        // Assert
        Assert.AreEqual("lloHe", result1);
        Assert.AreEqual("JS", result2);
    }

    [TestMethod]
    public void MoveFirstTwoToEnd_EdgeCases()
    {
        // Arrange
        string input1 = "ab";
        string input2 = "abc";
        string input3 = "a";
        string input4 = "";
        string input5 = "1234";
        string input6 = "test";

        // Act
        string result1 = BasicAlgorithm.MoveFirstTwoToEnd(input1);
        string result2 = BasicAlgorithm.MoveFirstTwoToEnd(input2);
        string result3 = BasicAlgorithm.MoveFirstTwoToEnd(input3);
        string result4 = BasicAlgorithm.MoveFirstTwoToEnd(input4);
        string result5 = BasicAlgorithm.MoveFirstTwoToEnd(input5);
        string result6 = BasicAlgorithm.MoveFirstTwoToEnd(input6);

        // Assert
        Assert.AreEqual("ab", result1);
        Assert.AreEqual("cab", result2);
        Assert.AreEqual("a", result3);
        Assert.AreEqual("", result4);
        Assert.AreEqual("3412", result5);
        Assert.AreEqual("stte", result6);
    }

    [TestMethod]
    public void MoveFirstTwoToEnd_LongerStrings()
    {
        // Arrange
        string input1 = "programming";
        string input2 = "abcdef";
        string input3 = "HelloWorld";

        // Act
        string result1 = BasicAlgorithm.MoveFirstTwoToEnd(input1);
        string result2 = BasicAlgorithm.MoveFirstTwoToEnd(input2);
        string result3 = BasicAlgorithm.MoveFirstTwoToEnd(input3);

        // Assert
        Assert.AreEqual("ogrammingpr", result1);
        Assert.AreEqual("cdefab", result2);
        Assert.AreEqual("lloWorldHe", result3);
    }

    // Exercise 69 - Move Last Two Characters to Start

    [TestMethod]
    public void MoveLastTwoToStart_TestCases()
    {
        // Arrange
        string input1 = "Hello";
        string input2 = "JS";

        // Act
        string result1 = BasicAlgorithm.MoveLastTwoToStart(input1);
        string result2 = BasicAlgorithm.MoveLastTwoToStart(input2);

        // Assert
        Assert.AreEqual("loHel", result1);
        Assert.AreEqual("JS", result2);
    }

    [TestMethod]
    public void MoveLastTwoToStart_EdgeCases()
    {
        // Arrange
        string input1 = "ab";
        string input2 = "abc";
        string input3 = "a";
        string input4 = "";
        string input5 = "1234";
        string input6 = "test";

        // Act
        string result1 = BasicAlgorithm.MoveLastTwoToStart(input1);
        string result2 = BasicAlgorithm.MoveLastTwoToStart(input2);
        string result3 = BasicAlgorithm.MoveLastTwoToStart(input3);
        string result4 = BasicAlgorithm.MoveLastTwoToStart(input4);
        string result5 = BasicAlgorithm.MoveLastTwoToStart(input5);
        string result6 = BasicAlgorithm.MoveLastTwoToStart(input6);

        // Assert
        Assert.AreEqual("ab", result1);
        Assert.AreEqual("bca", result2);
        Assert.AreEqual("a", result3);
        Assert.AreEqual("", result4);
        Assert.AreEqual("3412", result5);
        Assert.AreEqual("stte", result6);
    }

    [TestMethod]
    public void MoveLastTwoToStart_LongerStrings()
    {
        // Arrange
        string input1 = "programming";
        string input2 = "abcdef";
        string input3 = "HelloWorld";

        // Act
        string result1 = BasicAlgorithm.MoveLastTwoToStart(input1);
        string result2 = BasicAlgorithm.MoveLastTwoToStart(input2);
        string result3 = BasicAlgorithm.MoveLastTwoToStart(input3);

        // Assert
        Assert.AreEqual("ngprogrammi", result1);
        Assert.AreEqual("efabcd", result2);
        Assert.AreEqual("ldHelloWor", result3);
    }

    // Exercise 70 - Remove First and Last Char

    [TestMethod]
    public void RemoveFirstAndLastChars_TestCases()
    {
        // Arrange
        string input1 = "Hello";
        string input2 = "JS";
        string input3 = "";

        // Act
        string result1 = BasicAlgorithm.RemoveFirstAndLastChars(input1);
        string result2 = BasicAlgorithm.RemoveFirstAndLastChars(input2);
        string result3 = BasicAlgorithm.RemoveFirstAndLastChars(input3);

        // Assert
        Assert.AreEqual("ell", result1);
        Assert.AreEqual("", result2);
        Assert.AreEqual("", result3);
    }

    [TestMethod]
    public void RemoveFirstAndLastChars_EdgeCases()
    {
        // Arrange
        string input1 = "a";
        string input2 = "ab";
        string input3 = "abc";
        string input4 = "abcd";
        string input5 = "test";
        string input6 = "12345";

        // Act
        string result1 = BasicAlgorithm.RemoveFirstAndLastChars(input1);
        string result2 = BasicAlgorithm.RemoveFirstAndLastChars(input2);
        string result3 = BasicAlgorithm.RemoveFirstAndLastChars(input3);
        string result4 = BasicAlgorithm.RemoveFirstAndLastChars(input4);
        string result5 = BasicAlgorithm.RemoveFirstAndLastChars(input5);
        string result6 = BasicAlgorithm.RemoveFirstAndLastChars(input6);

        // Assert
        Assert.AreEqual("", result1);
        Assert.AreEqual("", result2);
        Assert.AreEqual("b", result3);
        Assert.AreEqual("bc", result4);
        Assert.AreEqual("es", result5);
        Assert.AreEqual("234", result6);
    }

    [TestMethod]
    public void RemoveFirstAndLastChar_LongerStrings()
    {
        // Arrange
        string input1 = "programming";
        string input2 = "Hello World";
        string input3 = "abcdefghijk";

        // Act
        string result1 = BasicAlgorithm.RemoveFirstAndLastChar(input1);
        string result2 = BasicAlgorithm.RemoveFirstAndLastChar(input2);
        string result3 = BasicAlgorithm.RemoveFirstAndLastChar(input3);

        // Assert
        Assert.AreEqual("rogrammin", result1);
        Assert.AreEqual("ello Worl", result2);
        Assert.AreEqual("bcdefghij", result3);
    }

    // Exercise 71 - Two Middle Characters of Even-Length String

    [TestMethod]
    public void TwoMiddleChars_TestCases()
    {
        string input1 = "Hell";
        string input2 = "JS";

        string result1 = BasicAlgorithm.TwoMiddleChars(input1);
        string result2 = BasicAlgorithm.TwoMiddleChars(input2);

        Assert.AreEqual("el", result1);
        Assert.AreEqual("JS", result2);
    }

    [TestMethod]
    public void TwoMiddleChars_EdgeCases()
    {
        string input1 = "abcd";
        string input2 = "test";
        string input3 = "123456";
        string input4 = "a";
        string input5 = "abc";

        string result1 = BasicAlgorithm.TwoMiddleChars(input1);
        string result2 = BasicAlgorithm.TwoMiddleChars(input2);
        string result3 = BasicAlgorithm.TwoMiddleChars(input3);
        string result4 = BasicAlgorithm.TwoMiddleChars(input4);
        string result5 = BasicAlgorithm.TwoMiddleChars(input5);

        Assert.AreEqual("bc", result1);
        Assert.AreEqual("es", result2);
        Assert.AreEqual("34", result3);
        Assert.AreEqual("a", result4);
        Assert.AreEqual("abc", result5);
    }

    // Exercise 72 - Ends with 'on'

    [TestMethod]
    public void EndsWithOn_TestCases()
    {
        string input1 = "Hello";
        string input2 = "Python";
        string input3 = "on";
        string input4 = "o";

        bool result1 = BasicAlgorithm.EndsWithOn(input1);
        bool result2 = BasicAlgorithm.EndsWithOn(input2);
        bool result3 = BasicAlgorithm.EndsWithOn(input3);
        bool result4 = BasicAlgorithm.EndsWithOn(input4);

        Assert.IsFalse(result1);
        Assert.IsTrue(result2);
        Assert.IsTrue(result3);
        Assert.IsFalse(result4);
    }

    [TestMethod]
    public void EndsWithOn_EdgeCases()
    {
        string input1 = "";
        string input2 = "n";
        string input3 = "onon";
        string input4 = "python";
        string input5 = "ON";

        bool result1 = BasicAlgorithm.EndsWithOn(input1);
        bool result2 = BasicAlgorithm.EndsWithOn(input2);
        bool result3 = BasicAlgorithm.EndsWithOn(input3);
        bool result4 = BasicAlgorithm.EndsWithOn(input4);
        bool result5 = BasicAlgorithm.EndsWithOn(input5);

        Assert.IsFalse(result1);
        Assert.IsFalse(result2);
        Assert.IsTrue(result3);
        Assert.IsTrue(result4);
        Assert.IsFalse(result5);
    }

    // Exercise 73 - First and Last n Characters of String

    [TestMethod]
    public void FirstLastNChars_TestCases()
    {
        string input1 = "Hello";
        int n1 = 1;
        string input2 = "Python";
        int n2 = 2;
        string input3 = "on";
        int n3 = 1;
        string input4 = "o";
        int n4 = 1;

        string result1 = BasicAlgorithm.FirstLastNChars(input1, n1);
        string result2 = BasicAlgorithm.FirstLastNChars(input2, n2);
        string result3 = BasicAlgorithm.FirstLastNChars(input3, n3);
        string result4 = BasicAlgorithm.FirstLastNChars(input4, n4);

        Assert.AreEqual("Ho", result1);
        Assert.AreEqual("Pyon", result2);
        Assert.AreEqual("on", result3);
        Assert.AreEqual("oo", result4);
    }

    [TestMethod]
    public void FirstLastNChars_EdgeCases()
    {
        string input1 = "abcd";
        int n1 = 2;
        string input2 = "test";
        int n2 = 3;
        string input3 = "x";
        int n3 = 2;
        string input4 = "programming";
        int n4 = 4;

        string result1 = BasicAlgorithm.FirstLastNChars(input1, n1);
        string result2 = BasicAlgorithm.FirstLastNChars(input2, n2);
        string result3 = BasicAlgorithm.FirstLastNChars(input3, n3);
        string result4 = BasicAlgorithm.FirstLastNChars(input4, n4);

        Assert.AreEqual("abcd", result1);
        Assert.AreEqual("tesest", result2);
        Assert.AreEqual("x", result3);
        Assert.AreEqual("progming", result4);
    }

    // Exercise 74 - Two Characters Starting at Index

    [TestMethod]
    public void TwoCharsFromIndex_TestCases()
    {
        string input1 = "Hello";
        int index1 = 1;
        string input2 = "Python";
        int index2 = 2;
        string input3 = "on";
        int index3 = 1;

        string result1 = BasicAlgorithm.TwoCharsFromIndex(input1, index1);
        string result2 = BasicAlgorithm.TwoCharsFromIndex(input2, index2);
        string result3 = BasicAlgorithm.TwoCharsFromIndex(input3, index3);

        Assert.AreEqual("el", result1);
        Assert.AreEqual("th", result2);
        Assert.AreEqual("n", result3);
    }

    [TestMethod]
    public void TwoCharsFromIndex_EdgeCases()
    {
        string input1 = "abcd";
        int index1 = 3;
        string input2 = "test";
        int index2 = 0;
        string input3 = "x";
        int index3 = 0;
        string input4 = "programming";
        int index4 = 5;

        string result1 = BasicAlgorithm.TwoCharsFromIndex(input1, index1);
        string result2 = BasicAlgorithm.TwoCharsFromIndex(input2, index2);
        string result3 = BasicAlgorithm.TwoCharsFromIndex(input3, index3);
        string result4 = BasicAlgorithm.TwoCharsFromIndex(input4, index4);

        Assert.AreEqual("d", result1);
        Assert.AreEqual("te", result2);
        Assert.AreEqual("x", result3);
        Assert.AreEqual("am", result4);
    }

    // Exercise 75 - Three Characters from Middle of String

    [TestMethod]
    public void ThreeCharsFromMiddle_TestCases()
    {
        string input1 = "Hello";
        string input2 = "Python";
        string input3 = "abc";

        string result1 = BasicAlgorithm.ThreeCharsFromMiddle(input1);
        string result2 = BasicAlgorithm.ThreeCharsFromMiddle(input2);
        string result3 = BasicAlgorithm.ThreeCharsFromMiddle(input3);

        Assert.AreEqual("ell", result1);
        Assert.AreEqual("tho", result2);
        Assert.AreEqual("abc", result3);
    }

    [TestMethod]
    public void ThreeCharsFromMiddle_EdgeCases()
    {
        string input1 = "abcd";
        string input2 = "abcde";
        string input3 = "abcdef";
        string input4 = "a";
        string input5 = "ab";

        string result1 = BasicAlgorithm.ThreeCharsFromMiddle(input1);
        string result2 = BasicAlgorithm.ThreeCharsFromMiddle(input2);
        string result3 = BasicAlgorithm.ThreeCharsFromMiddle(input3);
        string result4 = BasicAlgorithm.ThreeCharsFromMiddle(input4);
        string result5 = BasicAlgorithm.ThreeCharsFromMiddle(input5);

        Assert.AreEqual("bcd", result1);
        Assert.AreEqual("bcd", result2);
        Assert.AreEqual("cde", result3);
        Assert.AreEqual("a", result4);
        Assert.AreEqual("ab", result5);
    }

    // Exercise 76 - First Two Characters with Missing '#' if Short

    [TestMethod]
    public void FirstTwoCharsWithHash_TestCases()
    {
        string input1 = "Hello";
        string input2 = "Python";
        string input3 = "a";
        string input4 = "";

        string result1 = BasicAlgorithm.FirstTwoCharsWithHash(input1);
        string result2 = BasicAlgorithm.FirstTwoCharsWithHash(input2);
        string result3 = BasicAlgorithm.FirstTwoCharsWithHash(input3);
        string result4 = BasicAlgorithm.FirstTwoCharsWithHash(input4);

        Assert.AreEqual("He", result1);
        Assert.AreEqual("Py", result2);
        Assert.AreEqual("a#", result3);
        Assert.AreEqual("##", result4);
    }

    [TestMethod]
    public void FirstTwoCharsWithHash_EdgeCases()
    {
        string input1 = "ab";
        string input2 = "x";
        string input3 = "123";
        string input4 = "  ";

        string result1 = BasicAlgorithm.FirstTwoCharsWithHash(input1);
        string result2 = BasicAlgorithm.FirstTwoCharsWithHash(input2);
        string result3 = BasicAlgorithm.FirstTwoCharsWithHash(input3);
        string result4 = BasicAlgorithm.FirstTwoCharsWithHash(input4);

        Assert.AreEqual("ab", result1);
        Assert.AreEqual("x#", result2);
        Assert.AreEqual("12", result3);
        Assert.AreEqual("  ", result4);
    }

    // Exercise 77 - First and Last Char of Two Strings

    [TestMethod]
    public void FirstAndLastChar_TestCases()
    {
        string a1 = "Hello", b1 = "Hi";
        string a2 = "Python", b2 = "PHP";
        string a3 = "JS", b3 = "JS";
        string a4 = "Csharp", b4 = "";

        string result1 = BasicAlgorithm.FirstAndLastChar(a1, b1);
        string result2 = BasicAlgorithm.FirstAndLastChar(a2, b2);
        string result3 = BasicAlgorithm.FirstAndLastChar(a3, b3);
        string result4 = BasicAlgorithm.FirstAndLastChar(a4, b4);

        Assert.AreEqual("Hi", result1);
        Assert.AreEqual("PP", result2);
        Assert.AreEqual("JS", result3);
        Assert.AreEqual("C#", result4);
    }

    [TestMethod]
    public void FirstAndLastChar_EdgeCases()
    {
        string a1 = "", b1 = "test";
        string a2 = "x", b2 = "";
        string a3 = "", b3 = "";
        string a4 = "abc", b4 = "xyz";

        string result1 = BasicAlgorithm.FirstAndLastChar(a1, b1);
        string result2 = BasicAlgorithm.FirstAndLastChar(a2, b2);
        string result3 = BasicAlgorithm.FirstAndLastChar(a3, b3);
        string result4 = BasicAlgorithm.FirstAndLastChar(a4, b4);

        Assert.AreEqual("#t", result1);
        Assert.AreEqual("x#", result2);
        Assert.AreEqual("##", result3);
        Assert.AreEqual("az", result4);
    }

    // Exercise 78 - Combine Strings Removing Duplicates

    [TestMethod]
    public void CombineRemoveDuplicates_TestCases()
    {
        string a1 = "abc", b1 = "cat";
        string a2 = "python", b2 = "php";
        string a3 = "php", b3 = "php";

        string result1 = BasicAlgorithm.CombineRemoveDuplicates(a1, b1);
        string result2 = BasicAlgorithm.CombineRemoveDuplicates(a2, b2);
        string result3 = BasicAlgorithm.CombineRemoveDuplicates(a3, b3);

        Assert.AreEqual("abcat", result1);
        Assert.AreEqual("pythonphp", result2);
        Assert.AreEqual("phphp", result3);
    }

    [TestMethod]
    public void CombineRemoveDuplicates_EdgeCases()
    {
        string a1 = "hello", b1 = "world";
        string a2 = "test", b2 = "string";
        string a3 = "x", b3 = "x";
        string a4 = "", b4 = "abc";
        string a5 = "abc", b5 = "";

        string result1 = BasicAlgorithm.CombineRemoveDuplicates(a1, b1);
        string result2 = BasicAlgorithm.CombineRemoveDuplicates(a2, b2);
        string result3 = BasicAlgorithm.CombineRemoveDuplicates(a3, b3);
        string result4 = BasicAlgorithm.CombineRemoveDuplicates(a4, b4);
        string result5 = BasicAlgorithm.CombineRemoveDuplicates(a5, b5);

        Assert.AreEqual("helloworld", result1);
        Assert.AreEqual("teststring", result2);
        Assert.AreEqual("x", result3);
        Assert.AreEqual("abc", result4);
        Assert.AreEqual("abc", result5);
    }

    // Exercise 79 - Swap Last Two Characters

    [TestMethod]
    public void SwapLastTwoChars_TestCases()
    {
        string input1 = "Hello";
        string input2 = "Python";
        string input3 = "PHP";
        string input4 = "JS";
        string input5 = "C";

        string result1 = BasicAlgorithm.SwapLastTwoChars(input1);
        string result2 = BasicAlgorithm.SwapLastTwoChars(input2);
        string result3 = BasicAlgorithm.SwapLastTwoChars(input3);
        string result4 = BasicAlgorithm.SwapLastTwoChars(input4);
        string result5 = BasicAlgorithm.SwapLastTwoChars(input5);

        Assert.AreEqual("Helol", result1);
        Assert.AreEqual("Pythno", result2);
        Assert.AreEqual("PPH", result3);
        Assert.AreEqual("SJ", result4);
        Assert.AreEqual("C", result5);
    }

    [TestMethod]
    public void SwapLastTwoChars_EdgeCases()
    {
        string input1 = "ab";
        string input2 = "abc";
        string input3 = "";
        string input4 = "test";
        string input5 = "xy";

        string result1 = BasicAlgorithm.SwapLastTwoChars(input1);
        string result2 = BasicAlgorithm.SwapLastTwoChars(input2);
        string result3 = BasicAlgorithm.SwapLastTwoChars(input3);
        string result4 = BasicAlgorithm.SwapLastTwoChars(input4);
        string result5 = BasicAlgorithm.SwapLastTwoChars(input5);

        Assert.AreEqual("ba", result1);
        Assert.AreEqual("acb", result2);
        Assert.AreEqual("", result3);
        Assert.AreEqual("tets", result4);
        Assert.AreEqual("yx", result5);
    }

    // Exercise 80 - Starts with 'abc' or 'xyz'

    [TestMethod]
    public void StartsWithAbcOrXyz_TestCases()
    {
        string input1 = "abc";
        string input2 = "abcdef";
        string input3 = "C";
        string input4 = "xyz";
        string input5 = "xyzsder";

        string result1 = BasicAlgorithm.StartsWithAbcOrXyz(input1);
        string result2 = BasicAlgorithm.StartsWithAbcOrXyz(input2);
        string result3 = BasicAlgorithm.StartsWithAbcOrXyz(input3);
        string result4 = BasicAlgorithm.StartsWithAbcOrXyz(input4);
        string result5 = BasicAlgorithm.StartsWithAbcOrXyz(input5);

        Assert.AreEqual("abc", result1);
        Assert.AreEqual("abc", result2);
        Assert.AreEqual("", result3);
        Assert.AreEqual("xyz", result4);
        Assert.AreEqual("xyz", result5);
    }

    [TestMethod]
    public void StartsWithAbcOrXyz_EdgeCases()
    {
        string input1 = "abcd";
        string input2 = "xy";
        string input3 = "";
        string input4 = "abc123";
        string input5 = "xyzabc";

        string result1 = BasicAlgorithm.StartsWithAbcOrXyz(input1);
        string result2 = BasicAlgorithm.StartsWithAbcOrXyz(input2);
        string result3 = BasicAlgorithm.StartsWithAbcOrXyz(input3);
        string result4 = BasicAlgorithm.StartsWithAbcOrXyz(input4);
        string result5 = BasicAlgorithm.StartsWithAbcOrXyz(input5);

        Assert.AreEqual("abc", result1);
        Assert.AreEqual("", result2);
        Assert.AreEqual("", result3);
        Assert.AreEqual("abc", result4);
        Assert.AreEqual("xyz", result5);
    }

    // Exercise 81 - First Two and Last Two Characters Same

    [TestMethod]
    public void FirstTwoLastTwoSame_TestCases()
    {
        string input1 = "abab";
        string input2 = "abcdef";
        string input3 = "xyzsderxy";

        bool result1 = BasicAlgorithm.FirstTwoLastTwoSame(input1);
        bool result2 = BasicAlgorithm.FirstTwoLastTwoSame(input2);
        bool result3 = BasicAlgorithm.FirstTwoLastTwoSame(input3);

        Assert.IsTrue(result1);
        Assert.IsFalse(result2);
        Assert.IsTrue(result3);
    }

    [TestMethod]
    public void FirstTwoLastTwoSame_EdgeCases()
    {
        string input1 = "ab";
        string input2 = "aa";
        string input3 = "a";
        string input4 = "";
        string input5 = "abcab";
        string input6 = "xyzxyz";

        bool result1 = BasicAlgorithm.FirstTwoLastTwoSame(input1);
        bool result2 = BasicAlgorithm.FirstTwoLastTwoSame(input2);
        bool result3 = BasicAlgorithm.FirstTwoLastTwoSame(input3);
        bool result4 = BasicAlgorithm.FirstTwoLastTwoSame(input4);
        bool result5 = BasicAlgorithm.FirstTwoLastTwoSame(input5);
        bool result6 = BasicAlgorithm.FirstTwoLastTwoSame(input6);

        Assert.IsTrue(result1);
        Assert.IsTrue(result2);
        Assert.IsFalse(result3);
        Assert.IsFalse(result4);
        Assert.IsTrue(result5);
        Assert.IsFalse(result6);
    }

    // Exercise 82 - Combine Strings After Adjusting Lengths

    [TestMethod]
    public void CombineAdjustLengths_TestCases()
    {
        string a1 = "abc", b1 = "abcd";
        string a2 = "Python", b2 = "Python";
        string a3 = "JS", b3 = "Python";

        string result1 = BasicAlgorithm.CombineAdjustLengths(a1, b1);
        string result2 = BasicAlgorithm.CombineAdjustLengths(a2, b2);
        string result3 = BasicAlgorithm.CombineAdjustLengths(a3, b3);

        Assert.AreEqual("abcabc", result1);
        Assert.AreEqual("PythonPython", result2);
        Assert.AreEqual("JSPy", result3);
    }

    [TestMethod]
    public void CombineAdjustLengths_EdgeCases()
    {
        string a1 = "a", b1 = "bc";
        string a2 = "test", b2 = "x";
        string a3 = "", b3 = "abc";
        string a4 = "123", b4 = "4567";
        string a5 = "long", b5 = "short";

        string result1 = BasicAlgorithm.CombineAdjustLengths(a1, b1);
        string result2 = BasicAlgorithm.CombineAdjustLengths(a2, b2);
        string result3 = BasicAlgorithm.CombineAdjustLengths(a3, b3);
        string result4 = BasicAlgorithm.CombineAdjustLengths(a4, b4);
        string result5 = BasicAlgorithm.CombineAdjustLengths(a5, b5);

        Assert.AreEqual("ab", result1);
        Assert.AreEqual("tx", result2);
        Assert.AreEqual("", result3);
        Assert.AreEqual("123456", result4);
        Assert.AreEqual("longshor", result5);
    }

    // Exercise 83 - Three Copies of First Two Characters

    [TestMethod]
    public void ThreeCopiesFirstTwo_TestCases()
    {
        string input1 = "abc";
        string input2 = "Python";
        string input3 = "J";

        string result1 = BasicAlgorithm.ThreeCopiesFirstTwo(input1);
        string result2 = BasicAlgorithm.ThreeCopiesFirstTwo(input2);
        string result3 = BasicAlgorithm.ThreeCopiesFirstTwo(input3);

        Assert.AreEqual("ababab", result1);
        Assert.AreEqual("PyPyPy", result2);
        Assert.AreEqual("JJJ", result3);
    }

    [TestMethod]
    public void ThreeCopiesFirstTwo_EdgeCases()
    {
        string input1 = "ab";
        string input2 = "a";
        string input3 = "";
        string input4 = "test";
        string input5 = "12345";

        string result1 = BasicAlgorithm.ThreeCopiesFirstTwo(input1);
        string result2 = BasicAlgorithm.ThreeCopiesFirstTwo(input2);
        string result3 = BasicAlgorithm.ThreeCopiesFirstTwo(input3);
        string result4 = BasicAlgorithm.ThreeCopiesFirstTwo(input4);
        string result5 = BasicAlgorithm.ThreeCopiesFirstTwo(input5);

        Assert.AreEqual("ababab", result1);
        Assert.AreEqual("aaa", result2);
        Assert.AreEqual("", result3);
        Assert.AreEqual("tetete", result4);
        Assert.AreEqual("121212", result5);
    }

    // Exercise 84 - Remove First Two if Start and End Match

    [TestMethod]
    public void RemoveFirstTwoIfEndsMatch_TestCases()
    {
        string input1 = "abcab";
        string input2 = "Python";

        string result1 = BasicAlgorithm.RemoveFirstTwoIfEndsMatch(input1);
        string result2 = BasicAlgorithm.RemoveFirstTwoIfEndsMatch(input2);

        Assert.AreEqual("abcab", result1);
        Assert.AreEqual("Python", result2);
    }

    [TestMethod]
    public void RemoveFirstTwoIfEndsMatch_EdgeCases()
    {
        string input1 = "abca";
        string input2 = "xx";
        string input3 = "x";
        string input4 = "";
        string input5 = "aabaa";
        string input6 = "testt";

        string result1 = BasicAlgorithm.RemoveFirstTwoIfEndsMatch(input1);
        string result2 = BasicAlgorithm.RemoveFirstTwoIfEndsMatch(input2);
        string result3 = BasicAlgorithm.RemoveFirstTwoIfEndsMatch(input3);
        string result4 = BasicAlgorithm.RemoveFirstTwoIfEndsMatch(input4);
        string result5 = BasicAlgorithm.RemoveFirstTwoIfEndsMatch(input5);
        string result6 = BasicAlgorithm.RemoveFirstTwoIfEndsMatch(input6);

        Assert.AreEqual("ca", result1);
        Assert.AreEqual("", result2);
        Assert.AreEqual("x", result3);
        Assert.AreEqual("", result4);
        Assert.AreEqual("baa", result5);
        Assert.AreEqual("stt", result6);
    }

    // Exercise 85 - Remove First Two Except 'p' and 'y'

    [TestMethod]
    public void RemoveFirstTwoExceptPY_TestCases()
    {
        // Arrange
        string input1 = "abcab";
        string input2 = "python";
        string input3 = "press";
        string input4 = "jython";

        // Act
        string result1 = BasicAlgorithm.RemoveFirstTwoExceptPY(input1);
        string result2 = BasicAlgorithm.RemoveFirstTwoExceptPY(input2);
        string result3 = BasicAlgorithm.RemoveFirstTwoExceptPY(input3);
        string result4 = BasicAlgorithm.RemoveFirstTwoExceptPY(input4);

        // Assert
        Assert.AreEqual("cab", result1);
        Assert.AreEqual("python", result2);
        Assert.AreEqual("pess", result3);
        Assert.AreEqual("ython", result4);
    }

    [TestMethod]
    public void RemoveFirstTwoExceptPY_EdgeCases()
    {
        // Arrange
        string input1 = "py";
        string input2 = "p";
        string input3 = "";
        string input4 = "xylophone";
        string input5 = "pythonic";

        // Act
        string result1 = BasicAlgorithm.RemoveFirstTwoExceptPY(input1);
        string result2 = BasicAlgorithm.RemoveFirstTwoExceptPY(input2);
        string result3 = BasicAlgorithm.RemoveFirstTwoExceptPY(input3);
        string result4 = BasicAlgorithm.RemoveFirstTwoExceptPY(input4);
        string result5 = BasicAlgorithm.RemoveFirstTwoExceptPY(input5);

        // Assert
        Assert.AreEqual("py", result1);
        Assert.AreEqual("p", result2);
        Assert.AreEqual("", result3);
        Assert.AreEqual("ylophone", result4);
        Assert.AreEqual("pythonic", result5);
    }

    // Exercise 86 - Remove 'a' if at Start or End

    [TestMethod]
    public void RemoveAIfAtStartOrEnd_TestCases()
    {
        // Arrange
        string input1 = "abcab";
        string input2 = "python";
        string input3 = "abcda";
        string input4 = "jython";

        // Act
        string result1 = BasicAlgorithm.RemoveAIfAtStartOrEnd(input1);
        string result2 = BasicAlgorithm.RemoveAIfAtStartOrEnd(input2);
        string result3 = BasicAlgorithm.RemoveAIfAtStartOrEnd(input3);
        string result4 = BasicAlgorithm.RemoveAIfAtStartOrEnd(input4);

        // Assert
        Assert.AreEqual("bcab", result1);
        Assert.AreEqual("python", result2);
        Assert.AreEqual("bcd", result3);
        Assert.AreEqual("jython", result4);
    }

    [TestMethod]
    public void RemoveAIfAtStartOrEnd_EdgeCases()
    {
        // Arrange
        string input1 = "a";
        string input2 = "aa";
        string input3 = "aba";
        string input4 = "";
        string input5 = "banana";

        // Act
        string result1 = BasicAlgorithm.RemoveAIfAtStartOrEnd(input1);
        string result2 = BasicAlgorithm.RemoveAIfAtStartOrEnd(input2);
        string result3 = BasicAlgorithm.RemoveAIfAtStartOrEnd(input3);
        string result4 = BasicAlgorithm.RemoveAIfAtStartOrEnd(input4);
        string result5 = BasicAlgorithm.RemoveAIfAtStartOrEnd(input5);

        // Assert
        Assert.AreEqual("", result1);
        Assert.AreEqual("", result2);
        Assert.AreEqual("b", result3);
        Assert.AreEqual("", result4);
        Assert.AreEqual("banan", result5);
    }

    // Exercise 87 - Remove First Two 'a's if Present

    [TestMethod]
    public void RemoveFirstTwoAs_TestCases()
    {
        // Arrange
        string input1 = "abcab";
        string input2 = "python";
        string input3 = "aacda";
        string input4 = "jython";

        // Act
        string result1 = BasicAlgorithm.RemoveFirstTwoAs(input1);
        string result2 = BasicAlgorithm.RemoveFirstTwoAs(input2);
        string result3 = BasicAlgorithm.RemoveFirstTwoAs(input3);
        string result4 = BasicAlgorithm.RemoveFirstTwoAs(input4);

        // Assert
        Assert.AreEqual("bcab", result1);
        Assert.AreEqual("python", result2);
        Assert.AreEqual("cda", result3);
        Assert.AreEqual("jython", result4);
    }

    [TestMethod]
    public void RemoveFirstTwoAs_EdgeCases()
    {
        // Arrange
        string input1 = "aa";
        string input2 = "a";
        string input3 = "";
        string input4 = "banana";
        string input5 = "aabaa";

        // Act
        string result1 = BasicAlgorithm.RemoveFirstTwoAs(input1);
        string result2 = BasicAlgorithm.RemoveFirstTwoAs(input2);
        string result3 = BasicAlgorithm.RemoveFirstTwoAs(input3);
        string result4 = BasicAlgorithm.RemoveFirstTwoAs(input4);
        string result5 = BasicAlgorithm.RemoveFirstTwoAs(input5);

        // Assert
        Assert.AreEqual("", result1);
        Assert.AreEqual("", result2);
        Assert.AreEqual("", result3);
        Assert.AreEqual("banana", result4);
        Assert.AreEqual("baa", result5);
    }

    // Exercise 88 - 10 as First or Last Element in Array

    [TestMethod]
    public void Check10FirstOrLast_TestCases()
    {
        // Arrange
        int[] nums1 = { 10, 20, 40, 50 };
        int[] nums2 = { 5, 20, 40, 10 };
        int[] nums3 = { 10, 20, 40, 10 };
        int[] nums4 = { 12, 24, 35, 55 };

        // Act
        bool result1 = BasicAlgorithm.Check10FirstOrLast(nums1);
        bool result2 = BasicAlgorithm.Check10FirstOrLast(nums2);
        bool result3 = BasicAlgorithm.Check10FirstOrLast(nums3);
        bool result4 = BasicAlgorithm.Check10FirstOrLast(nums4);

        // Assert
        Assert.IsTrue(result1);
        Assert.IsTrue(result2);
        Assert.IsTrue(result3);
        Assert.IsFalse(result4);
    }

    [TestMethod]
    public void Check10FirstOrLast_EdgeCases()
    {
        // Arrange
        int[] nums1 = { 10 };
        int[] nums2 = { 10, 10 };
        int[] nums3 = { 5, 10 };
        int[] nums4 = { 10, 5 };
        int[] nums5 = { 1, 2, 3 };

        // Act
        bool result1 = BasicAlgorithm.Check10FirstOrLast(nums1);
        bool result2 = BasicAlgorithm.Check10FirstOrLast(nums2);
        bool result3 = BasicAlgorithm.Check10FirstOrLast(nums3);
        bool result4 = BasicAlgorithm.Check10FirstOrLast(nums4);
        bool result5 = BasicAlgorithm.Check10FirstOrLast(nums5);

        // Assert
        Assert.IsTrue(result1);
        Assert.IsTrue(result2);
        Assert.IsTrue(result3);
        Assert.IsTrue(result4);
        Assert.IsFalse(result5);
    }

    // Exercise 89 - First and Last Array Elements Equal

    [TestMethod]
    public void FirstLastEqual_TestCases()
    {
        // Arrange
        int[] nums1 = { 10, 20, 40, 50 };
        int[] nums2 = { 10, 20, 40, 10 };
        int[] nums3 = { 12, 24, 35, 55 };

        // Act
        bool result1 = BasicAlgorithm.FirstLastEqual(nums1);
        bool result2 = BasicAlgorithm.FirstLastEqual(nums2);
        bool result3 = BasicAlgorithm.FirstLastEqual(nums3);

        // Assert
        Assert.IsFalse(result1);
        Assert.IsTrue(result2);
        Assert.IsFalse(result3);
    }

    [TestMethod]
    public void FirstLastEqual_EdgeCases()
    {
        // Arrange
        int[] nums1 = { 5 };
        int[] nums2 = { 10, 10 };
        int[] nums3 = { 1, 2, 1 };
        int[] nums4 = { 7, 8, 9, 7 };
        int[] nums5 = { 3, 4, 5, 6 };

        // Act
        bool result1 = BasicAlgorithm.FirstLastEqual(nums1);
        bool result2 = BasicAlgorithm.FirstLastEqual(nums2);
        bool result3 = BasicAlgorithm.FirstLastEqual(nums3);
        bool result4 = BasicAlgorithm.FirstLastEqual(nums4);
        bool result5 = BasicAlgorithm.FirstLastEqual(nums5);

        // Assert
        Assert.IsTrue(result1);
        Assert.IsTrue(result2);
        Assert.IsTrue(result3);
        Assert.IsTrue(result4);
        Assert.IsFalse(result5);
    }

    // Exercise 90 - Same First or Last Element in Two Arrays

    [TestMethod]
    public void SameFirstOrLast_TestCases()
    {
        // Arrange
        int[] a1 = { 10, 20, 40, 50 };
        int[] b1 = { 10, 20, 40, 50 };
        int[] a2 = { 10, 20, 40, 50 };
        int[] b2 = { 10, 20, 40, 5 };
        int[] a3 = { 10, 20, 40, 50 };
        int[] b3 = { 1, 20, 40, 5 };

        // Act
        bool result1 = BasicAlgorithm.SameFirstOrLast(a1, b1);
        bool result2 = BasicAlgorithm.SameFirstOrLast(a2, b2);
        bool result3 = BasicAlgorithm.SameFirstOrLast(a3, b3);

        // Assert
        Assert.IsTrue(result1);
        Assert.IsTrue(result2);
        Assert.IsFalse(result3);
    }

    [TestMethod]
    public void SameFirstOrLast_EdgeCases()
    {
        // Arrange
        int[] a1 = { 5 };
        int[] b1 = { 5 };
        int[] a2 = { 1, 2 };
        int[] b2 = { 3, 2 };
        int[] a3 = { 7, 8, 9 };
        int[] b3 = { 7, 1, 1 };
        int[] a4 = { 4, 5, 6 };
        int[] b4 = { 1, 2, 6 };
        int[] a5 = { 1, 2, 3 };
        int[] b5 = { 4, 5, 6 };

        // Act
        bool result1 = BasicAlgorithm.SameFirstOrLast(a1, b1);
        bool result2 = BasicAlgorithm.SameFirstOrLast(a2, b2);
        bool result3 = BasicAlgorithm.SameFirstOrLast(a3, b3);
        bool result4 = BasicAlgorithm.SameFirstOrLast(a4, b4);
        bool result5 = BasicAlgorithm.SameFirstOrLast(a5, b5);

        // Assert
        Assert.IsTrue(result1);
        Assert.IsTrue(result2);
        Assert.IsTrue(result3);
        Assert.IsTrue(result4);
        Assert.IsFalse(result5);
    }

    // Exercise 91 - Sum of Array Elements

    [TestMethod]
    public void SumArray_TestCases()
    {
        // Arrange
        int[] nums1 = { 10, 20, 30, 40, 50 };
        int[] nums2 = { 10, 20, -30, -40, 50 };

        // Act
        int result1 = BasicAlgorithm.SumArray(nums1);
        int result2 = BasicAlgorithm.SumArray(nums2);

        // Assert
        Assert.AreEqual(150, result1);
        Assert.AreEqual(10, result2);
    }

    [TestMethod]
    public void SumArray_EdgeCases()
    {
        // Arrange
        int[] nums1 = { 5 };
        int[] nums2 = { };
        int[] nums3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] nums4 = { -1, -2, -3, -4, -5 };
        int[] nums5 = { 0, 0, 0, 0 };

        // Act
        int result1 = BasicAlgorithm.SumArray(nums1);
        int result2 = BasicAlgorithm.SumArray(nums2);
        int result3 = BasicAlgorithm.SumArray(nums3);
        int result4 = BasicAlgorithm.SumArray(nums4);
        int result5 = BasicAlgorithm.SumArray(nums5);

        // Assert
        Assert.AreEqual(5, result1);
        Assert.AreEqual(0, result2);
        Assert.AreEqual(55, result3);
        Assert.AreEqual(-15, result4);
        Assert.AreEqual(0, result5);
    }

    // Exercise 92 - Rotate Array Left

    [TestMethod]
    public void RotateLeft_TestCases()
    {
        // Arrange
        int[] nums = { 10, 20, -30, -40 };

        // Act
        int[] result = BasicAlgorithm.RotateLeft(nums);

        // Assert
        CollectionAssert.AreEqual(new int[] { 20, -30, -40, 10 }, result);
    }

    [TestMethod]
    public void RotateLeft_EdgeCases()
    {
        // Arrange
        int[] nums1 = { 1, 2, 3, 4 };
        int[] nums2 = { 5 };
        int[] nums3 = { };
        int[] nums4 = { -1, -2, -3, -4 };
        int[] nums5 = { 0, 0, 0, 0 };

        // Act
        int[] result1 = BasicAlgorithm.RotateLeft(nums1);
        int[] result2 = BasicAlgorithm.RotateLeft(nums2);
        int[] result3 = BasicAlgorithm.RotateLeft(nums3);
        int[] result4 = BasicAlgorithm.RotateLeft(nums4);
        int[] result5 = BasicAlgorithm.RotateLeft(nums5);

        // Assert
        CollectionAssert.AreEqual(new int[] { 2, 3, 4, 1 }, result1);
        CollectionAssert.AreEqual(new int[] { 5 }, result2);
        CollectionAssert.AreEqual(new int[] { }, result3);
        CollectionAssert.AreEqual(new int[] { -2, -3, -4, -1 }, result4);
        CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0 }, result5);
    }

    // Exercise 93 - Reverse Array

    [TestMethod]
    public void ReverseArray_TestCases()
    {
        // Arrange
        int[] nums = { 10, 20, -30, -40, 50 };

        // Act
        int[] result = BasicAlgorithm.ReverseArray(nums);

        // Assert
        CollectionAssert.AreEqual(new int[] { 50, -40, -30, 20, 10 }, result);
    }

    [TestMethod]
    public void ReverseArray_EdgeCases()
    {
        // Arrange
        int[] nums1 = { 1, 2, 3, 4, 5 };
        int[] nums2 = { 5 };
        int[] nums3 = { };
        int[] nums4 = { -1, -2, -3, -4, -5 };
        int[] nums5 = { 0, 0, 0, 0, 0 };

        // Act
        int[] result1 = BasicAlgorithm.ReverseArray(nums1);
        int[] result2 = BasicAlgorithm.ReverseArray(nums2);
        int[] result3 = BasicAlgorithm.ReverseArray(nums3);
        int[] result4 = BasicAlgorithm.ReverseArray(nums4);
        int[] result5 = BasicAlgorithm.ReverseArray(nums5);

        // Assert
        CollectionAssert.AreEqual(new int[] { 5, 4, 3, 2, 1 }, result1);
        CollectionAssert.AreEqual(new int[] { 5 }, result2);
        CollectionAssert.AreEqual(new int[] { }, result3);
        CollectionAssert.AreEqual(new int[] { -5, -4, -3, -2, -1 }, result4);
        CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0 }, result5);
    }

    // Exercise 94 - Replace All Elements with Max of First/Last

    [TestMethod]
    public void ReplaceWithMax_TestCases()
    {
        // Arrange
        int[] nums = { 10, 20, -30, -40 };

        // Act
        int[] result = BasicAlgorithm.ReplaceWithMax(nums);

        // Assert
        CollectionAssert.AreEqual(new int[] { 20, 20, 20, 20 }, result);
    }

    [TestMethod]
    public void ReplaceWithMax_EdgeCases()
    {
        // Arrange
        int[] nums1 = { 5, 2, 3, 4 };
        int[] nums2 = { 10 };
        int[] nums3 = { -5, -10, -3, -1 };
        int[] nums4 = { 0, 0, 0, 0 };
        int[] nums5 = { 100, 50, 75, 200 };

        // Act
        int[] result1 = BasicAlgorithm.ReplaceWithMax(nums1);
        int[] result2 = BasicAlgorithm.ReplaceWithMax(nums2);
        int[] result3 = BasicAlgorithm.ReplaceWithMax(nums3);
        int[] result4 = BasicAlgorithm.ReplaceWithMax(nums4);
        int[] result5 = BasicAlgorithm.ReplaceWithMax(nums5);

        // Assert
        CollectionAssert.AreEqual(new int[] { 5, 5, 5, 5 }, result1);
        CollectionAssert.AreEqual(new int[] { 10 }, result2);
        CollectionAssert.AreEqual(new int[] { -1, -1, -1, -1 }, result3);
        CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0 }, result4);
        CollectionAssert.AreEqual(new int[] { 200, 200, 200, 200 }, result5);
    }

    // Exercise 95 - Middle Elements from Two Arrays

    [TestMethod]
    public void GetMiddleElements_TestCases()
    {
        // Arrange
        int[] a = { 10, 20, -30, -40, 30 };
        int[] b = { 10, 20, 30, 40, 30 };

        // Act
        int[] result = BasicAlgorithm.GetMiddleElements(a, b);

        // Assert
        CollectionAssert.AreEqual(new int[] { -30, 30 }, result);
    }

    [TestMethod]
    public void GetMiddleElements_EdgeCases()
    {
        // Arrange
        int[] a1 = { 1, 2, 3, 4, 5 };
        int[] b1 = { 5, 4, 3, 2, 1 };
        int[] a2 = { 0, 0, 0, 0, 0 };
        int[] b2 = { 1, 1, 1, 1, 1 };
        int[] a3 = { -1, -2, -3, -4, -5 };
        int[] b3 = { -5, -4, -3, -2, -1 };

        // Act
        int[] result1 = BasicAlgorithm.GetMiddleElements(a1, b1);
        int[] result2 = BasicAlgorithm.GetMiddleElements(a2, b2);
        int[] result3 = BasicAlgorithm.GetMiddleElements(a3, b3);

        // Assert
        CollectionAssert.AreEqual(new int[] { 3, 3 }, result1);
        CollectionAssert.AreEqual(new int[] { 0, 1 }, result2);
        CollectionAssert.AreEqual(new int[] { -3, -3 }, result3);
    }

    // Exercise 96 - First and Last Elements of Array

    [TestMethod]
    public void GetFirstLastElements_TestCases()
    {
        // Arrange
        int[] nums = { 10, 20, -30, -40, 30 };

        // Act
        int[] result = BasicAlgorithm.GetFirstLastElements(nums);

        // Assert
        CollectionAssert.AreEqual(new int[] { 10, 30 }, result);
    }

    [TestMethod]
    public void GetFirstLastElements_EdgeCases()
    {
        // Arrange
        int[] nums1 = { 5 };
        int[] nums2 = { 1, 2 };
        int[] nums3 = { -1, -2, -3 };
        int[] nums4 = { 0, 0, 0, 0 };
        int[] nums5 = { 100, 200, 300, 400, 500 };

        // Act
        int[] result1 = BasicAlgorithm.GetFirstLastElements(nums1);
        int[] result2 = BasicAlgorithm.GetFirstLastElements(nums2);
        int[] result3 = BasicAlgorithm.GetFirstLastElements(nums3);
        int[] result4 = BasicAlgorithm.GetFirstLastElements(nums4);
        int[] result5 = BasicAlgorithm.GetFirstLastElements(nums5);

        // Assert
        CollectionAssert.AreEqual(new int[] { 5, 5 }, result1);
        CollectionAssert.AreEqual(new int[] { 1, 2 }, result2);
        CollectionAssert.AreEqual(new int[] { -1, -3 }, result3);
        CollectionAssert.AreEqual(new int[] { 0, 0 }, result4);
        CollectionAssert.AreEqual(new int[] { 100, 500 }, result5);
    }

    // Exercise 97 - Array of Length 2 Contains 15 or 20

    [TestMethod]
    public void Contains15Or20_TestCases()
    {
        // Arrange
        int[] nums1 = { 12, 20 };
        int[] nums2 = { 14, 15 };
        int[] nums3 = { 11, 21 };

        // Act
        bool result1 = BasicAlgorithm.Contains15Or20(nums1);
        bool result2 = BasicAlgorithm.Contains15Or20(nums2);
        bool result3 = BasicAlgorithm.Contains15Or20(nums3);

        // Assert
        Assert.IsTrue(result1);
        Assert.IsTrue(result2);
        Assert.IsFalse(result3);
    }

    [TestMethod]
    public void Contains15Or20_EdgeCases()
    {
        // Arrange
        int[] nums1 = { 15, 15 };
        int[] nums2 = { 20, 20 };
        int[] nums3 = { 15, 20 };
        int[] nums4 = { 0, 15 };
        int[] nums5 = { 20, 0 };

        // Act
        bool result1 = BasicAlgorithm.Contains15Or20(nums1);
        bool result2 = BasicAlgorithm.Contains15Or20(nums2);
        bool result3 = BasicAlgorithm.Contains15Or20(nums3);
        bool result4 = BasicAlgorithm.Contains15Or20(nums4);
        bool result5 = BasicAlgorithm.Contains15Or20(nums5);

        // Assert
        Assert.IsTrue(result1);
        Assert.IsTrue(result2);
        Assert.IsTrue(result3);
        Assert.IsTrue(result4);
        Assert.IsTrue(result5);
    }

    // Exercise 98 - Array of Length 2 Does Not Contain 15 or 20

    [TestMethod]
    public void NotContains15Or20_TestCases()
    {
        // Arrange
        int[] nums1 = { 12, 20 };
        int[] nums2 = { 14, 15 };
        int[] nums3 = { 11, 21 };

        // Act
        bool result1 = BasicAlgorithm.NotContains15Or20(nums1);
        bool result2 = BasicAlgorithm.NotContains15Or20(nums2);
        bool result3 = BasicAlgorithm.NotContains15Or20(nums3);

        // Assert
        Assert.IsFalse(result1);
        Assert.IsFalse(result2);
        Assert.IsTrue(result3);
    }

    [TestMethod]
    public void NotContains15Or20_EdgeCases()
    {
        // Arrange
        int[] nums1 = { 15, 15 };
        int[] nums2 = { 20, 20 };
        int[] nums3 = { 15, 20 };
        int[] nums4 = { 10, 25 };
        int[] nums5 = { 0, 30 };

        // Act
        bool result1 = BasicAlgorithm.NotContains15Or20(nums1);
        bool result2 = BasicAlgorithm.NotContains15Or20(nums2);
        bool result3 = BasicAlgorithm.NotContains15Or20(nums3);
        bool result4 = BasicAlgorithm.NotContains15Or20(nums4);
        bool result5 = BasicAlgorithm.NotContains15Or20(nums5);

        // Assert
        Assert.IsFalse(result1);
        Assert.IsFalse(result2);
        Assert.IsFalse(result3);
        Assert.IsTrue(result4);
        Assert.IsTrue(result5);
    }

    // Exercise 99 - Double Length Array with First Element Copied

    [TestMethod]
    public void DoubleLengthArray_TestCases()
    {
        // Arrange
        int[] nums = { 10, 20, -30, -40, 30 };

        // Act
        int[] result = BasicAlgorithm.DoubleLengthArray(nums);

        // Assert
        int[] expected = { 10, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void DoubleLengthArray_EdgeCases()
    {
        // Arrange
        int[] nums1 = { 5 };
        int[] nums2 = { 1, 2 };
        int[] nums3 = { -1, -2, -3 };
        int[] nums4 = { 0, 0, 0, 0 };

        // Act
        int[] result1 = BasicAlgorithm.DoubleLengthArray(nums1);
        int[] result2 = BasicAlgorithm.DoubleLengthArray(nums2);
        int[] result3 = BasicAlgorithm.DoubleLengthArray(nums3);
        int[] result4 = BasicAlgorithm.DoubleLengthArray(nums4);

        // Assert
        int[] expected1 = { 5, 0 };
        int[] expected2 = { 1, 0, 0, 0 };
        int[] expected3 = { -1, 0, 0, 0, 0, 0 };
        int[] expected4 = { 0, 0, 0, 0, 0, 0, 0, 0 };

        CollectionAssert.AreEqual(expected1, result1);
        CollectionAssert.AreEqual(expected2, result2);
        CollectionAssert.AreEqual(expected3, result3);
        CollectionAssert.AreEqual(expected4, result4);
    }

    // Exercise 100 - Check if 10 or 20 Appears Twice in Array

    [TestMethod]
    public void Contains10Or20Twice_TestCases()
    {
        // Arrange
        int[] nums1 = { 12, 20 };
        int[] nums2 = { 20, 20 };
        int[] nums3 = { 10, 10 };
        int[] nums4 = { 10 };

        // Act
        bool result1 = BasicAlgorithm.Contains10Or20Twice(nums1);
        bool result2 = BasicAlgorithm.Contains10Or20Twice(nums2);
        bool result3 = BasicAlgorithm.Contains10Or20Twice(nums3);
        bool result4 = BasicAlgorithm.Contains10Or20Twice(nums4);

        // Assert
        Assert.IsFalse(result1);
        Assert.IsTrue(result2);
        Assert.IsTrue(result3);
        Assert.IsFalse(result4);
    }

    [TestMethod]
    public void Contains10Or20Twice_EdgeCases()
    {
        // Arrange
        int[] nums1 = { };
        int[] nums2 = { 10, 20 };
        int[] nums3 = { 10, 10, 10 };
        int[] nums4 = { 20, 20, 20 };
        int[] nums5 = { 5, 5 };

        // Act
        bool result1 = BasicAlgorithm.Contains10Or20Twice(nums1);
        bool result2 = BasicAlgorithm.Contains10Or20Twice(nums2);
        bool result3 = BasicAlgorithm.Contains10Or20Twice(nums3);
        bool result4 = BasicAlgorithm.Contains10Or20Twice(nums4);
        bool result5 = BasicAlgorithm.Contains10Or20Twice(nums5);

        // Assert
        Assert.IsFalse(result1);
        Assert.IsFalse(result2);
        Assert.IsFalse(result3);
        Assert.IsFalse(result4);
        Assert.IsFalse(result5);
    }

    // Exercise 101 - Set 7 to 1 if Followed by 5

    [TestMethod]
    public void Set7To1IfFollowedBy5_TestCases()
    {
        // Arrange
        int[] nums = { 1, 5, 7 };

        // Act
        int[] result = BasicAlgorithm.Set7To1IfFollowedBy5(nums);

        // Assert
        CollectionAssert.AreEqual(new int[] { 1, 5, 1 }, result);
    }

    [TestMethod]
    public void Set7To1IfFollowedBy5_EdgeCases()
    {
        // Arrange
        int[] nums1 = { 5, 7, 8 };
        int[] nums2 = { 5, 7, 7 };
        int[] nums3 = { 1, 2, 3 };
        int[] nums4 = { 5, 5, 7 };
        int[] nums5 = { 7, 5, 7 };

        // Act
        int[] result1 = BasicAlgorithm.Set7To1IfFollowedBy5(nums1);
        int[] result2 = BasicAlgorithm.Set7To1IfFollowedBy5(nums2);
        int[] result3 = BasicAlgorithm.Set7To1IfFollowedBy5(nums3);
        int[] result4 = BasicAlgorithm.Set7To1IfFollowedBy5(nums4);
        int[] result5 = BasicAlgorithm.Set7To1IfFollowedBy5(nums5);

        // Assert
        CollectionAssert.AreEqual(new int[] { 5, 1, 8 }, result1);
        CollectionAssert.AreEqual(new int[] { 5, 1, 7 }, result2);
        CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, result3);
        CollectionAssert.AreEqual(new int[] { 5, 5, 1 }, result4);
        CollectionAssert.AreEqual(new int[] { 7, 5, 1 }, result5);
    }

    // Exercise 102 - Largest Sum Between Two Arrays

    [TestMethod]
    public void GetLargerSumArray_TestCases()
    {
        // Arrange
        int[] a = { 10, 20, -30 };
        int[] b = { 10, 20, 30 };

        // Act
        int[] result = BasicAlgorithm.GetLargerSumArray(a, b);

        // Assert
        CollectionAssert.AreEqual(b, result);
    }

    [TestMethod]
    public void GetLargerSumArray_EdgeCases()
    {
        // Arrange
        int[] a1 = { 1, 2, 3 };
        int[] b1 = { 4, 5, 6 };
        int[] a2 = { 10, 10, 10 };
        int[] b2 = { 5, 15, 10 };
        int[] a3 = { -1, -2, -3 };
        int[] b3 = { -4, -5, -6 };
        int[] a4 = { 0, 0, 0 };
        int[] b4 = { 0, 0, 0 };

        // Act
        int[] result1 = BasicAlgorithm.GetLargerSumArray(a1, b1);
        int[] result2 = BasicAlgorithm.GetLargerSumArray(a2, b2);
        int[] result3 = BasicAlgorithm.GetLargerSumArray(a3, b3);
        int[] result4 = BasicAlgorithm.GetLargerSumArray(a4, b4);

        // Assert
        CollectionAssert.AreEqual(b1, result1);
        CollectionAssert.AreEqual(a2, result2);
        CollectionAssert.AreEqual(a3, result3);
        CollectionAssert.AreEqual(a4, result4);
    }

    // Exercise 103 - Middle Elements of Even-Length Array

    [TestMethod]
    public void GetMiddleElement_TestCases()
    {
        // Arrange
        int[] nums = { 1, 5, 7, 9, 11, 13 };

        // Act
        int[] result = BasicAlgorithm.GetMiddleElements(nums);

        // Assert
        CollectionAssert.AreEqual(new int[] { 7, 9 }, result);
    }

    [TestMethod]
    public void GetMiddleElement_EdgeCases()
    {
        // Arrange
        int[] nums1 = { 1, 2 };
        int[] nums2 = { 1, 2, 3, 4 };
        int[] nums3 = { 10, 20, 30, 40, 50, 60 };
        int[] nums4 = { -1, -2, -3, -4 };
        int[] nums5 = { 0, 0, 0, 0 };

        // Act
        int[] result1 = BasicAlgorithm.GetMiddleElements(nums1);
        int[] result2 = BasicAlgorithm.GetMiddleElements(nums2);
        int[] result3 = BasicAlgorithm.GetMiddleElements(nums3);
        int[] result4 = BasicAlgorithm.GetMiddleElements(nums4);
        int[] result5 = BasicAlgorithm.GetMiddleElements(nums5);

        // Assert
        CollectionAssert.AreEqual(new int[] { 1, 2 }, result1);
        CollectionAssert.AreEqual(new int[] { 2, 3 }, result2);
        CollectionAssert.AreEqual(new int[] { 30, 40 }, result3);
        CollectionAssert.AreEqual(new int[] { -2, -3 }, result4);
        CollectionAssert.AreEqual(new int[] { 0, 0 }, result5);
    }

    // Exercise 104 - Merge Two Arrays of Length 3

    [TestMethod]
    public void MergeArrays_TestCases()
    {
        // Arrange
        int[] a = { 10, 20, 30 };
        int[] b = { 40, 50, 60 };

        // Act
        int[] result = BasicAlgorithm.MergeArrays(a, b);

        // Assert
        CollectionAssert.AreEqual(new int[] { 10, 20, 30, 40, 50, 60 }, result);
    }

    [TestMethod]
    public void MergeArrays_EdgeCases()
    {
        // Arrange
        int[] a1 = { 1, 2, 3 };
        int[] b1 = { 4, 5, 6 };
        int[] a2 = { -1, -2, -3 };
        int[] b2 = { -4, -5, -6 };
        int[] a3 = { 0, 0, 0 };
        int[] b3 = { 0, 0, 0 };
        int[] a4 = { 100, 200, 300 };
        int[] b4 = { 400, 500, 600 };

        // Act
        int[] result1 = BasicAlgorithm.MergeArrays(a1, b1);
        int[] result2 = BasicAlgorithm.MergeArrays(a2, b2);
        int[] result3 = BasicAlgorithm.MergeArrays(a3, b3);
        int[] result4 = BasicAlgorithm.MergeArrays(a4, b4);

        // Assert
        CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6 }, result1);
        CollectionAssert.AreEqual(new int[] { -1, -2, -3, -4, -5, -6 }, result2);
        CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0, 0 }, result3);
        CollectionAssert.AreEqual(new int[] { 100, 200, 300, 400, 500, 600 }, result4);
    }

    // Exercise 105 - Swap First and Last Array Elements

    [TestMethod]
    public void SwapFirstLast_TestCases()
    {
        // Arrange
        int[] nums = { 1, 5, 7, 9, 11, 13 };

        // Act
        int[] result = BasicAlgorithm.SwapFirstLast(nums);

        // Assert
        CollectionAssert.AreEqual(new int[] { 13, 5, 7, 9, 11, 1 }, result);
    }

    [TestMethod]
    public void SwapFirstLast_EdgeCases()
    {
        // Arrange
        int[] nums1 = { 1 };
        int[] nums2 = { 1, 2 };
        int[] nums3 = { 10, 20, 30 };
        int[] nums4 = { -1, -2, -3, -4 };
        int[] nums5 = { 0, 0, 0, 0, 0 };

        // Act
        int[] result1 = BasicAlgorithm.SwapFirstLast(nums1);
        int[] result2 = BasicAlgorithm.SwapFirstLast(nums2);
        int[] result3 = BasicAlgorithm.SwapFirstLast(nums3);
        int[] result4 = BasicAlgorithm.SwapFirstLast(nums4);
        int[] result5 = BasicAlgorithm.SwapFirstLast(nums5);

        // Assert
        CollectionAssert.AreEqual(new int[] { 1 }, result1);
        CollectionAssert.AreEqual(new int[] { 2, 1 }, result2);
        CollectionAssert.AreEqual(new int[] { 30, 20, 10 }, result3);
        CollectionAssert.AreEqual(new int[] { -4, -2, -3, -1 }, result4);
        CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0 }, result5);
    }

    // Exercise 106 - Middle Elements in New Array of Length 3

    [TestMethod]
    public void MiddleElementsToNewArray_TestCases()
    {
        // Arrange
        int[] nums = { 1, 5, 7, 9, 11, 13 };

        // Act
        int[] result = BasicAlgorithm.MiddleElementsToNewArray(nums);

        // Assert
        CollectionAssert.AreEqual(new int[] { 7, 9, 11 }, result);
    }

    [TestMethod]
    public void MiddleElementsToNewArray_EdgeCases()
    {
        // Arrange
        int[] nums1 = { 1, 2, 3, 4, 5 };
        int[] nums2 = { 10, 20, 30, 40, 50, 60, 70 };
        int[] nums3 = { -1, -2, -3, -4, -5 };
        int[] nums4 = { 0, 0, 0, 0, 0, 0 };

        // Act
        int[] result1 = BasicAlgorithm.MiddleElementsToNewArray(nums1);
        int[] result2 = BasicAlgorithm.MiddleElementsToNewArray(nums2);
        int[] result3 = BasicAlgorithm.MiddleElementsToNewArray(nums3);
        int[] result4 = BasicAlgorithm.MiddleElementsToNewArray(nums4);

        // Assert
        CollectionAssert.AreEqual(new int[] { 2, 3, 4 }, result1);
        CollectionAssert.AreEqual(new int[] { 30, 40, 50 }, result2);
        CollectionAssert.AreEqual(new int[] { -2, -3, -4 }, result3);
        CollectionAssert.AreEqual(new int[] { 0, 0, 0 }, result4);
    }

    // Exercise 107 - Largest Among First, Middle, and Last Elements

    [TestMethod]
    public void LargestFirstMiddleLast_TestCases()
    {
        // Arrange
        int[] nums1 = { 1 };
        int[] nums2 = { 1, 2, 9 };
        int[] nums3 = { 1, 2, 9, 3, 3 };
        int[] nums4 = { 1, 2, 3, 4, 5, 6, 7 };
        int[] nums5 = { 1, 2, 2, 3, 7, 8, 9, 10, 6, 5, 4 };

        // Act
        int result1 = BasicAlgorithm.LargestFirstMiddleLast(nums1);
        int result2 = BasicAlgorithm.LargestFirstMiddleLast(nums2);
        int result3 = BasicAlgorithm.LargestFirstMiddleLast(nums3);
        int result4 = BasicAlgorithm.LargestFirstMiddleLast(nums4);
        int result5 = BasicAlgorithm.LargestFirstMiddleLast(nums5);

        // Assert
        Assert.AreEqual(1, result1);
        Assert.AreEqual(9, result2);
        Assert.AreEqual(9, result3);
        Assert.AreEqual(7, result4);
        Assert.AreEqual(8, result5);
    }

    [TestMethod]
    public void LargestFirstMiddleLast_EdgeCases()
    {
        // Arrange
        int[] nums1 = { 5, 1, 5 };
        int[] nums2 = { 10, 20, 30, 40, 50 };
        int[] nums3 = { -5, -10, -3 };
        int[] nums4 = { 0, 0, 0 };
        int[] nums5 = { 100, 50, 75 };

        // Act
        int result1 = BasicAlgorithm.LargestFirstMiddleLast(nums1);
        int result2 = BasicAlgorithm.LargestFirstMiddleLast(nums2);
        int result3 = BasicAlgorithm.LargestFirstMiddleLast(nums3);
        int result4 = BasicAlgorithm.LargestFirstMiddleLast(nums4);
        int result5 = BasicAlgorithm.LargestFirstMiddleLast(nums5);

        // Assert
        Assert.AreEqual(5, result1);
        Assert.AreEqual(50, result2);
        Assert.AreEqual(-3, result3);
        Assert.AreEqual(0, result4);
        Assert.AreEqual(100, result5);
    }

    // Exercise 108 - First Two Elements or Full Array

    [TestMethod]
    public void FirstTwoElements_TestCases()
    {
        // Arrange
        int[] nums = { 1, 5, 7, 9, 11, 13 };

        // Act
        int[] result = BasicAlgorithm.FirstTwoElements(nums);

        // Assert
        CollectionAssert.AreEqual(new int[] { 1, 5 }, result);
    }

    [TestMethod]
    public void FirstTwoElements_EdgeCases()
    {
        // Arrange
        int[] nums1 = { 1 };
        int[] nums2 = { 1, 2 };
        int[] nums3 = { };
        int[] nums4 = { 10, 20, 30, 40 };
        int[] nums5 = { -1, -2, -3 };

        // Act
        int[] result1 = BasicAlgorithm.FirstTwoElements(nums1);
        int[] result2 = BasicAlgorithm.FirstTwoElements(nums2);
        int[] result3 = BasicAlgorithm.FirstTwoElements(nums3);
        int[] result4 = BasicAlgorithm.FirstTwoElements(nums4);
        int[] result5 = BasicAlgorithm.FirstTwoElements(nums5);

        // Assert
        CollectionAssert.AreEqual(new int[] { 1 }, result1);
        CollectionAssert.AreEqual(new int[] { 1, 2 }, result2);
        CollectionAssert.AreEqual(new int[] { }, result3);
        CollectionAssert.AreEqual(new int[] { 10, 20 }, result4);
        CollectionAssert.AreEqual(new int[] { -1, -2 }, result5);
    }

    // Exercise 109 - Count Even Elements in Array

    [TestMethod]
    public void CountEvenElements_TestCases()
    {
        // Arrange
        int[] nums = { 1, 5, 7, 9, 10, 12 };

        // Act
        int result = BasicAlgorithm.CountEvenElements(nums);

        // Assert
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void CountEvenElements_EdgeCases()
    {
        // Arrange
        int[] nums1 = { 2, 4, 6, 8 };
        int[] nums2 = { 1, 3, 5, 7 };
        int[] nums3 = { };
        int[] nums4 = { 0 };
        int[] nums5 = { 10, 15, 20, 25, 30 };

        // Act
        int result1 = BasicAlgorithm.CountEvenElements(nums1);
        int result2 = BasicAlgorithm.CountEvenElements(nums2);
        int result3 = BasicAlgorithm.CountEvenElements(nums3);
        int result4 = BasicAlgorithm.CountEvenElements(nums4);
        int result5 = BasicAlgorithm.CountEvenElements(nums5);

        // Assert
        Assert.AreEqual(4, result1);
        Assert.AreEqual(0, result2);
        Assert.AreEqual(0, result3);
        Assert.AreEqual(1, result4);
        Assert.AreEqual(3, result5);
    }

    // Exercise 110 - Difference Between Largest and Smallest Values

    [TestMethod]
    public void DifferenceMaxMin_TestCases()
    {
        // Arrange
        int[] nums = { 1, 5, 7, 9, 10, 12 };

        // Act
        int result = BasicAlgorithm.DifferenceMaxMin(nums);

        // Assert
        Assert.AreEqual(11, result);
    }

    [TestMethod]
    public void DifferenceMaxMin_EdgeCases()
    {
        // Arrange
        int[] nums1 = { 5 };
        int[] nums2 = { 10, 10 };
        int[] nums3 = { -5, -10, -3 };
        int[] nums4 = { 0, 0, 0 };
        int[] nums5 = { 100, 50, 75, 200 };

        // Act
        int result1 = BasicAlgorithm.DifferenceMaxMin(nums1);
        int result2 = BasicAlgorithm.DifferenceMaxMin(nums2);
        int result3 = BasicAlgorithm.DifferenceMaxMin(nums3);
        int result4 = BasicAlgorithm.DifferenceMaxMin(nums4);
        int result5 = BasicAlgorithm.DifferenceMaxMin(nums5);

        // Assert
        Assert.AreEqual(0, result1);
        Assert.AreEqual(0, result2);
        Assert.AreEqual(7, result3);
        Assert.AreEqual(0, result4);
        Assert.AreEqual(150, result5);
    }

    // Exercise 111 - Sum Excluding 17

    [TestMethod]
    public void TestSumExcluding17()
    {
        // Arrange
        int[] inputArray = { 1, 5, 7, 9, 10, 17 };

        // Act
        int result = BasicAlgorithm.SumExcluding17(inputArray);

        // Assert
        Assert.AreEqual(32, result);
    }

    // Exercise 112 - Sum Excluding Numbers Starting with 5 and 6

    [TestMethod]
    public void TestSumExcluding5And6Sequence()
    {
        // Arrange
        int[] inputArray1 = { 5, 6, 1, 5, 6, 9, 10, 17, 5, 6 };
        int[] inputArray2 = { 5, 6, 1, 5, 6, 9, 10, 17 };
        int[] inputArray3 = { 1, 5, 6, 9, 10, 17, 5, 6 };
        int[] inputArray4 = { 1, 5, 9, 10, 17, 5, 6 };
        int[] inputArray5 = { 1, 5, 9, 10, 17, 5 };

        // Act
        int result1 = BasicAlgorithm.SumExcluding5And6Sequence(inputArray1);
        int result2 = BasicAlgorithm.SumExcluding5And6Sequence(inputArray2);
        int result3 = BasicAlgorithm.SumExcluding5And6Sequence(inputArray3);
        int result4 = BasicAlgorithm.SumExcluding5And6Sequence(inputArray4);
        int result5 = BasicAlgorithm.SumExcluding5And6Sequence(inputArray5);

        // Assert
        Assert.AreEqual(37, result1);
        Assert.AreEqual(37, result2);
        Assert.AreEqual(37, result3);
        Assert.AreEqual(42, result4);
        Assert.AreEqual(47, result5);
    }

    // Exercise 113 - Check for 5 Next to 5

    [TestMethod]
    public void TestCheckFor5NextTo5()
    {
        // Arrange
        int[] inputArray1 = { 1, 5, 6, 9, 10, 17 };
        int[] inputArray2 = { 1, 5, 5, 9, 10, 17 };
        int[] inputArray3 = { 1, 5, 5, 9, 10, 17, 5, 5 };

        // Act
        bool result1 = BasicAlgorithm.CheckFor5NextTo5(inputArray1);
        bool result2 = BasicAlgorithm.CheckFor5NextTo5(inputArray2);
        bool result3 = BasicAlgorithm.CheckFor5NextTo5(inputArray3);

        // Assert
        Assert.AreEqual(false, result1);
        Assert.AreEqual(true, result2);
        Assert.AreEqual(true, result3);
    }

    // Exercise 114 - Check for Both 5's and 7's in Array

    [TestMethod]
    public void TestCheckFor5And7()
    {
        // Arrange
        int[] inputArray1 = { 1, 5, 6, 9, 10, 17 };
        int[] inputArray2 = { 1, 4, 7, 9, 10, 17 };
        int[] inputArray3 = { 1, 1, 2, 9, 10, 17 };

        // Act
        bool result1 = BasicAlgorithm.CheckFor5And7(inputArray1);
        bool result2 = BasicAlgorithm.CheckFor5And7(inputArray2);
        bool result3 = BasicAlgorithm.CheckFor5And7(inputArray3);

        // Assert
        Assert.AreEqual(false, result1);
        Assert.AreEqual(false, result2);
        Assert.AreEqual(false, result3);
    }

    // Exercise 115 - Sum of 5's Equals 15

    [TestMethod]
    public void TestSumOf5sEquals15()
    {
        // Arrange
        int[] inputArray1 = { 1, 5, 6, 9, 10, 17 };
        int[] inputArray2 = { 1, 5, 5, 5, 10, 17 };
        int[] inputArray3 = { 1, 1, 5, 5, 5, 5 };

        // Act
        bool result1 = BasicAlgorithm.SumOf5sEquals15(inputArray1);
        bool result2 = BasicAlgorithm.SumOf5sEquals15(inputArray2);
        bool result3 = BasicAlgorithm.SumOf5sEquals15(inputArray3);

        // Assert
        Assert.AreEqual(false, result1);
        Assert.AreEqual(true, result2);
        Assert.AreEqual(false, result3);
    }

    // Exercise 116 - Check If 3's Outnumber 5's

    [TestMethod]
    public void TestThreesOutnumberFives()
    {
        // Arrange
        int[] inputArray1 = { 1, 5, 6, 9, 3, 3 };
        int[] inputArray2 = { 1, 5, 5, 5, 10, 17 };
        int[] inputArray3 = { 1, 3, 3, 5, 5, 5 };

        // Act
        bool result1 = BasicAlgorithm.ThreesOutnumberFives(inputArray1);
        bool result2 = BasicAlgorithm.ThreesOutnumberFives(inputArray2);
        bool result3 = BasicAlgorithm.ThreesOutnumberFives(inputArray3);

        // Assert
        Assert.AreEqual(true, result1);
        Assert.AreEqual(false, result2);
        Assert.AreEqual(false, result3);
    }

    // Exercise 117 - Check If Array Contains 3 or 5

    [TestMethod]
    public void TestContains3Or5()
    {
        // Arrange
        int[] inputArray1 = { 5, 5, 5, 5, 5 };
        int[] inputArray2 = { 3, 3, 3, 3 };
        int[] inputArray3 = { 3, 3, 3, 5, 5, 5 };
        int[] inputArray4 = { 1, 6, 8, 10 };

        // Act
        bool result1 = BasicAlgorithm.Contains3Or5(inputArray1);
        bool result2 = BasicAlgorithm.Contains3Or5(inputArray2);
        bool result3 = BasicAlgorithm.Contains3Or5(inputArray3);
        bool result4 = BasicAlgorithm.Contains3Or5(inputArray4);

        // Assert
        Assert.AreEqual(true, result1);
        Assert.AreEqual(true, result2);
        Assert.AreEqual(true, result3);
        Assert.AreEqual(false, result4);
    }

    // Exercise 118 - Check If Array Contains No 3 or 5

    [TestMethod]
    public void TestContainsNo3Or5()
    {
        // Arrange
        int[] inputArray1 = { 5, 5, 5, 5, 5 };
        int[] inputArray2 = { 3, 3, 3, 3 };
        int[] inputArray3 = { 3, 3, 3, 5, 5, 5 };
        int[] inputArray4 = { 1, 6, 8, 10 };

        // Act
        bool result1 = BasicAlgorithm.ContainsNo3Or5(inputArray1);
        bool result2 = BasicAlgorithm.ContainsNo3Or5(inputArray2);
        bool result3 = BasicAlgorithm.ContainsNo3Or5(inputArray3);
        bool result4 = BasicAlgorithm.ContainsNo3Or5(inputArray4);

        // Assert
        Assert.AreEqual(false, result1);
        Assert.AreEqual(false, result2);
        Assert.AreEqual(false, result3);
        Assert.AreEqual(true, result4);
    }

    // Exercise 119 - Check for 3 or 5 Next to Each Other

    [TestMethod]
    public void TestHas3Or5Adjacent()
    {
        // Arrange
        int[] inputArray1 = { 5, 5, 5, 5, 5 };
        int[] inputArray2 = { 1, 2, 3, 4 };
        int[] inputArray3 = { 3, 3, 5, 5, 5, 5 };
        int[] inputArray4 = { 1, 5, 5, 7, 8, 10 };

        // Act
        bool result1 = BasicAlgorithm.Has3Or5Adjacent(inputArray1);
        bool result2 = BasicAlgorithm.Has3Or5Adjacent(inputArray2);
        bool result3 = BasicAlgorithm.Has3Or5Adjacent(inputArray3);
        bool result4 = BasicAlgorithm.Has3Or5Adjacent(inputArray4);

        // Assert
        Assert.AreEqual(true, result1);
        Assert.AreEqual(false, result2);
        Assert.AreEqual(true, result3);
        Assert.AreEqual(true, result4);
    }

    // Exercise 120 - Check for Two 5's Adjacent or Separated by One

    [TestMethod]
    public void TestHasTwo5sAdjacentOrSeparated()
    {
        // Arrange
        int[] inputArray1 = { 5, 5, 1, 5, 5 };
        int[] inputArray2 = { 1, 2, 3, 4 };
        int[] inputArray3 = { 3, 3, 5, 5, 5, 5 };
        int[] inputArray4 = { 1, 5, 5, 7, 8, 10 };

        // Act
        bool result1 = BasicAlgorithm.HasTwo5sAdjacentOrSeparated(inputArray1);
        bool result2 = BasicAlgorithm.HasTwo5sAdjacentOrSeparated(inputArray2);
        bool result3 = BasicAlgorithm.HasTwo5sAdjacentOrSeparated(inputArray3);
        bool result4 = BasicAlgorithm.HasTwo5sAdjacentOrSeparated(inputArray4);

        // Assert
        Assert.AreEqual(true, result1);
        Assert.AreEqual(false, result2);
        Assert.AreEqual(true, result3);
        Assert.AreEqual(true, result4);
    }

    // Exercise 121 - Check for 3 Before 5 in Array

    [TestMethod]
    public void TestHas3Before5()
    {
        // Arrange
        int[] inputArray1 = { 3, 5, 1, 3, 7 };
        int[] inputArray2 = { 1, 2, 3, 4 };
        int[] inputArray3 = { 3, 3, 5, 5, 5, 5 };
        int[] inputArray4 = { 2, 5, 5, 7, 8, 10 };

        // Act
        bool result1 = BasicAlgorithm.Has3Before5(inputArray1);
        bool result2 = BasicAlgorithm.Has3Before5(inputArray2);
        bool result3 = BasicAlgorithm.Has3Before5(inputArray3);
        bool result4 = BasicAlgorithm.Has3Before5(inputArray4);

        // Assert
        Assert.AreEqual(true, result1);
        Assert.AreEqual(false, result2);
        Assert.AreEqual(true, result3);
        Assert.AreEqual(false, result4);
    }

    // Exercise 122 - Two Consecutive Even or Odd Values

    [TestMethod]
    public void TestHasTwoConsecutiveEvenOrOdd()
    {
        // Arrange
        int[] inputArray1 = { 3, 5, 1, 3, 7 };
        int[] inputArray2 = { 1, 2, 3, 4 };
        int[] inputArray3 = { 3, 3, 5, 5, 5, 5 };
        int[] inputArray4 = { 2, 4, 5, 6 };

        // Act
        bool result1 = BasicAlgorithm.HasTwoConsecutiveEvenOrOdd(inputArray1);
        bool result2 = BasicAlgorithm.HasTwoConsecutiveEvenOrOdd(inputArray2);
        bool result3 = BasicAlgorithm.HasTwoConsecutiveEvenOrOdd(inputArray3);
        bool result4 = BasicAlgorithm.HasTwoConsecutiveEvenOrOdd(inputArray4);

        // Assert
        Assert.AreEqual(true, result1);
        Assert.AreEqual(false, result2);
        Assert.AreEqual(true, result3);
        Assert.AreEqual(true, result4);
    }

    // Exercise 123 - Check for 5 Exactly Five Times Without Adjacent

    [TestMethod]
    public void TestHasFive5sNoAdjacent()
    {
        // Arrange
        int[] inputArray1 = { 3, 5, 1, 5, 3, 5, 7, 5, 1, 5 };
        int[] inputArray2 = { 3, 5, 5, 5, 5, 5, 5 };
        int[] inputArray3 = { 3, 5, 2, 5, 4, 5, 7, 5, 8, 5 };
        int[] inputArray4 = { 2, 4, 5, 5, 5, 5 };
        int[] inputArray5 = { 3, 5, 5, 5, 5, 5, 5, 5, 5, 5 };

        // Act
        bool result1 = BasicAlgorithm.HasFive5sNoAdjacent(inputArray1);
        bool result2 = BasicAlgorithm.HasFive5sNoAdjacent(inputArray2);
        bool result3 = BasicAlgorithm.HasFive5sNoAdjacent(inputArray3);
        bool result4 = BasicAlgorithm.HasFive5sNoAdjacent(inputArray4);
        bool result5 = BasicAlgorithm.HasFive5sNoAdjacent(inputArray5);

        // Assert
        Assert.AreEqual(true, result1);
        Assert.AreEqual(false, result2);
        Assert.AreEqual(true, result3);
        Assert.AreEqual(false, result4);
        Assert.AreEqual(false, result5);
    }

    // Exercise 124 - Check If Every 5 is Next to Another 5

    [TestMethod]
    public void TestEvery5NextToAnother5()
    {
        // Arrange
        int[] inputArray1 = { 3, 5, 5, 3, 7 };
        int[] inputArray2 = { 3, 5, 5, 4, 1, 5, 7 };
        int[] inputArray3 = { 3, 5, 5, 5, 5, 5 };
        int[] inputArray4 = { 2, 4, 5, 5, 6, 7, 5 };

        // Act
        bool result1 = BasicAlgorithm.Every5NextToAnother5(inputArray1);
        bool result2 = BasicAlgorithm.Every5NextToAnother5(inputArray2);
        bool result3 = BasicAlgorithm.Every5NextToAnother5(inputArray3);
        bool result4 = BasicAlgorithm.Every5NextToAnother5(inputArray4);

        // Assert
        Assert.AreEqual(true, result1);
        Assert.AreEqual(false, result2);
        Assert.AreEqual(true, result3);
        Assert.AreEqual(false, result4);
    }

    // Exercise 125 - Check Equal Elements at Start and End

    [TestMethod]
    public void TestEqualElementsAtStartAndEnd()
    {
        // Arrange
        int[] inputArray1 = { 3, 7, 5, 5, 3, 7 };
        int[] inputArray2 = { 3, 7, 5, 5, 3, 7 };
        int[] inputArray3 = { 3, 7, 5, 5, 3, 7, 5 };

        // Act
        bool result1 = BasicAlgorithm.EqualElementsAtStartAndEnd(inputArray1, 2);
        bool result2 = BasicAlgorithm.EqualElementsAtStartAndEnd(inputArray2, 3);
        bool result3 = BasicAlgorithm.EqualElementsAtStartAndEnd(inputArray3, 3);

        // Assert
        Assert.AreEqual(true, result1);
        Assert.AreEqual(false, result2);
        Assert.AreEqual(true, result3);
    }

    // Exercise 126 - Check for Three Increasing Adjacent Numbers

    [TestMethod]
    public void TestHasThreeIncreasingAdjacent()
    {
        // Arrange
        int[] inputArray1 = { 1, 2, 3, 5, 3, 7 };
        int[] inputArray2 = { 3, 7, 5, 5, 3, 7 };
        int[] inputArray3 = { 3, 7, 5, 5, 6, 7, 5 };

        // Act
        bool result1 = BasicAlgorithm.HasThreeIncreasingAdjacent(inputArray1);
        bool result2 = BasicAlgorithm.HasThreeIncreasingAdjacent(inputArray2);
        bool result3 = BasicAlgorithm.HasThreeIncreasingAdjacent(inputArray3);

        // Assert
        Assert.AreEqual(true, result1);
        Assert.AreEqual(false, result2);
        Assert.AreEqual(true, result3);
    }

    // Exercise 127 - Shift Elements Left in Array

    [TestMethod]
    public void TestShiftLeft()
    {
        // Arrange
        int[] inputArray = { 10, 20, -30, -40, 50 };
        int[] expected = { 20, -30, -40, 50, 10 };

        // Act
        int[] result = BasicAlgorithm.ShiftLeft(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Exercise 128 - Elements Before 5 in Array

    [TestMethod]
    public void TestElementsBefore5()
    {
        // Arrange
        int[] inputArray = { 1, 2, 3, 5, 7 };
        int[] expected = { 1, 2, 3 };

        // Act
        int[] result = BasicAlgorithm.ElementsBefore5(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Exercise 129 - Elements After 5 in Array

    [TestMethod]
    public void TestElementsAfter5()
    {
        // Arrange
        int[] inputArray = { 1, 2, 3, 5, 7, 9, 11 };
        int[] expected = { 7, 9, 11 };

        // Act
        int[] result = BasicAlgorithm.ElementsAfter5(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Exercise 130 - Shift Zeros to Left in Array

    [TestMethod]
    public void TestShiftZerosLeft()
    {
        // Arrange
        int[] inputArray = { 1, 2, 0, 3, 5, 7, 0, 9, 11 };
        int[] expected = { 0, 0, 1, 2, 3, 5, 7, 9, 11 };

        // Act
        int[] result = BasicAlgorithm.ShiftZerosLeft(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Exercise 131 - Replace 5 with 0 and Shift Zeros Right

    [TestMethod]
    public void TestReplace5With0AndShiftRight()
    {
        // Arrange
        int[] inputArray = { 1, 2, 5, 3, 5, 7, 5, 9, 11 };
        int[] expected = { 1, 2, 3, 7, 9, 11, 0, 0, 0 };

        // Act
        int[] result = BasicAlgorithm.Replace5With0AndShiftRight(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Exercise 132 - Shift Even Numbers Before Odd Numbers

    [TestMethod]
    public void TestShiftEvenBeforeOdd()
    {
        // Arrange
        int[] inputArray = { 1, 2, 5, 3, 5, 4, 6, 9, 11 };
        int[] expected = { 2, 4, 6, 1, 5, 3, 5, 9, 11 };

        // Act
        int[] result = BasicAlgorithm.ShiftEvenBeforeOdd(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Exercise 133 - Check If Each Element ≥ Previous

    [TestMethod]
    public void TestIsEachElementGreaterOrEqual()
    {
        // Arrange
        int[] inputArray1 = { 5, 5, 1, 5, 5 };
        int[] inputArray2 = { 1, 2, 3, 4 };
        int[] inputArray3 = { 3, 3, 5, 5, 5, 5 };
        int[] inputArray4 = { 1, 5, 5, 7, 8, 10 };

        // Act
        bool result1 = BasicAlgorithm.IsEachElementGreaterOrEqual(inputArray1);
        bool result2 = BasicAlgorithm.IsEachElementGreaterOrEqual(inputArray2);
        bool result3 = BasicAlgorithm.IsEachElementGreaterOrEqual(inputArray3);
        bool result4 = BasicAlgorithm.IsEachElementGreaterOrEqual(inputArray4);

        // Assert
        Assert.AreEqual(false, result1);
        Assert.AreEqual(true, result2);
        Assert.AreEqual(true, result3);
        Assert.AreEqual(true, result4);
    }

    // Exercise 134 - Check for Two 15's Next to Each Other

    [TestMethod]
    public void TestHasTwo15sNextToEachOther()
    {
        // Arrange
        int[] inputArray1 = { 5, 5, 1, 15, 15 };
        int[] inputArray2 = { 15, 2, 3, 4, 15 };
        int[] inputArray3 = { 3, 3, 15, 15, 5, 5 };
        int[] inputArray4 = { 1, 5, 15, 7, 8, 15 };

        // Act
        bool result1 = BasicAlgorithm.HasTwo15sNextToEachOther(inputArray1);
        bool result2 = BasicAlgorithm.HasTwo15sNextToEachOther(inputArray2);
        bool result3 = BasicAlgorithm.HasTwo15sNextToEachOther(inputArray3);
        bool result4 = BasicAlgorithm.HasTwo15sNextToEachOther(inputArray4);

        // Assert
        Assert.AreEqual(true, result1);
        Assert.AreEqual(false, result2);
        Assert.AreEqual(true, result3);
        Assert.AreEqual(false, result4);
    }

    // Exercise 135 - Largest Average Between Array Halves

    [TestMethod]
    public void TestLargestAverageBetweenHalves()
    {
        // Arrange
        int[] inputArray1 = { 1, 2, 3, 4, 6, 8 };
        int[] inputArray2 = { 15, 2, 3, 4, 15, 11 };

        // Act
        int result1 = BasicAlgorithm.LargestAverageBetweenHalves(inputArray1);
        int result2 = BasicAlgorithm.LargestAverageBetweenHalves(inputArray2);

        // Assert
        Assert.AreEqual(6, result1);
        Assert.AreEqual(10, result2);
    }

    // Exercise 136 - Count Strings Matching Length

    [TestMethod]
    public void TestCountStringsWithLength()
    {
        // Arrange
        string[] inputArray = { "a", "b", "bb", "c", "ccc" };
        int targetLength = 1;

        // Act
        int result = BasicAlgorithm.CountStringsWithLength(inputArray, targetLength);

        // Assert
        Assert.AreEqual(3, result);
    }

    // Exercise 137 - First n Strings from String Array

    [TestMethod]
    public void TestFirstNStrings()
    {
        // Arrange
        string[] inputArray = { "a", "b", "bb", "c", "ccc" };
        int n = 3;
        string[] expected = { "a", "b", "bb" };

        // Act
        string[] result = BasicAlgorithm.FirstNStrings(inputArray, n);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Exercise 138 - Strings Matching Given Length

    [TestMethod]
    public void TestStringsMatchingLength()
    {
        // Arrange
        string[] inputArray = { "a", "aaa", "b", "bbb", "c", "ccc" };
        int length = 3;
        string[] expected = { "aaa", "bbb", "ccc" };

        // Act
        string[] result = BasicAlgorithm.StringsMatchingLength(inputArray, length);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Exercise 139 - Check If Number Contains 2

    [TestMethod]
    public void TestContainsDigit2()
    {
        // Arrange
        int input1 = 123;
        int input2 = 13;
        int input3 = 222;

        // Act
        bool result1 = BasicAlgorithm.ContainsDigit2(input1);
        bool result2 = BasicAlgorithm.ContainsDigit2(input2);
        bool result3 = BasicAlgorithm.ContainsDigit2(input3);

        // Assert
        Assert.AreEqual(true, result1);
        Assert.AreEqual(false, result2);
        Assert.AreEqual(true, result3);
    }

    // Exercise 140 - Array of Odd Numbers from Given Length

    [TestMethod]
    public void TestOddNumbersFromArray()
    {
        // Arrange
        int[] inputArray = { 1, 2, 3, 5, 7, 9, 10 };
        int length = 3;
        int[] expected = { 1, 3, 5 };

        // Act
        int[] result = BasicAlgorithm.OddNumbersFromArray(inputArray, length);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Exercise 141 - Multiply Each Integer by 3

    [TestMethod]
    public void TestMultiplyBy3()
    {
        // Arrange
        int[] inputArray = { 1, 2, 3, 4 };
        int[] expected = { 3, 6, 9, 12 };

        // Act
        int[] result = BasicAlgorithm.MultiplyBy3(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Exercise 142 - Cube Each Integer

    [TestMethod]
    public void TestCubeEachInteger()
    {
        // Arrange
        int[] inputArray = { 1, 2, 3, 4 };
        int[] expected = { 1, 8, 27, 64 };

        // Act
        int[] result = BasicAlgorithm.CubeEachInteger(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Exercise 143 - Add # at Start and End of Strings

    [TestMethod]
    public void TestAddHashToStartAndEnd()
    {
        // Arrange
        string[] inputArray = { "1", "2", "3", "4" };
        string[] expected = { "#1#", "#2#", "#3#", "#4#" };

        // Act
        string[] result = BasicAlgorithm.AddHashToStartAndEnd(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Exercise 144 - Repeat Strings Four Times

    [TestMethod]
    public void TestRepeatStringsFourTimes()
    {
        // Arrange
        string[] inputArray = { "1", "2", "3", "4" };
        string[] expected = { "1111", "2222", "3333", "4444" };

        // Act
        string[] result = BasicAlgorithm.RepeatStringsFourTimes(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Exercise 145 - (Value+2) * 5 for Each Integer

    [TestMethod]
    public void TestValuePlus2Times5()
    {
        // Arrange
        int[] inputArray = { 1, 2, 3, 4 };
        int[] expected = { 15, 20, 25, 30 };

        // Act
        int[] result = BasicAlgorithm.ValuePlus2Times5(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Exercise 146 - Rightmost Digits of Integers

    [TestMethod]
    public void TestRightmostDigits()
    {
        // Arrange
        int[] inputArray = { 10, 22, 35, 41 };
        int[] expected = { 0, 2, 5, 1 };

        // Act
        int[] result = BasicAlgorithm.RightmostDigits(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Exercise 147 - Convert Strings to Uppercase

    [TestMethod]
    public void TestConvertToUppercase()
    {
        // Arrange
        string[] inputArray = { "Abc", "cdef", "js", "php" };
        string[] expected = { "ABC", "CDEF", "JS", "PHP" };

        // Act
        string[] result = BasicAlgorithm.ConvertToUppercase(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Exercise 148 - Remove 'a' from Each String

    [TestMethod]
    public void TestRemoveAFromStrings()
    {
        // Arrange
        string[] inputArray = { "abc", "cdaef", "js", "php" };
        string[] expected = { "bc", "cdef", "js", "php" };

        // Act
        string[] result = BasicAlgorithm.RemoveAFromStrings(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Exercise 149 - Remove Integers Less Than 4

    [TestMethod]
    public void TestRemoveIntegersLessThan4()
    {
        // Arrange
        int[] inputArray = { 0, -2, 1, 2, 3, 5, 4, 7, 8 };
        int[] expected = { 0, -2, 1, 2, 3 };

        // Act
        int[] result = BasicAlgorithm.RemoveIntegersLessThan4(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // Exercise 150 - Remove Integers Ending in 7

    [TestMethod]
    public void TestRemoveIntegersEndingWith7()
    {
        // Arrange
        int[] inputArray = { 10, 22, 35, 47, 53, 67 };
        int[] expected = { 10, 22, 35, 53 };

        // Act
        int[] result = BasicAlgorithm.RemoveIntegersEndingWith7(inputArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}