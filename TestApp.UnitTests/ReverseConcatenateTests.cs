using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[] input = new string[] { "word" };
        string expected = "word";

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = new string[] { "dog", "cat", "raccoon" };
        string expected = "raccooncatdog";

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = null;
        string expected = String.Empty;

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // Arrange
        string[] input = new string[] { "Unit", " ", "testing" };
        string expected = "testing Unit";

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = new string[20000];

        for (int i = 0; i <= input.Length-1; i++)
        {
            input[i] = i.ToString();
        }

        string expected = string.Join("", input.Reverse());

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
