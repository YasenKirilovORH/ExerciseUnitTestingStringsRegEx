using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
 
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = new string[] { "test", "text" };
        string input = "This is a sentence without banned words.";
        string expected = "This is a sentence without banned words.";

        // Act
        string actual = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = new string[] { "word", "text" };
        string input = "In this text there will be more than one banned word.";
        string expected = "In this **** there will be more than one banned ****.";

        // Act
        string actual = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = Array.Empty<string>();
        string input = "This is a short text.";
        string expected = "This is a short text.";

        // Act
        string actual = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(actual,Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWords = new string[] { "Whitespace", " " };
        string input = "Whitespace is a banned word.";
        string expected = "***********is*a*banned*word.";

        // Act
        string actual = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
