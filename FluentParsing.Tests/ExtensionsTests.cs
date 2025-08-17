using FluentAssertions;

namespace FluentParsing.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Given_ValidPropertyToParse_When_ToDecimal_Then_ReturnValidDecimal()
    {
        // Arrange
        var propertyToParse = "1.234";
        var expected = 1.234m;

        // Act
        var result = propertyToParse.ToDecimal();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("invalid string to parse")]
    public void Given_InvalidPropertyToParce_When_ToDecimalWithShouldThrow_Then_ThrowArgumentException(string propertyToParse)
    {
        // Arrange & Act
        var result = () => propertyToParse.ToDecimal(shouldThrow: true);

        // Assert
        result.Should().Throw<ArgumentException>().WithMessage($"Unable to convert '{propertyToParse}' to 'decimal'");
    }

    [Fact]
    public void Given_ValidPropertyToParse_When_ToDouble_Then_ReturnValidDecimal()
    {
        // Arrange
        var propertyToParse = "1.234";
        var expected = 1.234d;

        // Act
        var result = propertyToParse.ToDouble();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("invalid string to parse")]
    public void Given_InvalidPropertyToParce_When_ToDoubleWithShouldThrow_Then_ThrowArgumentException(string propertyToParse)
    {
        // Arrange & Act
        var result = () => propertyToParse.ToDouble(shouldThrow: true);

        // Assert
        result.Should().Throw<ArgumentException>().WithMessage($"Unable to convert '{propertyToParse}' to 'double'");
    }

    [Fact]
    public void Given_ValidPropertyToParse_When_ToInt_Then_ReturnValidDecimal()
    {
        // Arrange
        var propertyToParse = "1234";
        var expected = 1234;

        // Act
        var result = propertyToParse.ToInt();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("invalid string to parse")]
    public void Given_InvalidPropertyToParce_When_ToIntWithShouldThrow_Then_ThrowArgumentException(string propertyToParse)
    {
        // Arrange & Act
        var result = () => propertyToParse.ToInt(shouldThrow: true);

        // Assert
        result.Should().Throw<ArgumentException>().WithMessage($"Unable to convert '{propertyToParse}' to 'int'");
    }

    [Fact]
    public void Given_ValidPropertyToParse_When_ToChar_Then_ReturnValidDecimal()
    {
        // Arrange
        var propertyToParse = "a";
        var expected = 'a';

        // Act
        var result = propertyToParse.ToChar();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("invalid string to parse")]
    public void Given_InvalidPropertyToParce_When_ToCharWithShouldThrow_Then_ThrowArgumentException(string propertyToParse)
    {
        // Arrange & Act
        var result = () => propertyToParse.ToChar(shouldThrow: true);

        // Assert
        result.Should().Throw<ArgumentException>().WithMessage($"Unable to convert '{propertyToParse}' to 'char'");
    }

    [Fact]
    public void Given_ValidPropertyToParse_When_ToLong_Then_ReturnValidDecimal()
    {
        // Arrange
        var propertyToParse = "1234567890";
        var expected = 1234567890L;

        // Act
        var result = propertyToParse.ToLong();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("invalid string to parse")]
    public void Given_InvalidPropertyToParce_When_ToLongWithShouldThrow_Then_ThrowArgumentException(string propertyToParse)
    {
        // Arrange & Act
        var result = () => propertyToParse.ToLong(shouldThrow: true);

        // Assert
        result.Should().Throw<ArgumentException>().WithMessage($"Unable to convert '{propertyToParse}' to 'long'");
    }

    [Fact]
    public void Given_ValidPropertyToParse_When_ToFloat_Then_ReturnValidDecimal()
    {
        // Arrange
        var propertyToParse = "12.3";
        var expected = 12.3F;

        // Act
        var result = propertyToParse.ToFloat();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("invalid string to parse")]
    public void Given_InvalidPropertyToParce_When_ToFloatWithShouldThrow_Then_ThrowArgumentException(string propertyToParse)
    {
        // Arrange & Act
        var result = () => propertyToParse.ToFloat(shouldThrow: true);

        // Assert
        result.Should().Throw<ArgumentException>().WithMessage($"Unable to convert '{propertyToParse}' to 'float'");
    }
}