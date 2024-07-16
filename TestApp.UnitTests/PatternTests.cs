using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("asd", 2, "aSdaSd")]
    [TestCase("text", 4, "tExTtExTtExTtExT")]
    [TestCase("a", 3, "aaa")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Act
        string actual = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = string.Empty;
        int repetitionFactor = 5;

        // Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "word";
        int repetitionFactor = -3;

        // Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input,repetitionFactor));
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "word";
        int repetitionFactor = 0;

        // Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input,repetitionFactor));
    }
}
