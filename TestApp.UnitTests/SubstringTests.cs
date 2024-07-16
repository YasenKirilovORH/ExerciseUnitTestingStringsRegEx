using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown jumps over the lazy dog";

        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "This";
        string input = "This is a simple text.";
        string expected = "is a simple text.";

        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "text";
        string input = "This is a simple text.";
        string expected = "This is a simple .";

        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(actual,Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "word";
        string input = "In this sentence we will remove  this word and also this word.";
        string expected = "In this sentence we will remove this and also this .";

        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
