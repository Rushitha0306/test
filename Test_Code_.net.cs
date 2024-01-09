using NUnit.Framework;

[TestFixture]
public class MathOperationsTests
{
    [Test]
    public void Add_TwoNumbers_ReturnsSum()
    {
        // Arrange
        int num1 = 5;
        int num2 = 7;

        // Act
        int result = MathOperations.Add(num1, num2);

        // Assert
        Assert.AreEqual(12, result);
    }

    [Test]
    public void Subtract_TwoNumbers_ReturnsDifference()
    {
        // Arrange
        int num1 = 10;
        int num2 = 3;

        // Act
        int result = MathOperations.Subtract(num1, num2);

        // Assert
        Assert.AreEqual(7, result);
    }
}

public static class MathOperations
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }
}
