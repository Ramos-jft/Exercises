using FluentAssertions;
using Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTests;

[TestClass]
public class MathExercisesTests
{
    /* Exercise 1 -  Write a C# Sharp program to get the absolute value of a number of Decimal values,
       Double values, Int16 values, Int32 values and Int64 values. */
    [TestMethod]
    public void GetDecimalAbs_ShouldReturnAbsoluteValue1()
    {
        var result = MathExercises.GetDecimalAbs(79228162514264337593543950335M);
        result.Should().Be(79228162514264337593543950335M);
    }

    [TestMethod]
    public void GetDecimalAbs_ShouldReturnAbsoluteValue2()
    {
        var result = MathExercises.GetDecimalAbs(15.55M);
        result.Should().Be(15.55M);
    }

    [TestMethod]
    public void GetDecimalAbs_ShouldReturnAbsoluteValue3()
    {
        var result = MathExercises.GetDecimalAbs(0M);
        result.Should().Be(0M);
    }

    [TestMethod]
    public void GetDecimalAbs_ShouldReturnAbsoluteValue4()
    {
        var result = MathExercises.GetDecimalAbs(-17.23M);
        result.Should().Be(17.23M);
    }

    [TestMethod]
    public void GetDecimalAbs_ShouldReturnAbsoluteValue5()
    {
        var result = MathExercises.GetDecimalAbs(-79228162514264337593543950335M);
        result.Should().Be(79228162514264337593543950335M);
    }

    [TestMethod]
    [DataRow(1.5354E-16, 1.5354E-16)]
    [DataRow(14.098123, 14.098123)]
    [DataRow(0.0, 0.0)]
    [DataRow(-17.069713, 17.069713)]
    [DataRow(-1.4058E+19, 1.4058E+19)]
    public void GetDoubleAbs_ShouldReturnAbsoluteValue(double input, double expected)
    {
        var result = MathExercises.GetDoubleAbs(input);
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow((short)32767, (short)32767)]
    [DataRow((short)10328, (short)10328)]
    [DataRow((short)0, (short)0)]
    [DataRow((short)-1476, (short)1476)]
    public void GetInt16Abs_ShouldReturnAbsoluteValue(short input, short expected)
    {
        var result = MathExercises.GetInt16Abs(input);
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow(2147483647, 2147483647)]
    [DataRow(16921, 16921)]
    [DataRow(0, 0)]
    [DataRow(-804128, 804128)]
    public void GetInt32Abs_ShouldReturnAbsoluteValue(int input, int expected)
    {
        var result = MathExercises.GetInt32Abs(input);
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow(9223372036854775807L, 9223372036854775807L)]
    [DataRow(109013L, 109013L)]
    [DataRow(0L, 0L)]
    [DataRow(-6871982L, 6871982L)]
    public void GetInt64Abs_ShouldReturnAbsoluteValue(long input, long expected)
    {
        var result = MathExercises.GetInt64Abs(input);
        result.Should().Be(expected);
    }

    // Exercise 2 - Write a C# Sharp program to find the maximum and smallest value of two variables.
    [TestMethod]
    [DataRow((byte)1, (byte)51, (byte)51)]
    public void MaxByte_ShouldReturnGreaterValue(byte a, byte b, byte expected)
    {
        var result = MathExercises.MaxByte(a, b);
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow((short)-2, (short)52, (short)52)]
    public void MaxInt16_ShouldReturnGreaterValue(short a, short b, short expected)
    {
        var result = MathExercises.MaxInt16(a, b);
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow(-3, 53, 53)]
    public void MaxInt32_ShouldReturnGreaterValue(int a, int b, int expected)
    {
        var result = MathExercises.MaxInt32(a, b);
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow(-4L, 54L, 54L)]
    public void MaxInt64_ShouldReturnGreaterValue(long a, long b, long expected)
    {
        var result = MathExercises.MaxInt64(a, b);
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow(5.0f, 55.0f, 55.0f)]
    public void MaxSingle_ShouldReturnGreaterValue(float a, float b, float expected)
    {
        var result = MathExercises.MaxSingle(a, b);
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow(6.0, 56.0, 56.0)]
    public void MaxDouble_ShouldReturnGreaterValue(double a, double b, double expected)
    {
        var result = MathExercises.MaxDouble(a, b);
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow((byte)1, (byte)51, (byte)1)]
    public void MinByte_ShouldReturnLesserValue(byte a, byte b, byte expected)
    {
        var result = MathExercises.MinByte(a, b);
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow((short)-2, (short)52, (short)-2)]
    public void MinInt16_ShouldReturnLesserValue(short a, short b, short expected)
    {
        var result = MathExercises.MinInt16(a, b);
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow(-3, 53, -3)]
    public void MinInt32_ShouldReturnLesserValue(int a, int b, int expected)
    {
        var result = MathExercises.MinInt32(a, b);
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow(-4L, 54L, -4L)]
    public void MinInt64_ShouldReturnLesserValue(long a, long b, long expected)
    {
        var result = MathExercises.MinInt64(a, b);
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow(5.0f, 55.0f, 5.0f)]
    public void MinSingle_ShouldReturnLesserValue(float a, float b, float expected)
    {
        var result = MathExercises.MinSingle(a, b);
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow(6.0, 56.0, 6.0)]
    public void MinDouble_ShouldReturnLesserValue(double a, double b, double expected)
    {
        var result = MathExercises.MinDouble(a, b);
        result.Should().Be(expected);
    }

    [TestMethod]
    public void MaxDecimal_ShouldReturnGreaterValue()
    {
        var result = MathExercises.MaxDecimal(7m, 57m);
        result.Should().Be(57m);
    }

    [TestMethod]
    public void MinDecimal_ShouldReturnLesserValue()
    {
        var result = MathExercises.MinDecimal(7m, 57m);
        result.Should().Be(7m);
    }

    // Exercise 3 - Write a C# Sharp program to calculate the value that results from raising 3 to a power ranging from 0 to 32.
    [TestMethod]
    public void CalculatePowerOfThree_Exponent0_ShouldReturn1()
    {
        var result = MathExercises.CalculatePowerOfThree(0);
        result.Should().Be(1L);
    }

    [TestMethod]
    public void CalculatePowerOfThree_Exponent1_ShouldReturn3()
    {
        var result = MathExercises.CalculatePowerOfThree(1);
        result.Should().Be(3L);
    }

    [TestMethod]
    public void CalculatePowerOfThree_Exponent2_ShouldReturn9()
    {
        var result = MathExercises.CalculatePowerOfThree(2);
        result.Should().Be(9L);
    }

    [TestMethod]
    public void CalculatePowerOfThree_Exponent3_ShouldReturn27()
    {
        var result = MathExercises.CalculatePowerOfThree(3);
        result.Should().Be(27L);
    }

    [TestMethod]
    public void CalculatePowerOfThree_Exponent4_ShouldReturn81()
    {
        var result = MathExercises.CalculatePowerOfThree(4);
        result.Should().Be(81L);
    }

    [TestMethod]
    public void CalculatePowerOfThree_Exponent5_ShouldReturn243()
    {
        var result = MathExercises.CalculatePowerOfThree(5);
        result.Should().Be(243L);
    }

    [TestMethod]
    public void CalculatePowerOfThree_Exponent32_ShouldReturn1853020188851841()
    {
        var result = MathExercises.CalculatePowerOfThree(32);
        result.Should().Be(1853020188851841L);
    }

    /* Exercise 4 - Write a C# Sharp program to calculate true mean value,
       mean with rounding away from zero and mean with rounding to the nearest of some specified decimal values. */
    private decimal[] _testValues = { 10.23m, 10.27m, 14.34m, 11.15m, 41.51m, 10.65m };

    [TestMethod]
    public void CalculateTrueMean_ShouldReturnCorrectValue()
    {
        var result = MathExercises.CalculateTrueMean(_testValues);
        result.Should().Be(16.36m);
    }

    [TestMethod]
    public void CalculateMeanAwayFromZero_ShouldReturnCorrectValue()
    {
        var result = MathExercises.CalculateMeanAwayFromZero(_testValues);
        result.Should().Be(16.37m);
    }

    [TestMethod]
    public void CalculateMeanToNearest_ShouldReturnCorrectValue()
    {
        var result = MathExercises.CalculateMeanToNearest(_testValues);
        result.Should().Be(16.35m);
    }

    // Exercise 5 - Write a C# Sharp program to determine the sign of a single value and display it on the console.
    [TestMethod]
    public void GetSign_ByteZero_ShouldReturn0()
    {
        var result = MathExercises.GetSign((byte)0);
        result.Should().Be(0);
    }

    [TestMethod]
    public void GetSign_Int16Negative_ShouldReturnNegative1()
    {
        var result = MathExercises.GetSign((short)-2);
        result.Should().Be(-1);
    }

    [TestMethod]
    public void GetSign_Int32Negative_ShouldReturnNegative1()
    {
        var result = MathExercises.GetSign(-3);
        result.Should().Be(-1);
    }

    [TestMethod]
    public void GetSign_Int64Negative_ShouldReturnNegative1()
    {
        var result = MathExercises.GetSign(-4L);
        result.Should().Be(-1);
    }

    [TestMethod]
    public void GetSign_SinglePositive_ShouldReturn1()
    {
        var result = MathExercises.GetSign(2.1f);
        result.Should().Be(1);
    }

    [TestMethod]
    public void GetSign_DoublePositive_ShouldReturn1()
    {
        var result = MathExercises.GetSign(6.0);
        result.Should().Be(1);
    }

    [TestMethod]
    public void GetSign_DecimalNegative_ShouldReturnNegative1()
    {
        var result = MathExercises.GetSign(-7m);
        result.Should().Be(-1);
    }

    // Exercise 6 - Write a C# Sharp program to calculate each city's square area based on the given area of some cities in the United States.
    [TestMethod]
    public void CalculateSquareSide_SitkaAlaska_ShouldReturn53_58()
    {
        var result = MathExercises.CalculateSquareSide(2870.3);
        result.Should().Be(53.58);
    }

    [TestMethod]
    public void CalculateSquareSide_NewYorkCity_ShouldReturn17_40()
    {
        var result = MathExercises.CalculateSquareSide(302.6);
        result.Should().Be(17.40);
    }

    [TestMethod]
    public void CalculateSquareSide_LosAngeles_ShouldReturn21_65()
    {
        var result = MathExercises.CalculateSquareSide(468.7);
        result.Should().Be(21.65);
    }

    [TestMethod]
    public void CalculateSquareSide_Detroit_ShouldReturn11_78()
    {
        var result = MathExercises.CalculateSquareSide(138.8);
        result.Should().Be(11.78);
    }

    [TestMethod]
    public void CalculateSquareSide_Chicago_ShouldReturn15_07()
    {
        var result = MathExercises.CalculateSquareSide(227.1);
        result.Should().Be(15.07);
    }

    [TestMethod]
    public void CalculateSquareSide_SanDiego_ShouldReturn18_03()
    {
        var result = MathExercises.CalculateSquareSide(325.2);
        result.Should().Be(18.03);
    }

    // Exercise 7 - Write a C# Sharp program to find the whole number and fractional part from a positive and negative Decimal number, Double number.
    [TestMethod]
    public void GetWholePart_DecimalPositive_ShouldReturn52()
    {
        var result = MathExercises.GetWholePart(52.7365m);
        result.Should().Be(52m);
    }

    [TestMethod]
    public void GetFractionalPart_DecimalPositive_ShouldReturn0_7365()
    {
        var result = MathExercises.GetFractionalPart(52.7365m);
        result.Should().Be(0.7365m);
    }

    [TestMethod]
    public void GetWholePart_DecimalNegative_ShouldReturnNegative52()
    {
        var result = MathExercises.GetWholePart(-52.736m);
        result.Should().Be(-52m);
    }

    [TestMethod]
    public void GetFractionalPart_DecimalNegative_ShouldReturnNegative0_736()
    {
        var result = MathExercises.GetFractionalPart(-52.736m);
        result.Should().Be(-0.736m);
    }

    [TestMethod]
    public void GetWholePart_DoublePositive_ShouldReturn92()
    {
        var result = MathExercises.GetWholePart(92.73165);
        result.Should().Be(92.0);
    }

    [TestMethod]
    public void GetFractionalPart_DoublePositive_ShouldReturn0_73165()
    {
        var result = MathExercises.GetFractionalPart(92.73165);
        result.Should().BeApproximately(0.73165, 0.0000001);
    }

    [TestMethod]
    public void GetWholePart_DoubleNegative_ShouldReturnNegative42()
    {
        var result = MathExercises.GetWholePart(-42.7636);
        result.Should().Be(-42.0);
    }

    [TestMethod]
    public void GetFractionalPart_DoubleNegative_ShouldReturnNegative0_7636()
    {
        var result = MathExercises.GetFractionalPart(-42.7636);
        result.Should().BeApproximately(-0.7636, 0.0000001);
    }

    // Exercise 8 - Write a C# Sharp program to calculate the quotient of two 32-bit signed integers and return the remainder as an output parameter.
    [TestMethod]
    public void DivideWithRemainder_IntMaxBy4000_ShouldReturn536870WithRemainder3647()
    {
        var remainder = 0;
        var quotient = MathExercises.DivideWithRemainder(int.MaxValue, 4000, out remainder);

        quotient.Should().Be(536870);
        remainder.Should().Be(3647);
    }

    [TestMethod]
    public void DivideWithRemainder_23547By4000_ShouldReturn5WithRemainder3547()
    {
        var remainder = 0;
        var quotient = MathExercises.DivideWithRemainder(23547, 4000, out remainder);

        quotient.Should().Be(5);
        remainder.Should().Be(3547);
    }

    [TestMethod]
    public void DivideWithRemainder_0By4000_ShouldReturn0WithRemainder0()
    {
        var remainder = 0;
        var quotient = MathExercises.DivideWithRemainder(0, 4000, out remainder);

        quotient.Should().Be(0);
        remainder.Should().Be(0);
    }

    [TestMethod]
    public void DivideWithRemainder_Negative12547By4000_ShouldReturnNegative3WithRemainderNegative547()
    {
        var remainder = 0;
        var quotient = MathExercises.DivideWithRemainder(-12547, 4000, out remainder);

        quotient.Should().Be(-3);
        remainder.Should().Be(-547);
    }

    [TestMethod]
    public void DivideWithRemainder_IntMinBy4000_ShouldReturnNegative536870WithRemainderNegative3648()
    {
        var remainder = 0;
        var quotient = MathExercises.DivideWithRemainder(int.MinValue, 4000, out remainder);

        quotient.Should().Be(-536870);
        remainder.Should().Be(-3648);
    }

    [TestMethod]
    public void DivideWithRemainder_IntMaxByNegative4000_ShouldReturnNegative536870WithRemainder3647()
    {
        var remainder = 0;
        var quotient = MathExercises.DivideWithRemainder(int.MaxValue, -4000, out remainder);

        quotient.Should().Be(-536870);
        remainder.Should().Be(3647);
    }

    [TestMethod]
    public void DivideWithRemainder_23547ByNegative4000_ShouldReturnNegative5WithRemainder3547()
    {
        var remainder = 0;
        var quotient = MathExercises.DivideWithRemainder(23547, -4000, out remainder);

        quotient.Should().Be(-5);
        remainder.Should().Be(3547);
    }

    [TestMethod]
    public void DivideWithRemainder_0ByNegative4000_ShouldReturn0WithRemainder0()
    {
        var remainder = 0;
        var quotient = MathExercises.DivideWithRemainder(0, -4000, out remainder);

        quotient.Should().Be(0);
        remainder.Should().Be(0);
    }

    [TestMethod]
    public void DivideWithRemainder_Negative12547ByNegative4000_ShouldReturn3WithRemainderNegative547()
    {
        var remainder = 0;
        var quotient = MathExercises.DivideWithRemainder(-12547, -4000, out remainder);

        quotient.Should().Be(3);
        remainder.Should().Be(-547);
    }

    [TestMethod]
    public void DivideWithRemainder_IntMinByNegative4000_ShouldReturn536870WithRemainderNegative3648()
    {
        var remainder = 0;
        var quotient = MathExercises.DivideWithRemainder(int.MinValue, -4000, out remainder);

        quotient.Should().Be(536870);
        remainder.Should().Be(-3648);
    }

    // Exercise 9 - Write a C# Sharp program to calculate the full product of two 32-bit numbers.
    [TestMethod]
    public void MultiplyInt32_MaxValueByMaxValue_ShouldReturn4611686014132420609()
    {
        var result = MathExercises.MultiplyInt32(int.MaxValue, int.MaxValue);
        result.Should().Be(4611686014132420609L);
    }

    [TestMethod]
    public void MultiplyInt32_MaxValueByMinValue_ShouldReturnCorrectResult()
    {
        var result = MathExercises.MultiplyInt32(int.MaxValue, int.MinValue);
        result.Should().Be(-4611686016279904256L);
    }

    [TestMethod]
    public void MultiplyInt32_MinValueByMinValue_ShouldReturnCorrectResult()
    {
        var result = MathExercises.MultiplyInt32(int.MinValue, int.MinValue);
        result.Should().Be(4611686018427387904L);
    }

    [TestMethod]
    public void MultiplyInt32_ZeroByMaxValue_ShouldReturnZero()
    {
        var result = MathExercises.MultiplyInt32(0, int.MaxValue);
        result.Should().Be(0L);
    }

    [TestMethod]
    public void MultiplyInt32_OneByMaxValue_ShouldReturnMaxValue()
    {
        var result = MathExercises.MultiplyInt32(1, int.MaxValue);
        result.Should().Be(int.MaxValue);
    }

    // Exercise 10 - Write a C# Sharp program to reverse the digits of a 32-bit signed integer.
    [TestMethod]
    [DataRow(123456, 654321)]
    [DataRow(-7654, -4567)]
    [DataRow(100, 1)]
    [DataRow(0, 0)]
    [DataRow(5, 5)]
    [DataRow(-123, -321)]
    [DataRow(120, 21)]
    public void ReverseInteger_ShouldReturnReversedNumber(int input, int expected)
    {
        var result = MathExercises.ReverseInteger(input);
        result.Should().Be(expected);
    }

    // Exercise 11 - Write a C# Sharp program to convert a given string value to a 32-bit signed integer.
    [TestMethod]
    [DataRow("123456", 123456)]
    [DataRow("+3456", 3456)]
    [DataRow("-123456", -123456)]
    [DataRow("a1234", 0)]
    [DataRow("123a456", 123)]
    [DataRow("0", 0)]
    [DataRow("2147483647", int.MaxValue)]
    [DataRow("-2147483648", int.MinValue)]
    public void StringToInteger_ShouldConvertCorrectly(string input, int expected)
    {
        var result = MathExercises.StringToInteger(input);
        result.Should().Be(expected);
    }

    /* Exercise 12 - Write a C# Sharp program to check whether a given integer is a palindrome integer or not.
       Return true if the number is a palindrome, otherwise return false. */
    [TestMethod]
    [DataRow(123456, false)]
    [DataRow(16461, true)]
    [DataRow(-121, false)]
    [DataRow(0, true)]
    [DataRow(5, true)]
    [DataRow(1221, true)]
    [DataRow(12321, true)]
    [DataRow(1234321, true)]
    public void IsPalindrome_ShouldReturnCorrectResult(int number, bool expected)
    {
        var result = MathExercises.IsPalindrome(number);
        result.Should().Be(expected);
    }

    // Exercise 13 - Write a C# Sharp program to convert a given integer value to Roman numerals.
    [TestMethod]
    [DataRow(2365, "MMCCCLXV")]
    [DataRow(254, "CCLIV")]
    [DataRow(45, "XLV")]
    [DataRow(8, "VIII")]
    [DataRow(1994, "MCMXCIV")]
    [DataRow(3999, "MMMCMXCIX")]
    [DataRow(1, "I")]
    [DataRow(4, "IV")]
    [DataRow(9, "IX")]
    public void IntegerToRoman_ShouldConvertCorrectly(int number, string expected)
    {
        var result = MathExercises.IntegerToRoman(number);
        result.Should().Be(expected);
    }

    /* Exercise 14 - Write a C# Sharp program to calculate the largest integral value less than or equal to
       and the smallest integral value greater than or equal to a given number. */
    [TestMethod]
    [DataRow(8.03, 9.0)]
    [DataRow(8.34, 9.0)]
    [DataRow(0.12, 1.0)]
    [DataRow(-0.14, 0.0)]
    [DataRow(-8.1, -8.0)]
    [DataRow(-8.6, -8.0)]
    public void GetCeiling_ShouldReturnCorrectValue(double input, double expected)
    {
        var result = MathExercises.GetCeiling(input);
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow(8.03, 8.0)]
    [DataRow(8.34, 8.0)]
    [DataRow(0.12, 0.0)]
    [DataRow(-0.14, -1.0)]
    [DataRow(-8.1, -9.0)]
    [DataRow(-8.6, -9.0)]
    public void GetFloor_ShouldReturnCorrectValue(double input, double expected)
    {
        var result = MathExercises.GetFloor(input);
        result.Should().Be(expected);
    }

    // Exercise 15 - Write a C# Sharp program to convert a given Roman numeral value to an integer value.
    [TestMethod]
    [DataRow("MMCCCLXV", 2365)]
    [DataRow("CCLIV", 254)]
    [DataRow("XLV", 45)]
    [DataRow("VIII", 8)]
    [DataRow("MCMXCIV", 1994)]
    [DataRow("III", 3)]
    [DataRow("IV", 4)]
    [DataRow("IX", 9)]
    [DataRow("XL", 40)]
    [DataRow("XC", 90)]
    [DataRow("CD", 400)]
    [DataRow("CM", 900)]
    public void RomanToInteger_ShouldConvertCorrectly(string roman, int expected)
    {
        var result = MathExercises.RomanToInteger(roman);
        result.Should().Be(expected);
    }

    /* Exercise 16 - Write a C# program to divide two given integers (dividend and divisor)
       and get the quotient without using multiplication, division and the mod operator. */
    [TestMethod]
    [DataRow(7, 3, 2)]
    [DataRow(-17, 5, -3)]
    [DataRow(35, 7, 5)]
    [DataRow(10, 2, 5)]
    [DataRow(0, 5, 0)]
    [DataRow(15, 3, 5)]
    [DataRow(-20, 4, -5)]
    [DataRow(100, 10, 10)]
    public void DivideWithoutOperators_ShouldReturnCorrectQuotient(int dividend, int divisor, int expected)
    {
        var result = MathExercises.DivideWithoutOperators(dividend, divisor);
        result.Should().Be(expected);
    }

    /* Exercise 17 - Write a C# program to return the string representation of the product of two non-negative integers n1 and n2,
       given two non-negative integers n1 and n2. */
    [TestMethod]
    [DataRow("12", "5", "60")]
    [DataRow("221", "415", "91715")]
    [DataRow("0", "15", "0")]
    [DataRow("123", "456", "56088")]
    [DataRow("999", "999", "998001")]
    [DataRow("2", "3", "6")]
    [DataRow("10", "10", "100")]
    public void MultiplyStrings_ShouldReturnCorrectProduct(string num1, string num2, string expected)
    {
        var result = MathExercises.MultiplyStrings(num1, num2);
        result.Should().Be(expected);
    }

    // Exercise 18 - Write a C# Sharp program to compute the sum of the positive and negative numbers of an array of integers and display the largest sum.
    [TestMethod]
    public void FindLargestSum_FirstExample_ShouldReturn105()
    {
        var nums = new[] { -10, -11, -12, -13, -14, 15, 16, 17, 18, 19, 20 };
        var result = MathExercises.FindLargestSum(nums);
        result.Should().Be(105);
    }

    [TestMethod]
    public void FindLargestSum_SecondExample_ShouldReturnNegative77()
    {
        var nums = new[] { -11, -22, -44, 0, 3, 4, 5, 9 };
        var result = MathExercises.FindLargestSum(nums);
        result.Should().Be(-77);
    }

    [TestMethod]
    public void FindLargestSum_AllPositive_ShouldReturnPositiveSum()
    {
        var nums = new[] { 1, 2, 3, 4, 5 };
        var result = MathExercises.FindLargestSum(nums);
        result.Should().Be(15);
    }

    [TestMethod]
    public void FindLargestSum_AllNegative_ShouldReturnNegativeSum()
    {
        var nums = new[] { -1, -2, -3, -4, -5 };
        var result = MathExercises.FindLargestSum(nums);
        result.Should().Be(-15);
    }

    [TestMethod]
    public void FindLargestSum_EmptyArray_ShouldReturnZero()
    {
        var nums = new int[0];
        var result = MathExercises.FindLargestSum(nums);
        result.Should().Be(0);
    }

    // Exercise 19 - Write a C# Sharp program to find PI value up to n (given number) decimal places.
    [TestMethod]
    public void GetPiValue_DecimalPlaces2_ShouldReturn3_14()
    {
        var result = MathExercises.GetPiValue(2);
        result.Should().Be(3.14m);
    }

    [TestMethod]
    public void GetPiValue_DecimalPlaces7_ShouldReturn3_1415927()
    {
        var result = MathExercises.GetPiValue(7);
        result.Should().Be(3.1415927m);
    }

    [TestMethod]
    public void GetPiValue_DecimalPlaces15_ShouldReturn3_141592653589793()
    {
        var result = MathExercises.GetPiValue(15);
        result.Should().Be(3.14159265358979m);
    }

    [TestMethod]
    public void GetPiValue_DecimalPlaces0_ShouldReturn3()
    {
        var result = MathExercises.GetPiValue(0);
        result.Should().Be(3m);
    }

    [TestMethod]
    public void GetPiValue_DecimalPlaces1_ShouldReturn3_1()
    {
        var result = MathExercises.GetPiValue(1);
        result.Should().Be(3.1m);
    }

    [TestMethod]
    public void GetPiValue_DecimalPlaces5_ShouldReturn3_14159()
    {
        var result = MathExercises.GetPiValue(5);
        result.Should().Be(3.14159m);
    }

    /* Exercise 20 - Write a C# Sharp program to find the Least Common Multiple (LCM) of more than two numbers.
       Take numbers from a given array of positive integers. */
    [TestMethod]
    public void CalculateLCM_FirstExample_ShouldReturn24()
    {
        var numbers = new[] { 4, 6, 8 };
        var result = MathExercises.CalculateLCM(numbers);
        result.Should().Be(24);
    }

    [TestMethod]
    public void CalculateLCM_SecondExample_ShouldReturn2520()
    {
        var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var result = MathExercises.CalculateLCM(numbers);
        result.Should().Be(2520);
    }

    [TestMethod]
    public void CalculateLCM_ThirdExample_ShouldReturn432()
    {
        var numbers = new[] { 48, 72, 108 };
        var result = MathExercises.CalculateLCM(numbers);
        result.Should().Be(432);
    }

    [TestMethod]
    public void CalculateLCM_SingleNumber_ShouldReturnNumberItself()
    {
        var numbers = new[] { 7 };
        var result = MathExercises.CalculateLCM(numbers);
        result.Should().Be(7);
    }

    [TestMethod]
    public void CalculateLCM_TwoNumbers_ShouldReturnCorrectLCM()
    {
        var numbers = new[] { 12, 18 };
        var result = MathExercises.CalculateLCM(numbers);
        result.Should().Be(36);
    }

    // Exercise 21 - Write a C# Sharp program to get the nth tetrahedral number from a given integer(n) value.
    [TestMethod]
    [DataRow(1, 1)]
    [DataRow(2, 4)]
    [DataRow(3, 10)]
    [DataRow(4, 20)]
    [DataRow(5, 35)]
    [DataRow(6, 56)]
    [DataRow(7, 84)]
    [DataRow(8, 120)]
    public void GetTetrahedralNumber_ShouldReturnCorrectValue(int n, int expected)
    {
        var result = MathExercises.GetTetrahedralNumber(n);
        result.Should().Be(expected);
    }

    // Exercise 22 - Write a C# Sharp program to sort a given positive number in descending/ascending order.
    [TestMethod]
    [DataRow(134543, 544331)]
    [DataRow(4375973, 9775433)]
    [DataRow(123, 321)]
    [DataRow(100, 100)]
    [DataRow(999, 999)]
    public void SortDescending_ShouldReturnCorrectValue(int input, int expected)
    {
        var result = MathExercises.SortDescending(input);
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow(134543, 133445)]
    [DataRow(4375973, 3345779)]
    [DataRow(321, 123)]
    [DataRow(100, 1)]
    [DataRow(999, 999)]
    public void SortAscending_ShouldReturnCorrectValue(int input, int expected)
    {
        var result = MathExercises.SortAscending(input);
        result.Should().Be(expected);
    }

    // Exercise 23 - Write a C# Sharp program to check whether a given number (integer) is oddish or evenish.
    [TestMethod]
    [DataRow(120, "Oddish")]
    [DataRow(321, "Evenish")]
    [DataRow(43, "Oddish")]
    [DataRow(4433, "Evenish")]
    [DataRow(373, "Oddish")]
    [DataRow(0, "Evenish")]
    [DataRow(1, "Oddish")]
    [DataRow(11, "Evenish")]
    public void CheckOddishEvenish_ShouldReturnCorrectResult(int number, string expected)
    {
        var result = MathExercises.CheckOddishEvenish(number);
        result.Should().Be(expected);
    }

    /* Exercise 24 - Write a C# Sharp program to reverse the binary representation of a
       given number and convert the reversed binary number into an integer. */
    [TestMethod]
    [DataRow(120, 15)]
    [DataRow(321, 261)]
    [DataRow(43, 53)]
    [DataRow(4433, 4433)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 3)]
    public void ReverseBinary_ShouldReturnCorrectResult(int number, int expected)
    {
        var result = MathExercises.ReverseBinary(number);
        result.Should().Be(expected);
    }

    /* Exercise 25 - Write a C# Sharp program to find the closest palindrome number of an integer.
       If there are two palindrome numbers in absolute distance return the smallest number. */
    [TestMethod]
    [DataRow(120, 121)]
    [DataRow(321, 323)]
    [DataRow(43, 44)]
    [DataRow(1234, 1221)]
    [DataRow(1, 1)]
    [DataRow(10, 9)]
    [DataRow(99, 99)]
    [DataRow(100, 99)]
    public void FindClosestPalindrome_ShouldReturnCorrectResult(int number, int expected)
    {
        var result = MathExercises.FindClosestPalindrome(number);
        result.Should().Be(expected);
    }

    // Exercise 26 - Write a C# Sharp program that takes an integer and determines whether it is uban or not.
    [TestMethod]
    [DataRow(63, true)]
    [DataRow(100, false)]
    [DataRow(100000, false)]
    [DataRow(1000005, true)]
    [DataRow(4, false)]
    [DataRow(14, false)]
    [DataRow(24, false)]
    [DataRow(34, false)]
    [DataRow(44, false)]
    [DataRow(54, false)]
    [DataRow(64, false)]
    [DataRow(74, false)]
    [DataRow(84, false)]
    [DataRow(94, false)]
    [DataRow(50, true)]
    [DataRow(999, false)]
    [DataRow(1000, false)]
    [DataRow(999999, false)]
    [DataRow(1000000, true)]
    public void IsUbanNumber_ShouldReturnCorrectResult(int number, bool expected)
    {
        var result = MathExercises.IsUbanNumber(number);
        result.Should().Be(expected);
    }
}
