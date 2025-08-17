namespace FluentParsing;

public static class Extensions
{
    /// <summary>
    /// Converts a string representation of a decimal number into a <see cref="decimal"/> object.
    /// </summary>
    /// <param name="propertyToParse">The string value to parse as a decimal.</param>
    /// <param name="shouldThrow">
    /// If <see langword="true"/>, throws an <see cref="ArgumentException"/> when parsing fails.
    /// If <see langword="false"/>, returns the default <see cref="decimal"/> value on failure.
    /// </param>
    /// <returns>
    /// The parsed <see cref="decimal"/> value if successful; otherwise, the default <see cref="decimal"/> value.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="shouldThrow"/> is <see langword="true"/> and the input string cannot be parsed as a decimal.
    /// </exception>
    public static decimal ToDecimal(this string propertyToParse, bool shouldThrow = false)
    {
        if (decimal.TryParse(propertyToParse, out decimal result))
        {
            return result;
        }

        if (shouldThrow)
        {
            throw new ArgumentException(GetExceptionMessage(propertyToParse, "decimal"));
        }

        return new decimal();
    }

    /// <summary>
    /// Converts a string representation of a double number into a <see cref="double"/> object.
    /// </summary>
    /// <param name="propertyToParse">The string value to parse as a double.</param>
    /// <param name="shouldThrow">
    /// If <see langword="true"/>, throws an <see cref="ArgumentException"/> when parsing fails.
    /// If <see langword="false"/>, returns the default <see cref="double"/> value on failure.
    /// </param>
    /// <returns>
    /// The parsed <see cref="double"/> value if successful; otherwise, the default <see cref="double"/> value.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="shouldThrow"/> is <see langword="true"/> and the input string cannot be parsed as a double.
    /// </exception>
    public static double ToDouble(this string propertyToParse, bool shouldThrow = false)
    {
        if (double.TryParse(propertyToParse, out double result))
        {
            return result;
        }

        if (shouldThrow)
        {
            throw new ArgumentException(GetExceptionMessage(propertyToParse, "double"));
        }

        return new double();
    }

    /// <summary>
    /// Converts a string representation of a int number into a <see cref="int"/> object.
    /// </summary>
    /// <param name="propertyToParse">The string value to parse as a int.</param>
    /// <param name="shouldThrow">
    /// If <see langword="true"/>, throws an <see cref="ArgumentException"/> when parsing fails.
    /// If <see langword="false"/>, returns the default <see cref="int"/> value on failure.
    /// </param>
    /// <returns>
    /// The parsed <see cref="int"/> value if successful; otherwise, the default <see cref="int"/> value.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="shouldThrow"/> is <see langword="true"/> and the input string cannot be parsed as a int.
    /// </exception>
    public static int ToInt(this string propertyToParse, bool shouldThrow = false)
    {
        if (int.TryParse(propertyToParse, out int result))
        {
            return result;
        }

        if (shouldThrow)
        {
            throw new ArgumentException(GetExceptionMessage(propertyToParse, "int"));
        }

        return new int();
    }

    /// <summary>
    /// Converts a string representation of a char into a <see cref="char"/> object.
    /// </summary>
    /// <param name="propertyToParse">The string value to parse as a char.</param>
    /// <param name="shouldThrow">
    /// If <see langword="true"/>, throws an <see cref="ArgumentException"/> when parsing fails.
    /// If <see langword="false"/>, returns the default <see cref="char"/> value on failure.
    /// </param>
    /// <returns>
    /// The parsed <see cref="char"/> value if successful; otherwise, the default <see cref="char"/> value.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="shouldThrow"/> is <see langword="true"/> and the input string cannot be parsed as a char.
    /// </exception>
    public static char ToChar(this string propertyToParse, bool shouldThrow = false)
    {
        if (char.TryParse(propertyToParse, out char result))
        {
            return result;
        }

        if (shouldThrow)
        {
            throw new ArgumentException(GetExceptionMessage(propertyToParse, "char"));
        }

        return new char();
    }

    /// <summary>
    /// Converts a string representation of a long number into a <see cref="long"/> object.
    /// </summary>
    /// <param name="propertyToParse">The string value to parse as a long.</param>
    /// <param name="shouldThrow">
    /// If <see langword="true"/>, throws an <see cref="ArgumentException"/> when parsing fails.
    /// If <see langword="false"/>, returns the default <see cref="long"/> value on failure.
    /// </param>
    /// <returns>
    /// The parsed <see cref="long"/> value if successful; otherwise, the default <see cref="long"/> value.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="shouldThrow"/> is <see langword="true"/> and the input string cannot be parsed as a long.
    /// </exception>
    public static long ToLong(this string propertyToParse, bool shouldThrow = false)
    {
        if (long.TryParse(propertyToParse, out long result))
        {
            return result;
        }

        if (shouldThrow)
        {
            throw new ArgumentException(GetExceptionMessage(propertyToParse, "long"));
        }

        return new long();
    }

    /// <summary>
    /// Converts a string representation of a float number into a <see cref="float"/> object.
    /// </summary>
    /// <param name="propertyToParse">The string value to parse as a float.</param>
    /// <param name="shouldThrow">
    /// If <see langword="true"/>, throws an <see cref="ArgumentException"/> when parsing fails.
    /// If <see langword="false"/>, returns the default <see cref="float"/> value on failure.
    /// </param>
    /// <returns>
    /// The parsed <see cref="float"/> value if successful; otherwise, the default <see cref="float"/> value.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Thrown when <paramref name="shouldThrow"/> is <see langword="true"/> and the input string cannot be parsed as a float.
    /// </exception>
    public static float ToFloat(this string propertyToParse, bool shouldThrow = false)
    {
        if (float.TryParse(propertyToParse, out float result))
        {
            return result;
        }

        if (shouldThrow)
        {
            throw new ArgumentException(GetExceptionMessage(propertyToParse, "float"));
        }

        return new float();
    }

    private static string GetExceptionMessage(string property, string type) => $"Unable to convert '{property}' to '{type}'";
}
