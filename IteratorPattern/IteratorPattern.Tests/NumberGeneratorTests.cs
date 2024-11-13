namespace IteratorPattern.Tests;

public class NumberGeneratorTests
{
    [Fact]
    public void GetNumbersByNumbersGenerator_Should_ReturnNumbersInSequence()
    {
        var numbers = Functions.GetNumbersByNumbersGenerator(5);

        var result = new List<int>();

        var enumerator = numbers.GetEnumerator();
        while (enumerator.MoveNext())
        {
            result.Add(enumerator.Current);
        }

        Assert.Equal(result, [1, 2, 3, 4, 5]);
    }

    [Fact]
    public void GetNumbersByYieldReturn_Should_ReturnNumbersInSequence()
    {
        var numbers = Functions.GetNumbersByYieldReturn(5);

        var result = new List<int>();

        var enumerator = numbers.GetEnumerator();
        while (enumerator.MoveNext())
        {
            result.Add(enumerator.Current);
        }

        Assert.Equal(result, [1, 2, 3, 4, 5]);
    }
}