namespace IteratorPattern.Tests;

public class StackTests
{
    [Fact]
    public void Foreach_Should_IterateOverStack()
    {
        // Arrange
        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Act
        var result = new List<int>();
        foreach (var element in stack)
        {
            result.Add(element);
        }

        // Assert
        Assert.Equal([3, 2, 1], result);
    }

    [Fact]
    public void Foreach_Should_IterateOverEmptyStack()
    {
        // Arrange
        var stack = new Stack<int>();

        // Act
        var result = new List<int>();
        foreach (var element in stack)
        {
            result.Add(element);
        }

        // Assert
        Assert.Equal([], result);
    }

    [Fact]
    public void Stack_Should_ReturnEnumerator()
    {
        // Arrange
        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        var result = new List<int>();

        // Act
        var enumerator = stack.GetEnumerator();
        while (enumerator.MoveNext())
        {
            result.Add(enumerator.Current);
        }
        enumerator.Reset();

        // Assert
        Assert.Equal([3, 2, 1], result);
    }
}