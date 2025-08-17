using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basic;
using System;
using System.IO;

namespace BasicTests
{
    [TestClass]
    public class ExercisesTests
    {
        // Exercise 11 - Print Age Message

        [TestMethod]
        public void GetAgeMessage_WithAge25()
        {
            // Arrange
            int age = 25;
            string expected = "You look older than 25";

            // Act
            string result = Exercise11.GetAgeMessage(age);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 12 - Repeat Number in Rows

        [TestMethod]

        public void GetNumberPattern()
        {
            // Arrange
            int number = 25;
            string expected = "25 25 25 25\r\n25252525\r\n25 25 25 25\r\n25252525";

            // Act
            string result = Exercise12.GetNumberPattern(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 13 - Rectangle Pattern with Number

        [TestMethod]
        public void GetRectanglePattern()
        {
            // Arrange
            int number = 5;
            string expected = "555\r\n5 5\r\n5 5\r\n5 5\r\n555";

            // Act
            string result = Exercise13.GetRectanglePattern(number);

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
            double result = Exercise14.ConvertToKelvin(celsius);

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
            double result = Exercise14.ConvertToFahrenheit(celsius);

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
            string result = Exercise14.GetTemperatureConversions(celsius);

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
            string result = Exercise15.RemoveCharacterAtIndex(input, index);

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
            string result = Exercise15.RemoveCharacterAtIndex(input, index);

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
            string result = Exercise15.RemoveCharacterAtIndex(input, index);

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
            string result = Exercise16.SwapFirstLastCharacters(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SwapFirst_LastCharacter()
        {
            // Arrange
            string input = "Python";
            string expected = "nythoP";

            // Act
            string result = Exercise16.SwapFirstLastCharacters(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NonSwapFirstLastCharacter()
        {
            // Arrange
            string input = "x";
            string expected = "x";

            // Act
            string result = Exercise16.SwapFirstLastCharacters(input);

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
            string result = Exercise17.AddFirstCharFrontAndBack(input);

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
            bool result = Exercise18.CheckPositiveNegativePair(first, second);

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
            int result = Exercise19.ComputeSum(a, b);

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
            int result = Exercise19.ComputeSum(a, b);

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
            int result = Exercise19.ComputeSum(a, b);

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
            int result = Exercise20.CalculateDifference(a, b);

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
            int result = Exercise20.CalculateDifference(a, b);

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
            bool result = Exercise21.CheckFor20(a, b);

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
            bool result = Exercise21.CheckFor20(a, b);

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
            bool result = Exercise21.CheckFor20(a, b);

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
            bool result = Exercise22.CheckWithin20(number);

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
            bool result = Exercise22.CheckWithin20(number);

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
            bool result = Exercise22.CheckWithin20(number);

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
            bool result = Exercise22.CheckWithin20(number);

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
            bool result = Exercise22.CheckWithin20(number);

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
            bool result = Exercise22.CheckWithin20(number);

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
            string result = Exercise22.GetCheckResult(number);

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
            string result = Exercise23.ConvertToLower(input);

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
            string result = Exercise23.ConvertToLower(input);

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
            string result = Exercise23.ConvertToLower(input);

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
            string result = Exercise23.ConvertToLower(input);

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
            string result = Exercise23.ConvertToLower(input);

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
            string result = Exercise23.GetLowercaseResult(input);

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
            string result = Exercise24.FindLongestWord(input);

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
            string result = Exercise25.GetOddNumbers();

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
            Exercise25.PrintOddNumbers();
            string result = stringWriter.ToString();

            // Assert
            StringAssert.Contains(result, expectedStart);
            StringAssert.Contains(result, expectedEnd);
            StringAssert.Contains(result, "...\r\n");
        }

        // Exercise 26 - Sum of First 500 Primes

        [TestClass]
        public class Exercise26Tests
        {
            [TestMethod]
            public void IsPrime()
            {
                Assert.IsTrue(Exercise26.IsPrime(2));
                Assert.IsTrue(Exercise26.IsPrime(3));
                Assert.IsTrue(Exercise26.IsPrime(5));
                Assert.IsTrue(Exercise26.IsPrime(7));
                Assert.IsFalse(Exercise26.IsPrime(1));
                Assert.IsFalse(Exercise26.IsPrime(4));
                Assert.IsFalse(Exercise26.IsPrime(9));
            }

            [TestMethod]
            public void SumOfFirst500Primes()
            {
                // Arrange
                long expected = 824693;

                // Act
                long result = Exercise26.SumOfFirst500Primes();

                // Assert
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void GetPrimeSumResult()
            {
                // Arrange
                string expectedStart = "Sum of the first 500 prime numbers:\n";
                long sum = Exercise26.SumOfFirst500Primes();

                // Act
                string result = Exercise26.GetPrimeSumResult();

                // Assert
                Assert.IsTrue(result.StartsWith(expectedStart));
                Assert.IsTrue(result.EndsWith(sum.ToString()));
            }

            // Exercise 27 - Sum of Digits in Integer

            [TestMethod]
            public void SumOfDigits()
            {
                Assert.AreEqual(3, Exercise27.SumOfDigits(12));
                Assert.AreEqual(15, Exercise27.SumOfDigits(12345));
                Assert.AreEqual(0, Exercise27.SumOfDigits(0));
                Assert.AreEqual(5, Exercise27.SumOfDigits(-5));
                Assert.AreEqual(6, Exercise27.SumOfDigits(-123));
            }

            [TestMethod]
            public void GetDigitSumResult()
            {
                string expected = "Sum of the digits of the said integer: 3";
                string result = Exercise27.GetDigitSumResult(12);
                Assert.AreEqual(expected, result);
            }

            // Exercise 28 - Reverse Words in Sentence

            [TestMethod]
            public void ReverseWords()
            {
                // Arrange
                string input = "Display the pattern like pyramid using the alphabet.";
                string expected = "alphabet. the using pyramid like pattern the Display";

                // Act
                string result = Exercise28.ReverseWords(input);

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
                string result = Exercise28.ReverseWords(input);

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
                string result = Exercise28.GetReversedSentenceResult(input);

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
                long actualSize = Exercise29.GetFileSize(TestFilePath);

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
                    Exercise29.GetFileSize(nonExistentFile));

                Assert.AreEqual($"File not found: {nonExistentFile}", exception.Message);
            }

            [TestMethod]
            public void GetFileSizeResult_WithNonExistentFile()
            {
                // Arrange
                string nonExistentFile = "nonexistentfile.txt";
                string expectedMessage = $"File not found: {nonExistentFile}";

                // Act
                string result = Exercise29.GetFileSizeResult(nonExistentFile);

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
                string result = Exercise29.GetFileSizeResult(TestFilePath);

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
                int result = Exercise30.HexToDecimal(hex);

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
                int result = Exercise30.HexToDecimal(hex);

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
                string result = Exercise30.GetConversionResult(hex);

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
                int[] result = Exercise31.MultiplyArrays(array1, array2);

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
                string result = Exercise31.GetMultiplicationResult(array1, array2);

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
                string result = Exercise32.GetLastFourCopies(input);

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
                bool result = Exercise33.IsMultipleOf3Or7(number);

                // Assert
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void IsMultipleOf3Or7_MultipleOf7()
            {
                // Arrange
                int number = 14;

                // Act
                bool result = Exercise33.IsMultipleOf3Or7(number);

                // Assert
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void IsMultipleOf3Or7_NotMultiple()
            {
                // Arrange
                int number = 16;

                // Act
                bool result = Exercise33.IsMultipleOf3Or7(number);

                // Assert
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void IsMultipleOf3Or7_Zero()
            {
                // Act
                bool result = Exercise33.IsMultipleOf3Or7(0);

                // Assert
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void IsMultipleOf3Or7_NegativeNumber()
            {
                // Act
                bool result = Exercise33.IsMultipleOf3Or7(-21);

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
                string result = Exercise33.GetCheckResult(number);

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
                bool result = Exercise34.StartsWithHello(input);

                // Assert
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void StartsWithHello_StartsWithHelloLowercase_ReturnsTrue()
            {
                // Arrange
                string input = "hello world";

                // Act
                bool result = Exercise34.StartsWithHello(input);

                // Assert
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void StartsWithHello_DoesNotStartWithHello_ReturnsFalse()
            {
                // Arrange
                string input = "Hi there";

                // Act
                bool result = Exercise34.StartsWithHello(input);

                // Assert
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void StartsWithHello_EmptyString_ReturnsFalse()
            {
                // Act
                bool result = Exercise34.StartsWithHello("");

                // Assert
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void StartsWithHello_WithLeadingSpaces_ReturnsTrue()
            {
                // Arrange
                string input = "   Hello everyone";

                // Act
                bool result = Exercise34.StartsWithHello(input);

                // Assert
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void GetCheckResult_FormatsOutputCorrectly()
            {
                // Arrange
                string input = "Hello how are you?";
                string expected = "Input a string : Hello how are you?\nTrue";

                // Act
                string result = Exercise34.GetCheckResult(input);

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
                bool result = Exercise35.CheckNumbers(num1, num2);

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
                bool result = Exercise35.CheckNumbers(num1, num2);

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
                bool result = Exercise35.CheckNumbers(num1, num2);

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
                bool result = Exercise35.CheckNumbers(num1, num2);

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
                string result = Exercise35.GetCheckResult(num1, num2);

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
                bool result = Exercise36.CheckInRange(num1, num2);

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
                bool result = Exercise36.CheckInRange(num1, num2);

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
                bool result = Exercise36.CheckInRange(num1, num2);

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
                bool result = Exercise36.CheckInRange(num1, num2);

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
                bool result = Exercise36.CheckInRange(num1, num2);

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
                string result = Exercise36.GetCheckResult(num1, num2);

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
                string result = Exercise37.RemoveHP(input);

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
                string result = Exercise37.RemoveHP(input);

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
                string result = Exercise37.RemoveHP(input);

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
                string result = Exercise37.RemoveHP(input);

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
                string result = Exercise37.GetModifiedString(input);

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
                string result = Exercise38.ExtractPH(input);

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
                string result = Exercise38.ExtractPH(input);

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
                string result = Exercise38.ExtractPH(input);

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
                string result = Exercise38.ExtractPH(input);

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
                string result = Exercise38.GetExtractionResult(input);

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
                var (largest, lowest) = Exercise39.FindLargestAndLowest(num1, num2, num3);

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
                var (largest, lowest) = Exercise39.FindLargestAndLowest(num1, num2, num3);

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
                var (largest, lowest) = Exercise39.FindLargestAndLowest(num1, num2, num3);

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
                string result = Exercise39.GetComparisonResult(num1, num2, num3);

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
                int result = Exercise40.FindNearestTo20(num1, num2);

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
                int result = Exercise40.FindNearestTo20(num1, num2);

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
                int result = Exercise40.FindNearestTo20(num1, num2);

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
                int result = Exercise40.FindNearestTo20(num1, num2);

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
                string result = Exercise40.GetNearestResult(num1, num2);

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
                bool result = Exercise41.CheckWCount(input);

                // Assert
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void CheckWCount_ThreeWs()
            {
                // Arrange
                string input = "www.example.com";

                // Act
                bool result = Exercise41.CheckWCount(input);

                // Assert
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void CheckWCount_ZeroWs()
            {
                // Arrange
                string input = "hello lucas";

                // Act
                bool result = Exercise41.CheckWCount(input);

                // Assert
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void CheckWCount_FourWs()
            {
                // Arrange
                string input = "wwww.example";

                // Act
                bool result = Exercise41.CheckWCount(input);

                // Assert
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void CheckWCount_MixedCaseWs()
            {
                // Arrange
                string input = "WwW.example";

                // Act
                bool result = Exercise41.CheckWCount(input);

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
                string result = Exercise41.GetCheckResult(input);

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
                string result = Exercise42.TransformString(input);

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
                string result = Exercise42.TransformString(input);

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
                string result = Exercise42.TransformString(input);

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
                string result = Exercise42.TransformString(input);

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
                string result = Exercise42.TransformString(input);

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
                string result = Exercise42.GetTransformedResult(input);

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
                bool result = Exercise43.CheckWWWStart(input);

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
                bool result = Exercise43.CheckWWWStart(input);

                // Assert
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void CheckWWWStart_InvalidStart()
            {
                // Arrange
                string input = "ww.example";

                // Act
                bool result = Exercise43.CheckWWWStart(input);

                // Assert
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void CheckWWWStart_ShortString()
            {
                // Arrange
                string input = "ww";

                // Act
                bool result = Exercise43.CheckWWWStart(input);

                // Assert
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void CheckWWWStart_EmptyString()
            {
                // Arrange
                string input = "";

                // Act
                bool result = Exercise43.CheckWWWStart(input);

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
                string result = Exercise43.GetCheckResult(input);

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
                string result = Exercise44.GetEveryOtherCharacter(input);

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
                string result = Exercise44.GetEveryOtherCharacter(input);

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
                string result = Exercise44.GetEveryOtherCharacter(input);

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
                string result = Exercise44.GetEveryOtherCharacter(input);

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
                string result = Exercise44.GetResultString(input);

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
                int result = Exercise45.CountNumberInArray(numbers, target);

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
                int result = Exercise45.CountNumberInArray(numbers, target);

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
                int result = Exercise45.CountNumberInArray(numbers, target);

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
                int result = Exercise45.CountNumberInArray(numbers, target);

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
                int result = Exercise45.CountNumberInArray(numbers, target);

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
                string result = Exercise45.GetCountResult(numbers, target);

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
                bool result = Exercise46.CheckFirstOrLast(array, number);

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
                bool result = Exercise46.CheckFirstOrLast(array, number);

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
                bool result = Exercise46.CheckFirstOrLast(array, number);

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
                bool result = Exercise46.CheckFirstOrLast(array, number);

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
                string result = Exercise46.GetCheckResult(array, number);

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
                int result = Exercise47.CalculateSum(array);

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
                int result = Exercise47.CalculateSum(array);

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
                int result = Exercise47.CalculateSum(array);

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
                string result = Exercise47.GetSumResult(array);

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
                bool result = Exercise48.CheckFirstLastEqual(array);

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
                bool result = Exercise48.CheckFirstLastEqual(array);

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
                bool result = Exercise48.CheckFirstLastEqual(array);

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
                string result = Exercise48.GetCheckResult(array);

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
                bool result = Exercise49.CheckFirstOrLastEqual(array1, array2);

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
                bool result = Exercise49.CheckFirstOrLastEqual(array1, array2);

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
                bool result = Exercise49.CheckFirstOrLastEqual(array1, array2);

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
                bool result = Exercise49.CheckFirstOrLastEqual(array1, array2);

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
                string result = Exercise49.GetCheckResult(array1, array2);

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
                int[] result = Exercise50.RotateLeft(array);

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
                int[] result = Exercise50.RotateLeft(array);

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
                string result = Exercise50.GetRotatedResult(array);

                // Assert
                Assert.AreEqual(expected, result);
            }
        }
    }
}

