# FluentParsing

**FluentParsing** is a lightweight .NET extension library that simplifies converting string values into primitive types with fluent syntax and optional error handling. Designed for developers who want cleaner, more expressive code when dealing with string parsing.

---

## Features

- Extension methods for parsing `string` to:
  - `int`
  - `long`
  - `float`
  - `double`
  - `decimal`
  - `char`
- Optional exception throwing for invalid input
- Fluent, readable syntax for safer conversions

---

## Installation

Install via NuGet Package Manager:

```bash
dotnet add package FluentParsing
```

Or via the NuGet UI in Visual Studio.

---

## Usage

Import the namespace:

```csharp
using FluentParsing;
```

### Basic Parsing

```csharp
string input = "42";
int value = input.ToInt(); // returns 42
```

### Graceful Failure

```csharp
string input = "not-a-number";
int value = input.ToInt(); // returns 0 (default int)
```

### Throw on Failure

```csharp
string input = "oops";
int value = input.ToInt(shouldThrow: true); // throws ArgumentException
```

### Supported Types

| Method         | Return Type | Default on Failure | Throws Exception         |
|----------------|-------------|---------------------|-------------------------|
| `ToInt()`      | `int`       | `0`                 | if `shouldThrow = true` |
| `ToLong()`     | `long`      | `0L`                | if `shouldThrow = true` |
| `ToFloat()`    | `float`     | `0f`                | if `shouldThrow = true` |
| `ToDouble()`   | `double`    | `0d`                | if `shouldThrow = true` |
| `ToDecimal()`  | `decimal`   | `0m`                | if `shouldThrow = true` |
| `ToChar()`     | `char`      | `'\0'`              | if `shouldThrow = true` |

---

## Example

```csharp
string price = "19.99";
decimal parsedPrice = price.ToDecimal(); // returns 19.99m

string invalid = "abc";
float parsedFloat = invalid.ToFloat(); // returns 0f

char letter = "A".ToChar(); // returns 'A'
```

---

## Error Handling

All methods support a `shouldThrow` parameter:

- `false` (default): returns default value on failure
- `true`: throws `ArgumentException` with a helpful message

```csharp
string input = "NaN";
double result = input.ToDouble(shouldThrow: true); 
// Throws: ArgumentException: Unable to convert 'NaN' to 'double'
```

---

## License

This project is licensed under the GNU GENERAL PUBLIC LICENSE.

---

## Feedback & Contributions

Feel free to open issues or submit pull requests to improve functionality or add new parsing types!

---

Let me know if you'd like a logo, badges, or CI/CD instructions added to the README!