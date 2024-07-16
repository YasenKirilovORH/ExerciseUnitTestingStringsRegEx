using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string input = "";
        List<string> expected = new List<string>();

        // Act
        List<string> actual = MatchUrls.ExtractUrls(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string input = "This is only a text without URLs.";
        List<string> expected = new List<string>();

        // Act
        List<string> actual = MatchUrls.ExtractUrls(input);

        // Assert
        CollectionAssert.AreEqual (expected, actual);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string input = "This is URL - https://regex101.com This is not - Just a text";
        List<string> expected = new List<string>() { "https://regex101.com" };

        // Act
        List<string> actual = MatchUrls.ExtractUrls (input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string input = "https://regex101.com, https://id.atlassian.com, https://github.com";
        List<string> expected = new List<string>() { "https://regex101.com", "https://id.atlassian.com", "https://github.com" };

        // Act
        List<string> actual = MatchUrls.ExtractUrls(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string input = "Test URL: \"https://regex101.com/\"";
        List<string> expected = new List<string>() { "https://regex101.com" };

        // Act
        List<string> actual = MatchUrls.ExtractUrls(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }
}
