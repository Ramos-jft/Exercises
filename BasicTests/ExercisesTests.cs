using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicExercises;
using System;
using System.IO;
using FluentAssertions;

namespace BasicExercisesTests
{
    [TestClass]
    public class ExercisesTests
    {
        [TestMethod]

        // Exercise 1 - Print Hello and Name
        public void ShouldReturnHelloAndName()
        {
            // Arrange

            var exercise = new Exercises();

            // Act

            var result = exercise.Message("Lucas");

            // Assert

            Assert.AreEqual("Hello\nLucas", result);
        }

        [TestMethod]

        // Exercise 2 - Sum of Two Numbers
        public void SumOfTwoNumbers()
        {
            // Arrange
            int n1 = 8;
            int n2 = 5;
            int expected = 13;

            // Act
            int result = Exercises.Sum(n1, n2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]

        // Exercise 3 - Divide Two Numbers
        public void DivideTwoNumbers()
        {
            // Arrange
            int n1 = 10;
            int n2 = 5;
            int expected = 2;

            // Act
            int result = Exercises.Divide(n1, n2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise04 4 -  Specified Operations Results

        [TestMethod]
        public void Calculate_Operation1_ReturnsCorrectResult()
        {
            // Arrange
            string operation = "-1 + 4 * 6";
            double expected = 23;

            // Act
            double result = Exercises.Calculate(operation);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_Operation2_ReturnsCorrectResult()
        {
            // Arrange
            string operation = "( 35 + 5 ) % 7";
            double expected = 5;

            // Act
            double result = Exercises.Calculate(operation);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_Operation3_ReturnsCorrectResult()
        {
            // Arrange
            string operation = "14 + ( -4 * 6 ) / 11";
            double expected = 11.82;

            // Act
            double result = Exercises.Calculate(operation);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_Operation4_ReturnsCorrectResult()
        {
            // Arrange
            string operation = "2 + ( 15 / 6 ) * 1 - ( 7 % 2 )";
            double expected = 3.5;

            // Act
            double result = Exercises.Calculate(operation);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 5 - Swap Two Numbers

        [TestMethod]
        public void Swap_TwoNumbers_ShouldSwapValues()
        {
            // Arrange
            int firstNumber = 5;
            int secondNumber = 6;

            // Act
            Exercises.Swap(ref firstNumber, ref secondNumber);

            // Assert
            Assert.AreEqual(6, firstNumber);
            Assert.AreEqual(5, secondNumber);
        }

        // Exercise 6 - Multiply Three Numbers

        [TestMethod]
        public void MultiplyThreeNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            int n1 = 2;
            int n2 = 3;
            int n3 = 6;
            int expected = 36;

            // Act
            int result = Exercises.MultiplyThreeNumbers(n1, n2, n3);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 7 - Arithmetic Operations

        [TestClass]
        public class ArithmeticOperationsTests
        {
            [TestMethod]
            public void AddTwoNumbers_ReturnsCorrectSum()
            {
                // Arrange
                int a = 25;
                int b = 4;
                int expected = 29;

                // Act
                int result = Exercises.AddTwoNumbers(a, b);

                // Assert
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void SubtractTwoNumbers_ReturnsCorrectDifference()
            {
                // Arrange
                int a = 25;
                int b = 4;
                int expected = 21;

                // Act
                int result = Exercises.SubtractTwoNumbers(a, b);

                // Assert
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void MultiplyTwoNumbers_ReturnsCorrectProduct()
            {
                // Arrange
                int a = 25;
                int b = 4;
                int expected = 100;

                // Act
                int result = Exercises.MultiplyTwoNumbers(a, b);

                // Assert
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void DivideTwoNumbers_ReturnsIntegerResult()
            {
                // Arrange
                int a = 25;
                int b = 4;
                int expected = 6;

                // Act
                int result = Exercises.DivideTwoNumbers(a, b);

                // Assert
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void ModulusTwoNumbers_ReturnsCorrectRemainder()
            {
                // Arrange
                int a = 25;
                int b = 4;
                int expected = 1;

                // Act
                int result = Exercises.ModulusTwoNumbers(a, b);

                // Assert
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void GetOperationResults_ReturnsFormattedString()
            {
                // Arrange
                int a = 25;
                int b = 4;
                string expected = "25 + 4 = 29\r\n" +
                                 "25 - 4 = 21\r\n" +
                                 "25 x 4 = 100\r\n" +
                                 "25 / 4 = 6\r\n" +
                                 "25 mod 4 = 1";

                // Act
                string result = Exercises.GetOperationResults(a, b);

                // Assert
                Assert.AreEqual(expected, result);
            }
        }

        // Exercise 8 - Multiplication Table

        [TestClass]
        public class MultiplicationTableTests
        {
            [TestMethod]
            public void GenerateTable_ForNumber5_ReturnsCorrectTable()
            {
                // Arrange
                int number = 5;
                string expected = "5 * 0 = 0\r\n" +
                                "5 * 1 = 5\r\n" +
                                "5 * 2 = 10\r\n" +
                                "5 * 3 = 15\r\n" +
                                "5 * 4 = 20\r\n" +
                                "5 * 5 = 25\r\n" +
                                "5 * 6 = 30\r\n" +
                                "5 * 7 = 35\r\n" +
                                "5 * 8 = 40\r\n" +
                                "5 * 9 = 45\r\n" +
                                "5 * 10 = 50";

                // Act
                string result = Exercises.GenerateMultiplicationTable(number);

                // Assert
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void GenerateTable_ForNumber0_ReturnsAllZeros()
            {
                // Arrange
                int number = 0;
                string expected = "0 * 0 = 0\r\n" +
                                "0 * 1 = 0\r\n" +
                                "0 * 2 = 0\r\n" +
                                "0 * 3 = 0\r\n" +
                                "0 * 4 = 0\r\n" +
                                "0 * 5 = 0\r\n" +
                                "0 * 6 = 0\r\n" +
                                "0 * 7 = 0\r\n" +
                                "0 * 8 = 0\r\n" +
                                "0 * 9 = 0\r\n" +
                                "0 * 10 = 0";

                // Act
                string result = Exercises.GenerateMultiplicationTable(number);

                // Assert
                Assert.AreEqual(expected, result);
            }
        }

        // Exercise 9 - Average of Four Numbers

        [TestClass]
        public class AverageCalculationTests
        {
            [TestMethod]
            public void CalculateAverage_FourNumbers_ReturnsCorrectAverage()
            {
                // Arrange
                int num1 = 10;
                int num2 = 15;
                int num3 = 20;
                int num4 = 30;
                double expected = 18.75;

                // Act
                double result = Exercises.CalculateAverage(num1, num2, num3, num4);

                // Assert
                Assert.AreEqual(expected, result);
            }
        }

        // Exercise 10 - Specified Formula with Three Numbers

        [TestMethod]
        public void CalculateFirstFormula_WithSampleNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int x = 5;
            int y = 6;
            int z = 7;
            int expected = 77; // (5+6)*7 = 77

            // Act
            int result = Exercises.CalculateFirstFormula(x, y, z);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateSecondFormula_WithSampleNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int x = 5;
            int y = 6;
            int z = 7;
            int expected = 72; // 5*6 + 6*7 = 30 + 42 = 72

            // Act
            int result = Exercises.CalculateSecondFormula(x, y, z);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetFormulasOutput_WithSampleNumbers_ReturnsCorrectString()
        {
            // Arrange
            int x = 5;
            int y = 6;
            int z = 7;
            string expected = "Result of specified formulas:\r\n" +
                            "(x + y).z = 77\r\n" +
                            "x.y + y.z = 72";

            // Act
            string result = Exercises.GetFormulasOutput(x, y, z);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 11 - Print Age Message

        [TestMethod]

        public void GetAgeMessage_WithAge25()
        {
            // Arrange
            int age = 25;
            string expected = "You look older than 25";

            // Act
            string result = Exercises.GetAgeMessage(age);

            // Assert
            result.Should().Be(expected);
        }

        // Exercise 12 - Repeat Number in Rows

        [TestMethod]
        [DataRow(25, "25 25 25 25\r\n25252525\r\n25 25 25 25\r\n25252525")]

        public void GetNumberPattern(int number, string expectedResult)
        {
            // Act
            string result = Exercises.GetNumberPattern(number);

            // Assert
            result.Should().Be(expectedResult);
        }

        // Exercise 13 - Rectangle Pattern with Number

        [TestMethod]
        public void GetRectanglePattern()
        {
            // Arrange
            int number = 5;
            string expected = "555\r\n5 5\r\n5 5\r\n5 5\r\n555";

            // Act
            string result = Exercises.GetRectanglePattern(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 14 - Celsius to Kelvin and Fahrenheit

        [TestMethod]
        public void ConvertCelsiusToKelvin()
        {
            // Arrange
            double celsius = 30;
            double expected = 303;

            // Act
            double result = Exercises.ConvertToKelvin(celsius);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertCelsiusToFahrenheit()
        {
            // Arrange
            double celsius = 30;
            double expected = 86;

            // Act
            double result = Exercises.ConvertToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetTemperatureConversions_String()
        {
            // Arrange
            double celsius = 30;
            string expected = "Kelvin = 303\r\nFahrenheit = 86";

            // Act
            string result = Exercises.GetTemperatureConversions(celsius);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 15 - Remove Character by Index

        [TestMethod]
        public void RemoveCharacterAtIndex_RemoveFirstCharacter()
        {
            // Arrange
            string input = "w3resource";
            int index = 0;
            string expected = "3resource";

            // Act
            string result = Exercises.RemoveCharacterAtIndex(input, index);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveCharacterAtIndex_RemoveSecondCharacter()
        {
            // Arrange
            string input = "w3resource";
            int index = 1;
            string expected = "wresource";

            // Act
            string result = Exercises.RemoveCharacterAtIndex(input, index);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveCharacterAtIndex_RemoveLastCharacter()
        {
            // Arrange
            string input = "w3resource";
            int index = 9;
            string expected = "w3resourc";

            // Act
            string result = Exercises.RemoveCharacterAtIndex(input, index);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 16 - Swap First and Last Characters

        [TestMethod]
        public void SwapFirstToLastCharacter()
        {
            // Arrange
            string input = "w3resource";
            string expected = "e3resourcw";

            // Act
            string result = Exercises.SwapFirstLastCharacters(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("Python", "nythoP")]
        [DataRow("Java", "aavJ")]
        public void SwapFirst_LastCharacter(string input, string expectedResult)
        {
            // Act
            string result = Exercises.SwapFirstLastCharacters(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void NonSwapFirstLastCharacter()
        {
            // Arrange
            string input = "x";
            string expected = "x";

            // Act
            string result = Exercises.SwapFirstLastCharacters(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 17 - Add First Character to Front and Back

        [TestMethod]
        public void AddFirstCharFrontAndBack()
        {
            // Arrange
            string input = "The quick brown fox jumps over the lazy dog.";
            string expected = "TThe quick brown fox jumps over the lazy dog.T";

            // Act
            string result = Exercises.AddFirstCharFrontAndBack(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 18 - Check Positive and Negative Pair

        [TestMethod]
        public void CheckPositiveNegativePair()
        {
            // Arrange
            int first = -5;
            int second = 25;
            bool expected = true;

            // Act
            bool result = Exercises.CheckPositiveNegativePair(first, second);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 19 - Sum or Triple Sum of Integers

        [TestMethod]
        public void ComputeSum_SameNumbers_ReturnsTripleSum()
        {
            // Arrange
            int a = 2;
            int b = 2;
            int expected = 12;

            // Act
            int result = Exercises.ComputeSum(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ComputeSum_DifferentNumbers_ReturnsSum()
        {
            // Arrange
            int a = 12;
            int b = 10;
            int expected = 22;

            // Act
            int result = Exercises.ComputeSum(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ComputeSum_OneNegative_ReturnsCorrectSum()
        {
            // Arrange
            int a = -5;
            int b = 2;
            int expected = -3;

            // Act
            int result = Exercises.ComputeSum(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 20 - Absolute Difference or Double It

        [TestMethod]
        public void CalculateDifference_FirstGreater_ReturnsDoubleAbsoluteDifference()
        {
            // Arrange
            int a = 15;
            int b = 7;
            int expected = 16;

            // Act
            int result = Exercises.CalculateDifference(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateDifference_SecondGreater_ReturnsAbsoluteDifference()
        {
            // Arrange
            int a = 5;
            int b = 12;
            int expected = 7;

            // Act
            int result = Exercises.CalculateDifference(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 21 - Check for 20 or Sum Equals 20

        [TestMethod]
        public void CheckFor20_FirstNumberIs20_ReturnsTrue()
        {
            // Arrange
            int a = 20;
            int b = 15;
            bool expected = true;

            // Act
            bool result = Exercises.CheckFor20(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckFor20_SecondNumberIs20_ReturnsTrue()
        {
            // Arrange
            int a = 12;
            int b = 20;
            bool expected = true;

            // Act
            bool result = Exercises.CheckFor20(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckFor20_SumIs20_ReturnsTrue()
        {
            // Arrange
            int a = 15;
            int b = 5;
            bool expected = true;

            // Act
            bool result = Exercises.CheckFor20(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 22 - Check Within 20 of 100 or 200

        [TestMethod]
        public void CheckWithin20_80_ReturnsTrue()
        {
            // Arrange
            int number = 80;
            bool expected = true;

            // Act
            bool result = Exercises.CheckWithin20(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckWithin20_120_ReturnsTrue()
        {
            // Arrange
            int number = 120;
            bool expected = true;

            // Act
            bool result = Exercises.CheckWithin20(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckWithin20_180_ReturnsTrue()
        {
            // Arrange
            int number = 180;
            bool expected = true;

            // Act
            bool result = Exercises.CheckWithin20(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckWithin20_220_ReturnsTrue()
        {
            // Arrange
            int number = 220;
            bool expected = true;

            // Act
            bool result = Exercises.CheckWithin20(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckWithin20_25_ReturnsFalse()
        {
            // Arrange
            int number = 25;
            bool expected = false;

            // Act
            bool result = Exercises.CheckWithin20(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckWithin20_150_ReturnsFalse()
        {
            // Arrange
            int number = 150;
            bool expected = false;

            // Act
            bool result = Exercises.CheckWithin20(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetCheckResult_FormatsOutputCorrectly()
        {
            // Arrange
            int number = 95;
            string expected = "Check result: True";

            // Act
            string result = Exercises.GetCheckResult(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise01 23 - Convert String to Lowercase

        [TestMethod]
        public void ConvertToLower_AllUppercase_ReturnsLowercase()
        {
            // Arrange
            string input = "HELLO WORLD";
            string expected = "hello world";

            // Act
            string result = Exercises.ConvertToLower(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertToLower_MixedCase_ReturnsAllLowercase()
        {
            // Arrange
            string input = "C# Programming";
            string expected = "c# programming";

            // Act
            string result = Exercises.ConvertToLower(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertToLower_AlreadyLowercase_ReturnsSame()
        {
            // Arrange
            string input = "already lowercase";
            string expected = "already lowercase";

            // Act
            string result = Exercises.ConvertToLower(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertToLower_WithNumbersAndSymbols_ReturnsLowercaseLettersOnly()
        {
            // Arrange
            string input = "123 ABC!@#";
            string expected = "123 abc!@#";

            // Act
            string result = Exercises.ConvertToLower(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertToLower_EmptyString_ReturnsEmpty()
        {
            // Arrange
            string input = "";
            string expected = "";

            // Act
            string result = Exercises.ConvertToLower(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetLowercaseResult_FormatsOutputCorrectly()
        {
            // Arrange
            string input = "Convert THIS";
            string expected = "Lowercase result: convert this";

            // Act
            string result = Exercises.GetLowercaseResult(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 24 - Find Longest Word in String

        [TestMethod]
        public void FindLongestWord_ShouldReturnLongestWord()
        {
            // Arrange
            string input = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            string expected = "following";

            // Act
            string result = Exercises.FindLongestWord(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 25 - Print Odd Numbers 1 to 99

        [TestMethod]
        public void GetOddNumbers_ShouldReturnCorrectSequence()
        {
            // Arrange
            string expected = "1\r\n3\r\n5\r\n7\r\n9\r\n11\r\n...\r\n95\r\n97\r\n99";

            // Act
            string result = Exercises.GetOddNumbers();

            // Assert
            Assert.IsTrue(result.Contains("1\r\n3\r\n5\r\n7\r\n9"));
            Assert.IsTrue(result.Contains("95\r\n97\r\n99"));
            Assert.IsTrue(result.Contains("..."));
        }

        [TestMethod]
        public void PrintOddNumbers_ShouldOutputCorrectFormat()
        {
            // Arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            string expectedStart = "Odd numbers from 1 to 99. Prints one number per line.\r\n1\r\n3\r\n5\r\n7\r\n9\r\n";
            string expectedEnd = "95\r\n97\r\n99\r\n";

            // Act
            Exercises.PrintOddNumbers();
            string result = stringWriter.ToString();

            // Assert
            StringAssert.Contains(result, expectedStart);
            StringAssert.Contains(result, expectedEnd);
            StringAssert.Contains(result, "...\r\n");
        }

        // Exercise 26 - Sum of First 500 Primes

        [TestMethod]
        public void IsPrime_ShouldIdentifyPrimesCorrectly()
        {
            // Números primos
            Assert.IsTrue(Exercises.IsPrime(2));
            Assert.IsTrue(Exercises.IsPrime(3));
            Assert.IsTrue(Exercises.IsPrime(5));
            Assert.IsTrue(Exercises.IsPrime(7));
            Assert.IsTrue(Exercises.IsPrime(11));

            // Não primos
            Assert.IsFalse(Exercises.IsPrime(1));
            Assert.IsFalse(Exercises.IsPrime(4));
            Assert.IsFalse(Exercises.IsPrime(9));
            Assert.IsFalse(Exercises.IsPrime(15));
        }

        [TestMethod]
        public void SumOfFirst500Primes_ShouldReturnCorrectSum()
        {
            // Arrange & Act
            long result = Exercises.SumOfFirst500Primes();

            // Assert
            Assert.AreEqual(824693, result); // Valor correto da soma
        }

        [TestMethod]
        public void GetPrimeSumResult_ShouldReturnFormattedString()
        {
            // Act
            string result = Exercises.GetPrimeSumResult();

            // Assert
            Assert.IsTrue(result.StartsWith("Sum of the first 500 prime numbers:\n"));
            Assert.IsTrue(result.EndsWith("824693")); // Verifica o valor final
        }

        // Exercise 27 - Sum of Digits in Integer

        [TestMethod]
        public void SumDigits_PositiveNumber()
        {
            // Arrange
            int number = 12345;
            int expected = 15;

            // Act
            int actual = Exercises.SumDigits(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumDigits_NegativeNumber()
        {
            // Arrange
            int number = -123;
            int expected = 6;

            // Act
            int actual = Exercises.SumDigits(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumDigits_Zero()
        {
            // Arrange
            int number = 0;
            int expected = 0;

            // Act
            int actual = Exercises.SumDigits(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumDigits_SingleDigit()
        {
            // Arrange
            int number = 7;
            int expected = 7;

            // Act
            int actual = Exercises.SumDigits(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumDigits_LargeNumber()
        {
            // Arrange
            int number = 123456789;
            int expected = 45;

            // Act
            int actual = Exercises.SumDigits(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // Exercise 28 - Reverse Words in Sentence

        [TestMethod]
        public void ReverseWords()
        {
            // Arrange
            string input = "Display the pattern like pyramid using the alphabet.";
            string expected = "alphabet. the using pyramid like pattern the Display";

            // Act
            string result = Exercises.ReverseWords(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReverseWords_WithMultipleSpaces()
        {
            // Arrange
            string input = "Hello    World";
            string expected = "World Hello";

            // Act
            string result = Exercises.ReverseWords(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetReversedSentenceResult()
        {
            // Arrange
            string input = "Hello World";
            string expected = "Original String: Hello World\nReverse String: World Hello";

            // Act
            string result = Exercises.GetReversedSentenceResult(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 29 - File Size in Bytes

        private const string TestFilePath = "testfile.txt";

        [TestInitialize]
        public void Setup()
        {
            // Create a test file with known size
            File.WriteAllText(TestFilePath, "This is a test file content.");
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Delete the test file
            if (File.Exists(TestFilePath))
                File.Delete(TestFilePath);
        }

        [TestMethod]
        public void GetFileSize()
        {
            // Arrange
            long expectedSize = new FileInfo(TestFilePath).Length;

            // Act
            long actualSize = Exercises.GetFileSize(TestFilePath);

            // Assert
            Assert.AreEqual(expectedSize, actualSize);
        }

        [TestMethod]
        public void GetFileSize_WithNonExistentFile()
        {
            // Arrange
            string nonExistentFile = "nonexistentfile.txt";

            // Act & Assert
            var exception = Assert.ThrowsException<FileNotFoundException>(() =>
                Exercises.GetFileSize(nonExistentFile));

            Assert.AreEqual($"File not found: {nonExistentFile}", exception.Message);
        }

        [TestMethod]
        public void GetFileSizeResult_WithNonExistentFile()
        {
            // Arrange
            string nonExistentFile = "nonexistentfile.txt";
            string expectedMessage = $"File not found: {nonExistentFile}";

            // Act
            string result = Exercises.GetFileSizeResult(nonExistentFile);

            // Assert
            Assert.AreEqual(expectedMessage, result);
        }

        [TestMethod]
        public void GetFileSizeResult()
        {
            // Arrange
            long size = new FileInfo(TestFilePath).Length;
            string expected = $"Size of a file: {size}";

            // Act
            string result = Exercises.GetFileSizeResult(TestFilePath);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 30 - Hexadecimal to Decimal

        [TestMethod]
        public void HexToDecimal_ValidHex()
        {
            // Arrange
            string hex = "4B0";
            int expected = 1200;

            // Act
            int result = Exercises.HexToDecimal(hex);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void HexToDecimal_LowercaseHex()
        {
            // Arrange
            string hex = "4b0";
            int expected = 1200;

            // Act
            int result = Exercises.HexToDecimal(hex);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetConversionResult_ValidHex()
        {
            // Arrange
            string hex = "4B0";
            string expected = "Hexadecimal number: 4B0\nConvert to-\nDecimal number: 1200";

            // Act
            string result = Exercises.GetConversionResult(hex);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 31 - Multiply Two Arrays

        [TestMethod]
        public void MultiplyArrays_ValidInput()
        {
            // Arrange
            int[] array1 = { 1, 3, -5, 4 };
            int[] array2 = { 1, 4, -5, -2 };
            int[] expected = { 1, 12, 25, -8 };

            // Act
            int[] result = Exercises.MultiplyArrays(array1, array2);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetMultiplicationResult()
        {
            // Arrange
            int[] array1 = { 1, 3, -5, 4 };
            int[] array2 = { 1, 4, -5, -2 };
            string expected = "Array1: [1, 3, -5, 4]\n" +
                            "Array2: [1, 4, -5, -2]\n" +
                            "Multiply corresponding elements of two arrays:\n" +
                            "1 12 25 -8";

            // Act
            string result = Exercises.GetMultiplicationResult(array1, array2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 32 - Four Copies of Last Four Characters

        [TestMethod]
        public void GetLastFourCopies()
        {
            // Arrange
            string input = "The quick brown fox jumps over the lazy dog.";
            string expected = "dog.dog.dog.dog.";

            // Act
            string result = Exercises.GetLastFourCopies(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 33 - Check Multiple of 3 or 7

        [TestMethod]
        public void IsMultipleOf3Or7_MultipleOf3()
        {
            // Arrange
            int number = 15;

            // Act
            bool result = Exercises.IsMultipleOf3Or7(number);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsMultipleOf3Or7_MultipleOf7()
        {
            // Arrange
            int number = 14;

            // Act
            bool result = Exercises.IsMultipleOf3Or7(number);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsMultipleOf3Or7_NotMultiple()
        {
            // Arrange
            int number = 16;

            // Act
            bool result = Exercises.IsMultipleOf3Or7(number);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsMultipleOf3Or7_Zero()
        {
            // Act
            bool result = Exercises.IsMultipleOf3Or7(0);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsMultipleOf3Or7_NegativeNumber()
        {
            // Act
            bool result = Exercises.IsMultipleOf3Or7(-21);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetCheckResult()
        {
            // Arrange
            int number = 15;
            string expected = "Input first integer:\n15\nTrue";

            // Act
            string result = Exercises.GetCheckResult0(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 34 - Check String Starts with Word

        [TestMethod]
        public void StartsWithHello_StartsWithHello_ReturnsTrue()
        {
            // Arrange
            string input = "Hello how are you?";

            // Act
            bool result = Exercises.StartsWithHello(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void StartsWithHello_StartsWithHelloLowercase_ReturnsTrue()
        {
            // Arrange
            string input = "hello world";

            // Act
            bool result = Exercises.StartsWithHello(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void StartsWithHello_DoesNotStartWithHello_ReturnsFalse()
        {
            // Arrange
            string input = "Hi there";

            // Act
            bool result = Exercises.StartsWithHello(input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void StartsWithHello_EmptyString_ReturnsFalse()
        {
            // Act
            bool result = Exercises.StartsWithHello("");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void StartsWithHello_WithLeadingSpaces_ReturnsTrue()
        {
            // Arrange
            string input = "   Hello everyone";

            // Act
            bool result = Exercises.StartsWithHello(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetCheckResult_FormatsOutputCorrectly1()
        {
            // Arrange
            string input = "Hello how are you?";
            string expected = "Input a string : Hello how are you?\nTrue";

            // Act
            string result = Exercises.GetCheckResult(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 35 - Check Numbers Less than 100 & Greater than 200

        [TestMethod]
        public void CheckNumbers_ValidCase()
        {
            // Arrange
            int num1 = 75;
            int num2 = 250;

            // Act
            bool result = Exercises.CheckNumbers(num1, num2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckNumbers_FirstNumberTooBig()
        {
            // Arrange
            int num1 = 150;
            int num2 = 250;

            // Act
            bool result = Exercises.CheckNumbers(num1, num2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckNumbers_SecondNumberTooSmall()
        {
            // Arrange
            int num1 = 50;
            int num2 = 150;

            // Act
            bool result = Exercises.CheckNumbers(num1, num2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckNumbers_BothNumbersInvalid()
        {
            // Arrange
            int num1 = 150;
            int num2 = 150;

            // Act
            bool result = Exercises.CheckNumbers(num1, num2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetCheckResult2()
        {
            // Arrange
            int num1 = 75;
            int num2 = 250;
            string expected = "Input a first number(<100): 75\n" +
                            "Input a second number(>200): 250\n" +
                            "True";

            // Act
            string result = Exercises.GetCheckResult(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 36 - Check Integer in Range -10 to 10

        [TestMethod]
        public void CheckInRange_FirstNumberInRange()
        {
            // Arrange
            int num1 = -5;
            int num2 = 15;

            // Act
            bool result = Exercises.CheckInRange(num1, num2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckInRange_SecondNumberInRange()
        {
            // Arrange
            int num1 = -15;
            int num2 = 8;

            // Act
            bool result = Exercises.CheckInRange(num1, num2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckInRange_BothNumbersInRange()
        {
            // Arrange
            int num1 = -10;
            int num2 = 10;

            // Act
            bool result = Exercises.CheckInRange(num1, num2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckInRange_NeitherNumberInRange()
        {
            // Arrange
            int num1 = -11;
            int num2 = 11;

            // Act
            bool result = Exercises.CheckInRange(num1, num2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckInRange_BoundaryValues()
        {
            // Arrange
            int num1 = -10;
            int num2 = 10;

            // Act
            bool result = Exercises.CheckInRange(num1, num2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetCheckResult3()
        {
            // Arrange
            int num1 = -5;
            int num2 = 8;
            string expected = "Input a first number: -5\n" +
                            "Input a second number: 8\n" +
                            "True";

            // Act
            string result = Exercises.GetCheckResult1(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 37 - Remove 'HP' from String

        [TestMethod]
        public void RemoveHP_WithHPAtSecondPosition()
        {
            // Arrange
            string input = "PHP Tutorial";
            string expected = "P Tutorial";

            // Act
            string result = Exercises.RemoveHP(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveHP_WithHpAtSecondPosition()
        {
            // Arrange
            string input = "Php Tutorial";
            string expected = "P Tutorial";

            // Act
            string result = Exercises.RemoveHP(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveHP_WithoutHPAtSecondPosition()
        {
            // Arrange
            string input = "C# Tutorial";
            string expected = "C# Tutorial";

            // Act
            string result = Exercises.RemoveHP(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveHP_ShortString()
        {
            // Arrange
            string input = "HP";
            string expected = "HP";

            // Act
            string result = Exercises.RemoveHP(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetModifiedString()
        {
            // Arrange
            string input = "PHP Tutorial";
            string expected = "Original String: PHP Tutorial\nModified String: P Tutorial";

            // Act
            string result = Exercises.GetModifiedString(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 38 - Extract 'PH' from String

        [TestMethod]
        public void ExtractPH_StartsWithPH()
        {
            // Arrange
            string input = "PHP";
            string expected = "PH";

            // Act
            string result = Exercises.ExtractPH(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExtractPH_StartsWithLowerCase()
        {
            // Arrange
            string input = "pHp";
            string expected = "";

            // Act
            string result = Exercises.ExtractPH(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExtractPH_DoesNotStartWithPH()
        {
            // Arrange
            string input = "CSharp";
            string expected = "";

            // Act
            string result = Exercises.ExtractPH(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExtractPH_ShortString()
        {
            // Arrange
            string input = "P";
            string expected = "";

            // Act
            string result = Exercises.ExtractPH(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetExtractionResult()
        {
            // Arrange
            string input = "PHP";
            string expected = "Test Data: PHP\nExtracted: PH";

            // Act
            string result = Exercises.GetExtractionResult(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 39 - Largest and Lowest of Three Integers

        [TestMethod]
        public void FindLargestAndLowest()
        {
            // Arrange
            int num1 = 15;
            int num2 = 25;
            int num3 = 30;
            (int expectedLargest, int expectedLowest) = (30, 15);

            // Act
            var (largest, lowest) = Exercises.FindLargestAndLowest(num1, num2, num3);

            // Assert
            Assert.AreEqual(expectedLargest, largest);
            Assert.AreEqual(expectedLowest, lowest);
        }

        [TestMethod]
        public void FindLargestAndLowest_WithNegativeNumbers()
        {
            // Arrange
            int num1 = -5;
            int num2 = -10;
            int num3 = -1;
            (int expectedLargest, int expectedLowest) = (-1, -10);

            // Act
            var (largest, lowest) = Exercises.FindLargestAndLowest(num1, num2, num3);

            // Assert
            Assert.AreEqual(expectedLargest, largest);
            Assert.AreEqual(expectedLowest, lowest);
        }

        [TestMethod]
        public void FindLargestAndLowest_WithEqualNumbers()
        {
            // Arrange
            int num1 = 10;
            int num2 = 10;
            int num3 = 10;
            (int expectedLargest, int expectedLowest) = (10, 10);

            // Act
            var (largest, lowest) = Exercises.FindLargestAndLowest(num1, num2, num3);

            // Assert
            Assert.AreEqual(expectedLargest, largest);
            Assert.AreEqual(expectedLowest, lowest);
        }

        [TestMethod]
        public void GetComparisonResult()
        {
            // Arrange
            int num1 = 15;
            int num2 = 25;
            int num3 = 30;
            string expected = "Largest of three: 30\nLowest of three: 15";

            // Act
            string result = Exercises.GetComparisonResult(num1, num2, num3);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 40 - Nearest to 20 or Return 0

        [TestMethod]
        public void FindNearestTo20_FirstNearer()
        {
            // Arrange
            int num1 = 15;
            int num2 = 12;
            int expected = 15;

            // Act
            int result = Exercises.FindNearestTo20(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindNearestTo20_SecondNearer()
        {
            // Arrange
            int num1 = 25;
            int num2 = 22;
            int expected = 22;

            // Act
            int result = Exercises.FindNearestTo20(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindNearestTo20_EqualDistance()
        {
            // Arrange
            int num1 = 18;
            int num2 = 22;
            int expected = 0;

            // Act
            int result = Exercises.FindNearestTo20(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindNearestTo20_EqualNumbers()
        {
            // Arrange
            int num1 = 15;
            int num2 = 15;
            int expected = 0;

            // Act
            int result = Exercises.FindNearestTo20(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetNearestResult()
        {
            // Arrange
            int num1 = 15;
            int num2 = 12;
            string expected = "Input first integer:\n15\n" +
                            "Input second integer:\n12\n" +
                            "Nearest to 20: 15";

            // Act
            string result = Exercises.GetNearestResult(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 41 - Check 'w' Appears 1-3 Times

        [TestMethod]
        public void CheckWCount_OneW()
        {
            // Arrange
            string input = "w3resource";

            // Act
            bool result = Exercises.CheckWCount(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckWCount_ThreeWs()
        {
            // Arrange
            string input = "www.example.com";

            // Act
            bool result = Exercises.CheckWCount(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckWCount_ZeroWs()
        {
            // Arrange
            string input = "hello lucas";

            // Act
            bool result = Exercises.CheckWCount(input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckWCount_FourWs()
        {
            // Arrange
            string input = "wwww.example";

            // Act
            bool result = Exercises.CheckWCount(input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckWCount_MixedCaseWs()
        {
            // Arrange
            string input = "WwW.example";

            // Act
            bool result = Exercises.CheckWCount(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetCheckResult4()
        {
            // Arrange
            string input = "w3resource";
            string expected = "Input a string (contains at least one 'w' char) : w3resource\n" +
                            "Test the string contains 'w' character between 1 and 3 times:\n" +
                            "True";

            // Act
            string result = Exercises.GetCheckResult2(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 42 - First 4 Chars Lowercase, Rest Uppercase

        [TestMethod]
        public void TransformString_ShortString()
        {
            // Arrange
            string input = "w3r";
            string expected = "W3R";

            // Act
            string result = Exercises.TransformString(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TransformString_LongString()
        {
            // Arrange
            string input = "HelloWorld";
            string expected = "hellOWORLD";

            // Act
            string result = Exercises.TransformString(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TransformString_Exactly4Chars()
        {
            // Arrange
            string input = "TEST";
            string expected = "test";

            // Act
            string result = Exercises.TransformString(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TransformString_EmptyString()
        {
            // Arrange
            string input = "";
            string expected = "";

            // Act
            string result = Exercises.TransformString(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TransformString_MixedCase()
        {
            // Arrange
            string input = "MiXeDCaSe";
            string expected = "mixeDCASE";

            // Act
            string result = Exercises.TransformString(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetTransformedResult()
        {
            // Arrange
            string input = "w3r";
            string expected = "Input a string: w3r\nW3R";

            // Act
            string result = Exercises.GetTransformedResult(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 43 - Check String Starts with 'www'

        [TestMethod]
        public void CheckWWWStart_ValidCase()
        {
            // Arrange
            string input = "www.example.com";

            // Act
            bool result = Exercises.CheckWWWStart(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckWWWStart_ExactWWW()
        {
            // Arrange
            string input = "www";
            bool expected = true;

            // Act
            bool result = Exercises.CheckWWWStart(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckWWWStart_InvalidStart()
        {
            // Arrange
            string input = "ww.example";

            // Act
            bool result = Exercises.CheckWWWStart(input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckWWWStart_ShortString()
        {
            // Arrange
            string input = "ww";

            // Act
            bool result = Exercises.CheckWWWStart(input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckWWWStart_EmptyString()
        {
            // Arrange
            string input = "";

            // Act
            bool result = Exercises.CheckWWWStart(input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetCheckResult5()
        {
            // Arrange
            string input = "www";
            string expected = "Input a string : www\nTrue";

            // Act
            string result = Exercises.GetCheckResult3(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 44 - Every Other Character in String

        [TestMethod]
        public void GetEveryOtherCharacter_SampleInput()
        {
            // Arrange
            string input = "w3resource";
            string expected = "wrsuc";

            // Act
            string result = Exercises.GetEveryOtherCharacter(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetEveryOtherCharacter_ShortString()
        {
            // Arrange
            string input = "A";
            string expected = "A";

            // Act
            string result = Exercises.GetEveryOtherCharacter(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetEveryOtherCharacter_EvenLengthString()
        {
            // Arrange
            string input = "ABCDEF";
            string expected = "ACE";

            // Act
            string result = Exercises.GetEveryOtherCharacter(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetEveryOtherCharacter_EmptyString()
        {
            // Arrange
            string input = "";
            string expected = "";

            // Act
            string result = Exercises.GetEveryOtherCharacter(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetResultString()
        {
            // Arrange
            string input = "w3resource";
            string expected = "Input a string : w3resource\nwrsuc";

            // Act
            string result = Exercises.GetResultString(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 45 - Count Specific Number in Array

        [TestMethod]
        public void CountNumberInArray_ValidInput()
        {
            // Arrange
            int[] numbers = { 1, 5, 3, 5, 9 };
            int target = 5;
            int expected = 2;

            // Act
            int result = Exercises.CountNumberInArray(numbers, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CountNumberInArray_NumberNotPresent()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4 };
            int target = 5;
            int expected = 0;

            // Act
            int result = Exercises.CountNumberInArray(numbers, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CountNumberInArray_EmptyArray()
        {
            // Arrange
            int[] numbers = Array.Empty<int>();
            int target = 5;
            int expected = 0;

            // Act
            int result = Exercises.CountNumberInArray(numbers, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CountNumberInArray_NullArray()
        {
            // Arrange
            int[] numbers = null;
            int target = 5;
            int expected = 0;

            // Act
            int result = Exercises.CountNumberInArray(numbers, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CountNumberInArray_MultipleOccurrences()
        {
            // Arrange
            int[] numbers = { 5, 5, 5, 5, 5 };
            int target = 5;
            int expected = 5;

            // Act
            int result = Exercises.CountNumberInArray(numbers, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetCountResult()
        {
            // Arrange
            int[] numbers = { 1, 5, 3, 5, 9 };
            int target = 5;
            string expected = "Number of 5 present in the said array: 2";

            // Act
            string result = Exercises.GetCountResult(numbers, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 46 - Check Number First or Last in Array

        [TestMethod]
        public void CheckFirstOrLast_NumberAtFirs()
        {
            // Arrange
            int[] array = { 25, 10, 15, 20 };
            int number = 25;

            // Act
            bool result = Exercises.CheckFirstOrLast(array, number);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckFirstOrLast_NumberAtLast()
        {
            // Arrange
            int[] array = { 10, 15, 20, 25 };
            int number = 25;

            // Act
            bool result = Exercises.CheckFirstOrLast(array, number);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckFirstOrLast_NumberNotAtEnds()
        {
            // Arrange
            int[] array = { 10, 25, 15, 20 };
            int number = 25;

            // Act
            bool result = Exercises.CheckFirstOrLast(array, number);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckFirstOrLast_SingleElementArray()
        {
            // Arrange
            int[] array = { 25 };
            int number = 25;

            // Act
            bool result = Exercises.CheckFirstOrLast(array, number);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetCheckResult6()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40 };
            int number = 25;
            string expected = "Input an integer: 25\nFalse";

            // Act
            string result = Exercises.GetCheckResult(array, number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 47 - Sum of Array Elements

        [TestMethod]
        public void CalculateSum_SampleArray()
        {
            // Arrange
            int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int expected = 69;

            // Act
            int result = Exercises.CalculateSum(array);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateSum_EmptyArray()
        {
            // Arrange
            int[] array = Array.Empty<int>();
            int expected = 0;

            // Act
            int result = Exercises.CalculateSum(array);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateSum_NegativeNumbers()
        {
            // Arrange
            int[] array = { -1, -2, -3, -4 };
            int expected = -10;

            // Act
            int result = Exercises.CalculateSum(array);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetSumResult()
        {
            // Arrange
            int[] array = { 1, 2, 3 };
            string expected = "Array1: [1, 2, 3]\nSum: 6";

            // Act
            string result = Exercises.GetSumResult(array);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 48 - First and Last Element Equal in Array

        [TestMethod]
        public void CheckFirstLastEqual_SampleArray()
        {
            // Arrange
            int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            bool expected = true;

            // Act
            bool result = Exercises.CheckFirstLastEqual(array);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckFirstLastEqual_NotEqual()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            bool expected = false;

            // Act
            bool result = Exercises.CheckFirstLastEqual(array);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckFirstLastEqual_SingleElement()
        {
            // Arrange
            int[] array = { 5 };
            bool expected = true;

            // Act
            bool result = Exercises.CheckFirstLastEqual(array);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetCheckResult7()
        {
            // Arrange
            int[] array = { 1, 2, 3, 1 };
            string expected = "Array1: [1, 2, 3, 1]\nTrue";

            // Act
            string result = Exercises.GetCheckResult(array);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise01 49 - First or Last Element Equal in Two Arrays

        [TestMethod]
        public void CheckFirstOrLastEqual_SampleArrays()
        {
            // Arrange
            int[] array1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] array2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            bool expected = true;

            // Act
            bool result = Exercises.CheckFirstOrLastEqual(array1, array2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckFirstOrLastEqual_FirstElementsEqual()
        {
            // Arrange
            int[] array1 = { 5, 2, 3 };
            int[] array2 = { 5, 4, 6 };
            bool expected = true;

            // Act
            bool result = Exercises.CheckFirstOrLastEqual(array1, array2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckFirstOrLastEqual_LastElementsEqual()
        {
            // Arrange
            int[] array1 = { 1, 2, 5 };
            int[] array2 = { 3, 4, 5 };
            bool expected = true;

            // Act
            bool result = Exercises.CheckFirstOrLastEqual(array1, array2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckFirstOrLastEqual_NoElementsEqual()
        {
            // Arrange
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            bool expected = false;

            // Act
            bool result = Exercises.CheckFirstOrLastEqual(array1, array2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetCheckResult8()
        {
            // Arrange
            int[] array1 = { 1, 2, 3, 1 };
            int[] array2 = { 1, 2, 3, 5 };
            string expected = "Array1: [1, 2, 3, 1]\n" +
                            "Array2: [1, 2, 3, 5]\n" +
                            "Check if the first element or the last element of the two arrays are equal:\n" +
                            "True";

            // Act
            string result = Exercises.GetCheckResult(array1, array2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 50 - Rotate Array Left

        [TestMethod]
        public void RotateLeft_SampleArray()
        {
            // Arrange
            int[] array = { 1, 2, 8 };
            int[] expected = { 2, 8, 1 };

            // Act
            int[] result = Exercises.RotateLeft(array);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RotateLeft_DifferentValues()
        {
            // Arrange
            int[] array = { 5, 10, 15 };
            int[] expected = { 10, 15, 5 };

            // Act
            int[] result = Exercises.RotateLeft(array);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetRotatedResult()
        {
            // Arrange
            int[] array = { 1, 2, 8 };
            string expected = "Array1: [1, 2, 8]\n" +
                            "After rotating array becomes: [2, 8, 1]";

            // Act
            string result = Exercises.GetRotatedResult(array);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 51 - Max of First and Last in Array

        [TestMethod]
        public void GetMaxOfFirstAndLast_ArrayWithFirstMax_ReturnsFirstElement()
        {
            // Arrange
            int[] array = { 10, 2, 5, 7, 8 };
            var exercises = new Exercises();

            // Act
            int result = exercises.GetMaxOfFirstAndLast(array);

            // Assert
            result.Should().Be(10);
        }

        [TestMethod]
        public void GetMaxOfFirstAndLast_ArrayWithLastMax_ReturnsLastElement()
        {
            // Arrange
            int[] array = { 1, 2, 5, 7, 15 };
            var exercises = new Exercises();

            // Act
            int result = exercises.GetMaxOfFirstAndLast(array);

            // Assert
            result.Should().Be(15);
        }

        [TestMethod]
        public void GetMaxOfFirstAndLast_ArrayWithEqualFirstAndLast_ReturnsSameValue()
        {
            // Arrange
            int[] array = { 5, 2, 3, 4, 5 };
            var exercises = new Exercises();

            // Act
            int result = exercises.GetMaxOfFirstAndLast(array);

            // Assert
            result.Should().Be(5);
        }

        [TestMethod]
        public void GetMaxOfFirstAndLast_ArrayWithNegativeNumbers_ReturnsCorrectMax()
        {
            // Arrange
            int[] array = { -10, 2, 5, 7, -5 };
            var exercises = new Exercises();

            // Act
            int result = exercises.GetMaxOfFirstAndLast(array);

            // Assert
            result.Should().Be(-5);
        }

        [TestMethod]
        public void GetMaxOfFirstAndLast_ArrayWithSingleElement_ReturnsElement()
        {
            // Arrange
            int[] array = { 42 };
            var exercises = new Exercises();

            // Act
            int result = exercises.GetMaxOfFirstAndLast(array);

            // Assert
            result.Should().Be(42);
        }

        [TestMethod]
        public void GetMaxOfFirstAndLast_TestDataFromExample_Returns8()
        {
            // Arrange
            int[] array = { 1, 2, 5, 7, 8 };
            var exercises = new Exercises();

            // Act
            int result = exercises.GetMaxOfFirstAndLast(array);

            // Assert
            result.Should().Be(8);
        }

        [TestMethod]
        public void GetMaxOfFirstAndLast_NullArray_ThrowsArgumentException()
        {
            // Arrange
            int[] array = null;
            var exercises = new Exercises();

            // Act
            Action act = () => exercises.GetMaxOfFirstAndLast(array);

            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Array cannot be null or empty");
        }

        [TestMethod]
        public void GetMaxOfFirstAndLast_EmptyArray_ThrowsArgumentException()
        {
            // Arrange
            int[] array = new int[0];
            var exercises = new Exercises();

            // Act
            Action act = () => exercises.GetMaxOfFirstAndLast(array);

            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Array cannot be null or empty");
        }

        // Exercise 52 - Middle Elements of Three Arrays

        [TestMethod]
        public void GetMiddleElements_ThreeArrays_ReturnsMiddleElements()
        {
            // Arrange
            int[] array1 = { 1, 2, 5 };
            int[] array2 = { 0, 3, 8 };
            int[] array3 = { -1, 0, 2 };
            var exercises = new Exercises();

            // Act
            int[] result = exercises.GetMiddleElements(array1, array2, array3);

            // Assert
            result.Should().NotBeNull();
            result.Should().HaveCount(3);
            result.Should().Equal(2, 3, 0);
        }

        [TestMethod]
        public void GetMiddleElements_ArraysWithNegativeNumbers_ReturnsCorrectMiddleElements()
        {
            // Arrange
            int[] array1 = { -5, -2, -1 };
            int[] array2 = { 10, 20, 30 };
            int[] array3 = { 0, -10, 5 };
            var exercises = new Exercises();

            // Act
            int[] result = exercises.GetMiddleElements(array1, array2, array3);

            // Assert
            result.Should().Equal(-2, 20, -10);
        }

        [TestMethod]
        public void GetMiddleElements_ArraysWithSameValues_ReturnsMiddleElements()
        {
            // Arrange
            int[] array1 = { 5, 5, 5 };
            int[] array2 = { 10, 10, 10 };
            int[] array3 = { 1, 1, 1 };
            var exercises = new Exercises();

            // Act
            int[] result = exercises.GetMiddleElements(array1, array2, array3);

            // Assert
            result.Should().Equal(5, 10, 1);
        }

        [TestMethod]
        public void GetMiddleElements_ArraysWithZero_ReturnsCorrectMiddleElements()
        {
            // Arrange
            int[] array1 = { 0, 0, 0 };
            int[] array2 = { 1, 0, 2 };
            int[] array3 = { 0, 5, 0 };
            var exercises = new Exercises();

            // Act
            int[] result = exercises.GetMiddleElements(array1, array2, array3);

            // Assert
            result.Should().Equal(0, 0, 5);
        }

        [TestMethod]
        public void GetMiddleElements_NullArray_ThrowsArgumentException()
        {
            // Arrange
            int[] array1 = { 1, 2, 3 };
            int[] array2 = null;
            int[] array3 = { 4, 5, 6 };
            var exercises = new Exercises();

            // Act
            Action act = () => exercises.GetMiddleElements(array1, array2, array3);

            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Arrays cannot be null");
        }

        [TestMethod]
        public void GetMiddleElements_ArrayNotLength3_ThrowsArgumentException()
        {
            // Arrange
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5 }; // Length 2
            int[] array3 = { 7, 8, 9 };
            var exercises = new Exercises();

            // Act
            Action act = () => exercises.GetMiddleElements(array1, array2, array3);

            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("All arrays must have length 3");
        }

        [TestMethod]
        public void GetMiddleElements_EmptyArray_ThrowsArgumentException()
        {
            // Arrange
            int[] array1 = { 1, 2, 3 };
            int[] array2 = new int[0]; // Empty
            int[] array3 = { 7, 8, 9 };
            var exercises = new Exercises();

            // Act
            Action act = () => exercises.GetMiddleElements(array1, array2, array3);

            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("All arrays must have length 3");
        }

        // Exercise 53 - Check Odd Number in Array

        [TestMethod]
        public void ContainsOddNumber_ArrayWithOddNumber_ReturnsTrue()
        {
            // Arrange
            int[] array = { 2, 4, 7, 8, 6 };
            var exercises = new Exercises();

            // Act
            bool result = exercises.ContainsOddNumber(array);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void ContainsOddNumber_ArrayWithOnlyEvenNumbers_ReturnsFalse()
        {
            // Arrange
            int[] array = { 2, 4, 8, 6, 10 };
            var exercises = new Exercises();

            // Act
            bool result = exercises.ContainsOddNumber(array);

            // Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void ContainsOddNumber_ArrayWithMultipleOddNumbers_ReturnsTrue()
        {
            // Arrange
            int[] array = { 1, 3, 5, 7, 9 };
            var exercises = new Exercises();

            // Act
            bool result = exercises.ContainsOddNumber(array);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void ContainsOddNumber_ArrayWithNegativeOddNumbers_ReturnsTrue()
        {
            // Arrange
            int[] array = { -1, -2, -3, -4, -5 };
            var exercises = new Exercises();

            // Act
            bool result = exercises.ContainsOddNumber(array);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void ContainsOddNumber_ArrayWithNegativeEvenNumbers_ReturnsFalse()
        {
            // Arrange
            int[] array = { -2, -4, -6, -8, -10 };
            var exercises = new Exercises();

            // Act
            bool result = exercises.ContainsOddNumber(array);

            // Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void ContainsOddNumber_ArrayWithZero_ReturnsFalse()
        {
            // Arrange
            int[] array = { 0, 2, 4, 6, 8 };
            var exercises = new Exercises();

            // Act
            bool result = exercises.ContainsOddNumber(array);

            // Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void ContainsOddNumber_EmptyArray_ReturnsFalse()
        {
            // Arrange
            int[] array = new int[0];
            var exercises = new Exercises();

            // Act
            bool result = exercises.ContainsOddNumber(array);

            // Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void ContainsOddNumber_NullArray_ReturnsFalse()
        {
            // Arrange
            int[] array = null;
            var exercises = new Exercises();

            // Act
            bool result = exercises.ContainsOddNumber(array);

            // Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void ContainsOddNumber_SingleOddElement_ReturnsTrue()
        {
            // Arrange
            int[] array = { 7 };
            var exercises = new Exercises();

            // Act
            bool result = exercises.ContainsOddNumber(array);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void ContainsOddNumber_SingleEvenElement_ReturnsFalse()
        {
            // Arrange
            int[] array = { 4 };
            var exercises = new Exercises();

            // Act
            bool result = exercises.ContainsOddNumber(array);

            // Assert
            result.Should().BeFalse();
        }

        // Exercise 54 - Find Century of Year

        [TestMethod]
        public void GetCentury_Year1()
        {
            // Arrange
            int year = 1;
            var exercises = new Exercises();

            // Act
            int result = exercises.GetCentury(year);

            // Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void GetCentury_Year100()
        {
            // Arrange
            int year = 100;
            var exercises = new Exercises();

            // Act
            int result = exercises.GetCentury(year);

            // Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void GetCentury_Year101()
        {
            // Arrange
            int year = 101;
            var exercises = new Exercises();

            // Act
            int result = exercises.GetCentury(year);

            // Assert
            result.Should().Be(2);
        }

        [TestMethod]
        public void GetCentury_Year200()
        {
            // Arrange
            int year = 200;
            var exercises = new Exercises();

            // Act
            int result = exercises.GetCentury(year);

            // Assert
            result.Should().Be(2);
        }

        [TestMethod]
        public void GetCentury_Year2023()
        {
            // Arrange
            int year = 2023;
            var exercises = new Exercises();

            // Act
            int result = exercises.GetCentury(year);

            // Assert
            result.Should().Be(21);
        }

        [TestMethod]
        public void GetCentury_Year2000()
        {
            // Arrange
            int year = 2000;
            var exercises = new Exercises();

            // Act
            int result = exercises.GetCentury(year);

            // Assert
            result.Should().Be(20);
        }

        [TestMethod]
        public void GetCentury_Year2001()
        {
            // Arrange
            int year = 2001;
            var exercises = new Exercises();

            // Act
            int result = exercises.GetCentury(year);

            // Assert
            result.Should().Be(21);
        }

        [TestMethod]
        public void GetCentury_Year1900()
        {
            // Arrange
            int year = 1900;
            var exercises = new Exercises();

            // Act
            int result = exercises.GetCentury(year);

            // Assert
            result.Should().Be(19);
        }

        [TestMethod]
        public void GetCentury_Year1901()
        {
            // Arrange
            int year = 1901;
            var exercises = new Exercises();

            // Act
            int result = exercises.GetCentury(year);

            // Assert
            result.Should().Be(20);
        }

        [TestMethod]
        public void GetCentury_Year0()
        {
            // Arrange
            int year = 0;
            var exercises = new Exercises();

            // Act
            Action act = () => exercises.GetCentury(year);

            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Year must be greater than 0");
        }

        [TestMethod]
        public void GetCentury_NegativeYear()
        {
            // Arrange
            int year = -100;
            var exercises = new Exercises();

            // Act
            Action act = () => exercises.GetCentury(year);

            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Year must be greater than 0");
        }

        [TestMethod]
        public void GetCentury_Year9999()
        {
            // Arrange
            int year = 9999;
            var exercises = new Exercises();

            // Act
            int result = exercises.GetCentury(year);

            // Assert
            result.Should().Be(100);
        }

        [TestMethod]
        public void GetCentury_Year10000()
        {
            // Arrange
            int year = 10000;
            var exercises = new Exercises();

            // Act
            int result = exercises.GetCentury(year);

            // Assert
            result.Should().Be(100);
        }

        // Exercise 55 - Max Product of Adjacent Elements

        [TestMethod]
        public void MaxAdjacentProduct_ArrayWithPositiveNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            var exercises = new Exercises();

            // Act
            int result = exercises.MaxAdjacentProduct(array);

            // Assert
            result.Should().Be(20); // 4 * 5 = 20
        }

        [TestMethod]
        public void MaxAdjacentProduct_ArrayWithMixedNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            int[] array = { 3, 6, -2, -5, 7, 3 };
            var exercises = new Exercises();

            // Act
            int result = exercises.MaxAdjacentProduct(array);

            // Assert
            result.Should().Be(21); // 7 * 3 = 21
        }

        [TestMethod]
        public void MaxAdjacentProduct_ArrayWithTwoElements_ReturnsTheirProduct()
        {
            // Arrange
            int[] array = { 9, 5 };
            var exercises = new Exercises();

            // Act
            int result = exercises.MaxAdjacentProduct(array);

            // Assert
            result.Should().Be(45); // 9 * 5 = 45
        }

        [TestMethod]
        public void MaxAdjacentProduct_ArrayWithNegativeNumbers_Returns12()
        {
            // Arrange
            int[] array = { -5, -2, -1, -4, -3 };
            var exercises = new Exercises();

            // Act
            int result = exercises.MaxAdjacentProduct(array);

            // Assert
            result.Should().Be(12); // (-4) * (-3) = 12
        }

        [TestMethod]
        public void MaxAdjacentProduct_ArrayWithLargeNegativeProduct_Returns10000()
        {
            // Arrange
            int[] array = { -100, -100, 5, 10 };
            var exercises = new Exercises();

            // Act
            int result = exercises.MaxAdjacentProduct(array);

            // Assert
            result.Should().Be(10000); // (-100) * (-100) = 10000
        }


        [TestMethod]
        public void MaxAdjacentProduct_ArrayWithZeros_ReturnsZero()
        {
            // Arrange
            int[] array = { 0, 0, 0, 0 };
            var exercises = new Exercises();

            // Act
            int result = exercises.MaxAdjacentProduct(array);

            // Assert
            result.Should().Be(0);
        }

        [TestMethod]
        public void MaxAdjacentProduct_ArrayWithSingleElement_ThrowsArgumentException()
        {
            // Arrange
            int[] array = { 5 };
            var exercises = new Exercises();

            // Act
            Action act = () => exercises.MaxAdjacentProduct(array);

            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Array must have at least 2 elements");
        }

        [TestMethod]
        public void MaxAdjacentProduct_EmptyArray_ThrowsArgumentException()
        {
            // Arrange
            int[] array = new int[0];
            var exercises = new Exercises();

            // Act
            Action act = () => exercises.MaxAdjacentProduct(array);

            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Array must have at least 2 elements");
        }

        [TestMethod]
        public void MaxAdjacentProduct_NullArray_ThrowsArgumentException()
        {
            // Arrange
            int[] array = null;
            var exercises = new Exercises();

            // Act
            Action act = () => exercises.MaxAdjacentProduct(array);

            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Array cannot be null");
        }

        [TestMethod]
        public void MaxAdjacentProduct_ArrayWithSpecificPattern_ReturnsCorrectProduct()
        {
            // Arrange
            int[] array = { 1, 0, 1, 0, 1000 };
            var exercises = new Exercises();

            // Act
            int result = exercises.MaxAdjacentProduct(array);

            // Assert
            result.Should().Be(0);
        }

        // Exercise 56 - Check Palindrome String

        [TestMethod]
        public void IsPalindrome_SimplePalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "aaa";
            var exercises = new Exercises();

            // Act
            bool result = exercises.IsPalindrome(input);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void IsPalindrome_NonPalindrome_ReturnsFalse()
        {
            // Arrange
            string input = "abcd";
            var exercises = new Exercises();

            // Act
            bool result = exercises.IsPalindrome(input);

            // Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void IsPalindrome_SingleCharacter_ReturnsTrue()
        {
            // Arrange
            string input = "a";
            var exercises = new Exercises();

            // Act
            bool result = exercises.IsPalindrome(input);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            // Arrange
            string input = "";
            var exercises = new Exercises();

            // Act
            bool result = exercises.IsPalindrome(input);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void IsPalindrome_EvenLengthPalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "abba";
            var exercises = new Exercises();

            // Act
            bool result = exercises.IsPalindrome(input);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void IsPalindrome_OddLengthPalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "radar";
            var exercises = new Exercises();

            // Act
            bool result = exercises.IsPalindrome(input);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void IsPalindrome_WithSpacesAndCase_ReturnsFalseByDefault()
        {
            // Arrange
            string input = "A man a plan a canal Panama";
            var exercises = new Exercises();

            // Act
            bool result = exercises.IsPalindrome(input);

            // Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void IsPalindrome_MixedCasePalindrome_ReturnsFalseByDefault()
        {
            // Arrange
            string input = "Racecar";
            var exercises = new Exercises();

            // Act
            bool result = exercises.IsPalindrome(input);

            // Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void IsPalindrome_NullString_ReturnsFalse()
        {
            // Arrange
            string input = null;
            var exercises = new Exercises();

            // Act
            bool result = exercises.IsPalindrome(input);

            // Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void IsPalindrome_WithSpecialCharacters_ReturnsCorrectResult()
        {
            // Arrange
            string input = "a!b@b#a";
            var exercises = new Exercises();

            // Act
            bool result = exercises.IsPalindrome(input);

            // Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void IsPalindrome_NumericPalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "12321";
            var exercises = new Exercises();

            // Act
            bool result = exercises.IsPalindrome(input);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void IsPalindrome_NumericNonPalindrome_ReturnsFalse()
        {
            // Arrange
            string input = "12345";
            var exercises = new Exercises();

            // Act
            bool result = exercises.IsPalindrome(input);

            // Assert
            result.Should().BeFalse();
        }

        // Exercise 57 - Max Product of Adjacent Integers

        [TestMethod]
        public void ArrayAdjacentElementsProduct_WithPositiveNumbers_ReturnsMaxProduct()
        {
            // Arrange
            int[] inputArray = { 3, 6, -2, -5, 7, 3 };
            int expected = 21;

            // Act
            int result = Exercises.ArrayAdjacentElementsProduct(inputArray);

            // Assert
            result.Should().Be(expected);
        }

        [TestMethod]
        public void ArrayAdjacentElementsProduct_WithNegativeNumbers_ReturnsMaxProduct()
        {
            // Arrange
            int[] inputArray = { -5, -2, -3, -1, -4 };
            int expected = 10;

            // Act
            int result = Exercises.ArrayAdjacentElementsProduct(inputArray);

            // Assert
            result.Should().Be(expected);
        }

        [TestMethod]
        public void ArrayAdjacentElementsProduct_WithMixedNumbers_ReturnsMaxProduct()
        {
            // Arrange
            int[] inputArray = { 1, -2, 3, -4, 5 };
            int expected = 12;

            // Act
            int result = Exercises.ArrayAdjacentElementsProduct(inputArray);

            // Assert
            result.Should().Be(-2);
        }

        [TestMethod]
        public void ArrayAdjacentElementsProduct_WithTwoElements_ReturnsTheirProduct()
        {
            // Arrange
            int[] inputArray = { 5, 8 };
            int expected = 40;

            // Act
            int result = Exercises.ArrayAdjacentElementsProduct(inputArray);

            // Assert
            result.Should().Be(expected);
        }

        [TestMethod]
        public void ArrayAdjacentElementsProduct_WithAllSameNumbers_ReturnsSquare()
        {
            // Arrange
            int[] inputArray = { 4, 4, 4, 4 };
            int expected = 16;

            // Act
            int result = Exercises.ArrayAdjacentElementsProduct(inputArray);

            // Assert
            result.Should().Be(expected);
        }

        [TestMethod]
        public void ArrayAdjacentElementsProduct_WithLargeNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            int[] inputArray = { 1000, 2, 500, 3 };
            int expected = 500000;

            // Act
            int result = Exercises.ArrayAdjacentElementsProduct(inputArray);

            // Assert
            result.Should().Be(2000);
        }

        [TestMethod]
        public void ArrayAdjacentElementsProduct_WithZeroInArray_HandlesZeroCorrectly()
        {
            // Arrange
            int[] inputArray = { 5, 0, 3, 4 };
            int expected = 12;

            // Act
            int result = Exercises.ArrayAdjacentElementsProduct(inputArray);

            // Assert
            result.Should().Be(expected);
        }

        [TestMethod]
        public void ArrayAdjacentElementsProduct_EdgeCaseWithMinimumValues_ReturnsCorrectProduct()
        {
            // Arrange
            int[] inputArray = { int.MinValue, int.MaxValue, 1 };

            // Act
            int result = Exercises.ArrayAdjacentElementsProduct(inputArray);

            // Assert
            result.Should().Be(int.MaxValue);
        }

        // Exercise 58 - Complete Missing Numbers in Range

        [TestMethod]
        public void CountMissingNumbersInRange_SampleInput_ReturnsCorrectCount()
        {
            // Arrange
            int[] numbers = { 1, 3, 4, 7, 9 };
            int expected = 4; // Missing: 2, 5, 6, 8

            // Act
            int result = Exercises.CountMissingNumbersInRange(numbers);

            // Assert
            result.Should().Be(expected);
        }

        [TestMethod]
        public void GetMissingNumbersInRange_SampleInput_ReturnsCorrectNumbers()
        {
            // Arrange
            int[] numbers = { 1, 3, 4, 7, 9 };
            List<int> expected = new List<int> { 2, 5, 6, 8 };

            // Act
            var result = Exercises.GetMissingNumbersInRange(numbers);

            // Assert
            result.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void CountMissingNumbersInRange_ConsecutiveNumbers_ReturnsZero()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Act
            int result = Exercises.CountMissingNumbersInRange(numbers);

            // Assert
            result.Should().Be(0);
        }

        [TestMethod]
        public void CountMissingNumbersInRange_SingleNumber_ReturnsZero()
        {
            // Arrange
            int[] numbers = { 5 };

            // Act
            int result = Exercises.CountMissingNumbersInRange(numbers);

            // Assert
            result.Should().Be(0);
        }

        [TestMethod]
        public void CountMissingNumbersInRange_NegativeNumbers_ReturnsCorrectCount()
        {
            // Arrange
            int[] numbers = { -3, 0, 2 };
            int expected = 3;
            // Range: -3 to 2, missing: -2, -1, 1

            // Act
            int result = Exercises.CountMissingNumbersInRange(numbers);

            // Assert
            result.Should().Be(expected); // -2, -1, 1
        }

        [TestMethod]
        public void CountMissingNumbersInRange_DuplicateNumbers_ReturnsCorrectCount()
        {
            // Arrange
            int[] numbers = { 1, 1, 3, 3, 5, 5 };
            // Range: 1 to 5, missing: 2, 4

            // Act
            int result = Exercises.CountMissingNumbersInRange(numbers);

            // Assert
            result.Should().Be(2);
        }

        [TestMethod]
        public void GetMissingNumbersResult_FormatsOutputCorrectly()
        {
            // Arrange
            int[] numbers = { 1, 3, 4, 7, 9 };
            string expectedStart = "Input: [1, 3, 4, 7, 9]";
            string expectedRange = "Range: 1 to 9";
            string expectedMissing = "Missing numbers: [2, 5, 6, 8]";
            string expectedCount = "Count of missing numbers: 4";

            // Act
            string result = Exercises.GetMissingNumbersResult(numbers);

            // Assert
            result.Should().Contain(expectedStart)
                  .And.Contain(expectedRange)
                  .And.Contain(expectedMissing)
                  .And.Contain(expectedCount);
        }

        [TestMethod]
        public void CountMissingNumbersInRange_LargeRange_ReturnsCorrectCount()
        {
            // Arrange
            int[] numbers = { 10, 50 };
            // Missing numbers from 11 to 49 = 39 numbers

            // Act
            int result = Exercises.CountMissingNumbersInRange(numbers);

            // Assert
            result.Should().Be(39);
        }

        // Exercise 59 - Check Strictly Increasing Sequence

        [TestMethod]
        public void CanBecomeStrictlyIncreasing_AlreadyStrictlyIncreasing_ReturnsTrue()
        {
            // Arrange
            int[] sequence = { 1, 2, 3, 4, 5 };

            // Act
            bool result = Exercises.CanBecomeStrictlyIncreasing(sequence);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void CanBecomeStrictlyIncreasing_RemoveOneElement_ReturnsTrue()
        {
            // Arrange
            int[] sequence = { 1, 3, 2, 4 }; // Remove 3 → [1, 2, 4]

            // Act
            bool result = Exercises.CanBecomeStrictlyIncreasing(sequence);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void CanBecomeStrictlyIncreasing_NeedMultipleRemovals_ReturnsFalse()
        {
            // Arrange
            int[] sequence = { 1, 1, 1, 1 }; // Need to remove 3 elements

            // Act
            bool result = Exercises.CanBecomeStrictlyIncreasing(sequence);

            // Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void CanBecomeStrictlyIncreasing_ComplexCase_ReturnsTrue()
        {
            // Arrange
            int[] sequence = { 10, 1, 2, 3, 4, 5 }; // Remove 10 → [1, 2, 3, 4, 5]

            // Act
            bool result = Exercises.CanBecomeStrictlyIncreasing(sequence);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void CanBecomeStrictlyIncreasing_ComplexCase2_ReturnsFalse()
        {
            // Arrange
            int[] sequence = { 1, 2, 1, 2, 1 }; // Multiple violations

            // Act
            bool result = Exercises.CanBecomeStrictlyIncreasing(sequence);

            // Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void CanBecomeStrictlyIncreasing_SingleElement_ReturnsTrue()
        {
            // Arrange
            int[] sequence = { 5 };

            // Act
            bool result = Exercises.CanBecomeStrictlyIncreasing(sequence);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void CanBecomeStrictlyIncreasing_EmptyArray_ReturnsTrue()
        {
            // Arrange
            int[] sequence = Array.Empty<int>();

            // Act
            bool result = Exercises.CanBecomeStrictlyIncreasing(sequence);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void CanBecomeStrictlyIncreasing_NullArray_ReturnsTrue()
        {
            // Arrange
            int[] sequence = null;

            // Act
            bool result = Exercises.CanBecomeStrictlyIncreasing(sequence);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void CanBecomeStrictlyIncreasing_EdgeCase_ReturnsTrue()
        {
            // Arrange
            int[] sequence = { 1, 2, 3, 4, 3, 6 }; // Remove 4 → [1, 2, 3, 3, 6] → Remove second 3 → [1, 2, 3, 6]

            // Act
            bool result = Exercises.CanBecomeStrictlyIncreasing(sequence);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void CanBecomeStrictlyIncreasing_EdgeCase2_ReturnsFalse()
        {
            // Arrange
            int[] sequence = { 1, 2, 3, 4, 3, 2, 5 }; // Multiple violations

            // Act
            bool result = Exercises.CanBecomeStrictlyIncreasing(sequence);

            // Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void GetStrictlyIncreasingResult_FormatsOutputCorrectly()
        {
            // Arrange
            int[] sequence = { 1, 3, 2, 4 };
            string expected = "Sequence: [1, 3, 2, 4]\n" +
                            "Can become strictly increasing: True";

            // Act
            string result = Exercises.GetStrictlyIncreasingResult(sequence);

            // Assert
            result.Should().Be(expected);
        }

        // Exercise 60 - Sum of Matrix with Zero Condition

        [TestMethod]
        public void SumMatrixWithZeroCondition_SampleMatrix_Returns14()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
                new int[] { 0, 2, 3, 2 },
                new int[] { 0, 6, 0, 1 },
                new int[] { 4, 0, 3, 0 }
            };
            int expected = 14;

            // Act
            int result = Exercises.SumMatrixWithZeroCondition(matrix);

            // Assert
            result.Should().Be(expected);
        }

        [TestMethod]
        public void SumMatrixWithZeroCondition_NoZeros_ReturnsTotalSum()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 }
            };
            int expected = 21;

            // Act
            int result = Exercises.SumMatrixWithZeroCondition(matrix);

            // Assert
            result.Should().Be(expected);
        }

        [TestMethod]
        public void SumMatrixWithZeroCondition_AllZeros_ReturnsZero()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 0, 0 }
            };

            // Act
            int result = Exercises.SumMatrixWithZeroCondition(matrix);

            // Assert
            result.Should().Be(0);
        }

        [TestMethod]
        public void SumMatrixWithZeroCondition_ZeroInMiddle_ExcludesBelow()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 0, 6 },
                new int[] { 7, 8, 9 }
            };
            int expected = 1 + 2 + 3 + 4 + 0 + 6 + 7 + 9;

            // Act
            int result = Exercises.SumMatrixWithZeroCondition(matrix);

            // Assert
            result.Should().Be(expected);
        }

        [TestMethod]
        public void SumMatrixWithZeroCondition_EmptyMatrix_ReturnsZero()
        {
            // Arrange
            int[][] matrix = new int[0][];

            // Act
            int result = Exercises.SumMatrixWithZeroCondition(matrix);

            // Assert
            result.Should().Be(0);
        }

        [TestMethod]
        public void SumMatrixWithZeroCondition_NullMatrix_ReturnsZero()
        {
            // Arrange
            int[][] matrix = null;

            // Act
            int result = Exercises.SumMatrixWithZeroCondition(matrix);

            // Assert
            result.Should().Be(0);
        }

        [TestMethod]
        public void GetMatrixSumResult_FormatsOutputCorrectly()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
                new int[] { 0, 2, 3, 2 },
                new int[] { 0, 6, 0, 1 }
            };

            // Act
            string result = Exercises.GetMatrixSumResult(matrix);

            // Assert
            result.Should().Contain("Matrix:")
                  .And.Contain("[0, 2, 3, 2]")
                  .And.Contain("[0, 6, 0, 1]")
                  .And.Contain("Sum: 14");
        }
    }
}

